Imports System.ComponentModel
Imports Newtonsoft.Json
Imports Strongchest.Home


Public Class ChangePassword
    Dim ProcessedFiles = 0
    Public Shared Password As String = Nothing

    Private Sub FormShown(sender As Object, e As EventArgs) Handles Me.Shown

        'Calcola la quantità di file
        Dim fileEnum = My.Computer.FileSystem.GetFiles(Paths.UserData, FileIO.SearchOption.SearchAllSubDirectories).Count

        'Ferma modifica file
        Home.Close()
        LoginPage.Close()

        'Avvia decittazione dati
        FileDecryption.RunWorkerAsync()

        'Attendi completamento
        While FileDecryption.IsBusy = True

            'Aspetta un pò
            WaitMilliseconds(1)

            'Aggiorna label
            Progress.Value = ((100 * ProcessedFiles) / fileEnum) / 2

        End While

        'Avvia cifratura dati
        FileEncryption.RunWorkerAsync()

        'Crea nuove chiavi
        IV = CreateIV(Password)
        Key = CreateKey(Password)

        'Attendi completamento
        While FileEncryption.IsBusy = True

            'Aspetta un pò
            WaitMilliseconds(1)

            'Aggiorna label
            Progress.Value = ((100 * ProcessedFiles) / fileEnum) / 2

        End While

        'Elimina cartella esportazione
        IO.Directory.Delete(Paths.ExportData, True)

        'Aggiorna password
        StorageInfo.Password = ComputeSHA256(Password)

        'Scrivi log
        Log.Add("Changed password successfully:")
        Log.Add(" - File count: " & fileEnum.ToString)
        Log.Add(" - Time: " & Date.Now.ToString)
        Log.Add(" - New Key Hash: " & ComputeSHA256(Password))
        Log.Add(" - Old Key Hash: " & ComputeSHA256(GlobalData.UserPassword))
        Log.Write()

        'Resetta password
        Password = Nothing
        GlobalData.UserPassword = Nothing

        'Scrivi dati
        Storage.WriteData

        'Riavvia
        Application.Restart()


    End Sub

    Private Sub FileDecryption_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles FileDecryption.DoWork

        'Elimina export precedenti
        If IO.Directory.Exists(Paths.TempData) = True Then IO.Directory.Delete(Paths.TempData, True)
        If IO.Directory.Exists(Paths.ExportData) = True Then IO.Directory.Delete(Paths.ExportData, True)

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

    Private Sub FileEncryption_DoWork(sender As Object, e As DoWorkEventArgs) Handles FileEncryption.DoWork

        'Per ogni file, decripta
        For Each parentFile In My.Computer.FileSystem.GetFiles(Paths.ExportData, FileIO.SearchOption.SearchTopLevelOnly)
            ProcessedFiles += 1
            Execute(parentFile, Paths.UserData & IO.Path.GetFileName(parentFile), CryptoAction.ActionEncrypt)
        Next

        'Per ogni file in ogni sub directory
        For Each subDirectory In My.Computer.FileSystem.GetDirectories(Paths.ExportData, FileIO.SearchOption.SearchAllSubDirectories, "*")

            For Each subFile In My.Computer.FileSystem.GetFiles(subDirectory, FileIO.SearchOption.SearchTopLevelOnly, "*.*")
                Execute(subFile, Paths.UserData & "\" & subDirectory.Replace(Paths.ExportData, "") & "\" & IO.Path.GetFileName(subFile), CryptoAction.ActionEncrypt)
                ProcessedFiles += 1
            Next

        Next



    End Sub

    Private Sub ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IO.File.Exists(Paths.CompanyData & "company_logo.png") Then picLogo.Image = Image.FromFile(Paths.CompanyData & "company_logo.png")
    End Sub
End Class