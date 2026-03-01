Public Class CompanyGUI
    Private Sub CloseForm_Click(sender As Object, e As EventArgs) Handles CloseForm.Click
        Me.Close()
    End Sub

    Private Sub GunaLabel1_Click(sender As Object, e As EventArgs) Handles lblCompanyLink.Click
        If Business.BusinessURL.Contains("http://") = True Then Process.Start(Business.BusinessURL)
    End Sub

    Private Sub CompanyPanel_Paint(sender As Object, e As PaintEventArgs) Handles CompanyPanel.Paint
        lblCompanyName.Text = Business.DisplayName
        lblCompanyHelp.Text = lblCompanyHelp.Text.Replace("{azienda}", Business.DisplayName)
    End Sub
End Class