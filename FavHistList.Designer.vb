<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FavHistList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FavHistList))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OuvrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OuvrirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OuvrirDansUnNouvelOngletToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OuvrirEnModenavigationPrivéeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SupprimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DévelopperLeDossierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReplierLeDossierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerLeDossierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.AfficherLeDossierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AfficherLeFavoriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.HistoryContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopierLadresseWebToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OuvrirToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OuvrirDansUnNouvelOngletToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OuvrirEnNavigationPrivéeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CopierLeTitreDeLaPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopierLadresseWebToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.SupprimerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.VButton4 = New VIBlend.WinForms.Controls.vButton()
        Me.VButton3 = New VIBlend.WinForms.Controls.vButton()
        Me.VButton2 = New VIBlend.WinForms.Controls.vButton()
        Me.VButton1 = New VIBlend.WinForms.Controls.vButton()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.HistoryContextMenuStrip.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.ImageList = Me.ImageList1
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(300, 344)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TreeView1)
        Me.TabPage1.ImageIndex = 0
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(292, 316)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Favoris"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TreeView1
        '
        Me.TreeView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Location = New System.Drawing.Point(3, 3)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.ShowRootLines = False
        Me.TreeView1.Size = New System.Drawing.Size(286, 310)
        Me.TreeView1.StateImageList = Me.ImageList1
        Me.TreeView1.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OuvrirToolStripMenuItem, Me.ToolStripSeparator1, Me.SupprimerToolStripMenuItem, Me.ModifierToolStripMenuItem, Me.ToolStripSeparator2, Me.DévelopperLeDossierToolStripMenuItem, Me.ReplierLeDossierToolStripMenuItem, Me.SupprimerLeDossierToolStripMenuItem, Me.ToolStripSeparator6, Me.AfficherLeDossierToolStripMenuItem, Me.AfficherLeFavoriToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(187, 198)
        '
        'OuvrirToolStripMenuItem
        '
        Me.OuvrirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OuvrirToolStripMenuItem1, Me.OuvrirDansUnNouvelOngletToolStripMenuItem, Me.OuvrirEnModenavigationPrivéeToolStripMenuItem})
        Me.OuvrirToolStripMenuItem.Name = "OuvrirToolStripMenuItem"
        Me.OuvrirToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.OuvrirToolStripMenuItem.Text = "Ouvrir"
        '
        'OuvrirToolStripMenuItem1
        '
        Me.OuvrirToolStripMenuItem1.Name = "OuvrirToolStripMenuItem1"
        Me.OuvrirToolStripMenuItem1.Size = New System.Drawing.Size(257, 22)
        Me.OuvrirToolStripMenuItem1.Text = "Ouvrir"
        '
        'OuvrirDansUnNouvelOngletToolStripMenuItem
        '
        Me.OuvrirDansUnNouvelOngletToolStripMenuItem.Name = "OuvrirDansUnNouvelOngletToolStripMenuItem"
        Me.OuvrirDansUnNouvelOngletToolStripMenuItem.Size = New System.Drawing.Size(257, 22)
        Me.OuvrirDansUnNouvelOngletToolStripMenuItem.Text = "Ouvrir dans un nouvel onglet"
        '
        'OuvrirEnModenavigationPrivéeToolStripMenuItem
        '
        Me.OuvrirEnModenavigationPrivéeToolStripMenuItem.Name = "OuvrirEnModenavigationPrivéeToolStripMenuItem"
        Me.OuvrirEnModenavigationPrivéeToolStripMenuItem.Size = New System.Drawing.Size(257, 22)
        Me.OuvrirEnModenavigationPrivéeToolStripMenuItem.Text = "Ouvrir en mode 'navigation privée'"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(183, 6)
        '
        'SupprimerToolStripMenuItem
        '
        Me.SupprimerToolStripMenuItem.Name = "SupprimerToolStripMenuItem"
        Me.SupprimerToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.SupprimerToolStripMenuItem.Text = "Supprimer"
        '
        'ModifierToolStripMenuItem
        '
        Me.ModifierToolStripMenuItem.Name = "ModifierToolStripMenuItem"
        Me.ModifierToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ModifierToolStripMenuItem.Text = "Modifier..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(183, 6)
        '
        'DévelopperLeDossierToolStripMenuItem
        '
        Me.DévelopperLeDossierToolStripMenuItem.Name = "DévelopperLeDossierToolStripMenuItem"
        Me.DévelopperLeDossierToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.DévelopperLeDossierToolStripMenuItem.Text = "Développer le dossier"
        '
        'ReplierLeDossierToolStripMenuItem
        '
        Me.ReplierLeDossierToolStripMenuItem.Name = "ReplierLeDossierToolStripMenuItem"
        Me.ReplierLeDossierToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ReplierLeDossierToolStripMenuItem.Text = "Replier le dossier"
        '
        'SupprimerLeDossierToolStripMenuItem
        '
        Me.SupprimerLeDossierToolStripMenuItem.Name = "SupprimerLeDossierToolStripMenuItem"
        Me.SupprimerLeDossierToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.SupprimerLeDossierToolStripMenuItem.Text = "Supprimer le dossier"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(183, 6)
        '
        'AfficherLeDossierToolStripMenuItem
        '
        Me.AfficherLeDossierToolStripMenuItem.Name = "AfficherLeDossierToolStripMenuItem"
        Me.AfficherLeDossierToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.AfficherLeDossierToolStripMenuItem.Text = "Afficher le dossier"
        '
        'AfficherLeFavoriToolStripMenuItem
        '
        Me.AfficherLeFavoriToolStripMenuItem.Name = "AfficherLeFavoriToolStripMenuItem"
        Me.AfficherLeFavoriToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.AfficherLeFavoriToolStripMenuItem.Text = "Afficher le favori"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "win_favourites_x16.png")
        Me.ImageList1.Images.SetKeyName(1, "win_folderhistory_close_16x16.png")
        Me.ImageList1.Images.SetKeyName(2, "win_close_x16.png")
        Me.ImageList1.Images.SetKeyName(3, "win_open_x16.png")
        Me.ImageList1.Images.SetKeyName(4, "win_web_x16.png")
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ListView1)
        Me.TabPage2.ImageIndex = 1
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(292, 316)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Historique"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.ContextMenuStrip = Me.HistoryContextMenuStrip
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(3, 3)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(286, 310)
        Me.ListView1.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Titre de la page"
        Me.ColumnHeader1.Width = 171
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Heure & Date"
        Me.ColumnHeader2.Width = 111
        '
        'HistoryContextMenuStrip
        '
        Me.HistoryContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopierLadresseWebToolStripMenuItem1, Me.OuvrirToolStripMenuItem2, Me.OuvrirDansUnNouvelOngletToolStripMenuItem1, Me.OuvrirEnNavigationPrivéeToolStripMenuItem, Me.ToolStripSeparator3, Me.CopierLeTitreDeLaPageToolStripMenuItem, Me.CopierLadresseWebToolStripMenuItem, Me.ToolStripSeparator5, Me.SupprimerToolStripMenuItem1})
        Me.HistoryContextMenuStrip.Name = "HistoryContextMenuStrip"
        Me.HistoryContextMenuStrip.Size = New System.Drawing.Size(229, 170)
        '
        'CopierLadresseWebToolStripMenuItem1
        '
        Me.CopierLadresseWebToolStripMenuItem1.Name = "CopierLadresseWebToolStripMenuItem1"
        Me.CopierLadresseWebToolStripMenuItem1.Size = New System.Drawing.Size(228, 22)
        Me.CopierLadresseWebToolStripMenuItem1.Text = "Copier l'adresse web"
        '
        'OuvrirToolStripMenuItem2
        '
        Me.OuvrirToolStripMenuItem2.Name = "OuvrirToolStripMenuItem2"
        Me.OuvrirToolStripMenuItem2.Size = New System.Drawing.Size(228, 22)
        Me.OuvrirToolStripMenuItem2.Text = "Ouvrir"
        '
        'OuvrirDansUnNouvelOngletToolStripMenuItem1
        '
        Me.OuvrirDansUnNouvelOngletToolStripMenuItem1.Name = "OuvrirDansUnNouvelOngletToolStripMenuItem1"
        Me.OuvrirDansUnNouvelOngletToolStripMenuItem1.Size = New System.Drawing.Size(228, 22)
        Me.OuvrirDansUnNouvelOngletToolStripMenuItem1.Text = "Ouvrir dans un nouvel onglet"
        '
        'OuvrirEnNavigationPrivéeToolStripMenuItem
        '
        Me.OuvrirEnNavigationPrivéeToolStripMenuItem.Name = "OuvrirEnNavigationPrivéeToolStripMenuItem"
        Me.OuvrirEnNavigationPrivéeToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.OuvrirEnNavigationPrivéeToolStripMenuItem.Text = "Ouvrir en navigation privée"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(225, 6)
        '
        'CopierLeTitreDeLaPageToolStripMenuItem
        '
        Me.CopierLeTitreDeLaPageToolStripMenuItem.Name = "CopierLeTitreDeLaPageToolStripMenuItem"
        Me.CopierLeTitreDeLaPageToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.CopierLeTitreDeLaPageToolStripMenuItem.Text = "Copier le titre de la page"
        '
        'CopierLadresseWebToolStripMenuItem
        '
        Me.CopierLadresseWebToolStripMenuItem.Name = "CopierLadresseWebToolStripMenuItem"
        Me.CopierLadresseWebToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.CopierLadresseWebToolStripMenuItem.Text = "Copier l'adresse web"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(225, 6)
        '
        'SupprimerToolStripMenuItem1
        '
        Me.SupprimerToolStripMenuItem1.Name = "SupprimerToolStripMenuItem1"
        Me.SupprimerToolStripMenuItem1.Size = New System.Drawing.Size(228, 22)
        Me.SupprimerToolStripMenuItem1.Text = "Supprimer"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.VButton4)
        Me.Panel1.Controls.Add(Me.VButton3)
        Me.Panel1.Controls.Add(Me.VButton2)
        Me.Panel1.Controls.Add(Me.VButton1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 344)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(300, 56)
        Me.Panel1.TabIndex = 0
        '
        'VButton4
        '
        Me.VButton4.AllowAnimations = True
        Me.VButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VButton4.BackColor = System.Drawing.Color.Transparent
        Me.VButton4.Image = CType(resources.GetObject("VButton4.Image"), System.Drawing.Image)
        Me.VButton4.Location = New System.Drawing.Point(202, 29)
        Me.VButton4.Name = "VButton4"
        Me.VButton4.RoundedCornersMask = CType(15, Byte)
        Me.VButton4.Size = New System.Drawing.Size(91, 23)
        Me.VButton4.TabIndex = 4
        Me.VButton4.Text = "Fermer"
        Me.VButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.VButton4.UseVisualStyleBackColor = False
        Me.VButton4.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.BLUEBLEND
        '
        'VButton3
        '
        Me.VButton3.AllowAnimations = True
        Me.VButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.VButton3.BackColor = System.Drawing.Color.Transparent
        Me.VButton3.Image = CType(resources.GetObject("VButton3.Image"), System.Drawing.Image)
        Me.VButton3.Location = New System.Drawing.Point(94, 29)
        Me.VButton3.Name = "VButton3"
        Me.VButton3.RoundedCornersMask = CType(15, Byte)
        Me.VButton3.Size = New System.Drawing.Size(91, 23)
        Me.VButton3.TabIndex = 3
        Me.VButton3.Text = "Vider l'"
        Me.VButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.VButton3.UseVisualStyleBackColor = False
        Me.VButton3.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.BLUEBLEND
        '
        'VButton2
        '
        Me.VButton2.AllowAnimations = True
        Me.VButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.VButton2.BackColor = System.Drawing.Color.Transparent
        Me.VButton2.Image = CType(resources.GetObject("VButton2.Image"), System.Drawing.Image)
        Me.VButton2.Location = New System.Drawing.Point(4, 29)
        Me.VButton2.Name = "VButton2"
        Me.VButton2.RoundedCornersMask = CType(15, Byte)
        Me.VButton2.Size = New System.Drawing.Size(91, 23)
        Me.VButton2.TabIndex = 2
        Me.VButton2.Text = "Vider les "
        Me.VButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.VButton2.UseVisualStyleBackColor = False
        Me.VButton2.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.BLUEBLEND
        '
        'VButton1
        '
        Me.VButton1.AllowAnimations = True
        Me.VButton1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VButton1.BackColor = System.Drawing.Color.Transparent
        Me.VButton1.Image = CType(resources.GetObject("VButton1.Image"), System.Drawing.Image)
        Me.VButton1.Location = New System.Drawing.Point(4, 4)
        Me.VButton1.Name = "VButton1"
        Me.VButton1.RoundedCornersMask = CType(15, Byte)
        Me.VButton1.Size = New System.Drawing.Size(289, 23)
        Me.VButton1.TabIndex = 1
        Me.VButton1.Text = "Ajouter la page courante aux favoris"
        Me.VButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.VButton1.UseVisualStyleBackColor = False
        Me.VButton1.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.BLUEBLEND
        '
        'FavHistList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Name = "FavHistList"
        Me.Size = New System.Drawing.Size(300, 400)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.HistoryContextMenuStrip.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents VButton1 As VIBlend.WinForms.Controls.vButton
    Friend WithEvents VButton4 As VIBlend.WinForms.Controls.vButton
    Friend WithEvents VButton3 As VIBlend.WinForms.Controls.vButton
    Friend WithEvents VButton2 As VIBlend.WinForms.Controls.vButton
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OuvrirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OuvrirToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OuvrirDansUnNouvelOngletToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OuvrirEnModenavigationPrivéeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ModifierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupprimerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DévelopperLeDossierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReplierLeDossierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupprimerLeDossierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents HistoryContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OuvrirToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OuvrirDansUnNouvelOngletToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OuvrirEnNavigationPrivéeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CopierLeTitreDeLaPageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopierLadresseWebToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupprimerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AfficherLeDossierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AfficherLeFavoriToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopierLadresseWebToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
