Imports Newtonsoft.Json
Imports Strongchest.Storage

Public Class SelectNewPassword
    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click

        'Esegui controlli da dizionario
        If PasswordBox.Text <> PasswordConfirm.Text Then
            ErrorLabel.Text = "Le password non corrispondono"
            Exit Sub
        End If

        'Controlla lunghezza
        If PasswordBox.Text.Length < 8 Then
            ErrorLabel.Text = "Devi immettere almeno 8 caratteri"
            Exit Sub
        End If

        'Controlla files
        If My.Computer.FileSystem.GetFiles(Paths.UserData).Count = 0 Then

            IV = CreateIV(PasswordBox.Text)
            Key = CreateKey(PasswordBox.Text)

            MainContainer.Controls.Remove(Me)
            Me.Close()
            Exit Sub

        End If

        'Riposiziona controlli
        Me.Hide()
        ErrorLabel.Text = ""
        ChangePassword.Password = PasswordBox.Text

        'Rimuovi
        MainContainer.Controls.Remove(Me)

        'Mostra changepassword
        ChangePassword.Show()

        'Nascondi e chiudi
        Me.Close()
        MainContainer.Hide()

    End Sub

    Private Sub CloseForm_Click(sender As Object, e As EventArgs) Handles CloseForm.Click

        'Rimuovi
        MainContainer.Controls.Remove(Me)

        'Chiudi
        Me.Close()

    End Sub
End Class