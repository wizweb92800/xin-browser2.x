Public Class MsgEraseHistory

    Public OptionChoosen As String = "DeleteHist_All"

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            OptionChoosen = "DeleteHist_LessThanOneHour"
        ElseIf RadioButton2.Checked = True Then
            OptionChoosen = "DeleteHist_OfThisDay"
        ElseIf RadioButton3.Checked = True Then
            OptionChoosen = "DeleteHist_All"
        End If
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class