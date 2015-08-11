<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.AlphaGradientPanel1 = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.VButton15 = New VIBlend.WinForms.Controls.vButton()
        Me.FavHistList1 = New Xin_Browser.FavHistList()
        Me.WebsiteInfoBulle1 = New Xin_Browser.WebsiteInfoBulle()
        Me.UrlLister1 = New Xin_Browser.UrlLister()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AnnulerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CouperToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CollerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CollerLurlEtYAccéderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SélectionnerToutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VButton14 = New VIBlend.WinForms.Controls.vButton()
        Me.VButton1 = New VIBlend.WinForms.Controls.vButton()
        Me.VButton11 = New VIBlend.WinForms.Controls.vButton()
        Me.VButton12 = New VIBlend.WinForms.Controls.vButton()
        Me.VButton13 = New VIBlend.WinForms.Controls.vButton()
        Me.TabControl1 = New MdiTabControl.TabControl()
        Me.VButton10 = New VIBlend.WinForms.Controls.vButton()
        Me.VButton9 = New VIBlend.WinForms.Controls.vButton()
        Me.VButton8 = New VIBlend.WinForms.Controls.vButton()
        Me.VButton7 = New VIBlend.WinForms.Controls.vButton()
        Me.VButton6 = New VIBlend.WinForms.Controls.vButton()
        Me.VButton5 = New VIBlend.WinForms.Controls.vButton()
        Me.VButton4 = New VIBlend.WinForms.Controls.vButton()
        Me.VButton3 = New VIBlend.WinForms.Controls.vButton()
        Me.VButton2 = New VIBlend.WinForms.Controls.vButton()
        Me.ResizePnl = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.AlphaGradientPanel1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AlphaGradientPanel1
        '
        Me.AlphaGradientPanel1.BackColor = System.Drawing.Color.Fuchsia
        Me.AlphaGradientPanel1.Border = True
        Me.AlphaGradientPanel1.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.AlphaGradientPanel1.Colors.Add(Me.ColorWithAlpha1)
        Me.AlphaGradientPanel1.Colors.Add(Me.ColorWithAlpha2)
        Me.AlphaGradientPanel1.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.AlphaGradientPanel1.Controls.Add(Me.Label2)
        Me.AlphaGradientPanel1.Controls.Add(Me.VButton15)
        Me.AlphaGradientPanel1.Controls.Add(Me.FavHistList1)
        Me.AlphaGradientPanel1.Controls.Add(Me.WebsiteInfoBulle1)
        Me.AlphaGradientPanel1.Controls.Add(Me.UrlLister1)
        Me.AlphaGradientPanel1.Controls.Add(Me.VButton14)
        Me.AlphaGradientPanel1.Controls.Add(Me.VButton1)
        Me.AlphaGradientPanel1.Controls.Add(Me.VButton11)
        Me.AlphaGradientPanel1.Controls.Add(Me.VButton12)
        Me.AlphaGradientPanel1.Controls.Add(Me.VButton13)
        Me.AlphaGradientPanel1.Controls.Add(Me.TabControl1)
        Me.AlphaGradientPanel1.Controls.Add(Me.VButton10)
        Me.AlphaGradientPanel1.Controls.Add(Me.VButton9)
        Me.AlphaGradientPanel1.Controls.Add(Me.VButton8)
        Me.AlphaGradientPanel1.Controls.Add(Me.VButton7)
        Me.AlphaGradientPanel1.Controls.Add(Me.VButton6)
        Me.AlphaGradientPanel1.Controls.Add(Me.VButton5)
        Me.AlphaGradientPanel1.Controls.Add(Me.VButton4)
        Me.AlphaGradientPanel1.Controls.Add(Me.VButton3)
        Me.AlphaGradientPanel1.Controls.Add(Me.TextBox1)
        Me.AlphaGradientPanel1.Controls.Add(Me.VButton2)
        Me.AlphaGradientPanel1.Controls.Add(Me.ResizePnl)
        Me.AlphaGradientPanel1.Controls.Add(Me.PictureBox1)
        Me.AlphaGradientPanel1.Controls.Add(Me.Label1)
        Me.AlphaGradientPanel1.CornerRadius = 1
        Me.AlphaGradientPanel1.Corners = CType((((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight) _
            Or BlueActivity.Controls.Corner.BottomLeft) _
            Or BlueActivity.Controls.Corner.BottomRight), BlueActivity.Controls.Corner)
        Me.AlphaGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AlphaGradientPanel1.Gradient = True
        Me.AlphaGradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.AlphaGradientPanel1.GradientOffset = 1.0!
        Me.AlphaGradientPanel1.GradientSize = New System.Drawing.Size(0, 0)
        Me.AlphaGradientPanel1.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.AlphaGradientPanel1.Grayscale = False
        Me.AlphaGradientPanel1.Image = Nothing
        Me.AlphaGradientPanel1.ImageAlpha = 75
        Me.AlphaGradientPanel1.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.AlphaGradientPanel1.ImagePosition = BlueActivity.Controls.ImagePosition.TopLeft
        Me.AlphaGradientPanel1.ImageSize = New System.Drawing.Size(32, 32)
        Me.AlphaGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.AlphaGradientPanel1.Name = "AlphaGradientPanel1"
        Me.AlphaGradientPanel1.Rounded = True
        Me.AlphaGradientPanel1.Size = New System.Drawing.Size(600, 480)
        Me.AlphaGradientPanel1.TabIndex = 0
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.SystemColors.ControlDark
        Me.ColorWithAlpha1.Parent = Me.AlphaGradientPanel1
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.SystemColors.ControlDarkDark
        Me.ColorWithAlpha2.Parent = Me.AlphaGradientPanel1
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label2.Location = New System.Drawing.Point(253, 465)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Xin Browser Bêta"
        Me.Label2.Visible = False
        '
        'VButton15
        '
        Me.VButton15.AllowAnimations = True
        Me.VButton15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VButton15.BackColor = System.Drawing.Color.Transparent
        Me.VButton15.Image = CType(resources.GetObject("VButton15.Image"), System.Drawing.Image)
        Me.VButton15.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.VButton15.Location = New System.Drawing.Point(455, 0)
        Me.VButton15.Name = "VButton15"
        Me.VButton15.RoundedCornersMask = CType(15, Byte)
        Me.VButton15.Size = New System.Drawing.Size(30, 24)
        Me.VButton15.TabIndex = 22
        Me.VButton15.UseVisualStyleBackColor = False
        Me.VButton15.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2010BLUE
        '
        'FavHistList1
        '
        Me.FavHistList1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FavHistList1.BackColor = System.Drawing.SystemColors.Control
        Me.FavHistList1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FavHistList1.Location = New System.Drawing.Point(293, 62)
        Me.FavHistList1.Name = "FavHistList1"
        Me.FavHistList1.Size = New System.Drawing.Size(297, 399)
        Me.FavHistList1.TabIndex = 21
        Me.FavHistList1.Visible = False
        '
        'WebsiteInfoBulle1
        '
        Me.WebsiteInfoBulle1.BackColor = System.Drawing.Color.Fuchsia
        Me.WebsiteInfoBulle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.WebsiteInfoBulle1.Location = New System.Drawing.Point(76, 62)
        Me.WebsiteInfoBulle1.Name = "WebsiteInfoBulle1"
        Me.WebsiteInfoBulle1.Size = New System.Drawing.Size(279, 137)
        Me.WebsiteInfoBulle1.TabIndex = 19
        Me.WebsiteInfoBulle1.Visible = False
        '
        'UrlLister1
        '
        Me.UrlLister1.AddressBox = Me.TextBox1
        Me.UrlLister1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UrlLister1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.UrlLister1.Location = New System.Drawing.Point(76, 62)
        Me.UrlLister1.Name = "UrlLister1"
        Me.UrlLister1.Size = New System.Drawing.Size(381, 238)
        Me.UrlLister1.TabIndex = 20
        Me.UrlLister1.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl
        Me.TextBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TextBox1.Location = New System.Drawing.Point(100, 38)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(288, 23)
        Me.TextBox1.TabIndex = 6
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnnulerToolStripMenuItem, Me.ToolStripSeparator1, Me.CouperToolStripMenuItem, Me.CopierToolStripMenuItem, Me.CollerToolStripMenuItem, Me.CollerLurlEtYAccéderToolStripMenuItem, Me.ToolStripSeparator2, Me.SélectionnerToutToolStripMenuItem, Me.SupprimerToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(195, 170)
        '
        'AnnulerToolStripMenuItem
        '
        Me.AnnulerToolStripMenuItem.Name = "AnnulerToolStripMenuItem"
        Me.AnnulerToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.AnnulerToolStripMenuItem.Text = "Annuler"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(191, 6)
        '
        'CouperToolStripMenuItem
        '
        Me.CouperToolStripMenuItem.Name = "CouperToolStripMenuItem"
        Me.CouperToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.CouperToolStripMenuItem.Text = "Couper"
        '
        'CopierToolStripMenuItem
        '
        Me.CopierToolStripMenuItem.Name = "CopierToolStripMenuItem"
        Me.CopierToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.CopierToolStripMenuItem.Text = "Copier"
        '
        'CollerToolStripMenuItem
        '
        Me.CollerToolStripMenuItem.Name = "CollerToolStripMenuItem"
        Me.CollerToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.CollerToolStripMenuItem.Text = "Coller"
        '
        'CollerLurlEtYAccéderToolStripMenuItem
        '
        Me.CollerLurlEtYAccéderToolStripMenuItem.Name = "CollerLurlEtYAccéderToolStripMenuItem"
        Me.CollerLurlEtYAccéderToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.CollerLurlEtYAccéderToolStripMenuItem.Text = "Coller l'url et y accéder"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(191, 6)
        '
        'SélectionnerToutToolStripMenuItem
        '
        Me.SélectionnerToutToolStripMenuItem.Name = "SélectionnerToutToolStripMenuItem"
        Me.SélectionnerToutToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.SélectionnerToutToolStripMenuItem.Text = "Sélectionner tout"
        '
        'SupprimerToolStripMenuItem
        '
        Me.SupprimerToolStripMenuItem.Name = "SupprimerToolStripMenuItem"
        Me.SupprimerToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.SupprimerToolStripMenuItem.Text = "Supprimer"
        '
        'VButton14
        '
        Me.VButton14.AllowAnimations = True
        Me.VButton14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VButton14.BackColor = System.Drawing.Color.Silver
        Me.VButton14.Image = CType(resources.GetObject("VButton14.Image"), System.Drawing.Image)
        Me.VButton14.Location = New System.Drawing.Point(575, 78)
        Me.VButton14.Name = "VButton14"
        Me.VButton14.RoundedCornersMask = CType(15, Byte)
        Me.VButton14.Size = New System.Drawing.Size(24, 24)
        Me.VButton14.TabIndex = 18
        Me.VButton14.UseVisualStyleBackColor = False
        Me.VButton14.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2010BLUE
        '
        'VButton1
        '
        Me.VButton1.AllowAnimations = True
        Me.VButton1.BackColor = System.Drawing.Color.Transparent
        Me.VButton1.Image = CType(resources.GetObject("VButton1.Image"), System.Drawing.Image)
        Me.VButton1.Location = New System.Drawing.Point(11, 38)
        Me.VButton1.Name = "VButton1"
        Me.VButton1.RoundedCornersMask = CType(15, Byte)
        Me.VButton1.Size = New System.Drawing.Size(24, 24)
        Me.VButton1.TabIndex = 0
        Me.VButton1.UseVisualStyleBackColor = False
        Me.VButton1.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2010BLUE
        '
        'VButton11
        '
        Me.VButton11.AllowAnimations = True
        Me.VButton11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VButton11.BackColor = System.Drawing.Color.Transparent
        Me.VButton11.Image = CType(resources.GetObject("VButton11.Image"), System.Drawing.Image)
        Me.VButton11.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.VButton11.Location = New System.Drawing.Point(491, 0)
        Me.VButton11.Name = "VButton11"
        Me.VButton11.RoundedCornersMask = CType(15, Byte)
        Me.VButton11.Size = New System.Drawing.Size(30, 24)
        Me.VButton11.TabIndex = 17
        Me.VButton11.UseVisualStyleBackColor = False
        Me.VButton11.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2010BLUE
        '
        'VButton12
        '
        Me.VButton12.AllowAnimations = True
        Me.VButton12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VButton12.BackColor = System.Drawing.Color.Transparent
        Me.VButton12.Image = CType(resources.GetObject("VButton12.Image"), System.Drawing.Image)
        Me.VButton12.Location = New System.Drawing.Point(520, 0)
        Me.VButton12.Name = "VButton12"
        Me.VButton12.RoundedCornersMask = CType(15, Byte)
        Me.VButton12.Size = New System.Drawing.Size(30, 24)
        Me.VButton12.TabIndex = 16
        Me.VButton12.UseVisualStyleBackColor = False
        Me.VButton12.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2010BLUE
        '
        'VButton13
        '
        Me.VButton13.AllowAnimations = True
        Me.VButton13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VButton13.BackColor = System.Drawing.Color.Transparent
        Me.VButton13.Image = CType(resources.GetObject("VButton13.Image"), System.Drawing.Image)
        Me.VButton13.Location = New System.Drawing.Point(549, 0)
        Me.VButton13.Name = "VButton13"
        Me.VButton13.RoundedCornersMask = CType(15, Byte)
        Me.VButton13.Size = New System.Drawing.Size(40, 24)
        Me.VButton13.TabIndex = 15
        Me.VButton13.UseVisualStyleBackColor = False
        Me.VButton13.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2010BLUE
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.BackHighColor = System.Drawing.Color.DarkGray
        Me.TabControl1.BackLowColor = System.Drawing.Color.Silver
        Me.TabControl1.CloseButtonVisible = True
        Me.TabControl1.Location = New System.Drawing.Point(1, 70)
        Me.TabControl1.MenuRenderer = Nothing
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Size = New System.Drawing.Size(598, 395)
        Me.TabControl1.TabBackHighColor = System.Drawing.Color.Silver
        Me.TabControl1.TabBackLowColor = System.Drawing.Color.Gray
        Me.TabControl1.TabCloseButtonImage = Nothing
        Me.TabControl1.TabCloseButtonImageDisabled = Nothing
        Me.TabControl1.TabCloseButtonImageHot = Nothing
        Me.TabControl1.TabIndex = 14
        '
        'VButton10
        '
        Me.VButton10.AllowAnimations = True
        Me.VButton10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VButton10.BackColor = System.Drawing.Color.Transparent
        Me.VButton10.Image = CType(resources.GetObject("VButton10.Image"), System.Drawing.Image)
        Me.VButton10.Location = New System.Drawing.Point(566, 38)
        Me.VButton10.Name = "VButton10"
        Me.VButton10.RoundedCornersMask = CType(15, Byte)
        Me.VButton10.Size = New System.Drawing.Size(24, 24)
        Me.VButton10.TabIndex = 13
        Me.VButton10.UseVisualStyleBackColor = False
        Me.VButton10.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2010BLUE
        '
        'VButton9
        '
        Me.VButton9.AllowAnimations = True
        Me.VButton9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VButton9.BackColor = System.Drawing.Color.Transparent
        Me.VButton9.Image = CType(resources.GetObject("VButton9.Image"), System.Drawing.Image)
        Me.VButton9.Location = New System.Drawing.Point(543, 38)
        Me.VButton9.Name = "VButton9"
        Me.VButton9.RoundedCornersMask = CType(15, Byte)
        Me.VButton9.Size = New System.Drawing.Size(24, 24)
        Me.VButton9.TabIndex = 12
        Me.VButton9.UseVisualStyleBackColor = False
        Me.VButton9.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2010BLUE
        '
        'VButton8
        '
        Me.VButton8.AllowAnimations = True
        Me.VButton8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VButton8.BackColor = System.Drawing.Color.Transparent
        Me.VButton8.Image = CType(resources.GetObject("VButton8.Image"), System.Drawing.Image)
        Me.VButton8.Location = New System.Drawing.Point(502, 38)
        Me.VButton8.Name = "VButton8"
        Me.VButton8.RoundedCornersMask = CType(15, Byte)
        Me.VButton8.Size = New System.Drawing.Size(24, 24)
        Me.VButton8.TabIndex = 11
        Me.VButton8.UseVisualStyleBackColor = False
        Me.VButton8.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2010BLUE
        '
        'VButton7
        '
        Me.VButton7.AllowAnimations = True
        Me.VButton7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VButton7.BackColor = System.Drawing.Color.Transparent
        Me.VButton7.Image = CType(resources.GetObject("VButton7.Image"), System.Drawing.Image)
        Me.VButton7.Location = New System.Drawing.Point(479, 38)
        Me.VButton7.Name = "VButton7"
        Me.VButton7.RoundedCornersMask = CType(15, Byte)
        Me.VButton7.Size = New System.Drawing.Size(24, 24)
        Me.VButton7.TabIndex = 10
        Me.VButton7.UseVisualStyleBackColor = False
        Me.VButton7.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2010BLUE
        '
        'VButton6
        '
        Me.VButton6.AllowAnimations = True
        Me.VButton6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VButton6.BackColor = System.Drawing.Color.Transparent
        Me.VButton6.Image = CType(resources.GetObject("VButton6.Image"), System.Drawing.Image)
        Me.VButton6.Location = New System.Drawing.Point(433, 38)
        Me.VButton6.Name = "VButton6"
        Me.VButton6.RoundedCornersMask = CType(15, Byte)
        Me.VButton6.Size = New System.Drawing.Size(24, 24)
        Me.VButton6.TabIndex = 9
        Me.VButton6.UseVisualStyleBackColor = False
        Me.VButton6.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2010BLUE
        '
        'VButton5
        '
        Me.VButton5.AllowAnimations = True
        Me.VButton5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VButton5.BackColor = System.Drawing.Color.Transparent
        Me.VButton5.Image = CType(resources.GetObject("VButton5.Image"), System.Drawing.Image)
        Me.VButton5.Location = New System.Drawing.Point(410, 38)
        Me.VButton5.Name = "VButton5"
        Me.VButton5.RoundedCornersMask = CType(15, Byte)
        Me.VButton5.Size = New System.Drawing.Size(24, 24)
        Me.VButton5.TabIndex = 8
        Me.VButton5.UseVisualStyleBackColor = False
        Me.VButton5.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2010BLUE
        '
        'VButton4
        '
        Me.VButton4.AllowAnimations = True
        Me.VButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VButton4.BackColor = System.Drawing.Color.Transparent
        Me.VButton4.Image = CType(resources.GetObject("VButton4.Image"), System.Drawing.Image)
        Me.VButton4.Location = New System.Drawing.Point(387, 38)
        Me.VButton4.Name = "VButton4"
        Me.VButton4.RoundedCornersMask = CType(15, Byte)
        Me.VButton4.Size = New System.Drawing.Size(24, 24)
        Me.VButton4.TabIndex = 7
        Me.VButton4.UseVisualStyleBackColor = False
        Me.VButton4.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2010BLUE
        '
        'VButton3
        '
        Me.VButton3.AllowAnimations = True
        Me.VButton3.BackColor = System.Drawing.Color.Transparent
        Me.VButton3.Location = New System.Drawing.Point(76, 38)
        Me.VButton3.Name = "VButton3"
        Me.VButton3.RoundedCornersMask = CType(15, Byte)
        Me.VButton3.Size = New System.Drawing.Size(24, 24)
        Me.VButton3.TabIndex = 5
        Me.VButton3.UseVisualStyleBackColor = False
        Me.VButton3.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2010BLUE
        '
        'VButton2
        '
        Me.VButton2.AllowAnimations = True
        Me.VButton2.BackColor = System.Drawing.Color.Transparent
        Me.VButton2.Image = CType(resources.GetObject("VButton2.Image"), System.Drawing.Image)
        Me.VButton2.Location = New System.Drawing.Point(34, 38)
        Me.VButton2.Name = "VButton2"
        Me.VButton2.RoundedCornersMask = CType(15, Byte)
        Me.VButton2.Size = New System.Drawing.Size(24, 24)
        Me.VButton2.TabIndex = 4
        Me.VButton2.UseVisualStyleBackColor = False
        Me.VButton2.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2010BLUE
        '
        'ResizePnl
        '
        Me.ResizePnl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ResizePnl.BackColor = System.Drawing.Color.Transparent
        Me.ResizePnl.Cursor = System.Windows.Forms.Cursors.SizeNWSE
        Me.ResizePnl.Location = New System.Drawing.Point(587, 468)
        Me.ResizePnl.Name = "ResizePnl"
        Me.ResizePnl.Size = New System.Drawing.Size(12, 12)
        Me.ResizePnl.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(41, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(408, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Xin Browser - Nouvel Onglet"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Fuchsia
        Me.ClientSize = New System.Drawing.Size(600, 480)
        Me.Controls.Add(Me.AlphaGradientPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(600, 480)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Xin Browser"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.AlphaGradientPanel1.ResumeLayout(False)
        Me.AlphaGradientPanel1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AlphaGradientPanel1 As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents VButton1 As VIBlend.WinForms.Controls.vButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ResizePnl As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents VButton2 As VIBlend.WinForms.Controls.vButton
    Friend WithEvents VButton3 As VIBlend.WinForms.Controls.vButton
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents VButton4 As VIBlend.WinForms.Controls.vButton
    Friend WithEvents VButton6 As VIBlend.WinForms.Controls.vButton
    Friend WithEvents VButton5 As VIBlend.WinForms.Controls.vButton
    Friend WithEvents VButton8 As VIBlend.WinForms.Controls.vButton
    Friend WithEvents VButton7 As VIBlend.WinForms.Controls.vButton
    Friend WithEvents VButton10 As VIBlend.WinForms.Controls.vButton
    Friend WithEvents VButton9 As VIBlend.WinForms.Controls.vButton
    Friend WithEvents TabControl1 As MdiTabControl.TabControl
    Friend WithEvents VButton11 As VIBlend.WinForms.Controls.vButton
    Friend WithEvents VButton12 As VIBlend.WinForms.Controls.vButton
    Friend WithEvents VButton13 As VIBlend.WinForms.Controls.vButton
    Friend WithEvents VButton14 As VIBlend.WinForms.Controls.vButton
    Friend WithEvents WebsiteInfoBulle1 As Xin_Browser.WebsiteInfoBulle
    Friend WithEvents UrlLister1 As Xin_Browser.UrlLister
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents FavHistList1 As Xin_Browser.FavHistList
    Friend WithEvents VButton15 As VIBlend.WinForms.Controls.vButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AnnulerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CouperToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CollerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CollerLurlEtYAccéderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SélectionnerToutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupprimerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
