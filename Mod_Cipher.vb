
Imports System
Imports System.IO
Imports System.Security
Imports System.Security.Cryptography
Module Cipher
    Public Function CreateKey(ByVal strPassword As String) As Byte()
        'Convert strPassword to an array and store in chrData.
        Dim chrData() As Char = strPassword.ToCharArray
        'Use intLength to get strPassword size.
        Dim intLength As Integer = chrData.GetUpperBound(0)
        'Declare bytDataToHash and make it the same size as chrData.
        Dim bytDataToHash(intLength) As Byte

        'Use For Next to convert and store chrData into bytDataToHash.
        For i As Integer = 0 To chrData.GetUpperBound(0)
            bytDataToHash(i) = CByte(Asc(chrData(i)))
        Next

        'Declare what hash to use.
        Dim SHA512 As New System.Security.Cryptography.SHA512Managed
        'Declare bytResult, Hash bytDataToHash and store it in bytResult.
        Dim bytResult As Byte() = SHA512.ComputeHash(bytDataToHash)
        'Declare bytKey(31).  It will hold 256 bits.
        Dim bytKey(31) As Byte

        'Use For Next to put a specific size (256 bits) of 
        'bytResult into bytKey. The 0 To 31 will put the first 256 bits
        'of 512 bits into bytKey.
        For i As Integer = 0 To 31
            bytKey(i) = bytResult(i)
        Next

        Return bytKey 'Return the key.
    End Function

    Public Function CreateIV(ByVal strPassword As String) As Byte()
        'Convert strPassword to an array and store in chrData.
        Dim chrData() As Char = strPassword.ToCharArray
        'Use intLength to get strPassword size.
        Dim intLength As Integer = chrData.GetUpperBound(0)
        'Declare bytDataToHash and make it the same size as chrData.
        Dim bytDataToHash(intLength) As Byte

        'Use For Next to convert and store chrData into bytDataToHash.
        For i As Integer = 0 To chrData.GetUpperBound(0)
            bytDataToHash(i) = CByte(Asc(chrData(i)))
        Next

        'Declare what hash to use.
        Dim SHA512 As New System.Security.Cryptography.SHA512Managed
        'Declare bytResult, Hash bytDataToHash and store it in bytResult.
        Dim bytResult As Byte() = SHA512.ComputeHash(bytDataToHash)
        'Declare bytIV(15).  It will hold 128 bits.
        Dim bytIV(15) As Byte

        'Use For Next to put a specific size (128 bits) of bytResult into bytIV.
        'The 0 To 30 for bytKey used the first 256 bits of the hashed password.
        'The 32 To 47 will put the next 128 bits into bytIV.
        For i As Integer = 32 To 47
            bytIV(i - 32) = bytResult(i)
        Next

        Return bytIV 'Return the IV.
    End Function

    Public Enum CryptoAction
        'Define the enumeration for CryptoAction.
        ActionEncrypt = 1
        ActionDecrypt = 2
    End Enum

    Public Sub Execute(ByVal strInputFile As String,
                                     ByVal strOutputFile As String,
                                     ByVal Direction As CryptoAction)
        'In case of errors.
        Dim fsInput As System.IO.FileStream
        Dim fsOutput As System.IO.FileStream

        'Setup file streams to handle input and output.
        fsInput = New System.IO.FileStream(strInputFile, FileMode.Open,
                                                  FileAccess.Read)
        fsOutput = New System.IO.FileStream(strOutputFile,
                                               FileMode.OpenOrCreate,
                                               FileAccess.Write)
        fsOutput.SetLength(0) 'make sure fsOutput is empty

        'Declare variables for encrypt/decrypt process.
        Dim bytBuffer(8192) As Byte 'holds a block of bytes for processing
        Dim lngBytesProcessed As Long = 0 'running count of bytes processed
        Dim lngFileLength As Long = fsInput.Length 'the input file's length
        Dim intBytesInCurrentBlock As Integer 'current bytes being processed
        Dim csCryptoStream As CryptoStream = Nothing
        'Declare your CryptoServiceProvider.
        Dim cspRijndael As New System.Security.Cryptography.RijndaelManaged

        'Determine if ecryption or decryption and setup CryptoStream.
        Select Case Direction
            Case CryptoAction.ActionEncrypt
                csCryptoStream = New CryptoStream(fsOutput,
                cspRijndael.CreateEncryptor(Key, IV),
                CryptoStreamMode.Write)

            Case CryptoAction.ActionDecrypt
                csCryptoStream = New CryptoStream(fsOutput,
                cspRijndael.CreateDecryptor(Key, IV),
                CryptoStreamMode.Write)
        End Select

        'Use While to loop until all of the file is processed.
        While lngBytesProcessed < lngFileLength
            'Read file with the input filestream.
            intBytesInCurrentBlock = fsInput.Read(bytBuffer, 0, 8192)
            'Write output file with the cryptostream.
            csCryptoStream.Write(bytBuffer, 0, intBytesInCurrentBlock)
            'Update lngBytesProcessed
            lngBytesProcessed += CLng(intBytesInCurrentBlock)
            'Update Progress Bar
            progressPercentage = CInt((lngBytesProcessed / lngFileLength) * 100)
        End While

        'Close FileStreams and CryptoStream
        csCryptoStream.Close()
        fsInput.Close()
        fsOutput.Close()
    End Sub

    Public Function ExecuteStream(ByVal strInputFile As String) As Stream
        'In case of errors.
        'In case of errors.

        Dim fsInput As System.IO.FileStream
        Dim fsOutput As System.IO.MemoryStream

        'Setup file streams to handle input and output.
        fsInput = New System.IO.FileStream(strInputFile, FileMode.Open,
                                                  FileAccess.Read)
        fsOutput = New MemoryStream()

        fsOutput.SetLength(0) 'make sure fsOutput is empty

        'Declare variables for encrypt/decrypt process.
        Dim bytBuffer(8192) As Byte 'holds a block of bytes for processing
        Dim lngBytesProcessed As Long = 0 'running count of bytes processed
        Dim lngFileLength As Long = fsInput.Length 'the input file's length
        Dim intBytesInCurrentBlock As Integer 'current bytes being processed
        Dim csCryptoStream As CryptoStream
        'Declare your CryptoServiceProvider.
        Dim cspRijndael As New System.Security.Cryptography.RijndaelManaged

        'Determine if ecryption or decryption and setup CryptoStream.
        csCryptoStream = New CryptoStream(fsOutput, cspRijndael.CreateDecryptor(Key, IV), CryptoStreamMode.Write)

        'Use While to loop until all of the file is processed.
        While lngBytesProcessed < lngFileLength
            'Read file with the input filestream.
            intBytesInCurrentBlock = fsInput.Read(bytBuffer, 0, 8192)
            'Write output file with the cryptostream.
            csCryptoStream.Write(bytBuffer, 0, intBytesInCurrentBlock)
            'Update lngBytesProcessed
            lngBytesProcessed += CLng(intBytesInCurrentBlock)
        End While

        Return fsOutput

        'Close FileStreams and CryptoStream
        csCryptoStream.Close()
        fsInput.Close()
        fsOutput.Close()

    End Function



    Function ComputeMD5(ByVal file_name As String)
        Dim hash = MD5.Create()
        Dim hashValue() As Byte
        Dim fileStream As FileStream = File.OpenRead(file_name)
        fileStream.Position = 0
        hashValue = hash.ComputeHash(fileStream)
        Dim hash_hex = PrintByteArray(hashValue)
        fileStream.Close()
        Return hash_hex
    End Function

    Public Function PrintByteArray(ByVal array() As Byte)
        Dim hex_value As String = ""
        Dim i As Integer
        For i = 0 To array.Length - 1
            hex_value += array(i).ToString("x2")
        Next i
        Return hex_value.ToLower
    End Function


End Module
