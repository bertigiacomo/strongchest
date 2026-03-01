Public Class LoginSettings

    Sub MeLoad() Handles MyBase.Load

        'Disabilità funzione per eliminare spazio se non ci sono spazi
        If Settings.IsSetUp = False Then
            btnChangePassword.Text = "Nessuno spazio"
            btnChangePassword.Enabled = False
        End If

    End Sub


    Private Sub CloseForm_Click(sender As Object, e As EventArgs) Handles CloseForm.Click
        MainContainer.pnlContainer.Controls.Remove(Me)
        Me.Close()
    End Sub

    Private Sub BtnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click

        'Mostra form per l'eliminazione dei contenuti
        Design.PanelSwitch(DeleteAllData)

        'Chiudi
        MainContainer.pnlContainer.Controls.Remove(Me)
        Me.Close()

    End Sub

    Private Sub BtnGetOnlineHelp_Click(sender As Object, e As EventArgs) Handles btnGetOnlineHelp.Click
        Process.Start("https://giacomo-berti.me/help")
    End Sub

    Private Sub ImportSpace_Click(sender As Object, e As EventArgs) Handles btnImportSpace.Click
        MainContainer.Hide()
        Import.Close()
        Import.Show()
    End Sub
End Class