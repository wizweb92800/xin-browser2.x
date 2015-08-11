Imports VIBlend.Utilities

Public Class WebsiteInfoBulle

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
    End Sub

#End Region


    Private Sub WebsiteInfoBulle_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Mise en place du thème choisi par l'utilisateur
        If My.Settings.CurrentTheme = "xinbrowser" Then
            SetOrangeTheme()
        ElseIf My.Settings.CurrentTheme = "modern" Then
            SetBlueTheme()
        ElseIf My.Settings.CurrentTheme = "classic" Then
            SetGreenTheme()
        End If
    End Sub

    Private Sub VButton2_Click(sender As Object, e As EventArgs) Handles VButton2.Click
        Me.Visible = False
    End Sub

    Private Sub VButton1_Click(sender As Object, e As EventArgs) Handles VButton1.Click
        CType(Me.ParentForm, Form1).TextBox1.Text = "xinbrowser://settings"
        CType(Me.ParentForm, Form1).VButton5.PerformClick()
    End Sub
End Class
