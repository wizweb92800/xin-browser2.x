<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CodeViewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CodeViewer))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CTextBox1 = New ChreneLib.Controls.TextBoxes.CTextBox()
        Me.SrchBtn = New System.Windows.Forms.Button()
        Me.SrchBtnPrev = New System.Windows.Forms.Button()
        Me.SrchBtnNext = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Status_Lbl = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(540, 24)
        Me.Panel1.TabIndex = 0
        '
        'Button5
        '
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Button5.Location = New System.Drawing.Point(460, 0)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(40, 24)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "?"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button4.Location = New System.Drawing.Point(221, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(90, 24)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Console"
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'Button3
        '
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button3.Location = New System.Drawing.Point(131, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(90, 24)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Inspecteur"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.DimGray
        Me.Button2.Location = New System.Drawing.Point(41, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 24)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "HTML"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "F12"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(500, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 24)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CTextBox1)
        Me.Panel2.Controls.Add(Me.SrchBtn)
        Me.Panel2.Controls.Add(Me.SrchBtnPrev)
        Me.Panel2.Controls.Add(Me.SrchBtnNext)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Button9)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Button8)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Button7)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 24)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(540, 24)
        Me.Panel2.TabIndex = 1
        '
        'CTextBox1
        '
        Me.CTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CTextBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.CTextBox1.Location = New System.Drawing.Point(338, 0)
        Me.CTextBox1.Name = "CTextBox1"
        Me.CTextBox1.Size = New System.Drawing.Size(130, 23)
        Me.CTextBox1.TabIndex = 3
        Me.CTextBox1.WaterMark = "Rechercher..."
        Me.CTextBox1.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.CTextBox1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CTextBox1.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'SrchBtn
        '
        Me.SrchBtn.BackColor = System.Drawing.Color.Green
        Me.SrchBtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.SrchBtn.FlatAppearance.BorderSize = 0
        Me.SrchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SrchBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SrchBtn.Image = CType(resources.GetObject("SrchBtn.Image"), System.Drawing.Image)
        Me.SrchBtn.Location = New System.Drawing.Point(468, 0)
        Me.SrchBtn.Name = "SrchBtn"
        Me.SrchBtn.Size = New System.Drawing.Size(24, 24)
        Me.SrchBtn.TabIndex = 2
        Me.SrchBtn.UseVisualStyleBackColor = False
        '
        'SrchBtnPrev
        '
        Me.SrchBtnPrev.BackColor = System.Drawing.Color.Gainsboro
        Me.SrchBtnPrev.Dock = System.Windows.Forms.DockStyle.Right
        Me.SrchBtnPrev.FlatAppearance.BorderSize = 0
        Me.SrchBtnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SrchBtnPrev.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SrchBtnPrev.Image = CType(resources.GetObject("SrchBtnPrev.Image"), System.Drawing.Image)
        Me.SrchBtnPrev.Location = New System.Drawing.Point(492, 0)
        Me.SrchBtnPrev.Name = "SrchBtnPrev"
        Me.SrchBtnPrev.Size = New System.Drawing.Size(24, 24)
        Me.SrchBtnPrev.TabIndex = 11
        Me.SrchBtnPrev.UseVisualStyleBackColor = False
        Me.SrchBtnPrev.Visible = False
        '
        'SrchBtnNext
        '
        Me.SrchBtnNext.BackColor = System.Drawing.Color.Gainsboro
        Me.SrchBtnNext.Dock = System.Windows.Forms.DockStyle.Right
        Me.SrchBtnNext.FlatAppearance.BorderSize = 0
        Me.SrchBtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SrchBtnNext.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SrchBtnNext.Image = CType(resources.GetObject("SrchBtnNext.Image"), System.Drawing.Image)
        Me.SrchBtnNext.Location = New System.Drawing.Point(516, 0)
        Me.SrchBtnNext.Name = "SrchBtnNext"
        Me.SrchBtnNext.Size = New System.Drawing.Size(24, 24)
        Me.SrchBtnNext.TabIndex = 12
        Me.SrchBtnNext.UseVisualStyleBackColor = False
        Me.SrchBtnNext.Visible = False
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label5.Location = New System.Drawing.Point(102, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(10, 24)
        Me.Label5.TabIndex = 10
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button9
        '
        Me.Button9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button9.Image = CType(resources.GetObject("Button9.Image"), System.Drawing.Image)
        Me.Button9.Location = New System.Drawing.Point(78, 0)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(24, 24)
        Me.Button9.TabIndex = 6
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.Location = New System.Drawing.Point(68, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 24)
        Me.Label4.TabIndex = 9
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button8
        '
        Me.Button8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button8.Image = CType(resources.GetObject("Button8.Image"), System.Drawing.Image)
        Me.Button8.Location = New System.Drawing.Point(44, 0)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(24, 24)
        Me.Button8.TabIndex = 5
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Location = New System.Drawing.Point(34, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 24)
        Me.Label3.TabIndex = 8
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button7
        '
        Me.Button7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.Location = New System.Drawing.Point(10, 0)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(24, 24)
        Me.Button7.TabIndex = 4
        Me.Button7.UseVisualStyleBackColor = True
        Me.Button7.Visible = False
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 24)
        Me.Label2.TabIndex = 7
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label2.Visible = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Status_Lbl)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 176)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(540, 24)
        Me.Panel3.TabIndex = 2
        '
        'Status_Lbl
        '
        Me.Status_Lbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Status_Lbl.ForeColor = System.Drawing.Color.Black
        Me.Status_Lbl.Location = New System.Drawing.Point(3, 2)
        Me.Status_Lbl.Name = "Status_Lbl"
        Me.Status_Lbl.Size = New System.Drawing.Size(533, 20)
        Me.Status_Lbl.TabIndex = 0
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 48)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.ShowSelectionMargin = True
        Me.RichTextBox1.Size = New System.Drawing.Size(540, 128)
        Me.RichTextBox1.TabIndex = 3
        Me.RichTextBox1.Text = "<!DOCTYPE HTML>"
        '
        'CodeViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "CodeViewer"
        Me.Size = New System.Drawing.Size(540, 200)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents SrchBtn As System.Windows.Forms.Button
    Friend WithEvents CTextBox1 As ChreneLib.Controls.TextBoxes.CTextBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents SrchBtnPrev As System.Windows.Forms.Button
    Friend WithEvents SrchBtnNext As System.Windows.Forms.Button
    Friend WithEvents Status_Lbl As System.Windows.Forms.Label

End Class
