Imports System.IO.Compression
Public Class Export
    Dim ProcessedFiles As Integer

    Private Sub FormLoad(sender As Object, e As EventArgs) Handles MyBase.Load

        'Cambia logo
        If IO.File.Exists(Paths.CompanyData & "company_logo.png") Then picLogo.Image = Image.FromFile(Paths.CompanyData & "company_logo.png")

        'Richiedi posizione file export
        If Not SaveExportDialog.ShowDialog = DialogResult.OK Then

            'Chiudi
            Application.Restart()

        End If

        'Elimina export precedenti
        If IO.Directory.Exists(Paths.TempData) = True Then IO.Directory.Delete(Paths.TempData, True)
        If IO.Directory.Exists(Paths.ExportData) = True Then IO.Directory.Delete(Paths.ExportData, True)


    End Sub

    Private Sub FormShown(sender As Object, e As EventArgs) Handles Me.Shown

        'Calcola la quantità di file
        Dim fileEnum = My.Computer.FileSystem.GetFiles(Paths.UserData, FileIO.SearchOption.SearchAllSubDirectories).Count

        'Avvia decifratura dei files
        FileDecrypt.RunWorkerAsync()

        'Rigenera chiavi
        IV = CreateIV(GlobalData.UserPassword)
        Key = CreateKey(GlobalData.UserPassword)

        'Aggiorna percentuale
        While FileDecrypt.IsBusy = True

            'Aspetta un pò
            WaitMilliseconds(1)

            'Aggiorna label
            Progress.Value = ((100 * ProcessedFiles) / fileEnum)

        End While

        'Avvia creazione zip
        CreateZip.RunWorkerAsync()

        'Attendi fine creazione zip
        While CreateZip.IsBusy = True

            'Aspetta un pò
            WaitMilliseconds(1)

        End While

        'Elimina cartella export
        IO.Directory.Delete(Paths.ExportData, True)

        'Rigenera chiavi
        IV = CreateIV(GlobalData.UserPassword)
        Key = CreateKey(GlobalData.UserPassword)

        'Avvia crypt dello zip
        EncryptArchive.RunWorkerAsync()

        'nel mentre che viene criptato lo zip
        While EncryptArchive.IsBusy = True

            'Aspetta un pò
            WaitMilliseconds(1)

            'Aggiorna dati
            Progress.Value = 100 + progressPercentage

        End While

        'Elimina zip non più utile
        IO.File.Delete(Paths.AppData & "export.data")

        'Avvia zip finale
        CreateData.RunWorkerAsync()

        'Nel mentre
        While CreateData.IsBusy = True

            'Aspetta un pò
            WaitMilliseconds(1)

        End While

        'Ripulisci cartella zip
        IO.Directory.Delete(Paths.AppData & "Zip", True)

        'Create log
        Log.Add("Space exported successfully:")
        Log.Add(" - File stored: " & fileEnum)
        Log.Add(" - Protected: Yes")
        Log.Add(" - Password Hash: " & ComputeSHA256(GlobalData.UserPassword))
        Log.Add(" - Storage ID: " & GetAlphaString(25))
        Log.Write()

        'Avvisa utente
        MainContainer.Show()
        Design.SwitchForm(Home)
        Me.Close()


    End Sub

    Private Sub FileDecrypt_Start(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles FileDecrypt.DoWork

        'Definisci directory
        IO.Directory.CreateDirectory(Paths.ExportData)
        CopyDirectory(Paths.UserData, Paths.ExportData)

        'Per ogni file, decripta
        For Each parentFile In My.Computer.FileSystem.GetFiles(Paths.UserData, FileIO.SearchOption.SearchTopLevelOnly)
            ProcessedFiles += 1
            Execute(parentFile, Paths.ExportData & IO.Path.GetFileName(parentFile), CryptoAction.ActionDecrypt)
        Next

        'Per ogni file in ogni sub directory
        For Each subDirectory In My.Computer.FileSystem.GetDirectories(Paths.UserData, FileIO.SearchOption.SearchAllSubDirectories, "*")

            For Each subFile In My.Computer.FileSystem.GetFiles(subDirectory, FileIO.SearchOption.SearchTopLevelOnly, "*.*")
                Execute(subFile, Paths.ExportData & "\" & subDirectory.Replace(Paths.UserData, "") & "\" & IO.Path.GetFileName(subFile), CryptoAction.ActionDecrypt)
                ProcessedFiles += 1
            Next

        Next


    End Sub

    Private Sub CreateZip_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles CreateZip.DoWork

        'Crea zip
        IO.Directory.CreateDirectory(Paths.AppData & "Zip")
        ZipFile.CreateFromDirectory(Paths.ExportData, Paths.AppData & "export.data")

    End Sub

    Private Sub EncryptArchive_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles EncryptArchive.DoWork


        'Cripta lo zip
        Execute(Paths.AppData & "export.data", Paths.AppData & "Zip\export.data", CryptoAction.ActionEncrypt)

        'Crea impronta
        IO.File.WriteAllText(Paths.AppData & "Zip\password.hash", ComputeSHA256(GlobalData.UserPassword))


    End Sub

    Private Sub CreateData_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles CreateData.DoWork

        'Crea ultimo zip
        ZipFile.CreateFromDirectory(Paths.AppData & "Zip", SaveExportDialog.FileName)

    End Sub
End Class