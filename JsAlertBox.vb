Public Class JsAlertBox

    Public host As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Dim checked As Boolean = CheckBox1.Checked
        If checked = True Then
            'On bloque les js popup
            If Not My.Settings.JsPopUpBlockedPage.Contains(host) Then
                My.Settings.JsPopUpBlockedPage.Add(host)
                My.Settings.Save()
            End If
        Else
            'On débloque les js popup
            My.Settings.JsPopUpBlockedPage.Remove(host)
            My.Settings.Save()
        End If
    End Sub
End Class