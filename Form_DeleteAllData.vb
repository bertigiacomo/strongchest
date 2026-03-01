Public Class DeleteAllData
    Private Sub GunaAdvenceTileButton4_Click(sender As Object, e As EventArgs) Handles btnDeleteAllData.Click

        'Create log
        Log.Add("The space was deleted by user. Application Restart")
        Log.Write()

        Configs.ResetSettings()
        Configs.SaveConfig()

        If IO.Directory.Exists(Paths.AppData) Then
            IO.Directory.Delete(Paths.AppData, True)
        End If
        Application.Restart()
    End Sub

    Private Sub CloseForm_Click(sender As Object, e As EventArgs) Handles CloseForm.Click

        MainContainer.pnlContainer.Controls.Remove(Me)
        Me.Close()
    End Sub
End Class