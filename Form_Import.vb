Imports System.IO.Compression
Imports Newtonsoft.Json

Public Class Import
    Public Shared ArchivePath
    Dim ProcessedFiles As Integer
    Dim ShaPassword As String = Nothing

    Private Sub Form_Import_Load(sender As Object, e As EventArgs) Handles MyBase.Shown

        'Avvio
        MainContainer.Hide()

        'Richiedi posizione file export
        If ArchivePath = Nothing Then

            If Not OpenExportDialog.ShowDialog = DialogResult.OK Then

                'Chiudi
                MainContainer.Show()
                ArchivePath = Nothing
                Me.Close()
                Exit Sub

            Else

                ArchivePath = OpenExportDialog.FileName

            End If
        End If

        'Aggiorna label
        DebugLabel.Text = "Creazione del nuovo spazio..."

        'Aspetta un pò
        Wait(1)

        'Ricrea la cartella export
        If IO.Directory.Exists(Paths.ExportData) Then IO.Directory.Delete(Paths.ExportData, True)
        IO.Directory.CreateDirectory(Paths.ExportData)

        'Avvia lettura
        ReadArchive.RunWorkerAsync()

        'Nel mentre
        If ReadArchive.IsBusy = True Then

            'Attendi un pò
            WaitMilliseconds(1)

        End If

        'Nascondimi
        Me.Hide()

        'Richiedi la password
        Dim Password As String = Nothing
        Dim Confirmed As Boolean = False
        While Confirmed = False

            'Ottieni input
            Password = AskData("Inserisci la password per sbloccare l'archivio", "", True)
            If Password = Nothing Then
                IO.Directory.Delete(Paths.ExportData, True)
                MainContainer.Show()
                Me.Close()
                Exit Sub
            End If

            If Not ComputeSHA256(Password) = ShaPassword Then

                If MsgBox("Password sbagliata, vuoi riprovare?", MsgBoxStyle.RetryCancel) <> MsgBoxResult.Retry Then
                    IO.Directory.Delete(Paths.ExportData, True)
                    MainContainer.Show()
                    Me.Close()
                End If

            Else

                Confirmed = True

            End If

        End While

        'Mostra
        Me.Show()

        'Verifica esistenza di uno spazio
        If Settings.IsSetUp = True Then

            'Avvisa utente
            Me.Hide()

            If MsgBox("Hai gia uno spazio configurato. Importando quello nuovo tutti i dati verranno eliminati. Continuare?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                'Elimina tutti i dati
                IO.Directory.Delete(Paths.UserData, True)
                IO.Directory.CreateDirectory(Paths.UserData)
                IO.File.Delete(Paths.AppData & "info.json")

            Else

                'Annulla processo
                If IO.Directory.Exists(Paths.ExportData) Then IO.Directory.Delete(Paths.ExportData, True)
                Application.Restart()

            End If
            Me.Show()

        End If

        'Crea chiavi
        IV = CreateIV(Password)
        Key = CreateKey(Password)

        'Avvia decittazione
        DecryptArchive.RunWorkerAsync()

        'Nel mentre
        While DecryptArchive.IsBusy = True

            'Aspetta un pò
            WaitMilliseconds(1)

            'Aggiorna progresso
            Progress.Value = progressPercentage

        End While

        'Ricrea cartella export
        IO.Directory.Delete(Paths.ExportData, True)
        IO.Directory.CreateDirectory(Paths.ExportData)

        'Crea data
        If Not IO.Directory.Exists(Paths.UserData) Then IO.Directory.CreateDirectory(Paths.UserData)

        'Avvio estrazione
        ImportData.RunWorkerAsync()

        'Nel mentre
        While ImportData.IsBusy = True

            'Aspetta un pò
            WaitMilliseconds(1)

        End While

        'Elimina archivio
        IO.File.Delete(Paths.AppData & "free.data")

        'Avvia cifratura dati
        EncryptData.RunWorkerAsync()

        'Conta files
        Dim fileEnum = My.Computer.FileSystem.GetFiles(Paths.ExportData, FileIO.SearchOption.SearchAllSubDirectories).Count

        'Nel mentre
        While EncryptData.IsBusy = True

            'Aggiorna progress
            If ProcessedFiles <> 0 Then Progress.Value = (ProcessedFiles * 100 / fileEnum) + 100

            'Aspetta un pò
            WaitMilliseconds(1)

        End While

        'Elimina exported
        IO.Directory.Delete(Paths.ExportData, True)

        'Aggiorna spazio
        Dim parts() As String = My.User.Name.Split("\")
        Dim realUsername As String = parts(1)

        'Nuovo archivio
        StorageInfo.Version = ApplicationConstants.StorageVersion
        StorageInfo.GenerationDate = Date.Now.ToString
        StorageInfo.Username = realUsername
        StorageInfo.Password = ShaPassword
        StorageInfo.ComputerName = parts(0)
        StorageInfo.StorageID = GetAlphaString(25)

        'Nuove impostazioni
        Settings.IsSetUp = True
        Settings.FirstAccess = False

        'Scrivi dati
        Storage.WriteData()
        Configs.SaveConfig()

        'Create log
        Log.Add("Space imported successfully with these settings:")
        Log.Add(" - Storage Version: " & StorageInfo.Version)
        Log.Add(" - Creation Date: " & StorageInfo.GenerationDate)
        Log.Add(" - Password Hash: " & ShaPassword)
        Log.Add(" - Profile: " & My.User.Name)
        Log.Add(" - Files count: " & My.Computer.FileSystem.GetFiles(Paths.UserData).Count)
        Log.Add(" - ID: " & StorageInfo.StorageID)
        Log.Write()

        Application.Exit()


    End Sub

    Private Sub ReadArchive_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles ReadArchive.DoWork

        ZipFile.ExtractToDirectory(ArchivePath, Paths.ExportData)
        ShaPassword = IO.File.ReadAllText(Paths.ExportData & "password.hash")

    End Sub

    Private Sub ImportData_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles ImportData.DoWork
        ZipFile.ExtractToDirectory(Paths.AppData & "free.data", Paths.ExportData)
    End Sub

    Private Sub DecryptArchive_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles DecryptArchive.DoWork
        Execute(Paths.ExportData & "export.data", Paths.AppData & "free.data", CryptoAction.ActionDecrypt)
    End Sub

    Private Sub EncryptData_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles EncryptData.DoWork

        'Definisci directory
        CopyDirectory(Paths.ExportData, Paths.UserData)

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

    Private Sub Form_Import_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        MainContainer.Hide()
        If IO.File.Exists(Paths.CompanyData & "company_logo.png") Then picLogo.Image = Image.FromFile(Paths.CompanyData & "company_logo.png")
    End Sub
End Class