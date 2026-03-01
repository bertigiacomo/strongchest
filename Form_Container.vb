Imports System.ComponentModel
Imports System.Net
Imports Newtonsoft.Json


Public Class MainContainer
    Sub CloseApplication() Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub ContainerStart(sender As Object, e As EventArgs) Handles Me.Load

        'Inizializza profilo utente e business
        Configs.InizializeSettings()
        Storage.InizializeStorage()
        Company.InizializeSettings()

        'Carica limiti spazio
        ManangeSpace.DeclareDic()

        'Elimina installer
        If IO.File.Exists("installer.msi") Then IO.File.Delete("installer.msi")

        'Ridimensiona
        Design.SetWindowsSize()

        'Disegna form
        Design.SetTheme()
        Design.SwitchForm(LoginPage)
        CenterToScreen()

        'Cerca aggiornamenti
        If Network.CheckForUpdates = True Then

            Dim updateNotification As New Control_NotificationTop
            updateNotification.Location = New Point((Size.Width - updateNotification.Size.Width) / 2, 25)
            pnlContainer.Controls.Add(updateNotification)
            updateNotification.Show()
            updateNotification.BringToFront()

        ElseIf Business.Enabled = True And Not IO.File.Exists(Paths.CompanyData & "company_logo.png") Then

            Dim businessNotify As New Control_NotificationTop
            businessNotify.Location = New Point((Size.Width - businessNotify.Size.Width) / 2, 25)
            pnlContainer.Controls.Add(businessNotify)
            businessNotify.NotificationClick.Text = "Questa copia di Strongchest è gestita da """ & Business.DisplayName & """. Maggiori info."
            businessNotify.NotificationClick.Image = Nothing
            businessNotify.Show()
            businessNotify.BringToFront()

        End If

        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)

    End Sub
    Private Sub ContainerForm_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd

        'Salva dimensioni schermo
        Settings.AppSize = Size
        Configs.SaveConfig()

    End Sub

    Private Sub WindowsMinimize(sender As Object, e As EventArgs) Handles btnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub WindowsMaximize(sender As Object, e As EventArgs) Handles btnMaximize.Click
        If Me.WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Normal
        Else
            WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub CloseApplication(sender As Object, e As EventArgs) Handles btnClose.Click

    End Sub
End Class
