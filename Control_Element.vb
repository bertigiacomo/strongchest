Imports System.ComponentModel
Imports Strongchest.Home

Public Class Element
    Property Path As String
    Property IsFolder As Boolean
    Property SizeOrElement As Decimal
    Property ID As String = GetAlphaString(25)


    Private Sub DesignElement() Handles MyBase.Load

        If Not IsFolder = True Then

            'Scrivi dimensione file
            Dim computeSize As Decimal = SizeOrElement \ 1000
            Dim finalString As String = ""

            'Cacola se mettere KB, MB, o GB
            If computeSize > 1000000 Then

                'Il file occupa 1GB o più, dividi i byte per 1.000.000
                computeSize \= 1000000
                finalString = computeSize & " GB"

            ElseIf computeSize > 1000 Then

                'Il file occupa 1MB o più, dividi i byte per 1.000
                computeSize \= 1000
                finalString = computeSize & " MB"
            Else

                'Il file è in kilobytes
                finalString = computeSize & " KB"

            End If

            'Scrivi displayname e dimensione
            prDisplayName.Text = IO.Path.GetFileName(Path)
            prSize.Text = finalString

            'Scrivi l'orario
            Dim Parts() As String = IO.Directory.GetLastWriteTime(Path).ToString.Split(":")
            prLastModify.Text = Parts(0) & ":" & Parts(1)

            'Ottieni estensione
            Dim fileExtension = IO.Path.GetExtension(Path)

            'Associa un icona
            If fileExtension = ".mp4" Or fileExtension = ".avi" Or fileExtension = ".mov" Or fileExtension = ".m4a" Then
                pctPictureIcon.Image = My.Resources.el_movie
            ElseIf fileExtension = ".mp3" Or fileExtension = ".wmv" Or fileExtension = ".ogg" Or fileExtension = ".flac" Or fileExtension = ".wav" Then
                pctPictureIcon.Image = My.Resources.el_music
            ElseIf fileExtension = ".png" Or fileExtension = ".jpg" Or fileExtension = ".jpeg" Or fileExtension = ".gif" Then
                Try
                    pctPictureIcon.Image = Image.FromStream(ExecuteStream(Path))
                Catch
                End Try
            ElseIf fileExtension = ".heif" Then
                pctPictureIcon.Image = My.Resources.el_image
            Else
                Dim icon As Icon = Icon.ExtractAssociatedIcon(Path)
                pctPictureIcon.Image = Icon.ToBitmap
            End If
        Else

            'Ottieni nome cartella
            Dim getParentName = Path.Split("\")
            Dim givenDirectoryName = getParentName(getParentName.Length - 1)

            'Scrivi nome cartella
            prDisplayName.Text = givenDirectoryName
            prSize.Text = SizeOrElement & " elementi"

            'Scrivi orario
            Dim Parts() As String = IO.Directory.GetLastWriteTime(Path).ToString.Split(":")
            prLastModify.Text = Parts(0) & ":" & Parts(1)

            'Associa icona
            pctPictureIcon.Image = My.Resources.el_folder

        End If

    End Sub

    Sub OpenElement() Handles prDisplayName.DoubleClick, cxtOpen.Click, pctPictureIcon.DoubleClick

        'Controlla se è una cartella o un file
        If IsFolder = False Then

            'Disponi controlli
            pctPictureIcon.Visible = False
            ProgressBar.Value = 60
            ProgressBar.Visible = True
            OpenFile.RunWorkerAsync()

            'Aspetta un pò
            Wait(1)

            'Calcola percentuale decrypt
            While OpenFile.IsBusy
                WaitMilliseconds(1)
                ProgressBar.Value = progressPercentage
            End While

        Else

            'Aggiorna working folder
            Paths.workingDirectory = Path & "\"
            UpdateExplorer()

        End If

    End Sub

    Private Sub OpenFile_Do() Handles OpenFile.DoWork
        StartFile(Path, ID)
    End Sub

    Private Sub OpenFile_Complete() Handles OpenFile.RunWorkerCompleted

        'Ridisposizione contolli
        pctPictureIcon.Visible = True
        ProgressBar.Value = 60
        ProgressBar.Visible = False

    End Sub

    Private Sub Delete() Handles cxtDeleteElement.Click

        'Elimina file (o cartella)
        If IsFolder = True Then
            IO.Directory.Delete(Path, True)
        Else
            IO.File.Delete(Path)
        End If
        Home.ElementsPanel.Controls.Remove(Me)

        'Se non ci sono ne file ne cartelle allora mostra "Cartella vuota"
        Dim filesNumber As Integer = My.Computer.FileSystem.GetFiles(Paths.workingDirectory, FileIO.SearchOption.SearchTopLevelOnly, "*.*").Count
        Dim dirsNumber As Integer = My.Computer.FileSystem.GetDirectories(Paths.workingDirectory, FileIO.SearchOption.SearchTopLevelOnly).Count

        'Aggiorna exporer
        If filesNumber = 0 And dirsNumber = 0 Then
            Call UpdateExplorer()
        End If

    End Sub

    Private Sub Rename() Handles cxtRename.Click

        'Chiedi all'utente i dati per rinominare
        Dim Data As String
        Try
            If IsFolder = True Then

                'Ottieni il nome della cartella
                Dim getParentName = Path.Split("\")
                Dim givenDirectoryName = getParentName(getParentName.Length - 1)

                'Ottieni dall'utente il nome
                Data = AskData("Scrivi un nuovo nome", givenDirectoryName, False, True)
                If Data = Nothing Then Exit Sub
                IO.Directory.Move(Path, IO.Path.GetDirectoryName(Path) & "\" & Data)

                'Cambia testo senza aggiornare
                prDisplayName.Text = givenDirectoryName
                Path = IO.Path.GetDirectoryName(Path) & "\" & Data

            Else

                'Chiedi nome all'utente, rinomina elemento e aggiorna elemento nella home senza aggiornare
                Data = AskData("Scrivi un nuovo nome", IO.Path.GetFileNameWithoutExtension(Path), False, True)
                If Data = Nothing Then Exit Sub

                'Rinomina il file
                IO.File.Move(Path, Path.Replace(IO.Path.GetFileName(Path), "") & Data & IO.Path.GetExtension(Path))
                Path = Path.Replace(IO.Path.GetFileName(Path), "") & Data & IO.Path.GetExtension(Path)

            End If

            prDisplayName.Text = If(IsFolder = True, Data, Data & IO.Path.GetExtension(Path))

        Catch ex As Exception
            AdviseBox("Caratteri non validi inseriti del nome del file/cartella")
        End Try

    End Sub

    Private Sub MoveElement() Handles cxtMove.Click

        'Avvia selezione della cartella
        GlobalData.NowSelectFolder = True
        Home.ChangeLocationPanel.Visible = True

        'Mentre l'utente sceglie la cartella aspetta un pò
        While GlobalData.SelectedFolder = ""
            WaitMilliseconds(20)
        End While

        'Controlla se è una cartella o meno
        If IsFolder = True Then

            'Ottieni il safeFileName della cartella
            Dim getParentName = Path.Split("\")
            Dim givenDirectoryName = getParentName(getParentName.Length - 1)

            'Sposta i dati nella nuova cartella
            IO.Directory.Move(Path, Paths.workingDirectory & "\" & givenDirectoryName)

        Else

            'Sposta il file
            IO.File.Move(Path, Paths.workingDirectory & "\" & IO.Path.GetFileName(Path))

        End If

        'Rispristina i dati della selezione cartella
        GlobalData.SelectedFolder = ""
        Home.ChangeLocationPanel.Visible = False
        Call UpdateExplorer()

    End Sub

    Private Sub CopyElement() Handles cxtCopy.Click

        'Mostra dialogo per copiare files
        GlobalData.NowSelectFolder = True
        Home.ChangeLocationPanel.Visible = True

        'Mentre l'utente sceglie la cartella, aspetta un pò
        While GlobalData.SelectedFolder = ""
            WaitMilliseconds(20)
        End While

        'Copia il file nel punto specificato
        IO.File.Copy(Path, Paths.workingDirectory & "\" & IO.Path.GetFileName(Path))

        'Ripristina dati della selezione cartella nella home
        GlobalData.SelectedFolder = ""
        GlobalData.NowSelectFolder = False
        Home.ChangeLocationPanel.Visible = False

    End Sub

    Private Sub ExportElement() Handles cxtExport.Click

        If IsFolder = False Then

            'Ottieni dati di esportazione per il file
            Export_SelectLocation.FileName = IO.Path.GetFileName(Path)
            Export_SelectLocation.DefaultExt = IO.Path.GetExtension(Path)

            'Chiedi all'utente dove esportare il file
            If Export_SelectLocation.ShowDialog = DialogResult.OK Then Export.RunWorkerAsync() Else Exit Sub

            'Nascondi icona e mostra progress
            pctPictureIcon.Visible = False
            ProgressBar.Visible = True

            'Aspetta un pò
            Wait(2)

            'Calcola la percentuale di esportazione
            While Export.IsBusy

                WaitMilliseconds(1)
                ProgressBar.Value = progressPercentage

            End While
        End If

    End Sub

    Private Sub ExportFile() Handles Export.DoWork
        Execute(Path, Export_SelectLocation.FileName, CryptoAction.ActionDecrypt)
    End Sub

    Private Sub ExportFileComplete() Handles Export.RunWorkerCompleted

        'Ripristina controlli
        GlobalData.ProgressBarCurrentValue = 0
        ProgressBar.Value = 60
        pctPictureIcon.Visible = True
        ProgressBar.Visible = False

        'Notifica l'utente che il file è stato esportato
        Notification.NotifyExport(IO.Path.GetFileName(Path))

    End Sub

    Private Sub ContextMenu_Opened() Handles RightClick.Opened

        'Focalizza elemento corrente
        prDisplayName.ForeColor = Color.White
        BackColor = Color.FromArgb(40, 41, 42)

    End Sub

    Private Sub ContextMenu_Closed(sender As Object, e As ToolStripDropDownClosedEventArgs) Handles RightClick.Closed

        'Ripristina colore di default
        prDisplayName.ForeColor = Color.Gainsboro
        BackColor = Color.FromArgb(30, 31, 32)

    End Sub

    Private Sub ContextMenu_Opening(sender As Object, e As CancelEventArgs) Handles RightClick.Opening

        'Mostra o nascondi alcune funzioni se è una cartella
        If IsFolder = True Then
            cxtMove.Visible = False
            cxtCopy.Visible = False
        Else
            cxtMove.Visible = True
            cxtCopy.Visible = True
        End If

    End Sub
End Class
