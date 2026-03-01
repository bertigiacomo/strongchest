Public Class SettingsGUI

    Private Sub DeleteSpace(sender As Object, e As EventArgs) Handles DeleteChest.Click

        'Avvia form
        Design.PanelSwitch(DeleteAllData)

        'Nascondi
        MainContainer.pnlContainer.Controls.Remove(Me)
        Me.Close()

    End Sub
    Private Sub CloseMyForm(sender As Object, e As EventArgs) Handles CloseForm.Click

        'Chiudi impostazioni
        MainContainer.pnlContainer.Controls.Remove(Me)
        Me.Close()

    End Sub

    Private Sub ReloadStrongchest_Click(sender As Object, e As EventArgs) Handles ReloadStrongchest.Click

        'Elimina i logs e ricarica Strongchest
        If IO.Directory.Exists(Paths.LogsData) Then IO.Directory.Delete(Paths.LogsData, True)
        Application.Restart()

    End Sub

    Private Sub ChangePasswordForm(sender As Object, e As EventArgs) Handles ChangePassword.Click

        'Disegna form
        Design.PanelSwitch(SelectNewPassword)

        'Nascondi settings
        Me.Close()

    End Sub

    Private Sub ExportData(sender As Object, e As EventArgs) Handles ExportSpace.Click

        'Chiudimi
        MainContainer.Controls.Remove(Me)

        'Avvia exporting
        MainContainer.Hide()
        Export.Show()
        Me.Close()

    End Sub

    Private Sub SwitchUpdates_Click(sender As Object, e As EventArgs)
        Process.Start("https://giacomo-berti.me/app/strongchest")
    End Sub

    Private Sub AdminSpace_Click(sender As Object, e As EventArgs) Handles AdminSpace.Click

        'Apri gestione spazio
        Design.PanelSwitch(ManangeSpace)
        Me.Close()

    End Sub
End Class