Public Class Settings

    Private Sub CheckBox_CheckForUpdates_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_CheckForUpdates.CheckedChanged
        My.Settings.CheckForUpdates = CheckBox_CheckForUpdates.Checked
        My.Settings.Save()
    End Sub

    Private Sub CheckBox_EnableBetaUpdates_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_EnableBetaUpdates.CheckedChanged
        My.Settings.EnableBetaUpdates = CheckBox_EnableBetaUpdates.Checked
        My.Settings.Save()
    End Sub

    Private Sub CheckBox_Downloads_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Downloads.CheckedChanged
        My.Settings.AskForSavingDownloads = CheckBox_Downloads.Checked
        My.Settings.Save()

        If CheckBox_Downloads.Checked = True Then
            Btn_DefaultDownloadsPlace.Enabled = False
            Btn_DownloadsPlace.Enabled = False
        Else
            Btn_DefaultDownloadsPlace.Enabled = True
            Btn_DownloadsPlace.Enabled = True
        End If
    End Sub

    Private Sub Btn_DownloadsPlace_Click(sender As Object, e As EventArgs) Handles Btn_DownloadsPlace.Click
        Dim dlg As New FolderBrowserDialog
        dlg.SelectedPath = TextBox_DownloadsPlace.Text
        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            If Not dlg.SelectedPath = Nothing Then
                TextBox_DownloadsPlace.Text = dlg.SelectedPath
                My.Settings.DownloadsPlace = dlg.SelectedPath
                My.Settings.Save()
            End If
        End If
    End Sub

    Private Sub Btn_DefaultDownloadsPlace_Click(sender As Object, e As EventArgs) Handles Btn_DefaultDownloadsPlace.Click
        Dim FirstDownloadPath As String = My.Computer.FileSystem.SpecialDirectories.Desktop
        Dim LastDownloadPath = FirstDownloadPath.Replace("Desktop", "")
        LastDownloadPath += "Downloads"
        TextBox_DownloadsPlace.Text = LastDownloadPath

        My.Settings.DownloadsPlace = TextBox_DownloadsPlace.Text
        My.Settings.Save()
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.DownloadsPlace = Nothing Then
            Btn_DefaultDownloadsPlace.PerformClick()
        End If

        CheckBox_CheckForUpdates.Checked = My.Settings.CheckForUpdates
        CheckBox_EnableBetaUpdates.Checked = My.Settings.EnableBetaUpdates
        CheckBox_Downloads.Checked = My.Settings.AskForSavingDownloads

        If CheckBox_Downloads.Checked = True Then
            Btn_DefaultDownloadsPlace.Enabled = False
            Btn_DownloadsPlace.Enabled = False
        Else
            Btn_DefaultDownloadsPlace.Enabled = True
            Btn_DownloadsPlace.Enabled = True
        End If

        TextBox_DownloadsPlace.Text = My.Settings.DownloadsPlace

        If My.Settings.CurrentTheme = "xinbrowser" Then
            RadioButton_OrangeTheme.Checked = True
            RadioButton_BlueTheme.Checked = False
            RadioButton_GreenTheme.Checked = False
        ElseIf My.Settings.CurrentTheme = "modern" Then
            RadioButton_OrangeTheme.Checked = False
            RadioButton_BlueTheme.Checked = True
            RadioButton_GreenTheme.Checked = False
        ElseIf My.Settings.CurrentTheme = "classic" Then
            RadioButton_OrangeTheme.Checked = False
            RadioButton_BlueTheme.Checked = False
            RadioButton_GreenTheme.Checked = True
        End If
    End Sub

    Private Sub RadioButton_OrangeTheme_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_OrangeTheme.CheckedChanged
        If RadioButton_OrangeTheme.Checked = True Then
            My.Settings.CurrentTheme = "xinbrowser"
            My.Settings.Save()

            For Each i As Form In My.Application.OpenForms
                Try
                    CType(i, Form1).SetOrangeTheme()
                    CType(i, Form1).WebsiteInfoBulle1.SetOrangeTheme()
                    CType(i, Form1).UrlLister1.SetOrangeTheme()
                    CType(i, Form1).FavHistList1.SetOrangeTheme()
                Catch ex As Exception

                End Try
            Next
        End If
    End Sub

    Private Sub RadioButton_BlueTheme_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_BlueTheme.CheckedChanged
        If RadioButton_BlueTheme.Checked = True Then
            My.Settings.CurrentTheme = "modern"
            My.Settings.Save()

            For Each i As Form In My.Application.OpenForms
                Try
                    CType(i, Form1).SetBlueTheme()
                    CType(i, Form1).WebsiteInfoBulle1.SetBlueTheme()
                    CType(i, Form1).UrlLister1.SetBlueTheme()
                    CType(i, Form1).FavHistList1.SetBlueTheme()
                Catch ex As Exception

                End Try
            Next
        End If
    End Sub

    Private Sub RadioButton_GreenTheme_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_GreenTheme.CheckedChanged
        If RadioButton_GreenTheme.Checked = True Then
            'My.Settings.CurrentTheme = "classic"
            'My.Settings.Save()
            '
            'For Each i As Form In My.Application.OpenForms
            '    Try
            '        CType(i, Form1).SetGreenTheme()
            '        CType(i, Form1).WebsiteInfoBulle1.SetGreenTheme()
            '        CType(i, Form1).UrlLister1.SetGreenTheme()
            '        CType(i, Form1).FavHistList1.SetGreenTheme()
            '    Catch ex As Exception

            '    End Try
            'Next
        End If
    End Sub
End Class