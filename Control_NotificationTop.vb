Public Class Control_NotificationTop
    Private Sub NotificationClick_Click(sender As Object, e As EventArgs) Handles NotificationClick.Click
        If Network.CheckForUpdates = False Then
            Design.PanelSwitch(CompanyGUI)
        Else
            MainContainer.pnlContainer.Controls.Remove(Me)
            UpdateSelector.Show()
        End If

    End Sub
End Class
