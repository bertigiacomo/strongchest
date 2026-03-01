Imports System.ComponentModel
Imports System.IO
Imports Strongchest.ManangeSpace

Public Class Home

    Dim FilesList() As String

    ReadOnly ImportControl As New ImportDataControl

    Public Shared LowestLimit As Integer

    Public Shared VoidControl As New VoidControl

    Public Shared DataList As New List(Of CheckElement)


    Private Sub OpenSettings(sender As Object, e As EventArgs) Handles menuOpenSettings.Click

        Design.PanelSwitch(SettingsGUI)

    End Sub

    Private Sub HomeForm_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If

    End Sub

    Private Sub HomeForm_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop

        'Controlla se il limite è già stato superato
        If Settings.SpaceLimitMB <> 0 And LowestLimit < 0 Then
            Notification.NotifySpace()
            Exit Sub
        End If

        filesList = e.Data.GetData(DataFormats.FileDrop)

        'Controlla se i dati da aggiungere superano il limite
        Dim InputSize As Integer
        If Settings.SpaceLimitMB <> 0 Then

            For Each Data As String In filesList

                If IO.Directory.Exists(Data) Then

                    InputSize += Convert.ToInt32(GetFolderSize(Data) / 1000000)

                ElseIf IO.File.Exists(Data) Then

                    Dim fileAttrib As New IO.FileInfo(Data)
                    InputSize += Convert.ToInt32(fileAttrib.Length \ 1000000)

                End If

            Next

            'Dichiarazione variabili per il calcolo dati
            Dim limitMB As Integer = Limits.Item(Settings.SpaceLimitMB)
            Dim filesMB As Integer = Convert.ToInt32(GetFolderSize(Paths.UserData) / 1000000)
            Dim avlimMB As Integer = limitMB - filesMB

            If avlimMB < InputSize Then
                Notification.NotifySpace()
                filesList = Nothing
                Exit Sub

            End If

        End If

        'Avvia il worker
        AddFiles.RunWorkerAsync()

        'Aggiungi il controllo "import"
        ImportControl.Dock = DockStyle.Top
        ImportControl.Size = New Size(Width, 42)
        ImportControl.Anchor = (AnchorStyles.Left Or AnchorStyles.Right)
        ImportControl.Dock = DockStyle.Top
        ElementsPanel.Controls.Add(ImportControl)

        'Avvia timer
        tmrUpdateData.Start()

    End Sub

    Private Sub UpdateData()

        'Variabili
        Dim CurrentWork = GlobalData.StringCurrentFile
        Dim SecondsCount = 0

        'Aggiorna contatori e label
        While Me.AddFiles.IsBusy = True
            WaitMilliseconds(1)

            'Nascondi opzione aggiorna e apri explorer
            cxtUpdate.Enabled = False
            cxtOpenExplorer.Enabled = False

            'Aggiorna variabili
            If CurrentWork = GlobalData.StringCurrentFile Then
                SecondsCount += 1
            Else
                CurrentWork = GlobalData.StringCurrentFile
                SecondsCount = 0
            End If

            'Se ci mette troppo tempo a cifrare i file
            If SecondsCount > 90 Then
                ImportControl.ProgressBar.Value = progressPercentage
                If GlobalData.TotalFilesCount = 1 Then
                    ImportControl.lblBig.Text = "Aggiungo " & GlobalData.StringCurrentFile & " — " & progressPercentage & "%"
                Else
                    ImportControl.lblBig.Text = "Aggiungo " & GlobalData.StringCurrentFile & " — " & progressPercentage & "% (Aggiunti " & GlobalData.TotalFilesCount & " files)"
                End If

            Else
                If GlobalData.TotalFilesCount = 1 Then
                    ImportControl.lblBig.Text = "Aggiunta di " & GlobalData.TotalFilesCount & " file alla libreria protetta"
                Else
                    ImportControl.lblBig.Text = "Aggiunti " & GlobalData.TotalFilesCount & " files alla libreria protetta"
                End If
                ImportControl.ProgressBar.Value = 60
            End If
        End While

        'Riabilita la funzione aggiorna
        cxtUpdate.Enabled = True
        cxtOpenExplorer.Enabled = True

    End Sub


    Private Sub WrkAddNewFiles_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles AddFiles.DoWork

        For Each droppedObject As String In FilesList

            'Check if it's a file or a directory
            If IO.Directory.Exists(droppedObject) Then

                'RECUPERA OGGETTI NELLA PRINCIPALE
                '==========================================

                Dim givenParentDirectory = droppedObject
                Dim getAbsoluteParentName = givenParentDirectory.Split("\")
                Dim givenAbsoluteDirectoryName = getAbsoluteParentName(getAbsoluteParentName.Length - 1)

                IO.Directory.CreateDirectory(Paths.workingDirectory & "\" & givenAbsoluteDirectoryName)

                For Each parentFile In My.Computer.FileSystem.GetFiles(droppedObject)
                    GlobalData.TotalFilesCount += 1
                    GlobalData.StringCurrentFile = Path.GetFileName(parentFile)
                    Execute(parentFile, Paths.workingDirectory & "\" & givenAbsoluteDirectoryName & "\" & Path.GetFileName(parentFile), CryptoAction.ActionEncrypt)
                Next



                'RECUPERA FILE NELLE SUBS
                '===========================================

                Dim givenDirectory = droppedObject

                Dim getParentName = givenDirectory.Split("\")
                Dim givenDirectoryName = getParentName(getParentName.Length - 1)
                'Ottieni lista file

                For Each subDirectory In My.Computer.FileSystem.GetDirectories(givenDirectory, FileIO.SearchOption.SearchAllSubDirectories, "*")

                    Dim subDirectoryPerc = subDirectory.Replace(givenDirectory & "\", "") ' sub1    sub1\sub2
                    IO.Directory.CreateDirectory(Paths.workingDirectory & "\" & givenDirectoryName & "\" & subDirectoryPerc)

                    For Each subFile In My.Computer.FileSystem.GetFiles(subDirectory, FileIO.SearchOption.SearchTopLevelOnly, "*.*")
                        Dim subFilePerc = subDirectory.Replace(givenDirectory & "\", "")
                        Execute(subFile, Paths.workingDirectory & "\" & givenDirectoryName & "\" & subFilePerc & "\" & Path.GetFileName(subFile), CryptoAction.ActionEncrypt)
                        GlobalData.StringCurrentFile = Path.GetFileName(subFile)
                        GlobalData.TotalFilesCount += 1
                    Next
                Next

                '================================================

            ElseIf IO.File.Exists(droppedObject) Then
                'SE L'OGGETTO TRASCINATO E' UN FILE
                GlobalData.TotalFilesCount += 1
                GlobalData.StringCurrentFile = IO.Path.GetFileName(droppedObject)
                Execute(droppedObject, Paths.workingDirectory & IO.Path.GetFileName(droppedObject), CryptoAction.ActionEncrypt)
            End If
        Next

    End Sub

    Private Sub WorkerAddNewFiles_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles AddFiles.RunWorkerCompleted

        'Riattiva controlli
        AllowDrop = True

        'Scrivi nuovo log
        Log.Add("Added new files to storage: " & GlobalData.TotalFilesCount & "file add")

        'Chiudi il form delle operazioni
        GlobalData.TotalFilesCount = 0
        ElementsPanel.Controls.Remove(ImportControl)

        'Resetta la progressbar
        GlobalData.ProgressBarCurrentValue = 0

        'Aggiorna l'explorer
        Call UpdateExplorer()

    End Sub
    Sub CallUpdateExporer() Handles cxtUpdate.Click
        UpdateExplorer()
    End Sub

    Public Shared Sub UpdateExplorer()

        'Controlla se è in aggiunta qualche dato
        If Home.AddFiles.IsBusy = True Then
            Exit Sub
        End If

        'Elimina controlli
        Home.ElementsPanel.Controls.Clear()

        'Crea resizer
        Design.CreateResizer()

        'Rigenera le chiavi
        IV = CreateIV(GlobalData.UserPassword)
        Key = CreateKey(GlobalData.UserPassword)

        'Aggiorna directory
        Dim filesDirectory = Paths.workingDirectory
        Dim filesNumber As Integer = My.Computer.FileSystem.GetFiles(filesDirectory, FileIO.SearchOption.SearchTopLevelOnly, "*.*").Count
        Dim dirsNumber As Integer = My.Computer.FileSystem.GetDirectories(filesDirectory, FileIO.SearchOption.SearchTopLevelOnly).Count

        'Aggiorna la working directory
        Dim precedentDir = Paths.workingDirectory.Substring(0, Paths.workingDirectory.Length - 1)
        Dim trimmedDir = precedentDir.Replace(Paths.UserData.Substring(0, Paths.UserData.Length - 1), "")
        Home.DirectoryLabel.Text = "Home" & trimmedDir.Replace("\", " > ")

        'Se i file e cartelle sono zero
        If filesNumber = 0 And dirsNumber = 0 Then
            If Paths.workingDirectory = Paths.UserData Then
                VoidControl.lblBig.Text = "La tua strongchest è vuota." & vbNewLine & "Trascina qualche file o cartella per iniziare."
                Home.DirectoryLabel.Text = ""
            Else
                VoidControl.lblBig.Text = "Questa cartella è vuota." & vbNewLine & "Trascina qualcosa all'interno."
            End If

            'Aggiungi controllo "cartella vuota"
            Home.Controls.Add(VoidControl)
            VoidControl.Visible = True
            VoidControl.BringToFront()

            'Disattiva funzioni esportazione
            SettingsGUI.ExportSpace.Text = "Funzione esporta disabilitata"
            SettingsGUI.ExportSpace.Enabled = False


            Exit Sub
        Else

            'Nascondi controlli "cartella vuota"
            VoidControl.Visible = False

            'Riattiva funzioni esportazione
            SettingsGUI.ExportSpace.Enabled = True
            SettingsGUI.ExportSpace.Text = "Esporta spazio"


        End If

        'Riattiva controlli "torna indietro"
        Home.goBack.Visible = True
        Home.Controls.Remove(VoidControl)

        'Per ogni file, aggiungi un controllo
        For Each file In My.Computer.FileSystem.GetFiles(filesDirectory, FileIO.SearchOption.SearchTopLevelOnly, "*.*")
            Dim visualFile As New Element
            Dim attiributesFiles As New FileInfo(file)
            visualFile.Path = file
            visualFile.IsFolder = False
            visualFile.SizeOrElement = attiributesFiles.Length
            visualFile.Size = New Size(Home.Width, 42)
            visualFile.Anchor = AnchorStyles.Left Or AnchorStyles.Right
            visualFile.Dock = DockStyle.Top
            Home.ElementsPanel.Controls.Add(visualFile)
        Next

        'Per ogni cartella aggiungi un controllo
        For Each folder In My.Computer.FileSystem.GetDirectories(filesDirectory, FileIO.SearchOption.SearchTopLevelOnly, "*")


            Dim visualDir As New Element With {
                .IsFolder = True,
                .Path = folder,
                .SizeOrElement = My.Computer.FileSystem.GetFiles(folder, FileIO.SearchOption.SearchAllSubDirectories).Count,
               .Size = New Size(Home.Width, 42),
                .Anchor = AnchorStyles.Left Or AnchorStyles.Right,
                .Dock = DockStyle.Top
            }
            Home.ElementsPanel.Controls.Add(visualDir)
        Next

    End Sub

    Public Shared Sub StartInterface() Handles MyBase.Load

        'Posiziona avviso "cartella vuota"
        VoidControl.Anchor = AnchorStyles.None
        VoidControl.Location = New Point((Home.Width - 400) / 2, (Home.Height - 60) / 2)
        VoidControl.Visible = False
        Home.Controls.Add(VoidControl)
        Design.ScrollBars = New Guna.UI.Lib.ScrollBar.PanelScrollHelper(Home.ElementsPanel, Home.HomeScrollBars, True)

        'Disabilita info azienda se non è abilitata
        If Business.Enabled = False Then Home.menuCompany.Visible = False

        'Avvia controllo modifiche file e aggiornamento directory
        Home.FileEdit.RunWorkerAsync()

    End Sub

    Private Sub CreateFolder(sender As Object, e As EventArgs) Handles cxtNewFolder.Click

        'Ottieni nome della cartella dall'utente
        Dim dirName = AskData("Inserisci il nome della cartella che vuoi creare", "", False, True)
        If dirName = Nothing Then Exit Sub
        If IO.Directory.Exists(Paths.workingDirectory & "\" & dirName) Then

            'Controlla se esiste già
            If Not dirName = Nothing Then
                AdviseBox("Questa cartella esiste già! Prova ad aggiornare se non riesci a visualizzarla.")
            End If
            Exit Sub
        End If

        'Crea cartella
        IO.Directory.CreateDirectory(Paths.workingDirectory & dirName)
        Call UpdateExplorer()

    End Sub

    Private Sub OpenFileExplorer(sender As Object, e As EventArgs) Handles cxtOpenExplorer.Click
        AdviseBox("I file possono essere aperti solo con Strongchest, l'explorer serve ad organizzarli o rinominarli.")
        Process.Start(Paths.workingDirectory)
    End Sub

    Private Sub StartFunc(sender As Object, e As EventArgs) Handles btnConfirm.Click
        GlobalData.SelectedFolder = Paths.workingDirectory
    End Sub

    Private Sub AbortFunc(sender As Object, e As EventArgs) Handles btnAbort.Click
        ChangeLocationPanel.Visible = False
        GlobalData.NowSelectFolder = False
    End Sub

    Private Sub GoBackFunc(sender As Object, e As EventArgs) Handles goBack.Click

        'Torna alla directory precendete
        If Paths.workingDirectory = Paths.UserData Then
            Exit Sub
        End If

        'Dichiarazioni
        Dim updatedWorkingDir = IO.Path.GetDirectoryName(Paths.workingDirectory)
        updatedWorkingDir = IO.Path.GetDirectoryName(updatedWorkingDir)

        'Aggiorna explorer
        Paths.workingDirectory = updatedWorkingDir & "\"
        UpdateExplorer()

    End Sub

    Private Sub CallUpdateExporer(sender As Object, e As EventArgs) Handles cxtUpdate.Click
        Call UpdateExplorer()
    End Sub

    Private Sub OpenMenu_Click(sender As Object, e As EventArgs)
        HamburgerMenu.Show(MainContainer.DesktopLocation.X + NavBarSettings.Location.X, MainContainer.DesktopLocation.Y + NavBarSettings.Location.Y + (NavBarSettings.Size.Height * 2))
    End Sub

    Private Sub OpenSettingsNavBar() Handles NavBarSettings.Click
        Design.PanelSwitch(SettingsGUI)
    End Sub


    Private Sub MenuLogOut_Click(sender As Object, e As EventArgs)
        Application.Restart()
    End Sub

    Private Sub MenuInfoAbout_Click(sender As Object, e As EventArgs) Handles menuInfoAbout.Click
        AboutStrongchest.Show()
    End Sub

    Private Sub TrspPanel_Paint(sender As Object, e As PaintEventArgs)
        e.Graphics.DrawLine(Pens.Yellow, 0, 0, 100, 100)
    End Sub

    Private Sub TmrUpdateData_Tick(sender As Object, e As EventArgs) Handles tmrUpdateData.Tick
        tmrUpdateData.Stop()
        Call UpdateData()
    End Sub

    Private Sub MenuManage_Click(sender As Object, e As EventArgs) Handles menuManage.Click

        'Show menu
        Design.PanelSwitch(ManangeSpace)

    End Sub

    Private Sub HomeShown(sender As Object, e As EventArgs) Handles Me.Shown

        'Aggiorna explorer
        UpdateExplorer()

    End Sub

    Public Sub CreateResizerHome()

        'Crea controller
        Design.CreateResizer()

    End Sub

    Private Sub FileEdit_DoWork(sender As Object, e As DoWorkEventArgs) Handles FileEdit.DoWork

        While (True)

            For Each File As CheckElement In DataList.ToList

                WaitMilliseconds(1)

                Try

                    'Verifica checksum
                    Dim CheckingChecksum = ComputeMD5(File.EditPath)
                    If File.CurrentHash <> CheckingChecksum Then

                        'Verifica che la sorgente esisti
                        If Not IO.File.Exists(File.DataPath) Then

                            'Esci perche non esiste più il file
                            Continue For

                        End If

                        'Salva nuovo file
                        Execute(File.EditPath, File.DataPath, CryptoAction.ActionEncrypt)

                        'Aggiorna lista
                        Dim NewData As New CheckElement With {
                            .DataPath = File.DataPath,
                            .EditPath = File.EditPath,
                            .CurrentHash = CheckingChecksum
                        }
                        DataList.Remove(File)
                        DataList.Add(NewData)

                        'Scrivi log
                        Log.Add("New changes saved by Strongchest:")
                        Log.Add(" - File: " & IO.Path.GetFileName(NewData.DataPath))
                        Log.Add(" - Time: " & Date.Now)
                        Log.Add(" - Old Hash: " & File.CurrentHash)
                        Log.Add(" - New Hash: " & CheckingChecksum)

                        'Notifica utente
                        Notification.NotifyChanges(IO.Path.GetFileName(File.DataPath))



                    End If

                Catch
                End Try



            Next


        End While



    End Sub


    Private Sub MenuCompany_Click(sender As Object, e As EventArgs) Handles menuCompany.Click
        Design.PanelSwitch(CompanyGUI)
    End Sub

    Private Sub OpenSettingsNavBar(sender As Object, e As EventArgs) Handles NavBarSettings.Click

    End Sub
End Class

Public Class GlobalData

    'Definisce la password dell'utente
    Public Shared UserPassword As String = ""

    'Definisce le statistiche dei dai
    Public Shared TotalFilesCount As Integer = 0
    Public Shared StringCurrentFile As String
    Public Shared ProgressBarCurrentValue As Integer = 0

    'Gestisce le cartelle
    Public Shared NowSelectFolder As Boolean = False
    Public Shared SelectedFolder As String = ""

End Class

Public Class CheckElement
    Property CurrentHash
    Property EditPath
    Property DataPath

    End Class