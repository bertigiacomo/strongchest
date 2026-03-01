Public Class RelaseNotes
    Private Sub DisplayChangelog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Log
        Log.Add("Update completed successfully: new version " & ApplicationConstants.AppVersion)

        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        TopLevel = True
        TopMost = True
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class