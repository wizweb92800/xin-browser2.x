Imports VIBlend.Utilities
Imports Awesomium.Core

Public Class TabWebBrowser

    Public WithEvents MyWebBrowser As Awesomium.Windows.Forms.WebControl
    Public IsInPrivateNavigation As Boolean = False

    Public UrlToLoadAtStart As String
    Public WBItem As Integer = 0

    Private FileName As String
    Private DirectoryName As String
    Private FileUrl As String

    Private Lst_SelectedText As String
    Private Lst_TargetUrl As String
    Private Lst_MediaUrl As String
    Private Lst_PosX As Integer
    Private Lst_PosY As Integer

    Private ZoomInt As Integer = 100

#Region "Themes"

    Public Sub SetBlueTheme()
        Dim colors() As Color = {Color.FromArgb(255, 39, 94, 176), _
            Color.FromArgb(255, 37, 92, 175), Color.FromArgb(255, 51, 105, 206), _
            Color.FromArgb(255, 53, 135, 226)}
        Dim highlightColors() As Color = {Color.FromArgb(255, 59, 114, 196), _
            Color.FromArgb(255, 57, 112, 185), Color.FromArgb(255, 71, 125, 226), _
            Color.FromArgb(255, 73, 155, 246)}
        Dim pressedColors() As Color = {Color.FromArgb(255, 79, 134, 216), _
            Color.FromArgb(255, 77, 132, 215), Color.FromArgb(255, 91, 145, 246), _
            Color.FromArgb(255, 93, 175, 255)}

        Dim normalStyle As New FillStyleGradientEx(colors(0), colors(1), _
            colors(2), colors(3), 90, 0.7F, 0.9F)
        Dim highlightStyle As New FillStyleGradientEx(highlightColors(0), _
            highlightColors(1), highlightColors(2), highlightColors(3), 90, 0.7F, 0.9F)
        Dim pressedStyle As New FillStyleGradientEx(pressedColors(0), _
            pressedColors(1), pressedColors(2), pressedColors(3), 90, 0.7F, 0.9F)
        Dim borderColor As Color = Color.FromArgb(31, 72, 161)

        Dim theme As ControlTheme = ControlTheme.GetDefaultTheme(VIBLEND_THEME.OFFICEBLUE).CreateCopy()
        theme.StyleNormal.FillStyle = normalStyle
        theme.StyleNormal.BorderColor = borderColor
        theme.StyleNormal.TextColor = Color.White
        theme.StyleHighlight.FillStyle = highlightStyle
        theme.StyleHighlight.BorderColor = borderColor
        theme.StyleHighlight.TextColor = Color.White
        theme.StylePressed.FillStyle = pressedStyle
        theme.StylePressed.BorderColor = borderColor
        theme.StylePressed.TextColor = Color.White

        VButton1.StyleKey = "XinDarkBlue"
        VButton1.RoundedCornersMask = CByte(VIBlend.Utilities.RoundedCornersMask.TOP_LEFT)
        VButton1.Theme = theme

        VButton2.StyleKey = "XinDarkBlue"
        VButton2.RoundedCornersMask = CByte(VIBlend.Utilities.RoundedCornersMask.TOP_RIGHT)
        VButton2.Theme = theme

        VButton3.StyleKey = "XinDarkBlue"
        VButton3.RoundedCornersMask = CByte(VIBlend.Utilities.RoundedCornersMask.TOP_LEFT And VIBlend.Utilities.RoundedCornersMask.BOTTOM_LEFT)
        VButton3.Theme = theme

        VButton4.StyleKey = "XinDarkBlue"
        VButton4.RoundedCornersMask = Nothing
        VButton4.Theme = theme

        VButton5.StyleKey = "XinDarkBlue"
        VButton5.RoundedCornersMask = CByte(VIBlend.Utilities.RoundedCornersMask.TOP_RIGHT And VIBlend.Utilities.RoundedCornersMask.BOTTOM_RIGHT)
        VButton5.Theme = theme
    End Sub

    Public Sub SetOrangeTheme()
        Dim colors() As Color = {Color.FromArgb(255, 210, 73, 18), _
            Color.FromArgb(255, 208, 71, 18), Color.FromArgb(255, 215, 78, 20), _
            Color.FromArgb(255, 216, 80, 20)}
        Dim highlightColors() As Color = {Color.FromArgb(255, 245, 120, 34), _
            Color.FromArgb(255, 245, 118, 32), Color.FromArgb(255, 250, 147, 43), _
            Color.FromArgb(255, 250, 150, 45)}
        Dim pressedColors() As Color = {Color.FromArgb(255, 200, 63, 8), _
            Color.FromArgb(255, 197, 60, 6), Color.FromArgb(255, 196, 66, 2), _
            Color.FromArgb(255, 194, 65, 2)}

        Dim normalStyle As New FillStyleGradientEx(colors(0), colors(1), _
            colors(2), colors(3), 90, 0.7F, 0.9F)
        Dim highlightStyle As New FillStyleGradientEx(highlightColors(0), _
            highlightColors(1), highlightColors(2), highlightColors(3), 90, 0.7F, 0.9F)
        Dim pressedStyle As New FillStyleGradientEx(pressedColors(0), _
            pressedColors(1), pressedColors(2), pressedColors(3), 90, 0.7F, 0.9F)
        Dim borderColor As Color = Color.FromArgb(210, 73, 0)

        Dim theme As ControlTheme = ControlTheme.GetDefaultTheme(VIBLEND_THEME.OFFICEBLUE).CreateCopy()
        theme.StyleNormal.FillStyle = normalStyle
        theme.StyleNormal.BorderColor = borderColor
        theme.StyleNormal.TextColor = Color.White
        theme.StyleHighlight.FillStyle = highlightStyle
        theme.StyleHighlight.BorderColor = borderColor
        theme.StyleHighlight.TextColor = Color.White
        theme.StylePressed.FillStyle = pressedStyle
        theme.StylePressed.BorderColor = borderColor
        theme.StylePressed.TextColor = Color.White

        VButton1.StyleKey = "XinDarkOrange"
        VButton1.RoundedCornersMask = CByte(VIBlend.Utilities.RoundedCornersMask.TOP_LEFT)
        VButton1.Theme = theme

        VButton2.StyleKey = "XinDarkOrange"
        VButton2.RoundedCornersMask = CByte(VIBlend.Utilities.RoundedCornersMask.TOP_RIGHT)
        VButton2.Theme = theme

        VButton3.StyleKey = "XinDarkOrange"
        VButton3.RoundedCornersMask = CByte(VIBlend.Utilities.RoundedCornersMask.TOP_LEFT And VIBlend.Utilities.RoundedCornersMask.BOTTOM_LEFT)
        VButton3.Theme = theme

        VButton4.StyleKey = "XinDarkOrange"
        VButton4.RoundedCornersMask = Nothing
        VButton4.Theme = theme

        VButton5.StyleKey = "XinDarkOrange"
        VButton5.RoundedCornersMask = CByte(VIBlend.Utilities.RoundedCornersMask.TOP_RIGHT And VIBlend.Utilities.RoundedCornersMask.BOTTOM_RIGHT)
        VButton5.Theme = theme
    End Sub

    Public Sub SetGreenTheme()
        Dim colors() As Color = {Color.FromArgb(255, 14, 99, 17), _
            Color.FromArgb(255, 12, 97, 17), Color.FromArgb(255, 19, 103, 19), _
            Color.FromArgb(255, 20, 105, 19)}
        Dim highlightColors() As Color = {Color.FromArgb(255, 25, 133, 29), _
            Color.FromArgb(255, 25, 131, 27), Color.FromArgb(255, 30, 150, 38), _
            Color.FromArgb(255, 30, 152, 40)}
        Dim pressedColors() As Color = {Color.FromArgb(255, 16, 87, 18), _
            Color.FromArgb(255, 13, 84, 16), Color.FromArgb(255, 12, 90, 12), _
            Color.FromArgb(255, 10, 89, 12)}

        Dim normalStyle As New FillStyleGradientEx(colors(0), colors(1), _
            colors(2), colors(3), 90, 0.7F, 0.9F)
        Dim highlightStyle As New FillStyleGradientEx(highlightColors(0), _
            highlightColors(1), highlightColors(2), highlightColors(3), 90, 0.7F, 0.9F)
        Dim pressedStyle As New FillStyleGradientEx(pressedColors(0), _
            pressedColors(1), pressedColors(2), pressedColors(3), 90, 0.7F, 0.9F)
        Dim borderColor As Color = Color.FromArgb(14, 99, 0)

        Dim theme As ControlTheme = ControlTheme.GetDefaultTheme(VIBLEND_THEME.OFFICEBLUE).CreateCopy()
        theme.StyleNormal.FillStyle = normalStyle
        theme.StyleNormal.BorderColor = borderColor
        theme.StyleNormal.TextColor = Color.White
        theme.StyleHighlight.FillStyle = highlightStyle
        theme.StyleHighlight.BorderColor = borderColor
        theme.StyleHighlight.TextColor = Color.White
        theme.StylePressed.FillStyle = pressedStyle
        theme.StylePressed.BorderColor = borderColor
        theme.StylePressed.TextColor = Color.White

        VButton1.StyleKey = "XinDarkGreen"
        VButton1.RoundedCornersMask = CByte(VIBlend.Utilities.RoundedCornersMask.TOP_LEFT)
        VButton1.Theme = theme

        VButton2.StyleKey = "XinDarkGreen"
        VButton2.RoundedCornersMask = CByte(VIBlend.Utilities.RoundedCornersMask.TOP_RIGHT)
        VButton2.Theme = theme

        VButton3.StyleKey = "XinDarkGreen"
        VButton3.RoundedCornersMask = CByte(VIBlend.Utilities.RoundedCornersMask.TOP_LEFT And VIBlend.Utilities.RoundedCornersMask.BOTTOM_LEFT)
        VButton3.Theme = theme

        VButton4.StyleKey = "XinDarkGreen"
        VButton4.RoundedCornersMask = Nothing
        VButton4.Theme = theme

        VButton5.StyleKey = "XinDarkGreen"
        VButton5.RoundedCornersMask = CByte(VIBlend.Utilities.RoundedCornersMask.TOP_RIGHT And VIBlend.Utilities.RoundedCornersMask.BOTTOM_RIGHT)
        VButton5.Theme = theme
    End Sub

