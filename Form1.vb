Imports VIBlend.Utilities

Public Class Form1

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
        VButton1.RoundedCornersMask = CByte(VIBlend.Utilities.RoundedCornersMask.TOP_LEFT Or RoundedCornersMask.BOTTOM_LEFT)
        VButton1.Theme = theme

        VButton2.StyleKey = "XinDarkBlue"
        VButton2.RoundedCornersMask = CByte(VIBlend.Utilities.RoundedCornersMask.TOP_RIGHT Or RoundedCornersMask.BOTTOM_RIGHT)
        VButton2.Theme = theme

        VButton3.StyleKey = "XinDarkBlue"
        VButton3.RoundedCornersMask = CByte(VIBlend.Utilities.RoundedCornersMask.TOP_LEFT Or RoundedCornersMask.BOTTOM_LEFT)
        VButton3.Theme = theme

        VButton4.StyleKey = "XinDarkBlue"
        VButton4.RoundedCornersMask = Nothing
        VButton4.Theme = theme

        VButton5.StyleKey = "XinDarkBlue"
        VButton5.RoundedCornersMask = Nothing
        VButton5.Theme = theme

        VButton6.StyleKey = "XinDarkBlue"
        VButton6.RoundedCornersMask = CByte(VIBlend.Utilities.RoundedCornersMask.TOP_RIGHT Or RoundedCornersMask.BOTTOM_RIGHT)
        VButton6.Theme = theme

        VButton7.StyleKey = "XinDarkBlue"
        VButton7.RoundedCornersMask = CByte(VIBlend.Utilities.RoundedCornersMask.TOP_LEFT Or RoundedCornersMask.BOTTOM_LEFT)
        VButton7.Theme = theme

        VButton8.StyleKey = "XinDarkBlue"
        VButton8.RoundedCornersMask = CByte(VIBlend.Utilities.RoundedCornersMask.TOP_RIGHT Or RoundedCornersMask.BOTTOM_RIGHT)
        VButton8.Theme = theme

        VButton9.StyleKey = "XinDarkBlue"
        VButton9.RoundedCornersMask = CByte(VIBlend.Utilities.RoundedCornersMask.TOP_LEFT Or RoundedCornersMask.BOTTOM_LEFT)
        VButton9.Theme = theme

        VButton10.StyleKey = "XinDarkBlue"
        VButton10.RoundedCornersMask = CByte(VIBlend.Utilities.RoundedCornersMask.TOP_RIGHT Or RoundedCornersMask.BOTTOM_RIGHT)
        VButton10.Theme = theme

        VButton11.StyleKey = "XinDarkBlue"
        VButton11.RoundedCornersMask = CByte(VIBlend.Utilities.RoundedCornersMask.BOTTOM_LEFT)
        VButton11.Theme = theme

        VButton12.StyleKey = "XinDarkBlue"
        VButton12.RoundedCornersMask = Nothing
        VButton12.Theme = theme

        VButton13.StyleKey = "XinDarkBlue"
        VButton13.RoundedCornersMask = CByte(RoundedCornersMask.BOTTOM_RIGHT)
        VButton13.Theme = theme

        VButton14.StyleKey = "XinDarkBlue"
        VButton14.RoundedCornersMask = CByte(RoundedCornersMask.TOP_LEFT Or RoundedCornersMask.TOP_RIGHT)
        VButton14.Theme = theme

        VButton15.StyleKey = "XinDarkBlue"
        VButton15.RoundedCornersMask = CByte(RoundedCornersMask.BOTTOM_LEFT Or RoundedCornersMask.BOTTOM_RIGHT)
        VButton15.Theme = theme
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
        VButton1.RoundedCornersMask = CByte(VIBlend.Utilities.RoundedCornersMask.TOP_LEFT Or RoundedCornersMask.BOTTOM_LEFT)
        VButton1.Theme = theme

        VButton2.StyleKey = "XinDarkOrange"
        VButton2.RoundedCornersMask = CByte(VIBlend.Utilities.RoundedCornersMask.TOP_RIGHT Or RoundedCornersMask.BOTTOM_RIGHT)
        VButton2.Theme = theme

        VButton3.StyleKey = "XinDarkOrange"
        VButton3.RoundedCornersMask = CByte(VIBlend.Utilities.RoundedCornersMask.TOP_LEFT Or RoundedCornersMask.BOTTOM_LEFT)
        VButton3.Theme = theme

        VButton4.StyleKey = "XinDarkOrange"
        VButton4.RoundedCornersMask = Nothing
        VButton4.Theme = theme

        VButton5.StyleKey = "XinDarkOrange"
        VButton5.RoundedCornersMask = Nothing
        VButton5.Theme = theme

        VButton6.StyleKey = "XinDarkOrange"
        VButton6.RoundedCornersMask = CByte(VIBlend.Utilities.RoundedCornersMask.TOP_RIGHT Or RoundedCornersMask.BOTTOM_RIGHT)
        VButton6.Theme = theme

        VButton7.StyleKey = "XinDarkOrange"
        VButton7.RoundedCornersMask = CByte(VIBlend.Utilities.RoundedCornersMask.TOP_LEFT Or RoundedCornersMask.BOTTOM_LEFT)
        VButton7.Theme = theme

        VButton8.StyleKey = "XinDarkOrange"
        VButton8.RoundedCornersMask = CByte(VIBlend.Utilities.RoundedCornersMask.TOP_RIGHT Or RoundedCornersMask.BOTTOM_RIGHT)
        VButton8.Theme = theme

        VButton9.StyleKey = "XinDarkOrange"
        VButton9.RoundedCornersMask = CByte(VIBlend.Utilities.RoundedCornersMask.TOP_LEFT Or RoundedCornersMask.BOTTOM_LEFT)
        VButton9.Theme = theme

        VButton10.StyleKey = "XinDarkOrange"
        VButton10.RoundedCornersMask = CByte(VIBlend.Utilities.RoundedCornersMask.TOP_RIGHT Or RoundedCornersMask.BOTTOM_RIGHT)
        VButton10.Theme = theme

        VButton11.StyleKey = "XinDarkOrange"
        VButton11.RoundedCornersMask = CByte(VIBlend.Utilities.RoundedCornersMask.BOTTOM_LEFT)
        VButton11.Theme = theme

        VButton12.StyleKey = "XinDarkOrange"
        VButton12.RoundedCornersMask = Nothing
        VButton12.Theme = theme

        VButton13.StyleKey = "XinDarkOrange"
        VButton13.RoundedCornersMask = CByte(RoundedCornersMask.BOTTOM_RIGHT)
        VButton13.Theme = theme

        VButton14.StyleKey = "XinDarkOrange"
        VButton14.RoundedCornersMask = CByte(RoundedCornersMask.TOP_LEFT Or RoundedCornersMask.TOP_RIGHT)
        VButton14.Theme = theme

        VButton15.StyleKey = "XinDarkOrange"
        VButton15.RoundedCornersMask = CByte(RoundedCornersMask.BOTTOM_LEFT Or RoundedCornersMask.BOTTOM_RIGHT)
        VButton15.Theme = theme
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
        VButton1.RoundedCornersMask = CByte(VIBlend.Utilities.RoundedCornersMask.TOP_LEFT Or RoundedCornersMask.BOTTOM_LEFT)
        VButton1.Theme = theme

        VButton2.StyleKey = "XinDarkGreen"
        VButton2.RoundedCornersMask = CByte(VIBlend.Utilities.RoundedCornersMask.TOP_RIGHT Or RoundedCornersMask.BOTTOM_RIGHT)
        VButton2.Theme = theme

        VButton3.StyleKey = "XinDarkGreen"
        VButton3.RoundedCornersMask = CByte(VIBlend.Utilities.RoundedCornersMask.TOP_LEFT Or RoundedCornersMask.BOTTOM_LEFT)
        VButton3.Theme = theme

        VButton4.StyleKey = "XinDarkGreen"
        VButton4.RoundedCornersMask = Nothing
        VButton4.Theme = theme

        VButton5.StyleKey = "XinDarkGreen"
        VButton5.RoundedCornersMask = Nothing
        VButton5.Theme = theme

        VButton6.StyleKey = "XinDarkGreen"
        VButton6.RoundedCornersMask = CByte(VIBlend.Utilities.RoundedCornersMask.TOP_RIGHT Or RoundedCornersMask.BOTTOM_RIGHT)
        VButton6.Theme = theme

        VButton7.StyleKey = "XinDarkGreen"
        VButton7.RoundedCornersMask = CByte(VIBlend.Utilities.RoundedCornersMask.TOP_LEFT Or RoundedCornersMask.BOTTOM_LEFT)
        VButton7.Theme = theme

        VButton8.StyleKey = "XinDarkGreen"
        VButton8.RoundedCornersMask = CByte(VIBlend.Utilities.RoundedCornersMask.TOP_RIGHT Or RoundedCornersMask.BOTTOM_RIGHT)
        VButton8.Theme = theme

        VButton9.StyleKey = "XinDarkGreen"
        VButton9.RoundedCornersMask = CByte(VIBlend.Utilities.RoundedCornersMask.TOP_LEFT Or RoundedCornersMask.BOTTOM_LEFT)
        VButton9.Theme = theme

        VButton10.StyleKey = "XinDarkGreen"
        VButton10.RoundedCornersMask = CByte(VIBlend.Utilities.RoundedCornersMask.TOP_RIGHT Or RoundedCornersMask.BOTTOM_RIGHT)
        VButton10.Theme = theme

        VButton11.StyleKey = "XinDarkGreen"
        VButton11.RoundedCornersMask = CByte(VIBlend.Utilities.RoundedCornersMask.BOTTOM_LEFT)
        VButton11.Theme = theme

        VButton12.StyleKey = "XinDarkGreen"
        VButton12.RoundedCornersMask = Nothing
        VButton12.Theme = theme

        VButton13.StyleKey = "XinDarkGreen"
        VButton13.RoundedCornersMask = CByte(RoundedCornersMask.BOTTOM_RIGHT)
        VButton13.Theme = theme

        VButton14.StyleKey = "XinDarkGreen"
        VButton14.RoundedCornersMask = CByte(RoundedCornersMask.TOP_LEFT Or RoundedCornersMask.TOP_RIGHT)
        VButton14.Theme = theme

        VButton15.StyleKey = "XinDarkGreen"
        VButton15.RoundedCornersMask = CByte(RoundedCornersMask.BOTTOM_LEFT Or RoundedCornersMask.BOTTOM_RIGHT)
        VButton15.Theme = theme
    End Sub

