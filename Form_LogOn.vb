Imports Newtonsoft.Json
Imports Strongchest.Home

Public Class LoginPage

    Dim buttonClickable As Boolean
    Dim passwordErrorCount As Integer

    Private Sub LogOn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Scrivi versione
        ShowInTaskbar = True
        tmrPasswordChecker.Start()

        'Posizione controller
        Design.CreateResizer()

        'Imposta i vari messaggi
        If Settings.IsSetUp = True Then
            StartInterface.Text = "Effettua accesso"
            lblOtherOptions.Text = "Reimposta password e altre opzioni"
        Else
            StartInterface.Text = "Crea spazio"
            lblOtherOptions.Text = "Visualizza più opzioni"
            If Not Settings.FirstAccess = True Then
                tmrPasswordChecker.Start()
            End If
        End If

        'Imposta i messaggi del primo accesso
        If Settings.FirstAccess = True Then
            lblOtherOptions.Text = "Cambia password"
            lblPasswordTips.Text = "Conferma password"
            StartInterface.Text = "Completa creazione"
        End If

        'Cambia logo
        If Business.Enabled = True And IO.File.Exists(Paths.CompanyData & "company_logo.png") Then pctLogoStrongchest.Image = Image.FromFile(Paths.CompanyData & "company_logo.png")

    End Sub

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles StartInterface.Click


        If txtPassword.Text.Length < 8 Then
            Exit Sub
        End If

        Select Case Settings.IsSetUp
            Case True

                'Visualizza progress bar
                StartInterface.Visible = False
                ProgressBar.Visible = True
                ProgressBar.BringToFront()
                txtPassword.ReadOnly = True

                'Aggiorna pulsante e cursore
                Dim checkPassword = txtPassword.Text

                If Not ComputeSHA256(checkPassword) = StorageInfo.Password Then
                    StartInterface.Text = "Password sbagliata"
                    txtPassword.Text = ""
                    txtPassword.ReadOnly = False
                    buttonClickable = True
                    ProgressBar.Visible = False
                    StartInterface.Visible = True
                    passwordErrorCount += 1
                    Exit Sub
                End If

                'Imposta proprietà first access su false
                If Settings.FirstAccess = True Then
                    Settings.FirstAccess = False
                    Configs.SaveConfig()
                End If

                'Scrivi password
                GlobalData.UserPassword = txtPassword.Text

                'Aggiorna home
                Home.UpdateExplorer()

                'Scrivi log
                Log.Add("New access at the personal storage:")
                Log.Add(" - Time: " & Date.Now)
                Log.Add(" - Passowrd Error Count: " & passwordErrorCount)

                'Avvia suono di Strongchest
                My.Computer.Audio.Play(My.Resources.open, AudioPlayMode.Background)

                'Aspetta un poco
                WaitMilliseconds(50)

                'Avvia home
                Design.ShowBackground(Home)
                Me.Close()

            Case False

                'Ferma timer
                tmrPasswordChecker.Stop()
                Dim checkPassword = txtPassword.Text

                'Blocca tasto utente
                StartInterface.Enabled = False
                txtPassword.ReadOnly = True

                'Conferma password
                If Settings.FirstAccess = True Then
                    Settings.FirstAccess = False
                    Settings.IsSetUp = True
                    Configs.SaveConfig()
                    Design.SwitchForm(Home)
                    Exit Sub
                End If

                'Genera cartella protetta
                IO.Directory.CreateDirectory(Paths.AppData)
                IO.Directory.CreateDirectory(Paths.UserData)

                'Scrivi informazioni
                Dim parts() As String = My.User.Name.Split("\")
                Dim realUsername As String = parts(1)

                Dim hashedPassword = ComputeSHA256(checkPassword)
                StorageInfo.Version = 1
                StorageInfo.GenerationDate = Date.Now.ToString
                StorageInfo.Username = realUsername
                StorageInfo.Password = hashedPassword
                StorageInfo.ComputerName = parts(0)
                StorageInfo.StorageID = GetAlphaString(25)


                'Scrivi dati su disco
                Storage.WriteData()
                GlobalData.UserPassword = txtPassword.Text

                'Scrivi il log
                Log.Add("Created a new space with this Settings:")
                Log.Add(" - Storage Version: " & StorageInfo.Version)
                Log.Add(" - Creation Date: " & StorageInfo.GenerationDate)
                Log.Add(" - Password Hash: " & hashedPassword)
                Log.Add(" - Profile: " & My.User.Name)
                Log.Add(" - ID: " & StorageInfo.StorageID)
                Log.Write()

                'Finito
                Settings.FirstAccess = True
                Configs.SaveConfig()
                Application.Restart()




        End Select
    End Sub

    Private Sub OtherOptions(sender As Object, e As EventArgs) Handles lblOtherOptions.Click
        If Settings.IsSetUp = True And Settings.FirstAccess = True Then

            Configs.ResetSettings()
            Configs.SaveConfig()

            If IO.Directory.Exists(Paths.AppData) Then
                IO.Directory.Delete(Paths.AppData, True)
            End If

            Application.Restart()

        Else

            Design.PanelSwitch(LoginSettings)

        End If

    End Sub

    Private Sub TmrPasswordChecker_Tick(sender As Object, e As EventArgs) Handles tmrPasswordChecker.Tick


        If Settings.FirstAccess = False And Settings.IsSetUp = False Then
            If txtPassword.Text.Count >= 3 Then

                If txtPassword.Text.Count < 8 Then
                    buttonClickable = False
                    StartInterface.Font = New Font("DM Sans", 10.1, FontStyle.Italic)
                    StartInterface.Text = "Scrivi almeno 8 caratteri"
                ElseIf txtPassword.Text = "password" Or txtPassword.Text.Contains("qwerty") Or txtPassword.Text.Contains("123456") Then
                    buttonClickable = False
                    StartInterface.Font = New Font("DM Sans", 10.1, FontStyle.Italic)
                    StartInterface.Text = "Password troppo semplice"
                ElseIf txtPassword.Text.Count = 129 Then
                    buttonClickable = False
                    StartInterface.Font = New Font("DM Sans", 10.1, FontStyle.Italic)
                    StartInterface.Text = "Puoi usare massimo 128 caratteri"
                Else
                    buttonClickable = True
                    StartInterface.Font = New Font("DM Sans", 10.1, FontStyle.Regular)
                    StartInterface.Text = "Crea spazio protetto"
                End If

            Else
                buttonClickable = True
                StartInterface.Font = New Font("DM Sans", 10.1, FontStyle.Regular)
                lblPasswordTips.Text = "Inserisci una password"
                StartInterface.Text = "Crea spazio protetto"
            End If
        End If

        If txtPassword.Focused = True Then
            lblPasswordTips.Hide()
        End If



    End Sub

    Private Sub ShowInfo_Click(sender As Object, e As EventArgs) Handles lblDisplayVersion.Click
        AboutStrongchest.Show()
    End Sub

    Private Sub PasswordTips_Click(sender As Object, e As EventArgs) Handles lblPasswordTips.Click
        txtPassword.Focus()
        lblPasswordTips.Hide()
    End Sub

    Private Sub Form_LogOn_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        'Gestisci comandi
        Dim filePath = Command.Replace(Chr(34), "")
        If IO.File.Exists(filePath) Then
            If IO.Path.GetExtension(filePath) = ".chest" Then
                Import.ArchivePath = filePath
                Import.Show()
            End If
        Else
            If Command.Contains("autologon:") Then
                Dim password() = Command.Split(":")
                txtPassword.Text = password(1)
                lblPasswordTips.Visible = False
                StartInterface.PerformClick()
            End If
        End If

        'Avvia interfaccia Home
        Design.BackgroundSwitch(Home)


    End Sub
End Class