#End Region

    Public Sub LoadUrl(ByVal url As String)
        UrlToLoadAtStart = url
    End Sub

    Private Sub OnDownloadBegin(sender As Object, e As DownloadBeginEventArgs)
        'Gestion des téléchargements ici lors d'un nouveau téléchargement
        Dim ndown As New DownloadTicket
        ndown.Dock = DockStyle.Top
        If My.Settings.AskForSavingDownloads = True Then
            ndown.AddNewDownload(e.Info.Url.ToString, e.Info.FileName, e.Info.SavePath)
        Else
            ndown.AddNewDownload(FileUrl, FileName, DirectoryName)
            FileName = Nothing
            DirectoryName = Nothing
            FileUrl = Nothing
        End If
        DownloadsForm.DownloadList.Controls.Add(ndown)
        DownloadsForm.Show()
        e.Info.Cancel()
    End Sub

    Private Sub DownloadEv(sender As Object, e As DownloadEventArgs)
        'On fait sa propre fonction pour enregistrer le téléchargement
        If My.Settings.AskForSavingDownloads = True Then
            e.Handled = False
        Else
            e.Handled = True
            FileName = e.SuggestedFileName
            DirectoryName = My.Settings.DownloadsPlace & "\" & e.SuggestedFileName
            FileUrl = e.Url.ToString
            e.Cancel = True
            Dim ndown As New DownloadTicket
            ndown.Dock = DockStyle.Top
            ndown.AddNewDownload(FileUrl, FileName, DirectoryName)
            DownloadsForm.DownloadList.Controls.Add(ndown)
            DownloadsForm.Show()
        End If
    End Sub

    Private Sub TabWebBrowser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler WebCore.DownloadBegin, AddressOf OnDownloadBegin
        AddHandler WebCore.Download, AddressOf DownloadEv

        Dim theme As ControlTheme = ControlTheme.GetDefaultTheme(VIBLEND_THEME.BLUEBLEND).CreateCopy()
        theme.Radius = 2
        VStripsRenderer1.Theme = theme

        MyWebBrowser = New Awesomium.Windows.Forms.WebControl

        'Définition des paramètres
        If Not IO.Directory.Exists(Environment.SpecialFolder.MyDocuments & "\Xin Browser") Then
            IO.Directory.CreateDirectory(Environment.SpecialFolder.MyDocuments & "\Xin Browser")
        End If
        If IsInPrivateNavigation = True Then
            Using myWebSession As WebSession = WebCore.CreateWebSession(Environment.SpecialFolder.MyDocuments & "\Xin Browser (Cache)", New WebPreferences() With {.CustomCSS = "::-webkit-scrollbar { visibility: hidden; }" & .AcceptLanguage = "fr-fr,fr" & .LocalStorage = False})
                Using myView As WebView = WebCore.CreateWebView(1280, 960, myWebSession)
                    MyWebBrowser.WebSession = myWebSession
                End Using
            End Using
            'Changement de la couleur de l'onglet pour indiquer la navigation privée
            CType(Me.ParentForm, Form1).TabControl1.TabPages.SelectedTab.BackHighColor = Color.Coral
            CType(Me.ParentForm, Form1).TabControl1.TabPages.SelectedTab.BackHighColor = Color.DarkOrange
        Else
            Using myWebSession As WebSession = WebCore.CreateWebSession(Environment.SpecialFolder.MyDocuments & "\Xin Browser (Cache)", New WebPreferences() With {.CustomCSS = "::-webkit-scrollbar { visibility: hidden; }" & .AcceptLanguage = "fr-fr,fr"})
                Using myView As WebView = WebCore.CreateWebView(1280, 960, myWebSession)
                    MyWebBrowser.WebSession = myWebSession
                End Using
            End Using
        End If

        'Mise en place du thème choisi par l'utilisateur
        If My.Settings.CurrentTheme = "xinbrowser" Then
            SetOrangeTheme()
        ElseIf My.Settings.CurrentTheme = "modern" Then
            SetBlueTheme()
        ElseIf My.Settings.CurrentTheme = "classic" Then
            SetGreenTheme()
        End If
        
        'Fin des définitions des paramètres

        MyWebBrowser.Dock = DockStyle.Fill

        If UrlToLoadAtStart = Nothing Then
            MyWebBrowser.Source = New Uri("http://www.google.fr/")
        Else
            MyWebBrowser.Source = New Uri(UrlToLoadAtStart)
        End If

        Controls.Add(MyWebBrowser)
        MyWebBrowser.BringToFront()
    End Sub

    Private Sub MyWebBrowser_DocumentReady(sender As Object, e As Awesomium.Core.UrlEventArgs) Handles MyWebBrowser.DocumentReady
        Dim oURL As Uri = New Uri(MyWebBrowser.Source.AbsoluteUri)
        If oURL.HostNameType = UriHostNameType.Dns Then
            Try
                Dim iconURL As String = "http://" & oURL.Host & "/favicon.ico"
                Dim web As New Net.WebClient
                Dim ms As New IO.MemoryStream(web.DownloadData(iconURL))
                Dim icon As New Icon(ms)
                Me.Icon = icon
                If icon Is Nothing Then
                    Me.Icon = Me.ParentForm.Icon
                End If
            Catch ex As Exception
                Me.Icon = Me.ParentForm.Icon
            End Try
        End If
        If Me.ParentForm.Text.StartsWith(Me.Text) Then
            CType(Me.ParentForm, Form1).TextBox1.Text = e.Url.ToString
            CType(Me.ParentForm, Form1).VButton3.Image = Icon.ToBitmap
        End If

        'Urls personnalisées

        Dim f1 As String = Strings.Replace(Application.StartupPath, "\", "/")
        Dim ff As String = Strings.Replace(f1, " ", "%20")
        If MyWebBrowser.Source.ToString = "file:///" & ff & "/html/a_propos.html" Or MyWebBrowser.Source.ToString.StartsWith("file:///" & ff & "/html/a_propos.html#") Then
            CType(Me.ParentForm, Form1).TextBox1.Text = "xinbrowser://about"
        End If
        If MyWebBrowser.Source.ToString = "file:///" & ff & "/html/CGU.html" Or MyWebBrowser.Source.ToString.StartsWith("file:///" & ff & "/html/CGU.html#") Then
            CType(Me.ParentForm, Form1).TextBox1.Text = "xinbrowser://cgu"
        End If
        If MyWebBrowser.Source.ToString = "file:///" & ff & "/html/contact.html" Or MyWebBrowser.Source.ToString.StartsWith("file:///" & ff & "/html/contact.html#") Then
            CType(Me.ParentForm, Form1).TextBox1.Text = "xinbrowser://contact"
        End If
        If MyWebBrowser.Source.ToString = "file:///" & ff & "/html/contributeurs.html" Or MyWebBrowser.Source.ToString.StartsWith("file:///" & ff & "/html/contributeurs.html#") Then
            CType(Me.ParentForm, Form1).TextBox1.Text = "xinbrowser://contribute"
        End If
        If MyWebBrowser.Source.ToString = "file:///" & ff & "/html/mise_a_jour.html" Or MyWebBrowser.Source.ToString.StartsWith("file:///" & ff & "/html/mise_a_jour.html#") Then
            CType(Me.ParentForm, Form1).TextBox1.Text = "xinbrowser://update"
            'Changement du numéro de version de Xin Browser
            MyWebBrowser.ExecuteJavascript("document.getElementById(" & """currentvers""" & ").innerHTML = """ & "Numéro de version: " & My.Application.Info.Version.ToString & """;")
        End If
        If MyWebBrowser.Source.ToString = "file:///" & ff & "/html/outils.html" Or MyWebBrowser.Source.ToString.StartsWith("file:///" & ff & "/html/outils.html#") Then
            CType(Me.ParentForm, Form1).TextBox1.Text = "xinbrowser://tools"
        End If
        If MyWebBrowser.Source.ToString = "file:///" & ff & "/html/newtab.html" Or MyWebBrowser.Source.ToString.StartsWith("file:///" & ff & "/html/newtab.html#") Then
            CType(Me.ParentForm, Form1).TextBox1.Text = "xinbrowser://newtab"
        End If
        If MyWebBrowser.Source.ToString = "file:///" & ff & "/html/parametres.html" Or MyWebBrowser.Source.ToString.StartsWith("file:///" & ff & "/html/parametres.html#") Then
            CType(Me.ParentForm, Form1).TextBox1.Text = "xinbrowser://settings"

            MyWebBrowser.ExecuteJavascript("document.getElementById(" & """homepageTextBox""" & ").value =""" & My.Settings.HomeUrl & """" & ";")

            If My.Settings.SearchEngineName = "Google" Then
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """GoogleSE""" & ").checked = true;")
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """BingSE""" & ").checked = false;")
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """Yahoo!SE""" & ").checked = false;")
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """DuckDuckGoSE""" & ").checked = false;")
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """QwantSE""" & ").checked = false;")
            ElseIf My.Settings.SearchEngineName = "Bing" Then
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """GoogleSE""" & ").checked = false;")
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """BingSE""" & ").checked = true;")
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """Yahoo!SE""" & ").checked = false;")
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """DuckDuckGoSE""" & ").checked = false;")
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """QwantSE""" & ").checked = false;")
            ElseIf My.Settings.SearchEngineName = "Yahoo" Then
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """GoogleSE""" & ").checked = false;")
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """BingSE""" & ").checked = false;")
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """Yahoo!SE""" & ").checked = true;")
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """DuckDuckGoSE""" & ").checked = false;")
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """QwantSE""" & ").checked = false;")
            ElseIf My.Settings.SearchEngineName = "DuckDuckGo" Then
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """GoogleSE""" & ").checked = false;")
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """BingSE""" & ").checked = false;")
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """Yahoo!SE""" & ").checked = false;")
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """DuckDuckGoSE""" & ").checked = true;")
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """QwantSE""" & ").checked = false;")
            ElseIf My.Settings.SearchEngineName = "Qwant" Then
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """GoogleSE""" & ").checked = false;")
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """BingSE""" & ").checked = false;")
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """Yahoo!SE""" & ").checked = false;")
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """DuckDuckGoSE""" & ").checked = false;")
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """QwantSE""" & ").checked = true;")
            End If

            If My.Settings.CurrentTheme = "xinbrowser" Then
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """optn:theme_xindarkblue""" & ").checked = false;")
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """optn:theme_xindarkorange""" & ").checked = true;")
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """optn:theme_xindarkgreen""" & ").checked = false;")
            ElseIf My.Settings.CurrentTheme = "modern" Then
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """optn:theme_xindarkblue""" & ").checked = true;")
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """optn:theme_xindarkorange""" & ").checked = false;")
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """optn:theme_xindarkgreen""" & ").checked = false;")
            ElseIf My.Settings.CurrentTheme = "classic" Then
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """optn:theme_xindarkblue""" & ").checked = false;")
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """optn:theme_xindarkorange""" & ").checked = false;")
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """optn:theme_xindarkgreen""" & ").checked = true;")
            End If

            If My.Settings.AskForSavingDownloads = True Then
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """autosavedownload""" & ").checked = true;")
            Else
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """autosavedownload""" & ").checked = false;")
            End If

            If My.Settings.NewTabSet = "optn:newtabpage" Then
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """optn:newtabpage""" & ").checked = true;")
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """optn:home""" & ").checked = false;")
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """optn:newtabs""" & ").checked = false;")
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """optn:blank""" & ").checked = false;")
            ElseIf My.Settings.NewTabSet = "optn:home" Then
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """optn:newtabpage""" & ").checked = false;")
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """optn:home""" & ").checked = true;")
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """optn:newtabs""" & ").checked = false;")
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """optn:blank""" & ").checked = false;")
            ElseIf My.Settings.NewTabSet = "optn:newtabs" Then
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """optn:newtabpage""" & ").checked = false;")
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """optn:home""" & ").checked = false;")
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """optn:newtabs""" & ").checked = true;")
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """optn:blank""" & ").checked = false;")
            ElseIf My.Settings.NewTabSet = "optn:blank" Then
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """optn:newtabpage""" & ").checked = false;")
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """optn:home""" & ").checked = false;")
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """optn:newtabs""" & ").checked = false;")
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """optn:blank""" & ").checked = true;")
            End If

            If My.Settings.Optn_BetaUpdate Then
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """syspgrm_betas""" & ").checked = true;")
            Else
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """syspgrm_betas""" & ").checked = false;")
            End If
            If My.Settings.Optn_Cache Then
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """navdata_cache""" & ").checked = true;")
            Else
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """navdata_cache""" & ").checked = false;")
            End If
            If My.Settings.Optn_Clipboard Then
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """navauto_clipboard""" & ").checked = true;")
            Else
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """navauto_clipboard""" & ").checked = false;")
            End If
            If My.Settings.Optn_Cookies Then
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """navdata_cookies""" & ").checked = true;")
            Else
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """navdata_cookies""" & ").checked = false;")
            End If
            If My.Settings.Optn_GPU Then
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """sys_gpu""" & ").checked = true;")
            Else
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """sys_gpu""" & ").checked = false;")
            End If
            If My.Settings.Optn_Insecure Then
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """navdata_insecure""" & ").checked = true;")
            Else
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """navdata_insecure""" & ").checked = false;")
            End If
            If My.Settings.Optn_Javascript Then
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """navauto_javascript""" & ").checked = true;")
            Else
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """navauto_javascript""" & ").checked = false;")
            End If
            If My.Settings.Optn_LocalFiles Then
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """navauto_localfiles""" & ").checked = true;")
            Else
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """navauto_localfiles""" & ").checked = false;")
            End If
            If My.Settings.Optn_Scripts Then
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """navauto_scripts""" & ").checked = true;")
            Else
                MyWebBrowser.ExecuteJavascript("document.getElementById(" & """navauto_scripts""" & ").checked = false;")
            End If
        End If

        If MyWebBrowser.Source.ToString = "file:///" & ff & "/html/partenariats.html" Or MyWebBrowser.Source.ToString.StartsWith("file:///" & ff & "/html/partenariats.html#") Then
            CType(Me.ParentForm, Form1).TextBox1.Text = "xinbrowser://partners"
        End If

        If CType(Me.ParentForm, Form1).TextBox1.Text.StartsWith("xinbrowser://") Then
            CType(Me.ParentForm, Form1).TextBox1.ForeColor = Color.Orange
        ElseIf CType(Me.ParentForm, Form1).TextBox1.Text.StartsWith("https://") Then
            CType(Me.ParentForm, Form1).TextBox1.ForeColor = Color.Green
        Else
            CType(Me.ParentForm, Form1).TextBox1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub MyWebBrowser_KeyUp(sender As Object, e As KeyEventArgs) Handles MyWebBrowser.KeyUp
        If e.Modifiers = Keys.F12 Then
            Dim tb As Boolean = CodeViewer1.Visible
            If tb = True Then
                CodeViewer1.Visible = False
            Else
                CodeViewer1.Visible = False
            End If
        End If
        If e.Modifiers = Keys.Control And e.KeyCode = Keys.F Then
            Dim tb As Boolean = Panel1.Visible
            If tb = True Then
                Panel1.Visible = False
            Else
                Panel1.Visible = False
            End If
        End If
    End Sub

    Private Sub MyWebBrowser_LoadingFrameFailed(sender As Object, e As LoadingFrameFailedEventArgs) Handles MyWebBrowser.LoadingFrameFailed
        'Erreur lors du chargement d'une page HTML
    End Sub

    Private Sub MyWebBrowser_LoginRequest(sender As Object, e As LoginRequestEventArgs) Handles MyWebBrowser.LoginRequest
        'Affichage de la form pour se connecter à un réseau particulier
    End Sub

    Private Sub MyWebBrowser_ShowContextMenu(sender As Object, e As ContextMenuEventArgs) Handles MyWebBrowser.ShowContextMenu
        e.Handled = True
        If e.Info.MediaType = MediaType.Audio Then
            ContextMenuStrip_Audio.Show(New Point(e.Info.MouseX, e.Info.MouseY))
            Lst_MediaUrl = e.Info.SourceURL.ToString
        ElseIf e.Info.MediaType = MediaType.Image Then
            ContextMenuStrip_Image.Show(New Point(e.Info.MouseX, e.Info.MouseY))
            Lst_MediaUrl = e.Info.SourceURL.ToString
        ElseIf e.Info.MediaType = MediaType.Video Then
            ContextMenuStrip_Video.Show(New Point(e.Info.MouseX, e.Info.MouseY))
            Lst_MediaUrl = e.Info.SourceURL.ToString
        ElseIf e.Info.HasLinkURL Then
            ContextMenuStrip_Link.Show(New Point(e.Info.MouseX, e.Info.MouseY))
            Lst_TargetUrl = e.Info.LinkURL.ToString
        ElseIf Not e.Info.SelectionText = Nothing Then
            ContextMenuStrip_Text.Show(New Point(e.Info.MouseX, e.Info.MouseY))
            Lst_SelectedText = e.Info.SelectionText
        Else
            ContextMenuStrip_Default.Show(New Point(e.Info.MouseX, e.Info.MouseY))
        End If
        Lst_PosX = e.Info.MouseX
        Lst_PosY = e.Info.MouseY
    End Sub

    Private Sub MyWebBrowser_ShowCreatedWebView(sender As Object, e As ShowCreatedWebViewEventArgs) Handles MyWebBrowser.ShowCreatedWebView
        'PopUps etc...
        If e.IsPost Or e.IsWindowOpen Then
            Dim ntab As New TabWebBrowser
            ntab.LoadUrl(e.OpenerURL.ToString)
            CType(Me.ParentForm, Form1).TabControl1.TabPages.Add(ntab)
        ElseIf e.IsNavigationCanceled Then
            'Page web: Navigation annulée
        ElseIf e.IsPopup Then
            Dim msgboxres As MsgBoxResult = MsgBox("Une fenêtre pop-up a tenté de s'ouvrir, voulez-vous la bloquer ou l'ouvrir tout de même ?", MsgBoxStyle.YesNo, "Avertissement PopUp - Xin Browser")
            If msgboxres = MsgBoxResult.Yes Then
                'Ouvre le popup
                Dim ntab As New TabWebBrowser
                ntab.LoadUrl(e.OpenerURL.ToString)
                CType(Me.ParentForm, Form1).TabControl1.TabPages.Add(ntab)
            Else
                'Ignore le popup
            End If
        End If
    End Sub

    Private Sub MyWebBrowser_ShowJavascriptDialog(sender As Object, e As JavascriptDialogEventArgs) Handles MyWebBrowser.ShowJavascriptDialog
        Dim f1 As String = Strings.Replace(Application.StartupPath, "\", "/")
        Dim ff As String = Strings.Replace(f1, " ", "%20")

        'Alertes et autres messages JavaScript
        e.Handled = True
        'Paramètre de Xin Browser à modifier
        If e.Message = "xboptn://update" Then
            'Demande de vérification des mises à jour
            Dim wb As New Net.WebClient
            Dim newvers As String = wb.DownloadString("https://dl.dropboxusercontent.com/u/56127675/XinLoxx/Xin%20Browser%20Bêta/version.txt")
            If My.Settings.EnableBetaUpdates = True Then
                If newvers.LastIndexOf(".") > My.Application.Info.Version.Revision Then
                    'Mise à jour bêta disponible
                    Dim res As MsgBoxResult = MsgBox("Une mise à jour (version bêta) est disponible, voulez-vous la télécharger et l'installer ?", MsgBoxStyle.YesNoCancel)
                    If res = MsgBoxResult.Yes Then
                        Process.Start(Application.StartupPath & "\updater.exe")
                    End If
                    End
                Else
                    'Vérification des mises à jour normales
                    If newvers > My.Application.Info.Version.ToString Then
                        'Mise à jour disponible
                        Dim res As MsgBoxResult = MsgBox("Une mise à jour de Xin Browser est disponible, voulez-vous la télécharger et l'installer ?", MsgBoxStyle.YesNoCancel)
                        If res = MsgBoxResult.Yes Then
                            Process.Start(Application.StartupPath & "\updater.exe")
                        End If
                        End
                    End If
                End If
            Else
                'Vérification des mises à jour normales
                If newvers > My.Application.Info.Version.ToString Then
                    'Mise à jour disponible
                    Dim res As MsgBoxResult = MsgBox("Une mise à jour de Xin Browser est disponible, voulez-vous la télécharger et l'installer ?", MsgBoxStyle.YesNoCancel)
                    If res = MsgBoxResult.Yes Then
                        Process.Start(Application.StartupPath & "\updater.exe")
                    End If
                    End
                End If
            End If
        ElseIf e.Message = "xboptn://sethomepage" Then
            'Demande de changement de l'url de la page d'accueil
            MyWebBrowser.ExecuteJavascript("document.getElementById(" & """homepageTextBox""" & ").value =""" & My.Settings.HomeUrl & """" & ";")
            MyWebBrowser.ExecuteJavascript("window.location.reload()")
        ElseIf e.Message = "xboptn://settheme/xindarkorange" Then
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
        ElseIf e.Message = "xboptn://open/favourites" Then
            CType(Me.ParentForm, Form1).FavHistList1.Visible = False
            CType(Me.ParentForm, Form1).VButton7.PerformClick()
        ElseIf e.Message = "xboptn://open/history" Then
            CType(Me.ParentForm, Form1).FavHistList1.Visible = False
            CType(Me.ParentForm, Form1).VButton8.PerformClick()
        ElseIf e.Message = "xboptn://open/downloads" Then
            CType(Me.ParentForm, Form1).FavHistList1.Visible = False
            CType(Me.ParentForm, Form1).VButton10.PerformClick()
        ElseIf e.Message = "xboptn://open/settings" Then
            Dim ntab As New TabWebBrowser
            ntab.LoadUrl("file:///" & ff & "/html/parametres.html")
            CType(Me.ParentForm, Form1).TabControl1.TabPages.Add(ntab)
        ElseIf e.Message = "xboptn://open/about" Then
            Dim ntab As New TabWebBrowser
            ntab.LoadUrl("file:///" & ff & "/html/a_propos.html")
            CType(Me.ParentForm, Form1).TabControl1.TabPages.Add(ntab)
        ElseIf e.Message = "xboptn://settheme/xindarkblue" Then
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
        ElseIf e.Message = "xboptn://settheme/xindarkgreen" Then
            My.Settings.CurrentTheme = "classic"
            My.Settings.Save()
            For Each i As Form In My.Application.OpenForms
                Try
                    CType(i, Form1).SetGreenTheme()
                    CType(i, Form1).WebsiteInfoBulle1.SetGreenTheme()
                    CType(i, Form1).UrlLister1.SetGreenTheme()
                    CType(i, Form1).FavHistList1.SetGreenTheme()
                Catch ex As Exception

                End Try
            Next
        ElseIf e.Message = "xboptn://cookieslist" Then
            'Demande de l'affichage de la liste des cookies
            MsgBox("Fonction bientôt disponible")
        ElseIf e.Message = "xboptn://exportfavourites" Then
            'Demande de l'export des favoris
            MsgBox("Fonction bientôt disponible")
        ElseIf e.Message = "xboptn://exporthistory" Then
            'Demande de l'export de l'historique
            MsgBox("Fonction bientôt disponible")
        ElseIf e.Message = "xboptn://importfavourites" Then
            'Demande de l'import des favoris
            MsgBox("Fonction bientôt disponible")
        ElseIf e.Message = "xboptn://importhistory" Then
            'Demande de l'import de l'historique
            MsgBox("Fonction bientôt disponible")
        ElseIf e.Message = "xboptn://setsearchengine/Google" Then
            My.Settings.SearchEngineName = "Google"
            My.Settings.SearchEngineUrl = "http://www.google.fr/search?q="
            My.Settings.Save()

            MyWebBrowser.ExecuteJavascript("document.getElementById(" & """GoogleSE""" & ").checked = true;")
            MyWebBrowser.ExecuteJavascript("document.getElementById(" & """BingSE""" & ").checked = false;")
            MyWebBrowser.ExecuteJavascript("document.getElementById(" & """Yahoo!SE""" & ").checked = false;")
            MyWebBrowser.ExecuteJavascript("document.getElementById(" & """DuckDuckGoSE""" & ").checked = false;")
            MyWebBrowser.ExecuteJavascript("document.getElementById(" & """QwantSE""" & ").checked = false;")
        ElseIf e.Message = "xboptn://setsearchengine/Bing" Then
            My.Settings.SearchEngineName = "Bing"
            My.Settings.SearchEngineUrl = "http://www.bing.com/search?q="
            My.Settings.Save()

            MyWebBrowser.ExecuteJavascript("document.getElementById(" & """GoogleSE""" & ").checked = false;")
            MyWebBrowser.ExecuteJavascript("document.getElementById(" & """BingSE""" & ").checked = true;")
            MyWebBrowser.ExecuteJavascript("document.getElementById(" & """Yahoo!SE""" & ").checked = false;")
            MyWebBrowser.ExecuteJavascript("document.getElementById(" & """DuckDuckGoSE""" & ").checked = false;")
            MyWebBrowser.ExecuteJavascript("document.getElementById(" & """QwantSE""" & ").checked = false;")
        ElseIf e.Message = "xboptn://setsearchengine/Yahoo!" Then
            My.Settings.SearchEngineName = "Yahoo!"
            My.Settings.SearchEngineUrl = "http://fr.search.yahoo.com/search?p="
            My.Settings.Save()

            MyWebBrowser.ExecuteJavascript("document.getElementById(" & """GoogleSE""" & ").checked = false;")
            MyWebBrowser.ExecuteJavascript("document.getElementById(" & """BingSE""" & ").checked = false;")
            MyWebBrowser.ExecuteJavascript("document.getElementById(" & """Yahoo!SE""" & ").checked = true;")
            MyWebBrowser.ExecuteJavascript("document.getElementById(" & """DuckDuckGoSE""" & ").checked = false;")
            MyWebBrowser.ExecuteJavascript("document.getElementById(" & """QwantSE""" & ").checked = false;")
        ElseIf e.Message = "xboptn://setsearchengine/Qwant" Then
            My.Settings.SearchEngineName = "Qwant"
            My.Settings.SearchEngineUrl = "http://www.qwant.com/?q="
            My.Settings.Save()

            MyWebBrowser.ExecuteJavascript("document.getElementById(" & """GoogleSE""" & ").checked = false;")
            MyWebBrowser.ExecuteJavascript("document.getElementById(" & """BingSE""" & ").checked = false;")
            MyWebBrowser.ExecuteJavascript("document.getElementById(" & """Yahoo!SE""" & ").checked = false;")
            MyWebBrowser.ExecuteJavascript("document.getElementById(" & """DuckDuckGoSE""" & ").checked = false;")
            MyWebBrowser.ExecuteJavascript("document.getElementById(" & """QwantSE""" & ").checked = true;")
        ElseIf e.Message = "xboptn://setsearchengine/DuckDuckGo" Then
            My.Settings.SearchEngineName = "DuckDuckGo"
            My.Settings.SearchEngineUrl = "http://www.duckduckgo.com/?q="
            My.Settings.Save()

            MyWebBrowser.ExecuteJavascript("document.getElementById(" & """GoogleSE""" & ").checked = false;")
            MyWebBrowser.ExecuteJavascript("document.getElementById(" & """BingSE""" & ").checked = false;")
            MyWebBrowser.ExecuteJavascript("document.getElementById(" & """Yahoo!SE""" & ").checked = false;")
            MyWebBrowser.ExecuteJavascript("document.getElementById(" & """DuckDuckGoSE""" & ").checked = true;")
            MyWebBrowser.ExecuteJavascript("document.getElementById(" & """QwantSE""" & ").checked = false;")
        ElseIf e.Message.StartsWith("xboptn://setdownload/") Then
            If e.Message.Substring(e.Message.LastIndexOf("/")) = "false" Then
                My.Settings.AskForSavingDownloads = False
                My.Settings.Save()
            ElseIf e.Message.Substring(e.Message.LastIndexOf("/")) = "true" Then
                My.Settings.AskForSavingDownloads = True
                My.Settings.Save()
            End If
        ElseIf e.Message = "xboptn://sethomesetting/newtabpage" Then
            My.Settings.NewTabSet = "optn:newtabpage"
            My.Settings.Save()
        ElseIf e.Message = "xboptn://sethomesetting/home" Then
            My.Settings.NewTabSet = "optn:home"
            My.Settings.Save()
        ElseIf e.Message = "xboptn://sethomesetting/newtabs" Then
            My.Settings.NewTabSet = "optn:newtabs"
            My.Settings.Save()
        ElseIf e.Message = "xboptn://sethomesetting/blank" Then
            My.Settings.NewTabSet = "optn:blank"
            My.Settings.Save()
        ElseIf e.Message.StartsWith("xboptn://setlocalfiles/") Then
            If e.Message.Substring(e.Message.LastIndexOf("/")) = "false" Then
                My.Settings.Optn_LocalFiles = False
                My.Settings.Save()
            ElseIf e.Message.Substring(e.Message.LastIndexOf("/")) = "true" Then
                My.Settings.Optn_LocalFiles = True
                My.Settings.Save()
            End If
        ElseIf e.Message.StartsWith("xboptn://setclipboard/") Then
            If e.Message.Substring(e.Message.Substring(e.Message.LastIndexOf("/"))) = "false" Then
                My.Settings.Optn_Clipboard = False
                My.Settings.Save()
            ElseIf e.Message.Substring(e.Message.Substring(e.Message.LastIndexOf("/"))) = "true" Then
                My.Settings.Optn_Clipboard = True
                My.Settings.Save()
            End If
        ElseIf e.Message.StartsWith("xboptn://setscripts/") Then
            If e.Message.Substring(e.Message.LastIndexOf("/")) = "false" Then
                My.Settings.Optn_Scripts = False
                My.Settings.Save()
            ElseIf e.Message.Substring(e.Message.LastIndexOf("/")) = "true" Then
                My.Settings.Optn_Scripts = True
                My.Settings.Save()
            End If
        ElseIf e.Message.StartsWith("xboptn://setjavascript/") Then
            If e.Message.Substring(e.Message.LastIndexOf("/")) = "false" Then
                My.Settings.Optn_Javascript = False
                My.Settings.Save()
            ElseIf e.Message.Substring(e.Message.LastIndexOf("/")) = "true" Then
                My.Settings.Optn_Javascript = True
                My.Settings.Save()
            End If
        ElseIf e.Message.StartsWith("xboptn://setinsecure/") Then
            If e.Message.Substring(e.Message.LastIndexOf("/")) = "false" Then
                My.Settings.Optn_Insecure = False
                My.Settings.Save()
            ElseIf e.Message.Substring(e.Message.LastIndexOf("/")) = "true" Then
                My.Settings.Optn_Insecure = True
                My.Settings.Save()
            End If
        ElseIf e.Message.StartsWith("xboptn://setcache/") Then
            If e.Message.Substring(e.Message.LastIndexOf("/")) = "false" Then
                My.Settings.Optn_Cache = False
                My.Settings.Save()
            ElseIf e.Message.Substring(e.Message.LastIndexOf("/")) = "true" Then
                My.Settings.Optn_Cache = True
                My.Settings.Save()
            End If
        ElseIf e.Message.StartsWith("xboptn://setcookies/") Then
            If e.Message.Substring(e.Message.LastIndexOf("/")) = "false" Then
                My.Settings.Optn_Cookies = False
                My.Settings.Save()
            ElseIf e.Message.Substring(e.Message.LastIndexOf("/")) = "true" Then
                My.Settings.Optn_Cookies = True
                My.Settings.Save()
            End If
        ElseIf e.Message.StartsWith("xboptn://setgpu/") Then
            If e.Message.Substring(e.Message.LastIndexOf("/")) = "false" Then
                My.Settings.Optn_GPU = False
                My.Settings.Save()
            ElseIf e.Message.Substring(e.Message.LastIndexOf("/")) = "true" Then
                My.Settings.Optn_GPU = True
                My.Settings.Save()
            End If
        ElseIf e.Message.StartsWith("xboptn://setbetaupdates/") Then
            If e.Message.Substring(e.Message.LastIndexOf("/")) = "false" Then
                My.Settings.Optn_BetaUpdate = False
                My.Settings.Save()
            ElseIf e.Message.Substring(e.Message.LastIndexOf("/")) = "true" Then
                My.Settings.Optn_BetaUpdate = True
                My.Settings.Save()
            End If
        ElseIf e.Message = "xboptn://resetall" Then
            My.Settings.AskForSavingDownloads = True
            My.Settings.Optn_BetaUpdate = False
            My.Settings.Optn_Cache = True
            My.Settings.Optn_Clipboard = True
            My.Settings.Optn_Cookies = True
            My.Settings.Optn_GPU = False
            My.Settings.Optn_Insecure = False
            My.Settings.Optn_Javascript = True
            My.Settings.Optn_LocalFiles = True
            My.Settings.Optn_Scripts = True
            My.Settings.SearchEngineName = "Google"
            My.Settings.SearchEngineUrl = "http://www.google.fr/search?q="
            My.Settings.NewTabSet = "optn:home"
            My.Settings.Save()
        Else
            'Message personnalisé
            If Not My.Settings.JsPopUpBlockedPage.Contains(MyWebBrowser.Source.ToString) Then
                Dim dlg As New JsAlertBox
                dlg.Label1.Text = e.Message
                dlg.host = MyWebBrowser.Source.ToString
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
                dlg.ShowDialog()
            End If
        End If
    End Sub

    Private Sub MyWebBrowser_TitleChanged(sender As Object, e As Awesomium.Core.TitleChangedEventArgs) Handles MyWebBrowser.TitleChanged
        If IsInPrivateNavigation = False Then
            Dim tTitle As String = MyWebBrowser.ExecuteJavascriptWithResult("document.title")
            If tTitle = Nothing Then
                Dim newhist As String = MyWebBrowser.Title + "|" & MyWebBrowser.Source.ToString & "|" & Date.Now.ToShortDateString & "|" & Date.Now.ToShortTimeString
                My.Settings.History.Add(newhist)
                My.Settings.Save()
            Else
                Dim newhist As String = tTitle + "|" & MyWebBrowser.Source.ToString & "|" & Date.Now.ToShortDateString & "|" & Date.Now.ToShortTimeString
                My.Settings.History.Add(newhist)
                My.Settings.Save()
            End If
            'Gestion du zoom
            MyWebBrowser.Zoom = MyWebBrowser.WebSession.GetZoomForURL(MyWebBrowser.Source)
            ZoomInt = MyWebBrowser.WebSession.GetZoomForURL(MyWebBrowser.Source)
            VButton5.Text = "Zoom: " & ZoomInt & "%"
        End If
        If Me.ParentForm.Text.StartsWith(Me.Text) Then
            Me.ParentForm.Text = e.Title & " - Xin Browser"
        End If
        Me.Text = e.Title
    End Sub

    Private Sub MyWebBrowser_WindowClose(sender As Object, e As WindowCloseEventArgs) Handles MyWebBrowser.WindowClose
        If IsInPrivateNavigation = True Then
            'On efface les données stockées sur l'ordinateur en cas de navigation privée
            MyWebBrowser.WebSession.ClearCache()
            MyWebBrowser.WebSession.ClearCookies()
        End If
    End Sub

    Private Sub OuvrirLeLienToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OuvrirLeLienToolStripMenuItem.Click
        MyWebBrowser.Source = New Uri(Lst_TargetUrl)
    End Sub

    Private Sub OuvrirDansUneNouvelleFenêtreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OuvrirDansUneNouvelleFenêtreToolStripMenuItem.Click
        Dim ntab As New TabWebBrowser
        ntab.LoadUrl(Lst_TargetUrl)
        CType(Me.ParentForm, Form1).TabControl1.TabPages.Add(ntab)
    End Sub

    Private Sub OuvrirEnModeNavigationPrivéeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OuvrirEnModeNavigationPrivéeToolStripMenuItem.Click
        Dim ntab As New TabWebBrowser
        ntab.LoadUrl(Lst_TargetUrl)
        CType(Me.ParentForm, Form1).TabControl1.TabPages.Add(ntab)
        ntab.IsInPrivateNavigation = True
        CType(Me.ParentForm, Form1).TabControl1.TabPages.SelectedTab.BackHighColor = Color.Coral
        CType(Me.ParentForm, Form1).TabControl1.TabPages.SelectedTab.BackHighColor = Color.DarkOrange
    End Sub

    Private Sub CopierLadresseDuLienToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopierLadresseDuLienToolStripMenuItem.Click
        Clipboard.SetText(Lst_TargetUrl)
    End Sub

    Private Sub LireToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LireToolStripMenuItem.Click
        MyWebBrowser.ExecuteJavascript("document.getElementsByTagName('audio')[0].play()")
    End Sub

    Private Sub PauseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PauseToolStripMenuItem.Click
        MyWebBrowser.ExecuteJavascript("document.getElementsByTagName('audio')[0].pause()")
    End Sub

    Public Function GetFileNameFromURL(ByVal URL As String) As String
        Try
            Return URL.Substring(URL.LastIndexOf("/") + 1)
        Catch ex As Exception
            Return URL
        End Try
    End Function

    Private Sub EnregistrerLeFichierAudioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnregistrerLeFichierAudioToolStripMenuItem.Click
        If My.Settings.AskForSavingDownloads = True Then
            Dim dlg As New SaveFileDialog
            dlg.Title = "Enregistrer l'audio sous..."
            dlg.Filter = "Fichier audio (*" + IO.Path.GetExtension(GetFileNameFromURL(Lst_MediaUrl)) + ")|*" + IO.Path.GetExtension(GetFileNameFromURL(Lst_MediaUrl))
            dlg.FileName = GetFileNameFromURL(Lst_MediaUrl)
            If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
                'Téléchargement à l'emplacement souhaité
                Dim ndown As New DownloadTicket
                ndown.Dock = DockStyle.Top
                ndown.AddNewDownload(Lst_MediaUrl, dlg.FileName.Substring(dlg.FileName.LastIndexOf("\") + 1), dlg.FileName)
                DownloadsForm.DownloadList.Controls.Add(ndown)
                DownloadsForm.Show()
            End If
        Else
            'Téléchargement direct
            Dim ndown As New DownloadTicket
            ndown.Dock = DockStyle.Top
            ndown.AddNewDownload(Lst_MediaUrl, GetFileNameFromURL(Lst_MediaUrl), My.Settings.DownloadsPlace & "\" & GetFileNameFromURL(Lst_MediaUrl))
            DownloadsForm.DownloadList.Controls.Add(ndown)
            DownloadsForm.Show()
        End If
    End Sub

    Private Sub CopierLurlDuFichierAudioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopierLurlDuFichierAudioToolStripMenuItem.Click
        Clipboard.SetText(Lst_MediaUrl)
    End Sub

    Private Sub OuvrirLeFichierDansUnNouvelOngletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OuvrirLeFichierDansUnNouvelOngletToolStripMenuItem.Click
        Dim ntab As New TabWebBrowser
        ntab.LoadUrl(Lst_MediaUrl)
        CType(Me.ParentForm, Form1).TabControl1.TabPages.Add(ntab)
    End Sub

    Private Sub LireToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LireToolStripMenuItem1.Click
        MyWebBrowser.ExecuteJavascript("document.getElementsByTagName('video')[0].play()")
    End Sub

    Private Sub PauseToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PauseToolStripMenuItem1.Click
        MyWebBrowser.ExecuteJavascript("document.getElementsByTagName('video')[0].pause()")
    End Sub

    Private Sub EnregistrerLaVidéoSousToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnregistrerLaVidéoSousToolStripMenuItem.Click
        If My.Settings.AskForSavingDownloads = True Then
            Dim dlg As New SaveFileDialog
            dlg.Title = "Enregistrer la vidéo sous..."
            dlg.Filter = "Fichier vidéo (*" + IO.Path.GetExtension(GetFileNameFromURL(Lst_MediaUrl)) + ")|*" + IO.Path.GetExtension(GetFileNameFromURL(Lst_MediaUrl))
            dlg.FileName = GetFileNameFromURL(Lst_MediaUrl)
            If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
                'Téléchargement à l'emplacement souhaité
                Dim ndown As New DownloadTicket
                ndown.Dock = DockStyle.Top
                ndown.AddNewDownload(Lst_MediaUrl, dlg.FileName.Substring(dlg.FileName.LastIndexOf("\") + 1), dlg.FileName)
                DownloadsForm.DownloadList.Controls.Add(ndown)
                DownloadsForm.Show()
            End If
        Else
            'Téléchargement direct
            Dim ndown As New DownloadTicket
            ndown.Dock = DockStyle.Top
            ndown.AddNewDownload(Lst_MediaUrl, GetFileNameFromURL(Lst_MediaUrl), My.Settings.DownloadsPlace & "\" & GetFileNameFromURL(Lst_MediaUrl))
            DownloadsForm.DownloadList.Controls.Add(ndown)
            DownloadsForm.Show()
        End If
    End Sub

    Private Sub CopierLurlDeLaVidéoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopierLurlDeLaVidéoToolStripMenuItem.Click
        Clipboard.SetText(Lst_MediaUrl)
    End Sub

    Private Sub OuvrirLaVidéoDansUnNouvelOngletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OuvrirLaVidéoDansUnNouvelOngletToolStripMenuItem.Click
        Dim ntab As New TabWebBrowser
        ntab.LoadUrl(Lst_MediaUrl)
        CType(Me.ParentForm, Form1).TabControl1.TabPages.Add(ntab)
    End Sub

    Private Sub RetourToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RetourToolStripMenuItem.Click
        MyWebBrowser.GoBack()
    End Sub

    Private Sub AvancerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AvancerToolStripMenuItem.Click
        MyWebBrowser.GoForward()
    End Sub

    Private Sub ActualiserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualiserToolStripMenuItem.Click
        MyWebBrowser.ExecuteJavascript("window.location.reload()")
    End Sub

    Private Sub EnregistrerSousToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnregistrerSousToolStripMenuItem.Click
        If My.Settings.AskForSavingDownloads = True Then
            Dim dlg As New SaveFileDialog
            dlg.Title = "Enregistrer la page sous..."
            dlg.Filter = "Fichier HTML (*.htm;*.html)|*.htm;*.html"
            dlg.FileName = GetFileNameFromURL(MyWebBrowser.Source.ToString)
            If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
                'Téléchargement à l'emplacement souhaité
                Dim ndown As New DownloadTicket
                ndown.Dock = DockStyle.Top
                ndown.AddNewDownload(MyWebBrowser.Source.ToString, dlg.FileName.Substring(dlg.FileName.LastIndexOf("\") + 1), dlg.FileName)
                DownloadsForm.DownloadList.Controls.Add(ndown)
                DownloadsForm.Show()
            End If
        Else
            'Téléchargement direct
            Dim ndown As New DownloadTicket
            ndown.Dock = DockStyle.Top
            ndown.AddNewDownload(MyWebBrowser.Source.ToString, GetFileNameFromURL(MyWebBrowser.Source.ToString), My.Settings.DownloadsPlace & "\" & GetFileNameFromURL(MyWebBrowser.Source.ToString))
            DownloadsForm.DownloadList.Controls.Add(ndown)
            DownloadsForm.Show()
        End If
    End Sub

    Private Sub ImprimerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimerToolStripMenuItem.Click
        Dim dlg As New SaveFileDialog
        dlg.Title = "Enregistrer la page sous..."
        dlg.Filter = "Fichier PDF (*.pdf)|*.pdf"
        dlg.FileName = GetFileNameFromURL(MyWebBrowser.Source.ToString)
        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            MyWebBrowser.PrintToFile(dlg.FileName, Awesomium.Core.PrintConfig.Default)
        End If
    End Sub

    Private Sub TraduireLaPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TraduireLaPageToolStripMenuItem.Click
        Dim oldUri As String = MyWebBrowser.Source.ToString
        MyWebBrowser.Source = New Uri("https://translate.google.fr/translate?sl=auto&tl=fr&js=y&prev=_t&hl=fr&ie=UTF-8&u=" + oldUri + "&edit-text=&act=url")
    End Sub

    Private Sub AfficherLeCodeSourceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AfficherLeCodeSourceToolStripMenuItem.Click
        CodeViewer1.LoadHtmlSource(MyWebBrowser)
        CodeViewer1.Visible = True
        WBItem += 1
    End Sub

    Private Sub Close_Btn_Click(sender As Object, e As EventArgs) Handles Close_Btn.Click
        Panel1.Visible = False
        WBItem -= 1
    End Sub

    Private Sub Close_Btn_MouseEnter(sender As Object, e As EventArgs) Handles Close_Btn.MouseEnter
        Close_Btn.ForeColor = Color.Silver
    End Sub

    Private Sub Close_Btn_MouseDown(sender As Object, e As MouseEventArgs) Handles Close_Btn.MouseDown
        Close_Btn.ForeColor = Color.DarkRed
    End Sub

    Private Sub Close_Btn_MouseLeave(sender As Object, e As EventArgs) Handles Close_Btn.MouseLeave
        Close_Btn.ForeColor = Color.White
    End Sub

    Private Sub Close_Btn2_Click(sender As Object, e As EventArgs) Handles Close_Btn2.Click
        Panel2.Visible = False
        WBItem -= 1
    End Sub

    Private Sub Close_Btn2_MouseEnter(sender As Object, e As EventArgs) Handles Close_Btn2.MouseEnter
        Close_Btn2.ForeColor = Color.Silver
    End Sub

    Private Sub Close_Btn2_MouseDown(sender As Object, e As MouseEventArgs) Handles Close_Btn2.MouseDown
        Close_Btn2.ForeColor = Color.DarkRed
    End Sub

    Private Sub Close_Btn2_MouseLeave(sender As Object, e As EventArgs) Handles Close_Btn2.MouseLeave
        Close_Btn2.ForeColor = Color.White
    End Sub

    Private Sub AfficherLimageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AfficherLimageToolStripMenuItem.Click
        Dim ntab As New TabWebBrowser
        ntab.LoadUrl(Lst_MediaUrl)
        CType(Me.ParentForm, Form1).TabControl1.TabPages.Add(ntab)
    End Sub

    Private Sub EnregistrerLimageSousToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnregistrerLimageSousToolStripMenuItem.Click
        If My.Settings.AskForSavingDownloads = True Then
            Dim dlg As New SaveFileDialog
            dlg.Title = "Enregistrer l'image sous..."
            dlg.Filter = "Image (*" + IO.Path.GetExtension(GetFileNameFromURL(Lst_MediaUrl)) + ")|*" + IO.Path.GetExtension(GetFileNameFromURL(Lst_MediaUrl))
            dlg.FileName = GetFileNameFromURL(Lst_MediaUrl)
            If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
                'Téléchargement à l'emplacement souhaité
                Dim ndown As New DownloadTicket
                ndown.Dock = DockStyle.Top
                ndown.AddNewDownload(Lst_MediaUrl, dlg.FileName.Substring(dlg.FileName.LastIndexOf("\") + 1), dlg.FileName)
                DownloadsForm.DownloadList.Controls.Add(ndown)
                DownloadsForm.Show()
            End If
        Else
            'Téléchargement direct
            Dim ndown As New DownloadTicket
            ndown.Dock = DockStyle.Top
            ndown.AddNewDownload(Lst_MediaUrl, GetFileNameFromURL(Lst_MediaUrl), My.Settings.DownloadsPlace & "\" & GetFileNameFromURL(Lst_MediaUrl))
            DownloadsForm.DownloadList.Controls.Add(ndown)
            DownloadsForm.Show()
        End If
    End Sub

    Private Sub CopierLurlDeLimageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopierLurlDeLimageToolStripMenuItem.Click
        Clipboard.SetText(Lst_MediaUrl)
    End Sub

    Private Sub CopierLimageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopierLimageToolStripMenuItem.Click
        MyWebBrowser.CopyImageAt(Lst_PosX, Lst_PosY)
    End Sub

    Private Sub CopierLeTexteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopierLeTexteToolStripMenuItem.Click
        Clipboard.SetText(Lst_SelectedText)
    End Sub

    Private Sub RechercherCeTexteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RechercherCeTexteToolStripMenuItem.Click
        MyWebBrowser.Source = New Uri("http://www.google.fr/?q=" & Lst_SelectedText)
    End Sub

    Private Sub TraduireCeTexteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TraduireCeTexteToolStripMenuItem.Click
        MyWebBrowser.Source = New Uri("https://translate.google.fr/#auto/fr/" & Lst_SelectedText)
    End Sub

    Private Sub RechercherSurLaPageToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RechercherSurLaPageToolStripMenuItem1.Click
        Dim vis As Boolean = Panel1.Visible
        If vis = False Then
            Panel1.Visible = True
            Panel1.BringToFront()
            WBItem += 1
        End If
    End Sub

    Private Sub VButton4_Click(sender As Object, e As EventArgs) Handles VButton4.Click
        If ZoomInt < 500 Then
            MyWebBrowser.Zoom += 20
            ZoomInt += 20
            VButton5.Text = "Zoom: " & ZoomInt & "%"
        End If
    End Sub

    Private Sub VButton3_Click(sender As Object, e As EventArgs) Handles VButton3.Click
        If ZoomInt > 40 Then
            MyWebBrowser.Zoom -= 20
            ZoomInt -= 20
            VButton5.Text = "Zoom: " & ZoomInt & "%"
        End If
    End Sub

    Private Sub VButton5_Click(sender As Object, e As EventArgs) Handles VButton5.Click
        MyWebBrowser.Zoom = 100
        ZoomInt = 100
        VButton5.Text = "Zoom: " & ZoomInt & "%"
    End Sub

    Private Sub GérerLeZoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GérerLeZoomToolStripMenuItem.Click
        Dim vis As Boolean = Panel1.Visible
        If vis = False Then
            Panel2.Visible = True
            Panel2.BringToFront()
            WBItem += 1
        End If
    End Sub

    Private Sub Search_TextBox_LostFocus(sender As Object, e As EventArgs) Handles Search_TextBox.LostFocus
        If Search_TextBox.Text = Nothing Then
            Search_TextBox.Font = New Font("Segoe UI", 9, FontStyle.Italic)
            Search_TextBox.ForeColor = Color.Gray
            Search_TextBox.Text = "Rechercher..."
        End If
    End Sub

    Private Sub Search_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Search_TextBox.TextChanged
        If Search_TextBox.Text = Nothing Then
            Search_TextBox.Font = New Font("Segoe UI", 9, FontStyle.Italic)
            Search_TextBox.ForeColor = Color.Gray
        ElseIf Not Search_TextBox.Text = "Rechercher..." Then
            Search_TextBox.Font = New Font("Segoe UI", 9, FontStyle.Regular)
            Search_TextBox.ForeColor = Color.Black
            MyWebBrowser.ExecuteJavascript("window.find(""" + Search_TextBox.Text + """, " + CheckBox1.Checked.ToString().ToLower() + ", false);")
        End If
    End Sub

    Private Sub Search_TextBox_MouseClick(sender As Object, e As MouseEventArgs) Handles Search_TextBox.MouseClick
        If Search_TextBox.Text = "Rechercher..." Then
            Search_TextBox.Clear()
        End If
    End Sub

    Private Sub VButton2_Click(sender As Object, e As EventArgs) Handles VButton2.Click
        If Not Search_TextBox.Text = "Rechercher..." Then
            If Not Search_TextBox.Text = Nothing Then
                MyWebBrowser.ExecuteJavascript("window.find(""" + Search_TextBox.Text + """, " + CheckBox1.Checked.ToString().ToLower() + ", false);")
            End If
        End If
    End Sub

    Private Sub VButton1_Click(sender As Object, e As EventArgs) Handles VButton1.Click
        If Not Search_TextBox.Text = "Rechercher..." Then
            If Not Search_TextBox.Text = Nothing Then
                MyWebBrowser.ExecuteJavascript("window.find(""" + Search_TextBox.Text + """, " + CheckBox1.Checked.ToString().ToLower() + ", true);")
            End If
        End If
    End Sub

    Private Sub Search_TextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles Search_TextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Search_TextBox.Text = Nothing Then
                If Not Search_TextBox.Text = "Rechercher..." Then
                    MyWebBrowser.ExecuteJavascript("window.find(""" + Search_TextBox.Text + """, " + CheckBox1.Checked.ToString().ToLower() + ", false);")
                End If
            End If
        End If
    End Sub
End Class