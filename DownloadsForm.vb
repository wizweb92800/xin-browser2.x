Public Class DownloadsForm

    Dim canClose As Boolean = False

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("search-ms:displayname=Xin%20Browser%20Search&crumb=System.Generic.String%3A" & CTextBox1.Text & "&crumb=location:" & IO.Path.GetPathRoot(Application.StartupPath))
    End Sub

    Private Sub CTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles CTextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not CTextBox1.Text = Nothing Then
                Button2.PerformClick()
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            For i = 0 To DownloadList.Controls.Count
                If CType(DownloadList.Controls(i), DownloadTicket).isDownloading = False Then
                    DownloadList.Controls.RemoveAt(i)
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DownloadsForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim downloadInProgress As Boolean = False
        If e.CloseReason = CloseReason.UserClosing Then
            If My.Application.OpenForms.Count = 1 Then
                'Il ne reste que la fenêtre des téléchargements
                If canClose = True Then
                    'Il ne se passe rien, l'application se ferme correctement
                Else
                    e.Cancel = True
                End If
                For i = 0 To DownloadList.Controls.Count - 1
                    If CType(DownloadList.Controls(i), DownloadTicket).isDownloading = True Then
                        downloadInProgress = True
                        canClose = False
                    Else
                        canClose = True
                        End
                    End If
                Next
            Else
                e.Cancel = True
                Me.Hide()
            End If
        ElseIf e.CloseReason = CloseReason.ApplicationExitCall Or e.CloseReason = CloseReason.TaskManagerClosing Or e.CloseReason = CloseReason.None Then
            If canClose = True Then
                'Il ne se passe rien, l'application se ferme correctement
            Else
                e.Cancel = True
            End If
            For i = 0 To DownloadList.Controls.Count - 1
                If CType(DownloadList.Controls(i), DownloadTicket).isDownloading = True Then
                    downloadInProgress = True
                    canClose = False
                Else
                    canClose = True
                    End
                End If
            Next
        End If

        If downloadInProgress = True Then
            Dim msgboxResult As MsgBoxResult = MsgBox("Un ou plusieurs téléchargements sont encore actifs, en quittant Xin Browser les téléchargements seront annulés... Voulez-vous quitter Xin Browser ?", MsgBoxStyle.YesNoCancel, "Téléchargements en cours")
            If msgboxResult = Microsoft.VisualBasic.MsgBoxResult.Yes Then
                canClose = True
                End
            Else
                'L'action reste annulée
                canClose = False
            End If

        End If
    End Sub
End Class