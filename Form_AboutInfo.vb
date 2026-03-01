Public Class AboutStrongchest
    Private Sub Info_Load(sender As Object, e As EventArgs) Handles Me.Load

        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        lblWelcome.Text = "Strongchest (versione " & ApplicationConstants.AppDisplayVersion & ")"
        DataVersions.Text = "Versione dello Storage: " & ApplicationConstants.StorageVersion & vbNewLine &
                          "Build di Strongchest: " & ApplicationConstants.AppBuild & vbNewLine &
                          "Prossima patch prevista: Ottobre 2020"
    End Sub

    Private Sub BtnDisableUpdates_Click(sender As Object, e As EventArgs)
        RelaseNotes.Show()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Public Sub ApplyTheme()
        Exit Sub
        If Settings.LightTheme = True Then

            pnlToolbar.BackColor = lightSecondaryNavBar
            lblWelcome.ForeColor = lightPrimaryText
            lblSubtitle.ForeColor = lightSecondaryText
            DataVersions.ForeColor = lightSecondaryText
            IconsCredit.ForeColor = lightSecondaryText
            BackColor = lightPopUp

        Else

            pnlToolbar.BackColor = darkSecondaryNavBar
            lblWelcome.ForeColor = darkPrimaryText
            lblSubtitle.ForeColor = darkSecondaryText
            DataVersions.ForeColor = darkSecondaryText
            IconsCredit.ForeColor = darkSecondaryText
            BackColor = darkPopUp



        End If



    End Sub

End Class