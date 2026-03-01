Public Class UpdateSelector
    Private Sub GunaAdvenceTileButton1_Click(sender As Object, e As EventArgs) Handles UpdateNO.Click
        Dim updateNotification As New Control_NotificationTop
        updateNotification.Location = New Point((MainContainer.Size.Width - updateNotification.Size.Width) / 2, 25)
        MainContainer.pnlContainer.Controls.Add(updateNotification)
        updateNotification.Show()
        updateNotification.BringToFront()
        Me.Close()
    End Sub

    Private Sub UpdateOK_Click(sender As Object, e As EventArgs) Handles UpdateOK.Click

        'Nascondi controllo utente
        MainContainer.Hide()
        Me.Hide()

        'Modifica controlli
        lblHeading.Text = "Download del pacchetto..."
        lblActionDescription.Text = "Il download dell'aggiornamento è in corso. Potrebbe volerci qualche minuto."
        UpdateOK.Visible = False
        UpdateNO.Visible = False

        'Scarica
        DownloadUpdate.RunWorkerAsync()


    End Sub

    Private Sub DownloadUpdate_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles DownloadUpdate.DoWork

        My.Computer.Network.DownloadFile(CDN.Installer, "installer.msi")
        Process.Start("installer.msi")
        End

    End Sub

    Private Sub UpdateFAST_Click(sender As Object, e As EventArgs) Handles UpdateFAST.Click

        'Nascondi controllo utente
        MainContainer.Hide()
        Me.Hide()

        'Modifica controlli
        lblHeading.Text = "Download del pacchetto..."
        lblActionDescription.Text = "Il download dell'aggiornamento è in corso. Potrebbe volerci qualche minuto."
        UpdateOK.Visible = False
        UpdateNO.Visible = False

        'Scarica
        DownloadUpdateFast.RunWorkerAsync()


    End Sub

    Private Sub DownloadUpdateFast_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles DownloadUpdateFast.DoWork
        My.Computer.Network.DownloadFile(CDN.Installer, "installer.msi")
        Process.Start("installer.msi", "/passive")
        End
    End Sub
End Class