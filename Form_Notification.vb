Public Class Notification
    Public Shared Sub NotifyChanges(Text As String)

        'Imposta il livello massimo
        Notification.TopLevel = True
        Notification.TopMost = True

        'Notifica
        Notification.lblCorp.Text = "Le modifiche a """ & Text & """ sono state salvate su Strongchest"
        Notification.lblHeading.Text = "Modifiche salvate"
        Notification.PicIcon.Image = My.Resources.fl_tick

        Notification.Show()

    End Sub

    Public Shared Sub NotifyExport(Text As String)

        'Imposta il livello massimo
        Notification.TopLevel = True
        Notification.TopMost = True

        'Notifica
        Notification.lblCorp.Text = """" & Text & """ è stato esportato correttamente nella posizione indicata"
        Notification.lblHeading.Text = "File esportato"
        Notification.PicIcon.Image = My.Resources.fl_tick

        Notification.Show()

    End Sub

    Public Shared Sub NotifySpace()

        'Imposta il livello massimo
        Notification.TopLevel = True
        Notification.TopMost = True

        'Notifica
        Notification.lblCorp.Text = "Impossibile aggiungere altri dati all'archivio, limite spazio raggiunto."
        Notification.lblHeading.Text = "Spazio esaurito"
        Notification.PicIcon.Image = My.Resources.fl_exlamation

        Notification.Show()

    End Sub

    Private Sub Component_Advise_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        My.Computer.Audio.Play(My.Resources.notify, AudioPlayMode.Background)
        Wait(2)
        Me.Close()
    End Sub

    Private Sub Component_Advise_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Scurisci bordi
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)

        'Ottieni grandezza schermo
        Dim X As Integer = Screen.PrimaryScreen.Bounds.Width - Me.Width
        Dim Y As Integer = Screen.PrimaryScreen.Bounds.Height - Me.Height - 55

        Dim NotifyPoint As New Point(X, Y)

        Me.Location = NotifyPoint

    End Sub
End Class

