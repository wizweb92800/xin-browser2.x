Public Class MsgEraseFavourites

    Public OptionChoosen As String = "EraseFavourites"

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            OptionChoosen = "ExportFavourites"
        ElseIf RadioButton2.Checked = True Then
            OptionChoosen = "ExportAndEraseFavourites"
        ElseIf RadioButton3.Checked = True Then
            OptionChoosen = "EraseFavourites"
        End If
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class