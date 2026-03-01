Imports System.IO
Module FunctionsApp
    Public Sub Wait(ByVal seconds As Integer)
        For i As Integer = 0 To seconds * 100
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub
    Public Sub WaitMilliseconds(ByVal seconds As Integer)
        For i As Integer = 0 To seconds
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub



    Public Function ComputeSHA256(ByVal text As String) As String
        Dim Crypto As New Security.Cryptography.SHA256CryptoServiceProvider
        Dim ByteString() As Byte = System.Text.Encoding.ASCII.GetBytes(text)
        ByteString = Crypto.ComputeHash(ByteString)

        Dim finalString As String = Nothing
        For Each bt As Byte In ByteString
            finalString &= bt.ToString("x2")
        Next

        Return finalString

    End Function
    Public Function StringEncrypt(ByVal input As String, ByVal pass As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim encrypted As String
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateEncryptor
            Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(input)
            encrypted = Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return encrypted
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function StringDecrypt(ByVal input As String, ByVal pass As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim decrypted As String
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateDecryptor
            Dim Buffer As Byte() = Convert.FromBase64String(input)
            decrypted = System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return decrypted
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Sub StartFile(ByVal Path As String, ID As String)

        'Dichiarazione variabili
        Dim fileOpeningDir = Paths.TempData & ID & "\" & IO.Path.GetFileNameWithoutExtension(Path) & " (Strongchest)" & IO.Path.GetExtension(Path)

        'Dichiarazioni
        Dim fileDirOutput = Paths.TempData & ID & "\"

        'Crea cartella
        If Not IO.Directory.Exists(fileDirOutput) Then IO.Directory.CreateDirectory(fileDirOutput)
        If IO.File.Exists(fileOpeningDir) Then
            Process.Start(fileOpeningDir)
            Exit Sub
        End If

        'Crea elemento
        Dim Data As New CheckElement With {
            .EditPath = fileOpeningDir,
            .DataPath = Path
        }

        'Aggiungi Hash
        Execute(Path, fileOpeningDir, CryptoAction.ActionDecrypt)
        Data.CurrentHash = ComputeMD5(fileOpeningDir)

        'Aggiungi alla lista
        Home.DataList.Add(Data)

        'Apri il nuovo file
        Process.Start(fileOpeningDir)

    End Sub


    Public Function AskData(Display As String, Optional WrittenData As String = "", Optional Password As Boolean = False, Optional Emmbedded As Boolean = False) As String

        'Imposta i cambi da chiedere all'utente
        MsgBoxGetData.Display = Display
        MsgBoxGetData.IsPass = Password
        MsgBoxGetData.WrittenData = WrittenData

        'Mostra in base alla funziome
        If Emmbedded = True Then
            Design.PanelSwitch(MsgBoxGetData)
        Else
            MsgBoxGetData.Show()
        End If

        'Aspetta che i dati vengano inviati
        While MsgBoxGetData.DataSubmitted = False
            WaitMilliseconds(1)
        End While

        'Scrivi dati
        Dim Data = MsgBoxGetData.DataRequested

        'Ripristina form
        MsgBoxGetData.DataRequested = Nothing
        MsgBoxGetData.DataSubmitted = False
        MsgBoxGetData.txtDataRequest.Text = ""

        'Chiudi e ritorna i dati
        MsgBoxGetData.Close()
        Return Data

    End Function

    Function GetFolderSize(ByVal DirPath As String,
   Optional IncludeSubFolders As Boolean = True) As Long

        Dim lngDirSize As Long
        Dim objFileInfo As FileInfo
        Dim objDir As DirectoryInfo = New DirectoryInfo(DirPath)
        Dim objSubFolder As DirectoryInfo

        Try

            'add length of each file
            For Each objFileInfo In objDir.GetFiles()
                lngDirSize += objFileInfo.Length
            Next

            'call recursively to get sub folders
            'if you don't want this set optional
            'parameter to false 
            If IncludeSubFolders Then
                For Each objSubFolder In objDir.GetDirectories()
                    lngDirSize += GetFolderSize(objSubFolder.FullName)
                Next
            End If

        Catch Ex As Exception


        End Try

        Return lngDirSize
    End Function

    Public Sub CopyDirectory(ByVal sourcePath As String, ByVal destinationPath As String)
        Dim sourceDirectoryInfo As New System.IO.DirectoryInfo(sourcePath)

        ' If the destination folder don't exist then create it
        If Not System.IO.Directory.Exists(destinationPath) Then
            System.IO.Directory.CreateDirectory(destinationPath)
        End If

        Dim fileSystemInfo As System.IO.FileSystemInfo
        For Each fileSystemInfo In sourceDirectoryInfo.GetFileSystemInfos
            Dim destinationFileName As String =
                System.IO.Path.Combine(destinationPath, fileSystemInfo.Name)

            ' Now check whether its a file or a folder and take action accordingly
            If TypeOf fileSystemInfo Is System.IO.FileInfo Then
                'System.IO.File.Copy(fileSystemInfo.FullName, destinationFileName, True)
            Else
                ' Recursively call the mothod to copy all the neste folders
                CopyDirectory(fileSystemInfo.FullName, destinationFileName)
            End If
        Next
    End Sub



End Module
