Public Class AddRemoveFavForm

    Public Sub SetFavInfo(ByVal Title As String, ByVal Url As String)
        TextBox1.Text = Title
        TextBox2.Text = Url
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class