Imports Awesomium.Windows.Forms

Public Class CodeViewer

    Public isHTMLTab As Boolean = True
    Public isInspectorTab As Boolean = False
    Public isConsoleTab As Boolean = False

    Private Gray64 As Color = Color.FromArgb(64, 64, 64)

    Public Sub LoadHtmlSource(ByVal webCtrl As WebControl)
        RichTextBox1.Clear()
        'Dim htmlSource As String = webCtrl.ExecuteJavascriptWithResult("document.documentElement.innerHTML")
        Dim wb As New Net.WebClient
        Dim htmlSource As String = wb.DownloadString(webCtrl.Source)
        RichTextBox1.Text = htmlSource

        CTextBox1.Text = ""
        Status_Lbl.Text = ""

        isHTMLTab = True
        isInspectorTab = False
        isConsoleTab = False

        Button2.BackColor = Color.White
        Button2.ForeColor = Color.DimGray
        Button2.Font = New Font("Segoe UI", 9, FontStyle.Bold)

        Button3.BackColor = Gray64
        Button3.ForeColor = Color.White
        Button3.Font = New Font("Segoe UI", 9, FontStyle.Regular)

        Button4.BackColor = Gray64
        Button4.ForeColor = Color.White
        Button4.Font = New Font("Segoe UI", 9, FontStyle.Regular)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        isHTMLTab = True
        isInspectorTab = False
        isConsoleTab = False

        Button2.BackColor = Color.White
        Button2.ForeColor = Color.DimGray
        Button2.Font = New Font("Segoe UI", 9, FontStyle.Bold)

        Button3.BackColor = Gray64
        Button3.ForeColor = Color.White
        Button3.Font = New Font("Segoe UI", 9, FontStyle.Regular)

        Button4.BackColor = Gray64
        Button4.ForeColor = Color.White
        Button4.Font = New Font("Segoe UI", 9, FontStyle.Regular)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        isHTMLTab = False
        isInspectorTab = True
        isConsoleTab = False

        Button2.BackColor = Gray64
        Button2.ForeColor = Color.White
        Button2.Font = New Font("Segoe UI", 9, FontStyle.Regular)

        Button3.BackColor = Color.White
        Button3.ForeColor = Color.DimGray
        Button3.Font = New Font("Segoe UI", 9, FontStyle.Bold)

        Button4.BackColor = Gray64
        Button4.ForeColor = Color.White
        Button4.Font = New Font("Segoe UI", 9, FontStyle.Regular)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        isHTMLTab = False
        isInspectorTab = False
        isConsoleTab = True

        Button2.BackColor = Gray64
        Button2.ForeColor = Color.White
        Button2.Font = New Font("Segoe UI", 9, FontStyle.Regular)

        Button3.BackColor = Gray64
        Button3.ForeColor = Color.White
        Button3.Font = New Font("Segoe UI", 9, FontStyle.Regular)

        Button4.BackColor = Color.White
        Button4.ForeColor = Color.DimGray
        Button4.Font = New Font("Segoe UI", 9, FontStyle.Bold)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CType(Me.ParentForm, TabWebBrowser).WBItem -= 1
        Me.Visible = False
    End Sub

    Dim cnt As Integer
    Dim lstIdx As Integer

    Private Sub SrchBtn_Click(sender As Object, e As EventArgs) Handles SrchBtn.Click
        RichTextBox1.SelectionStart = 0
        RichTextBox1.SelectionLength = RichTextBox1.TextLength
        RichTextBox1.SelectionBackColor = SystemColors.Control

        Dim idx As Integer = 0
        cnt = 0

        Status_Lbl.Text = "Recherche de '" + CTextBox1.Text + "' dans le code source..."

        While idx < RichTextBox1.Text.LastIndexOf(CTextBox1.Text)
            RichTextBox1.Find(CTextBox1.Text, idx, RichTextBox1.TextLength, RichTextBoxFinds.None)
            RichTextBox1.SelectionBackColor = Color.Yellow
            cnt += 1
            idx = RichTextBox1.Text.IndexOf(CTextBox1.Text, idx) + 1
        End While

        Status_Lbl.Text = cnt.ToString() + " occurences trouvées pour '" + CTextBox1.Text + "'"
    End Sub

    Private Sub SrchBtnPrev_Click(sender As Object, e As EventArgs) Handles SrchBtnPrev.Click
        'Dim idx As Integer = 0

        'While 0 < idx < lstIdx
        '    RichTextBox1.Find(CTextBox1.Text, idx, RichTextBox1.TextLength, RichTextBoxFinds.None)
        '    RichTextBox1.SelectionBackColor = Color.Orange
        '    idx = RichTextBox1.Text.IndexOf(CTextBox1.Text, idx) + 1
        'End While

        'RichTextBox1.ScrollToCaret()
    End Sub

    Private Sub SrchBtnNext_Click(sender As Object, e As EventArgs) Handles SrchBtnNext.Click
        'Dim idx As Integer = 0

        'While lstIdx < idx < RichTextBox1.Text.LastIndexOf(CTextBox1.Text)
        '    RichTextBox1.Find(CTextBox1.Text, idx, RichTextBox1.TextLength, RichTextBoxFinds.None)
        '    RichTextBox1.SelectionBackColor = Color.Orange
        '    idx = RichTextBox1.Text.IndexOf(CTextBox1.Text, idx) + 1
        'End While

        'RichTextBox1.ScrollToCaret()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim ntab As New TabWebBrowser
        ntab.LoadUrl("http://xinloxx-tickets.hol.es/")
        CType(CType(Me.ParentForm, TabWebBrowser).ParentForm, Form1).TabControl1.TabPages.Add(ntab)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Clipboard.SetText(RichTextBox1.Text)
        Status_Lbl.Text = "Le code HTML a bien été copié dans le presse-papiers"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim dlg As New SaveFileDialog
        dlg.Title = "Enregistrer le code source"
        dlg.Filter = "Page Web (*.html;*.htm)|*.html;*.htm|Fichier Texte (*.txt)|*.txt"
        If dlg.ShowDialog = DialogResult.OK Then
            RichTextBox1.SaveFile(dlg.FileName, RichTextBoxStreamType.PlainText)
            Status_Lbl.Text = "Le code HTML a bien été enregistré dans le fichier '" + IO.Path.GetFileName(dlg.FileName) + "'"
        End If
    End Sub

    Private Sub CTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles CTextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call SrchBtn_Click(sender, New System.EventArgs)
        End If
    End Sub
End Class
