Public Class AdvBox

    Sub FormLoad() Handles Me.Load
        ' Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
    End Sub

    Private Sub CloseForm_Click(sender As Object, e As EventArgs) Handles CloseForm.Click
        BoxAccepted = True
        Me.Close()
    End Sub
End Class


Module BoxFunction

    Public BoxAccepted As Boolean = False

    Public Function AdviseBox(text As String) As Boolean

        AdvBox.CorpLabel.Text = text
        AdvBox.Show()

        While BoxAccepted = False
            WaitMilliseconds(1)
        End While

        BoxAccepted = False
        Return True


    End Function




End Module