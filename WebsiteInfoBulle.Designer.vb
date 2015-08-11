<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WebsiteInfoBulle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WebsiteInfoBulle))
        Me.AlphaGradientPanel1 = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.SecurityClearImg = New System.Windows.Forms.PictureBox()
        Me.AdvertSecurityImg = New System.Windows.Forms.PictureBox()
        Me.AlertSecurityImg = New System.Windows.Forms.PictureBox()
        Me.UnknownSecurityImg = New System.Windows.Forms.PictureBox()
        Me.HTTPImg = New System.Windows.Forms.PictureBox()
        Me.HTTPSImg = New System.Windows.Forms.PictureBox()
        Me.PrivateNavImg = New System.Windows.Forms.PictureBox()
        Me.WebsiteIdentityLbl = New System.Windows.Forms.Label()
        Me.VButton1 = New VIBlend.WinForms.Controls.vButton()
        Me.VButton2 = New VIBlend.WinForms.Controls.vButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AlphaGradientPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.SecurityClearImg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdvertSecurityImg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlertSecurityImg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnknownSecurityImg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HTTPImg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HTTPSImg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrivateNavImg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AlphaGradientPanel1
        '
        Me.AlphaGradientPanel1.BackColor = System.Drawing.SystemColors.Control
        Me.AlphaGradientPanel1.Border = True
        Me.AlphaGradientPanel1.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.AlphaGradientPanel1.Colors.Add(Me.ColorWithAlpha1)
        Me.AlphaGradientPanel1.Colors.Add(Me.ColorWithAlpha2)
        Me.AlphaGradientPanel1.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.AlphaGradientPanel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.AlphaGradientPanel1.Controls.Add(Me.WebsiteIdentityLbl)
        Me.AlphaGradientPanel1.Controls.Add(Me.VButton1)
        Me.AlphaGradientPanel1.Controls.Add(Me.VButton2)
        Me.AlphaGradientPanel1.Controls.Add(Me.Label1)
        Me.AlphaGradientPanel1.Controls.Add(Me.PictureBox1)
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
        Me.AlphaGradientPanel1.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.AlphaGradientPanel1.ImageSize = New System.Drawing.Size(48, 48)
        Me.AlphaGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.AlphaGradientPanel1.Name = "AlphaGradientPanel1"
        Me.AlphaGradientPanel1.Rounded = True
        Me.AlphaGradientPanel1.Size = New System.Drawing.Size(280, 140)
        Me.AlphaGradientPanel1.TabIndex = 0
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.White
        Me.ColorWithAlpha1.Parent = Me.AlphaGradientPanel1
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.SystemColors.Control
        Me.ColorWithAlpha2.Parent = Me.AlphaGradientPanel1
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.Controls.Add(Me.SecurityClearImg)
        Me.FlowLayoutPanel1.Controls.Add(Me.AdvertSecurityImg)
        Me.FlowLayoutPanel1.Controls.Add(Me.AlertSecurityImg)
        Me.FlowLayoutPanel1.Controls.Add(Me.UnknownSecurityImg)
        Me.FlowLayoutPanel1.Controls.Add(Me.HTTPImg)
        Me.FlowLayoutPanel1.Controls.Add(Me.HTTPSImg)
        Me.FlowLayoutPanel1.Controls.Add(Me.PrivateNavImg)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(16, 103)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(136, 22)
        Me.FlowLayoutPanel1.TabIndex = 17
        '
        'SecurityClearImg
        '
        Me.SecurityClearImg.Image = CType(resources.GetObject("SecurityClearImg.Image"), System.Drawing.Image)
        Me.SecurityClearImg.Location = New System.Drawing.Point(3, 3)
        Me.SecurityClearImg.Name = "SecurityClearImg"
        Me.SecurityClearImg.Size = New System.Drawing.Size(16, 16)
        Me.SecurityClearImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.SecurityClearImg.TabIndex = 3
        Me.SecurityClearImg.TabStop = False
        '
        'AdvertSecurityImg
        '
        Me.AdvertSecurityImg.Image = CType(resources.GetObject("AdvertSecurityImg.Image"), System.Drawing.Image)
        Me.AdvertSecurityImg.Location = New System.Drawing.Point(25, 3)
        Me.AdvertSecurityImg.Name = "AdvertSecurityImg"
        Me.AdvertSecurityImg.Size = New System.Drawing.Size(16, 16)
        Me.AdvertSecurityImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.AdvertSecurityImg.TabIndex = 5
        Me.AdvertSecurityImg.TabStop = False
        Me.AdvertSecurityImg.Visible = False
        '
        'AlertSecurityImg
        '
        Me.AlertSecurityImg.Image = CType(resources.GetObject("AlertSecurityImg.Image"), System.Drawing.Image)
        Me.AlertSecurityImg.Location = New System.Drawing.Point(47, 3)
        Me.AlertSecurityImg.Name = "AlertSecurityImg"
        Me.AlertSecurityImg.Size = New System.Drawing.Size(16, 16)
        Me.AlertSecurityImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.AlertSecurityImg.TabIndex = 7
        Me.AlertSecurityImg.TabStop = False
        Me.AlertSecurityImg.Visible = False
        '
        'UnknownSecurityImg
        '
        Me.UnknownSecurityImg.BackColor = System.Drawing.Color.Transparent
        Me.UnknownSecurityImg.Image = CType(resources.GetObject("UnknownSecurityImg.Image"), System.Drawing.Image)
        Me.UnknownSecurityImg.Location = New System.Drawing.Point(69, 3)
        Me.UnknownSecurityImg.Name = "UnknownSecurityImg"
        Me.UnknownSecurityImg.Size = New System.Drawing.Size(16, 16)
        Me.UnknownSecurityImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.UnknownSecurityImg.TabIndex = 8
        Me.UnknownSecurityImg.TabStop = False
        Me.UnknownSecurityImg.Visible = False
        '
        'HTTPImg
        '
        Me.HTTPImg.Image = CType(resources.GetObject("HTTPImg.Image"), System.Drawing.Image)
        Me.HTTPImg.Location = New System.Drawing.Point(91, 3)
        Me.HTTPImg.Name = "HTTPImg"
        Me.HTTPImg.Size = New System.Drawing.Size(16, 16)
        Me.HTTPImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.HTTPImg.TabIndex = 4
        Me.HTTPImg.TabStop = False
        '
        'HTTPSImg
        '
        Me.HTTPSImg.BackColor = System.Drawing.Color.Transparent
        Me.HTTPSImg.Image = CType(resources.GetObject("HTTPSImg.Image"), System.Drawing.Image)
        Me.HTTPSImg.Location = New System.Drawing.Point(113, 3)
        Me.HTTPSImg.Name = "HTTPSImg"
        Me.HTTPSImg.Size = New System.Drawing.Size(16, 16)
        Me.HTTPSImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.HTTPSImg.TabIndex = 6
        Me.HTTPSImg.TabStop = False
        Me.HTTPSImg.Visible = False
        '
        'PrivateNavImg
        '
        Me.PrivateNavImg.BackColor = System.Drawing.Color.Transparent
        Me.PrivateNavImg.Image = CType(resources.GetObject("PrivateNavImg.Image"), System.Drawing.Image)
        Me.PrivateNavImg.Location = New System.Drawing.Point(3, 25)
        Me.PrivateNavImg.Name = "PrivateNavImg"
        Me.PrivateNavImg.Size = New System.Drawing.Size(16, 16)
        Me.PrivateNavImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PrivateNavImg.TabIndex = 9
        Me.PrivateNavImg.TabStop = False
        Me.PrivateNavImg.Visible = False
        '
        'WebsiteIdentityLbl
        '
        Me.WebsiteIdentityLbl.AutoSize = True
        Me.WebsiteIdentityLbl.BackColor = System.Drawing.Color.Transparent
        Me.WebsiteIdentityLbl.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.WebsiteIdentityLbl.ForeColor = System.Drawing.Color.Green
        Me.WebsiteIdentityLbl.Location = New System.Drawing.Point(53, 33)
        Me.WebsiteIdentityLbl.Name = "WebsiteIdentityLbl"
        Me.WebsiteIdentityLbl.Size = New System.Drawing.Size(96, 19)
        Me.WebsiteIdentityLbl.TabIndex = 16
        Me.WebsiteIdentityLbl.Text = "www.google.fr"
        '
        'VButton1
        '
        Me.VButton1.AllowAnimations = True
        Me.VButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VButton1.BackColor = System.Drawing.Color.Transparent
        Me.VButton1.Location = New System.Drawing.Point(158, 103)
        Me.VButton1.Name = "VButton1"
        Me.VButton1.RoundedCornersMask = CType(15, Byte)
        Me.VButton1.Size = New System.Drawing.Size(67, 22)
        Me.VButton1.TabIndex = 15
        Me.VButton1.Text = "Sécurité..."
        Me.VButton1.UseVisualStyleBackColor = False
        Me.VButton1.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2010BLUE
        '
        'VButton2
        '
        Me.VButton2.AllowAnimations = True
        Me.VButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VButton2.BackColor = System.Drawing.Color.Transparent
        Me.VButton2.Location = New System.Drawing.Point(224, 103)
        Me.VButton2.Name = "VButton2"
        Me.VButton2.RoundedCornersMask = CType(15, Byte)
        Me.VButton2.Size = New System.Drawing.Size(42, 22)
        Me.VButton2.TabIndex = 14
        Me.VButton2.Text = "&OK"
        Me.VButton2.UseVisualStyleBackColor = False
        Me.VButton2.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2010BLUE
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(53, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Identité du site web"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'WebsiteInfoBulle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.AlphaGradientPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Name = "WebsiteInfoBulle"
        Me.Size = New System.Drawing.Size(280, 140)
        Me.AlphaGradientPanel1.ResumeLayout(False)
        Me.AlphaGradientPanel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.SecurityClearImg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdvertSecurityImg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlertSecurityImg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnknownSecurityImg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HTTPImg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HTTPSImg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrivateNavImg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AlphaGradientPanel1 As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SecurityClearImg As System.Windows.Forms.PictureBox
    Friend WithEvents HTTPImg As System.Windows.Forms.PictureBox
    Friend WithEvents AdvertSecurityImg As System.Windows.Forms.PictureBox
    Friend WithEvents AlertSecurityImg As System.Windows.Forms.PictureBox
    Friend WithEvents UnknownSecurityImg As System.Windows.Forms.PictureBox
    Friend WithEvents HTTPSImg As System.Windows.Forms.PictureBox
    Friend WithEvents VButton2 As VIBlend.WinForms.Controls.vButton
    Friend WithEvents VButton1 As VIBlend.WinForms.Controls.vButton
    Friend WithEvents WebsiteIdentityLbl As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents PrivateNavImg As System.Windows.Forms.PictureBox

End Class
