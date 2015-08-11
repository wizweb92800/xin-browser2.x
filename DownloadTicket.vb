Imports Awesomium.Core
Imports System.Net

Public Class DownloadTicket

    Public isDownloading As Boolean = False
    Private isCancelled As Boolean = False

    Private SaveLocation As String
    Private SaveFileName As String

    Private WithEvents Downloader As WebClient

    Private LastMemoryBytesReceived As String
    Private CurrentBytesReceiving As String

    Private TotalBytesToReceive As String

    Private Function checkIfValueIsDecimal(ByVal value As String) As String
        Dim result As String
        If value.Contains(",") Then : result = CDbl(value).ToString("###.##")
        Else : result = CDbl(value).ToString("###.00") : End If
        Return result
    End Function

    Private Function roundObjectSize(ByVal ObjectSize As String) As String
        Dim oneByte As Integer = 1
        Dim kiloByte As Integer = 1024
        Dim megaByte As Integer = 1048576
        Dim gigaByte As Integer = 1073741824
        Dim terraByte As Long = 1099511627776
        Dim pettaByte As Long = 1125899906842624

        Select Case CLng(ObjectSize)
            Case 0 To kiloByte - 1
                If (CDbl(checkIfValueIsDecimal(CStr(CDec(ObjectSize) / oneByte))) >= 1000) = False Then
                    ObjectSize = CStr(CInt(ObjectSize) / 1) + " Bytes"
                Else : ObjectSize = "1,00 Kb" : End If

            Case kiloByte To megaByte - 1
                If (CDbl(checkIfValueIsDecimal(CStr(CDec(ObjectSize) / kiloByte))) >= 1000) = False Then
                    ObjectSize = checkIfValueIsDecimal(CStr(CDec(ObjectSize) / kiloByte)) + " Kb"
                Else : ObjectSize = "1,00 Mb" : End If

            Case megaByte To gigaByte - 1
                If (CDbl(checkIfValueIsDecimal(CStr(CDec(ObjectSize) / megaByte))) >= 1000) = False Then
                    ObjectSize = checkIfValueIsDecimal(CStr(CDec(ObjectSize) / megaByte)) + " Mb"
                Else : ObjectSize = "1,00 Gb" : End If

            Case gigaByte To terraByte - 1
                If (CDbl(checkIfValueIsDecimal(CStr(CDec(ObjectSize) / gigaByte))) >= 1000) = False Then
                    ObjectSize = checkIfValueIsDecimal(CStr(CDec(ObjectSize) / gigaByte)) + " Gb"
                Else : ObjectSize = "1,00 Tb" : End If

            Case terraByte To pettaByte - 1
                If (CDbl(checkIfValueIsDecimal(CStr(CDec(ObjectSize) / terraByte))) >= 1000) = False Then
                    ObjectSize = checkIfValueIsDecimal(CStr(CDec(ObjectSize) / terraByte)) + " Tb"
                Else : ObjectSize = "1,00 Pb" : End If
        End Select
        Return ObjectSize
    End Function

    Public Function roundTiming(ByVal time As Double) As String
        If time <= 60 Then
            Return time & "s"
        ElseIf 60 < time <= 3600 Then
            Return Math.Truncate(time / 60) & " min " & Math.Round((time / 60 - Math.Truncate(time / 60)) * 60, 1) & " s"
        ElseIf 3600 < time <= 86400 Then
            Dim ntime As Double = time / 60
            Return Math.Truncate(ntime / 60) & " h " & Math.Round((ntime / 60 - Math.Truncate(ntime / 60)) * 60, 1) & " min"
        ElseIf time > 86400 Then
            Return "Plus d'une journée"
        Else
            Return Nothing
        End If
    End Function

    Public Function GetFileIcon(ByVal extension_type As String) As Bitmap
        If extension_type = ".doc" Or extension_type = ".docx" Or extension_type = ".odt" Or extension_type = ".wps" Then
            Return My.Resources.file_word
        ElseIf extension_type = ".app" Then
            Return My.Resources.application_osx
        ElseIf extension_type = ".exe" Or extension_type = ".bat" Then
            Return My.Resources.application_xp
        ElseIf extension_type = ".iso" Or extension_type = ".cue" Then
            Return My.Resources.cd
        ElseIf extension_type = ".xls" Or extension_type = ".xlsx" Or extension_type = ".ods" Or extension_type = ".csv" Then
            Return My.Resources.file_excel
        ElseIf extension_type = ".swf" Then
            Return My.Resources.file_extension_swf
        ElseIf extension_type = ".torrent" Then
            Return My.Resources.file_extension_torrent
        ElseIf extension_type = ".ttf" Then
            Return My.Resources.file_extension_ttf
        ElseIf extension_type = ".msi" Then
            Return My.Resources.file_install
        ElseIf extension_type = ".mp3" Or extension_type = ".mp2" Or extension_type = ".ogg" Or extension_type = ".wav" Or extension_type = ".wma" Or extension_type = ".aiff" Or extension_type = ".flac" Then
            Return My.Resources.file_music
        ElseIf extension_type = ".pdf" Then
            Return My.Resources.file_pdf
        ElseIf extension_type = ".jpeg" Or extension_type = ".jpg" Or extension_type = ".jfif" Or extension_type = ".tiff" Or extension_type = ".gif" Or extension_type = ".bmp" Or extension_type = ".png" Or extension_type = ".svg" Then
            Return My.Resources.file_picture
        ElseIf extension_type = ".mkv" Or extension_type = ".flv" Or extension_type = ".avi" Or extension_type = ".mov" Or extension_type = ".wmv" Or extension_type = ".asf" Or extension_type = ".mp4" Or extension_type = ".mpg" Or extension_type = ".mpeg" Or extension_type = ".3gp" Then
            Return My.Resources.file_video
        ElseIf extension_type = ".zip" Or extension_type = ".rar" Or extension_type = ".7z" Or extension_type = ".jar" Or extension_type = ".bin" Then
            Return My.Resources.file_zip
        Else
            Return My.Resources.page_white
        End If
    End Function

    Public Sub AddNewDownload(ByVal uri As String, ByVal filename As String, ByVal savepath As String)
        isDownloading = True

        Lbl_DownloadTitle.Text = filename
        Lbl_DownloadUrl.Text = uri

        FilePic.Image = GetFileIcon(IO.Path.GetExtension(filename))

        SaveLocation = savepath
        SaveFileName = filename

        'Vérification: si le fichier existe déjà, on supprime l'ancien
        If IO.File.Exists(savepath) Then
            Try
                IO.File.Delete(savepath)
            Catch ex As Exception

            End Try
        End If

        Downloader = New WebClient
        Downloader.DownloadFileAsync(New Uri(uri), savepath)

        Timer1.Start()
    End Sub

    Private Sub Btn_OpenFile_Click(sender As Object, e As EventArgs) Handles Btn_OpenFile.Click
        If IO.File.Exists(SaveLocation) Then
            Process.Start(SaveLocation)
        Else
            MsgBox("Erreur: Le fichier est introuvable à l'emplacement sauvegardé ! Il se peut qu'il ait été déplacé, modifié ou supprimé.", MsgBoxStyle.Critical)
            Me.Hide()
        End If
    End Sub

    Private Sub Btn_OpenFolder_Click(sender As Object, e As EventArgs) Handles Btn_OpenFolder.Click
        If IO.Directory.Exists(IO.Path.GetDirectoryName(SaveLocation)) Then
            Process.Start("explorer", "/select," & SaveLocation)
        Else
            MsgBox("Erreur: Le dossier n'existe pas ! Il se peut qu'il ait été déplacé, modifié ou supprimé.", MsgBoxStyle.Critical)
            Me.Hide()
        End If
    End Sub

    Private Sub Btn_DeleteFile_Click(sender As Object, e As EventArgs) Handles Btn_DeleteFile.Click
        If IO.File.Exists(SaveLocation) Then
            IO.File.Delete(SaveLocation)
            Me.Hide()
        Else
            MsgBox("Erreur: Le fichier est introuvable à l'emplacement sauvegardé ! Il se peut qu'il ait été déplacé, modifié ou supprimé.", MsgBoxStyle.Critical)
            Me.Hide()
        End If
    End Sub

    Private Sub Lbl_DownloadUrl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Lbl_DownloadUrl.LinkClicked
        Dim ntab As New TabWebBrowser
        ntab.LoadUrl(Lbl_DownloadUrl.Text)
        CType(Me.ParentForm, Form1).TabControl1.TabPages.Add(ntab)
    End Sub

    Private Sub Downloader_DownloadFileCompleted(sender As Object, e As System.ComponentModel.AsyncCompletedEventArgs) Handles Downloader.DownloadFileCompleted
        If isCancelled = False Then
            isDownloading = False
            Btn_Cancel.Visible = False
            Btn_DeleteFile.Visible = True
            Btn_OpenFile.Visible = True
            Btn_OpenFolder.Visible = True
            Btn_Retry.Visible = False
            DownloadProgressBar.Visible = False

            OuvrirLeFichierToolStripMenuItem.Enabled = True
            OuvrirLemplacementDuFichierToolStripMenuItem.Visible = True
            SupprimerToolStripMenuItem.Enabled = True
            RéessayerLeTéléchargementToolStripMenuItem.Enabled = True
            RetirerDeLaListeDesTéléchargementsToolStripMenuItem.Enabled = True


            Lbl_DownloadSpeed.Visible = False
            Lbl_ProgressPercentage.Visible = False
            Lbl_FileSizeToFileCompleteSize.Visible = False
            Timer1.Stop()
        End If
    End Sub

    Private Sub Downloader_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles Downloader.DownloadProgressChanged
        TotalBytesToReceive = e.TotalBytesToReceive

        DownloadProgressBar.Value = e.ProgressPercentage
        Lbl_ProgressPercentage.Text = e.ProgressPercentage & "%"
        CurrentBytesReceiving = e.BytesReceived
        Lbl_FileSizeToFileCompleteSize.Text = roundObjectSize(e.BytesReceived) & "/" & roundObjectSize(e.TotalBytesToReceive)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Débit du téléchargement à la seconde
        Lbl_DownloadSpeed.Text = roundObjectSize((CurrentBytesReceiving) - (LastMemoryBytesReceived)) & "/s"
        LastMemoryBytesReceived = CurrentBytesReceiving

        'Temps restant
        'Lbl_TimeRemaining.Text = roundTiming(Math.Truncate(CDbl(TotalBytesToReceive)) / Math.Truncate(CurrentBytesReceiving) - Math.Truncate(LastMemoryBytesReceived))
    End Sub

    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles Btn_Cancel.Click
        Downloader.CancelAsync()
        Btn_Cancel.Visible = False
        Btn_Retry.Visible = True
        Lbl_DownloadSpeed.Visible = False
        Lbl_FileSizeToFileCompleteSize.Visible = False
        Lbl_ProgressPercentage.Visible = False
        OuvrirLeFichierToolStripMenuItem.Enabled = False
        OuvrirLemplacementDuFichierToolStripMenuItem.Visible = False
        SupprimerToolStripMenuItem.Enabled = True
        RéessayerLeTéléchargementToolStripMenuItem.Enabled = True
        RetirerDeLaListeDesTéléchargementsToolStripMenuItem.Enabled = True
        DownloadProgressBar.Visible = False
        Timer1.Stop()
        isCancelled = True
    End Sub

    Private Sub Btn_Retry_Click(sender As Object, e As EventArgs) Handles Btn_Retry.Click
        Dim ndown As New DownloadTicket
        ndown.Dock = DockStyle.Top
        ndown.AddNewDownload(Lbl_DownloadUrl.Text, Lbl_DownloadTitle.Text, SaveLocation)
        DownloadsForm.DownloadList.Controls.Add(ndown)
        Me.Hide()
    End Sub

    Private Sub OuvrirLeFichierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OuvrirLeFichierToolStripMenuItem.Click
        Btn_OpenFile.PerformClick()
    End Sub

    Private Sub OuvrirLemplacementDuFichierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OuvrirLemplacementDuFichierToolStripMenuItem.Click
        Btn_OpenFolder.PerformClick()
    End Sub

    Private Sub RéessayerLeTéléchargementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RéessayerLeTéléchargementToolStripMenuItem.Click
        Btn_Retry.PerformClick()
    End Sub

    Private Sub SupprimerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupprimerToolStripMenuItem.Click
        Btn_DeleteFile.PerformClick()
    End Sub

    Private Sub RetirerDeLaListeDesTéléchargementsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RetirerDeLaListeDesTéléchargementsToolStripMenuItem.Click
        Me.Hide()
    End Sub
End Class