#End Region

    Dim isMaximized As Boolean = False
    Dim LastXWindowPos As Integer
    Dim LastYWindowPos As Integer
    Dim LastWindowWidth As Integer
    Dim LastWindowHeight As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Démarrage de la fenêtre des téléchargements en arrière-plan
        DownloadsForm.Hide()

        If My.Settings.CheckForUpdates = True Then
            Try
                'Vérification des mises à jour
                Dim wb As New Net.WebClient
                Dim newvers As String = wb.DownloadString("https://dl.dropboxusercontent.com/u/56127675/XinLoxx/Xin%20Browser%20Bêta/version.txt")
                If My.Settings.EnableBetaUpdates = True Then
                    If newvers.LastIndexOf(".") > My.Application.Info.Version.Revision Then
                        'Mise à jour bêta disponible
                        Process.Start(Application.StartupPath & "\updater.exe")
                        End
                    Else
                        'Vérification des mises à jour normales
                        If newvers > My.Application.Info.Version.ToString Then
                            'Mise à jour disponible
                            Process.Start(Application.StartupPath & "\updater.exe")
                            End
                        End If
                    End If
                Else
                    'Vérification des mises à jour normales
                    If newvers > My.Application.Info.Version.ToString Then
                        'Mise à jour disponible
                        Process.Start(Application.StartupPath & "\updater.exe")
                        End
                    End If
                End If
            Catch ex As Exception

            End Try
        End If

        'Mise en place du thème choisi par l'utilisateur
        If My.Settings.CurrentTheme = "xinbrowser" Then
            SetOrangeTheme()
        ElseIf My.Settings.CurrentTheme = "modern" Then
            SetBlueTheme()
        ElseIf My.Settings.CurrentTheme = "classic" Then
            SetGreenTheme()
        End If

        'Mise en place du dossier des téléchargements lors du 1er démarrage
        If My.Settings.DownloadsPlace = Nothing Then
            Dim path As String = IO.Path.GetDirectoryName(Environment.GetFolderPath(Environment.SpecialFolder.Personal))
            path = IO.Path.Combine(path, "Downloads")
            My.Settings.DownloadsPlace = path
            My.Settings.Save()
        End If

        'Application - Fond avec couleurs
        If My.Settings.appbackgroundstyle = "optn:fillgradient" Then
            'Gradient en 2 couleurs

            ColorWithAlpha1.Color = My.Settings.appbackgroundcolor1
            ColorWithAlpha2.Color = My.Settings.appbackgroundcolor2
        ElseIf My.Settings.appbackgroundstyle = "optn:glassgradient" Then
            'Gradient style aero en 2 couleurs
            ColorWithAlpha1.Color = My.Settings.appbackgroundcolor1
            ColorWithAlpha2.Color = My.Settings.appbackgroundcolor2
        ElseIf My.Settings.appbackgroundstyle = "optn:gradient1color" Then
            'Gradient 1 couleur
            ColorWithAlpha1.Color = My.Settings.appbackgroundcolor1
            ColorWithAlpha2.Color = My.Settings.appbackgroundcolor1
        ElseIf My.Settings.appbackgroundstyle = "optn:glass1color" Then
            'Gradient style aero 1 couleur
            ColorWithAlpha1.Color = My.Settings.appbackgroundcolor1
            ColorWithAlpha2.Color = My.Settings.appbackgroundcolor1
        End If

        'Ajout d'un nouvel onglet, personnalisé dans les options par l'utilisateur
        Dim ntab As New TabWebBrowser
        TabControl1.TabPages.Add(ntab)
    End Sub

    Private Sub Form1_TextChanged(sender As Object, e As EventArgs) Handles Me.TextChanged
        Label1.Text = Me.Text
    End Sub

