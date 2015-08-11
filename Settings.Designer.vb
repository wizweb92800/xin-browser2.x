<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Général"}, 0, System.Drawing.Color.White, System.Drawing.SystemColors.ActiveCaption, Nothing)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Navigation", 1)
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Données", 2)
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Langue", 3)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GeneralPanel = New System.Windows.Forms.Panel()
        Me.RadioButton_GreenTheme = New System.Windows.Forms.RadioButton()
        Me.RadioButton_BlueTheme = New System.Windows.Forms.RadioButton()
        Me.RadioButton_OrangeTheme = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Btn_DefaultDownloadsPlace = New System.Windows.Forms.Button()
        Me.TextBox_DownloadsPlace = New System.Windows.Forms.TextBox()
        Me.Btn_DownloadsPlace = New System.Windows.Forms.Button()
        Me.CheckBox_Downloads = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBox_EnableBetaUpdates = New System.Windows.Forms.CheckBox()
        Me.CheckBox_CheckForUpdates = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GeneralPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.SystemColors.Control
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Top
        ListViewItem5.StateImageIndex = 0
        ListViewItem6.StateImageIndex = 0
        ListViewItem7.StateImageIndex = 0
        ListViewItem8.StateImageIndex = 0
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8})
        Me.ListView1.LargeImageList = Me.ImageList1
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(574, 61)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "setting_tools.png")
        Me.ImageList1.Images.SetKeyName(1, "world.png")
        Me.ImageList1.Images.SetKeyName(2, "lock.png")
        Me.ImageList1.Images.SetKeyName(3, "flag_france.png")
        '
        'GeneralPanel
        '
        Me.GeneralPanel.Controls.Add(Me.RadioButton_GreenTheme)
        Me.GeneralPanel.Controls.Add(Me.RadioButton_BlueTheme)
        Me.GeneralPanel.Controls.Add(Me.RadioButton_OrangeTheme)
        Me.GeneralPanel.Controls.Add(Me.Label3)
        Me.GeneralPanel.Controls.Add(Me.Btn_DefaultDownloadsPlace)
        Me.GeneralPanel.Controls.Add(Me.TextBox_DownloadsPlace)
        Me.GeneralPanel.Controls.Add(Me.Btn_DownloadsPlace)
        Me.GeneralPanel.Controls.Add(Me.CheckBox_Downloads)
        Me.GeneralPanel.Controls.Add(Me.Label2)
        Me.GeneralPanel.Controls.Add(Me.CheckBox_EnableBetaUpdates)
        Me.GeneralPanel.Controls.Add(Me.CheckBox_CheckForUpdates)
        Me.GeneralPanel.Controls.Add(Me.Label1)
        Me.GeneralPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GeneralPanel.Location = New System.Drawing.Point(0, 61)
        Me.GeneralPanel.Name = "GeneralPanel"
        Me.GeneralPanel.Size = New System.Drawing.Size(574, 371)
        Me.GeneralPanel.TabIndex = 1
        '
        'RadioButton_GreenTheme
        '
        Me.RadioButton_GreenTheme.AutoSize = True
        Me.RadioButton_GreenTheme.Location = New System.Drawing.Point(313, 305)
        Me.RadioButton_GreenTheme.Name = "RadioButton_GreenTheme"
        Me.RadioButton_GreenTheme.Size = New System.Drawing.Size(93, 19)
        Me.RadioButton_GreenTheme.TabIndex = 11
        Me.RadioButton_GreenTheme.TabStop = True
        Me.RadioButton_GreenTheme.Text = "Classic (Vert)"
        Me.RadioButton_GreenTheme.UseVisualStyleBackColor = True
        Me.RadioButton_GreenTheme.Visible = False
        '
        'RadioButton_BlueTheme
        '
        Me.RadioButton_BlueTheme.AutoSize = True
        Me.RadioButton_BlueTheme.Location = New System.Drawing.Point(190, 305)
        Me.RadioButton_BlueTheme.Name = "RadioButton_BlueTheme"
        Me.RadioButton_BlueTheme.Size = New System.Drawing.Size(101, 19)
        Me.RadioButton_BlueTheme.TabIndex = 10
        Me.RadioButton_BlueTheme.TabStop = True
        Me.RadioButton_BlueTheme.Text = "Modern (Bleu)"
        Me.RadioButton_BlueTheme.UseVisualStyleBackColor = True
        '
        'RadioButton_OrangeTheme
        '
        Me.RadioButton_OrangeTheme.AutoSize = True
        Me.RadioButton_OrangeTheme.Location = New System.Drawing.Point(24, 305)
        Me.RadioButton_OrangeTheme.Name = "RadioButton_OrangeTheme"
        Me.RadioButton_OrangeTheme.Size = New System.Drawing.Size(137, 19)
        Me.RadioButton_OrangeTheme.TabIndex = 9
        Me.RadioButton_OrangeTheme.TabStop = True
        Me.RadioButton_OrangeTheme.Text = "Xin Browser (Orange)"
        Me.RadioButton_OrangeTheme.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 272)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Thème"
        '
        'Btn_DefaultDownloadsPlace
        '
        Me.Btn_DefaultDownloadsPlace.Location = New System.Drawing.Point(115, 221)
        Me.Btn_DefaultDownloadsPlace.Name = "Btn_DefaultDownloadsPlace"
        Me.Btn_DefaultDownloadsPlace.Size = New System.Drawing.Size(75, 27)
        Me.Btn_DefaultDownloadsPlace.TabIndex = 7
        Me.Btn_DefaultDownloadsPlace.Text = "Par défaut"
        Me.Btn_DefaultDownloadsPlace.UseVisualStyleBackColor = True
        '
        'TextBox_DownloadsPlace
        '
        Me.TextBox_DownloadsPlace.BackColor = System.Drawing.Color.White
        Me.TextBox_DownloadsPlace.Location = New System.Drawing.Point(24, 192)
        Me.TextBox_DownloadsPlace.Name = "TextBox_DownloadsPlace"
        Me.TextBox_DownloadsPlace.ReadOnly = True
        Me.TextBox_DownloadsPlace.Size = New System.Drawing.Size(337, 23)
        Me.TextBox_DownloadsPlace.TabIndex = 6
        '
        'Btn_DownloadsPlace
        '
        Me.Btn_DownloadsPlace.Location = New System.Drawing.Point(24, 221)
        Me.Btn_DownloadsPlace.Name = "Btn_DownloadsPlace"
        Me.Btn_DownloadsPlace.Size = New System.Drawing.Size(85, 27)
        Me.Btn_DownloadsPlace.TabIndex = 5
        Me.Btn_DownloadsPlace.Text = "Parcourir..."
        Me.Btn_DownloadsPlace.UseVisualStyleBackColor = True
        '
        'CheckBox_Downloads
        '
        Me.CheckBox_Downloads.AutoSize = True
        Me.CheckBox_Downloads.Location = New System.Drawing.Point(24, 158)
        Me.CheckBox_Downloads.Name = "CheckBox_Downloads"
        Me.CheckBox_Downloads.Size = New System.Drawing.Size(303, 19)
        Me.CheckBox_Downloads.TabIndex = 4
        Me.CheckBox_Downloads.Text = "Toujours choisir où enregistrer mes téléchargements"
        Me.CheckBox_Downloads.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Téléchargements"
        '
        'CheckBox_EnableBetaUpdates
        '
        Me.CheckBox_EnableBetaUpdates.AutoSize = True
        Me.CheckBox_EnableBetaUpdates.Location = New System.Drawing.Point(24, 74)
        Me.CheckBox_EnableBetaUpdates.Name = "CheckBox_EnableBetaUpdates"
        Me.CheckBox_EnableBetaUpdates.Size = New System.Drawing.Size(325, 19)
        Me.CheckBox_EnableBetaUpdates.TabIndex = 2
        Me.CheckBox_EnableBetaUpdates.Text = "Télécharger les versions expérimentales (bêta) du logiciel"
        Me.CheckBox_EnableBetaUpdates.UseVisualStyleBackColor = True
        '
        'CheckBox_CheckForUpdates
        '
        Me.CheckBox_CheckForUpdates.AutoSize = True
        Me.CheckBox_CheckForUpdates.Location = New System.Drawing.Point(24, 51)
        Me.CheckBox_CheckForUpdates.Name = "CheckBox_CheckForUpdates"
        Me.CheckBox_CheckForUpdates.Size = New System.Drawing.Size(197, 19)
        Me.CheckBox_CheckForUpdates.TabIndex = 1
        Me.CheckBox_CheckForUpdates.Text = "Vérifier l'existance de mise à jour"
        Me.CheckBox_CheckForUpdates.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mises à jour"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Info
        Me.Label4.Location = New System.Drawing.Point(359, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(216, 49)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Les options de navigation, données et langue seront disponibles lors de la procha" & _
    "ine mise à jour de Xin Browser."
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 432)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GeneralPanel)
        Me.Controls.Add(Me.ListView1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Paramètres"
        Me.GeneralPanel.ResumeLayout(False)
        Me.GeneralPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents GeneralPanel As System.Windows.Forms.Panel
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckBox_EnableBetaUpdates As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_CheckForUpdates As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CheckBox_Downloads As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox_DownloadsPlace As System.Windows.Forms.TextBox
    Friend WithEvents Btn_DownloadsPlace As System.Windows.Forms.Button
    Friend WithEvents Btn_DefaultDownloadsPlace As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RadioButton_GreenTheme As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_BlueTheme As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_OrangeTheme As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
