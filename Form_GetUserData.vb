Class MsgBoxGetData

    Property DataRequested As String
    Property DataSubmitted As Boolean
    Property Display As String
    Property WrittenData As String
    Property IsPass As Boolean


    Private Sub GetUserInput_Load(sender As Object, e As EventArgs) Handles Me.Shown
        txtDataRequest.Focus()
    End Sub

    Private Sub GetUserInput_Start(sender As Object, e As EventArgs) Handles MyBase.Load
        lblActionDesc.Text = Display
        txtDataRequest.Text = WrittenData
        txtDataRequest.UseSystemPasswordChar = IsPass
    End Sub

    Private Sub BtnSubmitData_Click(sender As Object, e As EventArgs) Handles btnSubmitData.Click
        DataRequested = txtDataRequest.Text
        DataSubmitted = True
    End Sub

    Private Sub CloseForm_Click(sender As Object, e As EventArgs) Handles CloseForm.Click
        DataRequested = Nothing
        DataSubmitted = True
    End Sub
End Class