#Region "Form Moving and Resizing"

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub AlphaGradientPanel1_MouseDown(sender As Object, e As MouseEventArgs) Handles AlphaGradientPanel1.MouseDown
        If isMaximized = False Then
            drag = True
            mousex = Windows.Forms.Cursor.Position.X - Me.Left
            mousey = Windows.Forms.Cursor.Position.Y - Me.Top
        End If
    End Sub

    Private Sub AlphaGradientPanel1_MouseMove(sender As Object, e As MouseEventArgs) Handles AlphaGradientPanel1.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub AlphaGradientPanel1_MouseUp(sender As Object, e As MouseEventArgs) Handles AlphaGradientPanel1.MouseUp
        drag = False
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles ResizePnl.MouseDown
        Timer1.Enabled = True
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles ResizePnl.MouseUp
        Timer1.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.Size.Width < Me.MinimumSize.Width And Me.Size.Height < Me.MinimumSize.Height Then
        Else
            Me.Size = MousePosition - Me.Location
        End If
    End Sub

    Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles Label1.MouseDown
        If isMaximized = False Then
            drag = True
            mousex = Windows.Forms.Cursor.Position.X - Me.Left
            mousey = Windows.Forms.Cursor.Position.Y - Me.Top
        End If
    End Sub

    Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs) Handles Label1.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Label1_MouseUp(sender As Object, e As MouseEventArgs) Handles Label1.MouseUp
        drag = False
    End Sub

