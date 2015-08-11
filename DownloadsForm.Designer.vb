<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DownloadsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DownloadsForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CTextBox1 = New ChreneLib.Controls.TextBoxes.CTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DownloadList = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.CTextBox1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 175)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(404, 37)
        Me.Panel1.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(202, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(36, 25)
        Me.Button2.TabIndex = 2
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CTextBox1
        '
        Me.CTextBox1.Location = New System.Drawing.Point(7, 7)
        Me.CTextBox1.Name = "CTextBox1"
        Me.CTextBox1.Size = New System.Drawing.Size(196, 23)
        Me.CTextBox1.TabIndex = 1
        Me.CTextBox1.WaterMark = "Rechercher sur windows..."
        Me.CTextBox1.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.CTextBox1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CTextBox1.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(295, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 27)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Vider la liste"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DownloadList
        '
        Me.DownloadList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DownloadList.Location = New System.Drawing.Point(0, 0)
        Me.DownloadList.Name = "DownloadList"
        Me.DownloadList.Size = New System.Drawing.Size(404, 175)
        Me.DownloadList.TabIndex = 1
        '
        'DownloadsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 212)
        Me.Controls.Add(Me.DownloadList)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(420, 250)
        Me.Name = "DownloadsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Téléchargements"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CTextBox1 As ChreneLib.Controls.TextBoxes.CTextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DownloadList As System.Windows.Forms.Panel
End Class
