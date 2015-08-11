<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UrlLister
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UrlLister))
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Suggestions Google", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Adresses web", System.Windows.Forms.HorizontalAlignment.Left)
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha()
        Me.AlphaGradientPanel1 = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha3 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha4 = New BlueActivity.Controls.ColorWithAlpha()
        Me.VButton5 = New VIBlend.WinForms.Controls.vButton()
        Me.VButton4 = New VIBlend.WinForms.Controls.vButton()
        Me.VButton3 = New VIBlend.WinForms.Controls.vButton()
        Me.VButton2 = New VIBlend.WinForms.Controls.vButton()
        Me.VButton1 = New VIBlend.WinForms.Controls.vButton()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.AlphaGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.White
        Me.ColorWithAlpha1.Parent = Nothing
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.SystemColors.Control
        Me.ColorWithAlpha2.Parent = Nothing
        '
        'AlphaGradientPanel1
        '
        Me.AlphaGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.AlphaGradientPanel1.Border = True
        Me.AlphaGradientPanel1.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.AlphaGradientPanel1.Colors.Add(Me.ColorWithAlpha3)
        Me.AlphaGradientPanel1.Colors.Add(Me.ColorWithAlpha4)
        Me.AlphaGradientPanel1.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.AlphaGradientPanel1.Controls.Add(Me.VButton5)
        Me.AlphaGradientPanel1.Controls.Add(Me.VButton4)
        Me.AlphaGradientPanel1.Controls.Add(Me.VButton3)
        Me.AlphaGradientPanel1.Controls.Add(Me.VButton2)
        Me.AlphaGradientPanel1.Controls.Add(Me.VButton1)
        Me.AlphaGradientPanel1.CornerRadius = 1
        Me.AlphaGradientPanel1.Corners = CType((((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight) _
            Or BlueActivity.Controls.Corner.BottomLeft) _
            Or BlueActivity.Controls.Corner.BottomRight), BlueActivity.Controls.Corner)
        Me.AlphaGradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.AlphaGradientPanel1.Gradient = True
        Me.AlphaGradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.AlphaGradientPanel1.GradientOffset = 1.0!
        Me.AlphaGradientPanel1.GradientSize = New System.Drawing.Size(0, 0)
        Me.AlphaGradientPanel1.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.AlphaGradientPanel1.Grayscale = False
        Me.AlphaGradientPanel1.Image = Nothing
        Me.AlphaGradientPanel1.ImageAlpha = 75
        Me.AlphaGradientPanel1.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.AlphaGradientPanel1.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.AlphaGradientPanel1.ImageSize = New System.Drawing.Size(48, 48)
        Me.AlphaGradientPanel1.Location = New System.Drawing.Point(0, 257)
        Me.AlphaGradientPanel1.Name = "AlphaGradientPanel1"
        Me.AlphaGradientPanel1.Rounded = True
        Me.AlphaGradientPanel1.Size = New System.Drawing.Size(494, 36)
        Me.AlphaGradientPanel1.TabIndex = 0
        '
        'ColorWithAlpha3
        '
        Me.ColorWithAlpha3.Alpha = 255
        Me.ColorWithAlpha3.Color = System.Drawing.SystemColors.GradientActiveCaption
        Me.ColorWithAlpha3.Parent = Me.AlphaGradientPanel1
        '
        'ColorWithAlpha4
        '
        Me.ColorWithAlpha4.Alpha = 255
        Me.ColorWithAlpha4.Color = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ColorWithAlpha4.Parent = Me.AlphaGradientPanel1
        '
        'VButton5
        '
        Me.VButton5.AllowAnimations = True
        Me.VButton5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VButton5.BackColor = System.Drawing.Color.Transparent
        Me.VButton5.Image = CType(resources.GetObject("VButton5.Image"), System.Drawing.Image)
        Me.VButton5.Location = New System.Drawing.Point(463, 5)
        Me.VButton5.Name = "VButton5"
        Me.VButton5.RoundedCornersMask = CType(15, Byte)
        Me.VButton5.Size = New System.Drawing.Size(26, 26)
        Me.VButton5.TabIndex = 4
        Me.VButton5.UseVisualStyleBackColor = False
        Me.VButton5.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.BLUEBLEND
        '
        'VButton4
        '
        Me.VButton4.AllowAnimations = True
        Me.VButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VButton4.BackColor = System.Drawing.Color.Transparent
        Me.VButton4.Image = CType(resources.GetObject("VButton4.Image"), System.Drawing.Image)
        Me.VButton4.Location = New System.Drawing.Point(438, 5)
        Me.VButton4.Name = "VButton4"
        Me.VButton4.RoundedCornersMask = CType(15, Byte)
        Me.VButton4.Size = New System.Drawing.Size(26, 26)
        Me.VButton4.TabIndex = 3
        Me.VButton4.UseVisualStyleBackColor = False
        Me.VButton4.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.BLUEBLEND
        '
        'VButton3
        '
        Me.VButton3.AllowAnimations = True
        Me.VButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VButton3.BackColor = System.Drawing.Color.Transparent
        Me.VButton3.Image = CType(resources.GetObject("VButton3.Image"), System.Drawing.Image)
        Me.VButton3.Location = New System.Drawing.Point(413, 5)
        Me.VButton3.Name = "VButton3"
        Me.VButton3.RoundedCornersMask = CType(15, Byte)
        Me.VButton3.Size = New System.Drawing.Size(26, 26)
        Me.VButton3.TabIndex = 2
        Me.VButton3.UseVisualStyleBackColor = False
        Me.VButton3.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.BLUEBLEND
        '
        'VButton2
        '
        Me.VButton2.AllowAnimations = True
        Me.VButton2.BackColor = System.Drawing.Color.Transparent
        Me.VButton2.Location = New System.Drawing.Point(156, 5)
        Me.VButton2.Name = "VButton2"
        Me.VButton2.RoundedCornersMask = CType(15, Byte)
        Me.VButton2.Size = New System.Drawing.Size(213, 26)
        Me.VButton2.TabIndex = 1
        Me.VButton2.Text = "Désactiver les suggestions google"
        Me.VButton2.UseVisualStyleBackColor = False
        Me.VButton2.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.BLUEBLEND
        Me.VButton2.Visible = False
        '
        'VButton1
        '
        Me.VButton1.AllowAnimations = True
        Me.VButton1.BackColor = System.Drawing.Color.Transparent
        Me.VButton1.Location = New System.Drawing.Point(7, 5)
        Me.VButton1.Name = "VButton1"
        Me.VButton1.RoundedCornersMask = CType(15, Byte)
        Me.VButton1.Size = New System.Drawing.Size(150, 26)
        Me.VButton1.TabIndex = 0
        Me.VButton1.Text = "Gérer les suggestions..."
        Me.VButton1.UseVisualStyleBackColor = False
        Me.VButton1.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.BLUEBLEND
        Me.VButton1.Visible = False
        '
        'ListView1
        '
        Me.ListView1.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ListView1.BackColor = System.Drawing.SystemColors.Control
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.FullRowSelect = True
        ListViewGroup1.Header = "Suggestions Google"
        ListViewGroup1.Name = "ListViewGroup1"
        ListViewGroup2.Header = "Adresses web"
        ListViewGroup2.Name = "ListViewGroup2"
        Me.ListView1.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2})
        Me.ListView1.LargeImageList = Me.ImageList1
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(494, 257)
        Me.ListView1.SmallImageList = Me.ImageList1
        Me.ListView1.StateImageList = Me.ImageList1
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Tile
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "win_search_x16.png")
        Me.ImageList1.Images.SetKeyName(1, "win_web_x16.png")
        '
        'UrlLister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.AlphaGradientPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Name = "UrlLister"
        Me.Size = New System.Drawing.Size(494, 293)
        Me.AlphaGradientPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents AlphaGradientPanel1 As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha3 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha4 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents VButton2 As VIBlend.WinForms.Controls.vButton
    Friend WithEvents VButton1 As VIBlend.WinForms.Controls.vButton
    Friend WithEvents VButton3 As VIBlend.WinForms.Controls.vButton
    Friend WithEvents VButton5 As VIBlend.WinForms.Controls.vButton
    Friend WithEvents VButton4 As VIBlend.WinForms.Controls.vButton

End Class