#End Region


    Private Sub TabControl1_SelectedTabChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedTabChanged
        Me.Text = TabControl1.SelectedForm.Text & " - Xin Browser"
        VButton3.Image = TabControl1.SelectedForm.Icon.ToBitmap
        VButton3.StretchImage = True
        TextBox1.Text = CType(TabControl1.SelectedForm.Controls.Item(CType(TabControl1.SelectedForm, TabWebBrowser).WBItem), Awesomium.Windows.Forms.WebControl).Source.ToString()
        'Urls personnalisées

        Dim f1 As String = Strings.Replace(Application.StartupPath, "\", "/")
        Dim ff As String = Strings.Replace(f1, " ", "%20")
        If CType(TabControl1.SelectedForm.Controls.Item(CType(TabControl1.SelectedForm, TabWebBrowser).WBItem), Awesomium.Windows.Forms.WebControl).Source.ToString.StartsWith("file:///" & ff & "/html/a_propos.html") Then
            TextBox1.Text = "xinbrowser://about"
        End If
        If CType(TabControl1.SelectedForm.Controls.Item(CType(TabControl1.SelectedForm, TabWebBrowser).WBItem), Awesomium.Windows.Forms.WebControl).Source.ToString.StartsWith("file:///" & ff & "/html/CGU.html") Then
            TextBox1.Text = "xinbrowser://cgu"
        End If
        If CType(TabControl1.SelectedForm.Controls.Item(CType(TabControl1.SelectedForm, TabWebBrowser).WBItem), Awesomium.Windows.Forms.WebControl).Source.ToString.StartsWith("file:///" & ff & "/html/contact.html") Then
            TextBox1.Text = "xinbrowser://contact"
        End If
        If CType(TabControl1.SelectedForm.Controls.Item(CType(TabControl1.SelectedForm, TabWebBrowser).WBItem), Awesomium.Windows.Forms.WebControl).Source.ToString.StartsWith("file:///" & ff & "/html/contributeurs.html") Then
            TextBox1.Text = "xinbrowser://contribute"
        End If
        If CType(TabControl1.SelectedForm.Controls.Item(CType(TabControl1.SelectedForm, TabWebBrowser).WBItem), Awesomium.Windows.Forms.WebControl).Source.ToString.StartsWith("file:///" & ff & "/html/mise_a_jour.html") Then
            TextBox1.Text = "xinbrowser://update"
        End If
        If CType(TabControl1.SelectedForm.Controls.Item(CType(TabControl1.SelectedForm, TabWebBrowser).WBItem), Awesomium.Windows.Forms.WebControl).Source.ToString.StartsWith("file:///" & ff & "/html/outils.html") Then
            TextBox1.Text = "xinbrowser://tools"
        End If
        If CType(TabControl1.SelectedForm.Controls.Item(CType(TabControl1.SelectedForm, TabWebBrowser).WBItem), Awesomium.Windows.Forms.WebControl).Source.ToString.StartsWith("file:///" & ff & "/html/newtab.html") Then
            TextBox1.Text = "xinbrowser://newtab"
        End If
        If CType(TabControl1.SelectedForm.Controls.Item(CType(TabControl1.SelectedForm, TabWebBrowser).WBItem), Awesomium.Windows.Forms.WebControl).Source.ToString.StartsWith("file:///" & ff & "/html/parametres.html") Then
            TextBox1.Text = "xinbrowser://settings"
        End If
        If CType(TabControl1.SelectedForm.Controls.Item(CType(TabControl1.SelectedForm, TabWebBrowser).WBItem), Awesomium.Windows.Forms.WebControl).Source.ToString.StartsWith("file:///" & ff & "/html/partenariats.html") Then
            TextBox1.Text = "xinbrowser://partners"
        End If
        If TabControl1.TabPages.Count > 1 Then
            TabControl1.TabCloseButtonVisible = True
        Else
            TabControl1.TabCloseButtonVisible = False
        End If
    End Sub

    Private Sub VButton14_Click(sender As Object, e As EventArgs) Handles VButton14.Click
        Dim ntab As New TabWebBrowser
        TabControl1.TabPages.Add(ntab)

        Dim f1 As String = Strings.Replace(Application.StartupPath, "\", "/")
        Dim ff As String = Strings.Replace(f1, " ", "%20")
        If My.Settings.NewTabSet = "optn:newtabpage" Then
            CType(TabControl1.SelectedForm.Controls.Item(CType(TabControl1.SelectedForm, TabWebBrowser).WBItem), Awesomium.Windows.Forms.WebControl).Source = New Uri("file:///" & ff & "/html/newtab.html")
        ElseIf My.Settings.NewTabSet = "optn:home" Then
            CType(TabControl1.SelectedForm.Controls.Item(CType(TabControl1.SelectedForm, TabWebBrowser).WBItem), Awesomium.Windows.Forms.WebControl).Source = New Uri(My.Settings.HomeUrl)
        ElseIf My.Settings.NewTabSet = "optn:newtabs" Then
            'Pas encore de code à exécuter pour le moment // EN TRAVAIL
        ElseIf My.Settings.NewTabSet = "optn:blank" Then
            CType(TabControl1.SelectedForm.Controls.Item(CType(TabControl1.SelectedForm, TabWebBrowser).WBItem), Awesomium.Windows.Forms.WebControl).Source = New Uri("about:blank")
        End If
    End Sub

    Private Sub VButton13_Click(sender As Object, e As EventArgs) Handles VButton13.Click
        Try
            For i = 0 To TabControl1.TabPages.Count
                Try
                    TabControl1.TabPages.RemoveAt(0)
                Catch ex2 As Exception

                End Try
            Next
            Me.Close()
        Catch ex As Exception
            Me.Close()
        End Try
    End Sub

    Private Sub VButton12_Click(sender As Object, e As EventArgs) Handles VButton12.Click
        If isMaximized Then
            isMaximized = False
            Me.Location = New Point(LastXWindowPos, LastYWindowPos)
            Me.Size = New Point(LastWindowWidth, LastWindowHeight)
            'On doit pouvoir redimensionner la fenêtre
            ResizePnl.Enabled = True
        Else
            isMaximized = True
            LastXWindowPos = Me.Location.X
            LastYWindowPos = Me.Location.Y
            LastWindowWidth = Me.Size.Width
            LastWindowHeight = Me.Size.Height
            Me.Location = New Point(0, 0)
            Me.Size = New Point(My.Computer.Screen.WorkingArea.Width, My.Computer.Screen.WorkingArea.Height)
            'On ne doit plus pouvoir redimensionner la fenêtre
            ResizePnl.Enabled = False
        End If
    End Sub

    Private Sub VButton11_Click(sender As Object, e As EventArgs) Handles VButton11.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub VButton1_Click(sender As Object, e As EventArgs) Handles VButton1.Click
        CType(TabControl1.SelectedForm.Controls.Item(CType(TabControl1.SelectedForm, TabWebBrowser).WBItem), Awesomium.Windows.Forms.WebControl).GoBack()
    End Sub

    Private Sub VButton2_Click(sender As Object, e As EventArgs) Handles VButton2.Click
        CType(TabControl1.SelectedForm.Controls.Item(CType(TabControl1.SelectedForm, TabWebBrowser).WBItem), Awesomium.Windows.Forms.WebControl).GoForward()
    End Sub

    Private Sub VButton3_Click(sender As Object, e As EventArgs) Handles VButton3.Click
        If WebsiteInfoBulle1.Visible = False Then
            'Vérification du niveau de sécurité
            If CType(TabControl1.SelectedForm.Controls.Item(CType(TabControl1.SelectedForm, TabWebBrowser).WBItem), Awesomium.Windows.Forms.WebControl).Source.ToString().StartsWith("https://") Then
                WebsiteInfoBulle1.SecurityClearImg.Visible = True
                WebsiteInfoBulle1.AdvertSecurityImg.Visible = False
                WebsiteInfoBulle1.AlertSecurityImg.Visible = False
                WebsiteInfoBulle1.UnknownSecurityImg.Visible = False
                WebsiteInfoBulle1.HTTPImg.Visible = False
                WebsiteInfoBulle1.HTTPSImg.Visible = True
                WebsiteInfoBulle1.WebsiteIdentityLbl.ForeColor = Color.Green

                WebsiteInfoBulle1.ColorWithAlpha1.Color = Color.White
                WebsiteInfoBulle1.ColorWithAlpha2.Color = SystemColors.Control
            ElseIf CType(TabControl1.SelectedForm.Controls.Item(CType(TabControl1.SelectedForm, TabWebBrowser).WBItem), Awesomium.Windows.Forms.WebControl).Source.ToString().StartsWith("http://") Then
                WebsiteInfoBulle1.SecurityClearImg.Visible = False
                WebsiteInfoBulle1.AdvertSecurityImg.Visible = False
                WebsiteInfoBulle1.AlertSecurityImg.Visible = False
                WebsiteInfoBulle1.UnknownSecurityImg.Visible = True
                WebsiteInfoBulle1.HTTPImg.Visible = True
                WebsiteInfoBulle1.HTTPSImg.Visible = False
                WebsiteInfoBulle1.WebsiteIdentityLbl.ForeColor = Color.Black

                WebsiteInfoBulle1.ColorWithAlpha1.Color = Color.White
                WebsiteInfoBulle1.ColorWithAlpha2.Color = SystemColors.Control
            ElseIf CType(TabControl1.SelectedForm.Controls.Item(CType(TabControl1.SelectedForm, TabWebBrowser).WBItem), Awesomium.Windows.Forms.WebControl).Source.ToString().StartsWith("ftps://") Then
                WebsiteInfoBulle1.SecurityClearImg.Visible = True
                WebsiteInfoBulle1.AdvertSecurityImg.Visible = False
                WebsiteInfoBulle1.AlertSecurityImg.Visible = False
                WebsiteInfoBulle1.UnknownSecurityImg.Visible = False
                WebsiteInfoBulle1.HTTPImg.Visible = False
                WebsiteInfoBulle1.HTTPSImg.Visible = True
                WebsiteInfoBulle1.WebsiteIdentityLbl.ForeColor = Color.Green

                WebsiteInfoBulle1.ColorWithAlpha1.Color = Color.White
                WebsiteInfoBulle1.ColorWithAlpha2.Color = SystemColors.Control
            ElseIf CType(TabControl1.SelectedForm.Controls.Item(CType(TabControl1.SelectedForm, TabWebBrowser).WBItem), Awesomium.Windows.Forms.WebControl).Source.ToString().StartsWith("ftp://") Then
                WebsiteInfoBulle1.SecurityClearImg.Visible = False
                WebsiteInfoBulle1.AdvertSecurityImg.Visible = True
                WebsiteInfoBulle1.AlertSecurityImg.Visible = False
                WebsiteInfoBulle1.UnknownSecurityImg.Visible = False
                WebsiteInfoBulle1.HTTPImg.Visible = False
                WebsiteInfoBulle1.HTTPSImg.Visible = True
                WebsiteInfoBulle1.WebsiteIdentityLbl.ForeColor = Color.Black

                WebsiteInfoBulle1.ColorWithAlpha1.Color = Color.White
                WebsiteInfoBulle1.ColorWithAlpha2.Color = SystemColors.Control
            ElseIf TextBox1.Text.StartsWith("xinbrowser://") Then
                WebsiteInfoBulle1.SecurityClearImg.Visible = True
                WebsiteInfoBulle1.AdvertSecurityImg.Visible = False
                WebsiteInfoBulle1.AlertSecurityImg.Visible = False
                WebsiteInfoBulle1.UnknownSecurityImg.Visible = False
                WebsiteInfoBulle1.HTTPImg.Visible = False
                WebsiteInfoBulle1.HTTPSImg.Visible = True
                WebsiteInfoBulle1.WebsiteIdentityLbl.ForeColor = Color.DarkOrange

                WebsiteInfoBulle1.ColorWithAlpha1.Color = Color.Green
                WebsiteInfoBulle1.ColorWithAlpha2.Color = Color.DarkGreen
            Else
                WebsiteInfoBulle1.SecurityClearImg.Visible = False
                WebsiteInfoBulle1.AdvertSecurityImg.Visible = False
                WebsiteInfoBulle1.AlertSecurityImg.Visible = True
                WebsiteInfoBulle1.UnknownSecurityImg.Visible = False
                WebsiteInfoBulle1.HTTPImg.Visible = True
                WebsiteInfoBulle1.HTTPSImg.Visible = False
                WebsiteInfoBulle1.WebsiteIdentityLbl.ForeColor = Color.Black

                WebsiteInfoBulle1.ColorWithAlpha1.Color = Color.Red
                WebsiteInfoBulle1.ColorWithAlpha2.Color = Color.DarkRed
            End If
            'Vérification si il y a activation de la navigation privée ou non
            If CType(TabControl1.SelectedForm, TabWebBrowser).IsInPrivateNavigation = True Then
                WebsiteInfoBulle1.PrivateNavImg.Visible = True
            Else
                WebsiteInfoBulle1.PrivateNavImg.Visible = False
            End If
            'Définition des informations à afficher
            WebsiteInfoBulle1.WebsiteIdentityLbl.Text = CType(TabControl1.SelectedForm.Controls.Item(CType(TabControl1.SelectedForm, TabWebBrowser).WBItem), Awesomium.Windows.Forms.WebControl).Source.Host
            'Affiche de l'infobulle
            WebsiteInfoBulle1.Visible = True
        Else
            'On masque l'infobulle
            WebsiteInfoBulle1.Visible = False
        End If
    End Sub

    Private Sub VButton5_Click(sender As Object, e As EventArgs) Handles VButton5.Click
        Try
            If TextBox1.Text = "xinbrowser://about" Then
                Dim f1 As String = Strings.Replace(Application.StartupPath, "\", "/")
                Dim ff As String = Strings.Replace(f1, " ", "%20")
                CType(TabControl1.SelectedForm.Controls.Item(CType(TabControl1.SelectedForm, TabWebBrowser).WBItem), Awesomium.Windows.Forms.WebControl).Source = New Uri("file:///" & ff & "/html/a_propos.html")
            ElseIf TextBox1.Text = "xinbrowser://settings" Then
                Dim f1 As String = Strings.Replace(Application.StartupPath, "\", "/")
                Dim ff As String = Strings.Replace(f1, " ", "%20")
                CType(TabControl1.SelectedForm.Controls.Item(CType(TabControl1.SelectedForm, TabWebBrowser).WBItem), Awesomium.Windows.Forms.WebControl).Source = New Uri("file:///" & ff & "/html/parametres.html")
            ElseIf TextBox1.Text = "xinbrowser://cgu" Then
                Dim f1 As String = Strings.Replace(Application.StartupPath, "\", "/")
                Dim ff As String = Strings.Replace(f1, " ", "%20")
                CType(TabControl1.SelectedForm.Controls.Item(CType(TabControl1.SelectedForm, TabWebBrowser).WBItem), Awesomium.Windows.Forms.WebControl).Source = New Uri("file:///" & ff & "/html/cgu.html")
            ElseIf TextBox1.Text = "xinbrowser://contact" Then
                Dim f1 As String = Strings.Replace(Application.StartupPath, "\", "/")
                Dim ff As String = Strings.Replace(f1, " ", "%20")
                CType(TabControl1.SelectedForm.Controls.Item(CType(TabControl1.SelectedForm, TabWebBrowser).WBItem), Awesomium.Windows.Forms.WebControl).Source = New Uri("file:///" & ff & "/html/contact.html")
            ElseIf TextBox1.Text = "xinbrowser://contribute" Then
                Dim f1 As String = Strings.Replace(Application.StartupPath, "\", "/")
                Dim ff As String = Strings.Replace(f1, " ", "%20")
                CType(TabControl1.SelectedForm.Controls.Item(CType(TabControl1.SelectedForm, TabWebBrowser).WBItem), Awesomium.Windows.Forms.WebControl).Source = New Uri("file:///" & ff & "/html/contributeurs.html")
            ElseIf TextBox1.Text = "xinbrowser://update" Then
                Dim f1 As String = Strings.Replace(Application.StartupPath, "\", "/")
                Dim ff As String = Strings.Replace(f1, " ", "%20")
                CType(TabControl1.SelectedForm.Controls.Item(CType(TabControl1.SelectedForm, TabWebBrowser).WBItem), Awesomium.Windows.Forms.WebControl).Source = New Uri("file:///" & ff & "/html/mise_a_jour.html")
            ElseIf TextBox1.Text = "xinbrowser://tools" Then
                Dim f1 As String = Strings.Replace(Application.StartupPath, "\", "/")
                Dim ff As String = Strings.Replace(f1, " ", "%20")
                CType(TabControl1.SelectedForm.Controls.Item(CType(TabControl1.SelectedForm, TabWebBrowser).WBItem), Awesomium.Windows.Forms.WebControl).Source = New Uri("file:///" & ff & "/html/outils.html")
            ElseIf TextBox1.Text = "xinbrowser://partners" Then
                Dim f1 As String = Strings.Replace(Application.StartupPath, "\", "/")
                Dim ff As String = Strings.Replace(f1, " ", "%20")
                CType(TabControl1.SelectedForm.Controls.Item(CType(TabControl1.SelectedForm, TabWebBrowser).WBItem), Awesomium.Windows.Forms.WebControl).Source = New Uri("file:///" & ff & "/html/partenariats.html")
            ElseIf TextBox1.Text = "xinbrowser://newtab" Then
                Dim f1 As String = Strings.Replace(Application.StartupPath, "\", "/")
                Dim ff As String = Strings.Replace(f1, " ", "%20")
                CType(TabControl1.SelectedForm.Controls.Item(CType(TabControl1.SelectedForm, TabWebBrowser).WBItem), Awesomium.Windows.Forms.WebControl).Source = New Uri("file:///" & ff & "/html/newtab.html")
            End If
            CType(TabControl1.SelectedForm.Controls.Item(CType(TabControl1.SelectedForm, TabWebBrowser).WBItem), Awesomium.Windows.Forms.WebControl).Source = New Uri(TextBox1.Text)
        Catch ex As Exception
            If TextBox1.Text.StartsWith("www.") Or TextBox1.Text.EndsWith(".fr") Or TextBox1.Text.EndsWith(".com") Or TextBox1.Text.EndsWith(".net") Or TextBox1.Text.EndsWith(".org") Or TextBox1.Text.EndsWith(".info") Or TextBox1.Text.EndsWith(".cf") Or TextBox1.Text.EndsWith(".co.uk") Or TextBox1.Text.EndsWith(".eu") Or TextBox1.Text.EndsWith(".cf") Then
                CType(TabControl1.SelectedForm.Controls.Item(CType(TabControl1.SelectedForm, TabWebBrowser).WBItem), Awesomium.Windows.Forms.WebControl).Source = New Uri("http://" & TextBox1.Text)
            Else
                CType(TabControl1.SelectedForm.Controls.Item(CType(TabControl1.SelectedForm, TabWebBrowser).WBItem), Awesomium.Windows.Forms.WebControl).Source = New Uri(My.Settings.SearchEngineUrl & TextBox1.Text)
            End If
        End Try
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                If TextBox1.Text = "xinbrowser://about" Then
                    Dim f1 As String = Strings.Replace(Application.StartupPath, "\", "/")
                    Dim ff As String = Strings.Replace(f1, " ", "%20")
                    CType(TabControl1.SelectedForm.Controls.Item(CType(TabControl1.SelectedForm, TabWebBrowser).WBItem), Awesomium.Windows.Forms.WebControl).Source = New Uri("file:///" & ff & "/html/a_propos.html")
                ElseIf TextBox1.Text = "xinbrowser://settings" Then
                    Dim f1 As String = Strings.Replace(Application.StartupPath, "\", "/")
                    Dim ff As String = Strings.Replace(f1, " ", "%20")
                    CType(TabControl1.SelectedForm.Controls.Item(CType(TabControl1.SelectedForm, TabWebBrowser).WBItem), Awesomium.Windows.Forms.WebControl).Source = New Uri("file:///" & ff & "/html/parametres.html")
                ElseIf TextBox1.Text = "xinbrowser://cgu" Then
                    Dim f1 As String = Strings.Replace(Application.StartupPath, "\", "/")
                    Dim ff As String = Strings.Replace(f1, " ", "%20")
                    CType(TabControl1.SelectedForm.Controls.Item(CType(TabControl1.SelectedForm, TabWebBrowser).WBItem), Awesomium.Windows.Forms.WebControl).Source = New Uri("file:///" & ff & "/html/cgu.html")
                ElseIf TextBox1.Text = "xinbrowser://contact" Then
                    Dim f1 As String = Strings.Replace(Application.StartupPath, "\", "/")
                    Dim ff As String = Strings.Replace(f1, " ", "%20")
                    CType(TabControl1.SelectedForm.Controls.Item(CType(TabControl1.SelectedForm, TabWebBrowser).WBItem), Awesomium.Windows.Forms.WebControl).Source = New Uri("file:///" & ff & "/html/contact.html")
                ElseIf TextBox1.Text = "xinbrowser://contribute" Then
                    Dim f1 As String = Strings.Replace(Application.StartupPath, "\", "/")
                    Dim ff As String = Strings.Replace(f1, " ", "%20")
                    CType(TabControl1.SelectedForm.Controls.Item(CType(TabControl1.SelectedForm, TabWebBrowser).WBItem), Awesomium.Windows.Forms.WebControl).Source = New Uri("file:///" & ff & "/html/contributeurs.html")
                ElseIf TextBox1.Text = "xinbrowser://update" Then
                    Dim f1 As String = Strings.Replace(Application.StartupPath, "\", "/")
                    Dim ff As String = Strings.Replace(f1, " ", "%20")
                    CType(TabControl1.SelectedForm.Controls.Item(CType(TabControl1.SelectedForm, TabWebBrowser).WBItem), Awesomium.Windows.Forms.WebControl).Source = New Uri("file:///" & ff & "/html/mise_a_jour.html")
                ElseIf TextBox1.Text = "xinbrowser://tools" Then
                    Dim f1 As String = Strings.Replace(Application.StartupPath, "\", "/")
                    Dim ff As String = Strings.Replace(f1, " ", "%20")
                    CType(TabControl1.SelectedForm.Controls.Item(CType(TabControl1.SelectedForm, TabWebBrowser).WBItem), Awesomium.Windows.Forms.WebControl).Source = New Uri("file:///" & ff & "/html/outils.html")
                ElseIf TextBox1.Text = "xinbrowser://partners" Then
                    Dim f1 As String = Strings.Replace(Application.StartupPath, "\", "/")
                    Dim ff As String = Strings.Replace(f1, " ", "%20")
                    CType(TabControl1.SelectedForm.Controls.Item(CType(TabControl1.SelectedForm, TabWebBrowser).WBItem), Awesomium.Windows.Forms.WebControl).Source = New Uri("file:///" & ff & "/html/partenariats.html")
                ElseIf TextBox1.Text = "xinbrowser://newtab" Then
                    Dim f1 As String = Strings.Replace(Application.StartupPath, "\", "/")
                    Dim ff As String = Strings.Replace(f1, " ", "%20")
                    CType(TabControl1.SelectedForm.Controls.Item(CType(TabControl1.SelectedForm, TabWebBrowser).WBItem), Awesomium.Windows.Forms.WebControl).Source = New Uri("file:///" & ff & "/html/newtab.html")
                End If
                CType(TabControl1.SelectedForm.Controls.Item(CType(TabControl1.SelectedForm, TabWebBrowser).WBItem), Awesomium.Windows.Forms.WebControl).Source = New Uri(TextBox1.Text)
            Catch ex As Exception
                If TextBox1.Text.StartsWith("www.") Or TextBox1.Text.EndsWith(".fr") Or TextBox1.Text.EndsWith(".com") Or TextBox1.Text.EndsWith(".net") Or TextBox1.Text.EndsWith(".org") Or TextBox1.Text.EndsWith(".info") Or TextBox1.Text.EndsWith(".cf") Or TextBox1.Text.EndsWith(".co.uk") Or TextBox1.Text.EndsWith(".eu") Or TextBox1.Text.EndsWith(".cf") Then
                    CType(TabControl1.SelectedForm.Controls.Item(CType(TabControl1.SelectedForm, TabWebBrowser).WBItem), Awesomium.Windows.Forms.WebControl).Source = New Uri("http://" & TextBox1.Text)
                Else
                    CType(TabControl1.SelectedForm.Controls.Item(CType(TabControl1.SelectedForm, TabWebBrowser).WBItem), Awesomium.Windows.Forms.WebControl).Source = New Uri(My.Settings.SearchEngineUrl & TextBox1.Text)
                End If
            End Try
        End If
    End Sub

    Private Sub VButton6_Click(sender As Object, e As EventArgs) Handles VButton6.Click
        If CType(TabControl1.SelectedForm.Controls.Item(0), Awesomium.Windows.Forms.WebControl).IsNavigating = True Then
            'Navigation en cours donc l'utilisateur veut arrêter le chargement
            CType(TabControl1.SelectedForm.Controls.Item(CType(TabControl1.SelectedForm, TabWebBrowser).WBItem), Awesomium.Windows.Forms.WebControl).Stop()
        Else
            'Chargement terminé, l'utilisateur veut donc rafraîchir/recharger la page
            CType(TabControl1.SelectedForm.Controls.Item(CType(TabControl1.SelectedForm, TabWebBrowser).WBItem), Awesomium.Windows.Forms.WebControl).ExecuteJavascriptWithResult("window.location.reload()")
        End If
    End Sub

    Private Sub VButton4_Click(sender As Object, e As EventArgs) Handles VButton4.Click
        If UrlLister1.Visible = True Then
            UrlLister1.Visible = False
        Else
            UrlLister1.Visible = True
        End If
    End Sub

    Private Sub VButton7_Click(sender As Object, e As EventArgs) Handles VButton7.Click
        If FavHistList1.Visible = True Then
            FavHistList1.Visible = False
        Else
            FavHistList1.Visible = True
            FavHistList1.TabControl1.SelectTab(0)
            FavHistList1.LoadFavourites()
        End If
    End Sub

    Private Sub VButton8_Click(sender As Object, e As EventArgs) Handles VButton8.Click
        If FavHistList1.Visible = True Then
            FavHistList1.Visible = False
        Else
            FavHistList1.Visible = True
            FavHistList1.TabControl1.SelectTab(1)
            FavHistList1.LoadHistory()
        End If
    End Sub

    Private Sub VButton9_Click(sender As Object, e As EventArgs) Handles VButton9.Click
        Dim F2 As TabWebBrowser = CType(TabControl1.SelectedForm, TabWebBrowser)
        F2.MyWebBrowser.Source = New Uri(My.Settings.HomeUrl)
    End Sub

    Private Sub VButton10_Click(sender As Object, e As EventArgs) Handles VButton10.Click
        DownloadsForm.Show()
    End Sub

    Private Sub VButton15_Click(sender As Object, e As EventArgs) Handles VButton15.Click
        Dim f1 As String = Strings.Replace(Application.StartupPath, "\", "/")
        Dim ff As String = Strings.Replace(f1, " ", "%20")
        Dim nform As New TabWebBrowser
        nform.LoadUrl("file:///" & ff & "/html/parametres.html")
        TabControl1.TabPages.Add(nform)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim f1 As String = Strings.Replace(Application.StartupPath, "\", "/")
        Dim ff As String = Strings.Replace(f1, " ", "%20")
        Dim nform As New TabWebBrowser
        nform.LoadUrl("file:///" & ff & "/html/a_propos.html")
        TabControl1.TabPages.Add(nform)
    End Sub

    Private Sub AnnulerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnnulerToolStripMenuItem.Click
        TextBox1.Undo()
    End Sub

    Private Sub CouperToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CouperToolStripMenuItem.Click
        TextBox1.Cut()
    End Sub

    Private Sub CopierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopierToolStripMenuItem.Click
        TextBox1.Copy()
    End Sub

    Private Sub CollerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CollerToolStripMenuItem.Click
        TextBox1.Paste()
    End Sub

    Private Sub CollerLurlEtYAccéderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CollerLurlEtYAccéderToolStripMenuItem.Click
        TextBox1.Paste()
        VButton5.PerformClick()
    End Sub

    Private Sub SélectionnerToutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SélectionnerToutToolStripMenuItem.Click
        TextBox1.SelectAll()
    End Sub

    Private Sub SupprimerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupprimerToolStripMenuItem.Click
        TextBox1.SelectedText = ""
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        AnnulerToolStripMenuItem.Enabled = TextBox1.CanUndo
        If TextBox1.SelectedText = Nothing Then
            CouperToolStripMenuItem.Enabled = False
            CopierToolStripMenuItem.Enabled = False
            SupprimerToolStripMenuItem.Enabled = False
        Else
            CouperToolStripMenuItem.Enabled = True
            CopierToolStripMenuItem.Enabled = True
            SupprimerToolStripMenuItem.Enabled = True
        End If
        If TextBox1.Text = Nothing Then
            SélectionnerToutToolStripMenuItem.Enabled = False
        Else
            SélectionnerToutToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub Label1_DoubleClick(sender As Object, e As EventArgs) Handles Label1.DoubleClick
        Call VButton12_Click(sender, e)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text.StartsWith("https://") Then
            TextBox1.ForeColor = Color.Green
        ElseIf TextBox1.Text.StartsWith("xinbrowser://") Then
            TextBox1.ForeColor = Color.Orange
        Else
            TextBox1.ForeColor = Color.Black
        End If
    End Sub
End Class