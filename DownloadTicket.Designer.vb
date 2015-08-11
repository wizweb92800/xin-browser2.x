<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DownloadTicket
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
        Me.Lbl_DownloadTitle = New System.Windows.Forms.Label()
        Me.Lbl_DownloadUrl = New System.Windows.Forms.LinkLabel()
        Me.Lbl_ProgressPercentage = New System.Windows.Forms.Label()
        Me.Lbl_DownloadSpeed = New System.Windows.Forms.Label()
        Me.Btn_Cancel = New System.Windows.Forms.Button()
        Me.DownloadProgressBar = New System.Windows.Forms.ProgressBar()
        Me.Btn_OpenFile = New System.Windows.Forms.Button()
        Me.Btn_OpenFolder = New System.Windows.Forms.Button()
        Me.Btn_DeleteFile = New System.Windows.Forms.Button()
        Me.FilePic = New System.Windows.Forms.PictureBox()
        Me.Btn_Retry = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Lbl_FileSizeToFileCompleteSize = New System.Windows.Forms.Label()
        Me.Lbl_TimeRemaining = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OuvrirLeFichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SupprimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RetirerDeLaListeDesTéléchargementsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RéessayerLeTéléchargementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OuvrirLemplacementDuFichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.FilePic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_DownloadTitle
        '
        Me.Lbl_DownloadTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_DownloadTitle.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Lbl_DownloadTitle.Location = New System.Drawing.Point(45, 6)
        Me.Lbl_DownloadTitle.Name = "Lbl_DownloadTitle"
        Me.Lbl_DownloadTitle.Size = New System.Drawing.Size(274, 15)
        Me.Lbl_DownloadTitle.TabIndex = 1
        Me.Lbl_DownloadTitle.Text = "Nom du téléchargement"
        '
        'Lbl_DownloadUrl
        '
        Me.Lbl_DownloadUrl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_DownloadUrl.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Lbl_DownloadUrl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_DownloadUrl.Location = New System.Drawing.Point(45, 24)
        Me.Lbl_DownloadUrl.Name = "Lbl_DownloadUrl"
        Me.Lbl_DownloadUrl.Size = New System.Drawing.Size(274, 15)
        Me.Lbl_DownloadUrl.TabIndex = 2
        Me.Lbl_DownloadUrl.TabStop = True
        Me.Lbl_DownloadUrl.Text = "http://www.emplacement.com/page/fichier.ext"
        '
        'Lbl_ProgressPercentage
        '
        Me.Lbl_ProgressPercentage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_ProgressPercentage.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_ProgressPercentage.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Lbl_ProgressPercentage.Location = New System.Drawing.Point(361, 3)
        Me.Lbl_ProgressPercentage.Name = "Lbl_ProgressPercentage"
        Me.Lbl_ProgressPercentage.Size = New System.Drawing.Size(42, 14)
        Me.Lbl_ProgressPercentage.TabIndex = 3
        Me.Lbl_ProgressPercentage.Text = "100%"
        Me.Lbl_ProgressPercentage.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Lbl_DownloadSpeed
        '
        Me.Lbl_DownloadSpeed.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_DownloadSpeed.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_DownloadSpeed.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Lbl_DownloadSpeed.Location = New System.Drawing.Point(324, 20)
        Me.Lbl_DownloadSpeed.Name = "Lbl_DownloadSpeed"
        Me.Lbl_DownloadSpeed.Size = New System.Drawing.Size(79, 14)
        Me.Lbl_DownloadSpeed.TabIndex = 4
        Me.Lbl_DownloadSpeed.Text = "900 ko/s"
        Me.Lbl_DownloadSpeed.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Btn_Cancel
        '
        Me.Btn_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cancel.Location = New System.Drawing.Point(2, 65)
        Me.Btn_Cancel.Name = "Btn_Cancel"
        Me.Btn_Cancel.Size = New System.Drawing.Size(75, 26)
        Me.Btn_Cancel.TabIndex = 5
        Me.Btn_Cancel.Text = "Annuler"
        Me.Btn_Cancel.UseVisualStyleBackColor = True
        '
        'DownloadProgressBar
        '
        Me.DownloadProgressBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DownloadProgressBar.Location = New System.Drawing.Point(86, 69)
        Me.DownloadProgressBar.Name = "DownloadProgressBar"
        Me.DownloadProgressBar.Size = New System.Drawing.Size(306, 18)
        Me.DownloadProgressBar.TabIndex = 6
        '
        'Btn_OpenFile
        '
        Me.Btn_OpenFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_OpenFile.Location = New System.Drawing.Point(325, 65)
        Me.Btn_OpenFile.Name = "Btn_OpenFile"
        Me.Btn_OpenFile.Size = New System.Drawing.Size(75, 26)
        Me.Btn_OpenFile.TabIndex = 7
        Me.Btn_OpenFile.Text = "Ouvrir"
        Me.Btn_OpenFile.UseVisualStyleBackColor = True
        Me.Btn_OpenFile.Visible = False
        '
        'Btn_OpenFolder
        '
        Me.Btn_OpenFolder.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_OpenFolder.Location = New System.Drawing.Point(187, 65)
        Me.Btn_OpenFolder.Name = "Btn_OpenFolder"
        Me.Btn_OpenFolder.Size = New System.Drawing.Size(138, 26)
        Me.Btn_OpenFolder.TabIndex = 8
        Me.Btn_OpenFolder.Text = "Ouvrir l'emplacement"
        Me.Btn_OpenFolder.UseVisualStyleBackColor = True
        Me.Btn_OpenFolder.Visible = False
        '
        'Btn_DeleteFile
        '
        Me.Btn_DeleteFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_DeleteFile.Location = New System.Drawing.Point(111, 65)
        Me.Btn_DeleteFile.Name = "Btn_DeleteFile"
        Me.Btn_DeleteFile.Size = New System.Drawing.Size(75, 26)
        Me.Btn_DeleteFile.TabIndex = 9
        Me.Btn_DeleteFile.Text = "Supprimer"
        Me.Btn_DeleteFile.UseVisualStyleBackColor = True
        Me.Btn_DeleteFile.Visible = False
        '
        'FilePic
        '
        Me.FilePic.ContextMenuStrip = Me.ContextMenuStrip1
        Me.FilePic.Location = New System.Drawing.Point(7, 7)
        Me.FilePic.Name = "FilePic"
        Me.FilePic.Size = New System.Drawing.Size(32, 32)
        Me.FilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.FilePic.TabIndex = 0
        Me.FilePic.TabStop = False
        '
        'Btn_Retry
        '
        Me.Btn_Retry.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Retry.Location = New System.Drawing.Point(3, 65)
        Me.Btn_Retry.Name = "Btn_Retry"
        Me.Btn_Retry.Size = New System.Drawing.Size(183, 26)
        Me.Btn_Retry.TabIndex = 10
        Me.Btn_Retry.Text = "Réessayer le téléchargement"
        Me.Btn_Retry.UseVisualStyleBackColor = True
        Me.Btn_Retry.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Lbl_FileSizeToFileCompleteSize
        '
        Me.Lbl_FileSizeToFileCompleteSize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_FileSizeToFileCompleteSize.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_FileSizeToFileCompleteSize.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Lbl_FileSizeToFileCompleteSize.Location = New System.Drawing.Point(259, 48)
        Me.Lbl_FileSizeToFileCompleteSize.Name = "Lbl_FileSizeToFileCompleteSize"
        Me.Lbl_FileSizeToFileCompleteSize.Size = New System.Drawing.Size(143, 14)
        Me.Lbl_FileSizeToFileCompleteSize.TabIndex = 11
        Me.Lbl_FileSizeToFileCompleteSize.Text = "0Mo/0Mo"
        Me.Lbl_FileSizeToFileCompleteSize.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Lbl_TimeRemaining
        '
        Me.Lbl_TimeRemaining.BackColor = System.Drawing.Color.DarkSalmon
        Me.Lbl_TimeRemaining.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Lbl_TimeRemaining.Location = New System.Drawing.Point(0, 48)
        Me.Lbl_TimeRemaining.Name = "Lbl_TimeRemaining"
        Me.Lbl_TimeRemaining.Size = New System.Drawing.Size(143, 14)
        Me.Lbl_TimeRemaining.TabIndex = 12
        Me.Lbl_TimeRemaining.Text = "0h Non prêt à l'utilisation"
        Me.Lbl_TimeRemaining.Visible = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OuvrirLeFichierToolStripMenuItem, Me.OuvrirLemplacementDuFichierToolStripMenuItem, Me.ToolStripSeparator1, Me.RéessayerLeTéléchargementToolStripMenuItem, Me.ToolStripSeparator2, Me.SupprimerToolStripMenuItem, Me.RetirerDeLaListeDesTéléchargementsToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(273, 148)
        '
        'OuvrirLeFichierToolStripMenuItem
        '
        Me.OuvrirLeFichierToolStripMenuItem.Enabled = False
        Me.OuvrirLeFichierToolStripMenuItem.Name = "OuvrirLeFichierToolStripMenuItem"
        Me.OuvrirLeFichierToolStripMenuItem.Size = New System.Drawing.Size(272, 22)
        Me.OuvrirLeFichierToolStripMenuItem.Text = "Ouvrir le fichier"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(269, 6)
        '
        'SupprimerToolStripMenuItem
        '
        Me.SupprimerToolStripMenuItem.Enabled = False
        Me.SupprimerToolStripMenuItem.Name = "SupprimerToolStripMenuItem"
        Me.SupprimerToolStripMenuItem.Size = New System.Drawing.Size(272, 22)
        Me.SupprimerToolStripMenuItem.Text = "Supprimer"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(269, 6)
        '
        'RetirerDeLaListeDesTéléchargementsToolStripMenuItem
        '
        Me.RetirerDeLaListeDesTéléchargementsToolStripMenuItem.Enabled = False
        Me.RetirerDeLaListeDesTéléchargementsToolStripMenuItem.Name = "RetirerDeLaListeDesTéléchargementsToolStripMenuItem"
        Me.RetirerDeLaListeDesTéléchargementsToolStripMenuItem.Size = New System.Drawing.Size(272, 22)
        Me.RetirerDeLaListeDesTéléchargementsToolStripMenuItem.Text = "Retirer de la liste des téléchargements"
        '
        'RéessayerLeTéléchargementToolStripMenuItem
        '
        Me.RéessayerLeTéléchargementToolStripMenuItem.Enabled = False
        Me.RéessayerLeTéléchargementToolStripMenuItem.Name = "RéessayerLeTéléchargementToolStripMenuItem"
        Me.RéessayerLeTéléchargementToolStripMenuItem.Size = New System.Drawing.Size(272, 22)
        Me.RéessayerLeTéléchargementToolStripMenuItem.Text = "Réessayer le téléchargement"
        '
        'OuvrirLemplacementDuFichierToolStripMenuItem
        '
        Me.OuvrirLemplacementDuFichierToolStripMenuItem.Enabled = False
        Me.OuvrirLemplacementDuFichierToolStripMenuItem.Name = "OuvrirLemplacementDuFichierToolStripMenuItem"
        Me.OuvrirLemplacementDuFichierToolStripMenuItem.Size = New System.Drawing.Size(272, 22)
        Me.OuvrirLemplacementDuFichierToolStripMenuItem.Text = "Ouvrir l'emplacement du fichier"
        '
        'DownloadTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.Lbl_TimeRemaining)
        Me.Controls.Add(Me.Lbl_FileSizeToFileCompleteSize)
        Me.Controls.Add(Me.Btn_Retry)
        Me.Controls.Add(Me.Btn_DeleteFile)
        Me.Controls.Add(Me.Btn_OpenFolder)
        Me.Controls.Add(Me.Btn_OpenFile)
        Me.Controls.Add(Me.DownloadProgressBar)
        Me.Controls.Add(Me.Btn_Cancel)
        Me.Controls.Add(Me.Lbl_DownloadSpeed)
        Me.Controls.Add(Me.Lbl_ProgressPercentage)
        Me.Controls.Add(Me.Lbl_DownloadUrl)
        Me.Controls.Add(Me.Lbl_DownloadTitle)
        Me.Controls.Add(Me.FilePic)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Name = "DownloadTicket"
        Me.Size = New System.Drawing.Size(402, 93)
        CType(Me.FilePic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FilePic As System.Windows.Forms.PictureBox
    Friend WithEvents Lbl_DownloadTitle As System.Windows.Forms.Label
    Friend WithEvents Lbl_DownloadUrl As System.Windows.Forms.LinkLabel
    Friend WithEvents Lbl_ProgressPercentage As System.Windows.Forms.Label
    Friend WithEvents Lbl_DownloadSpeed As System.Windows.Forms.Label
    Friend WithEvents Btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents DownloadProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents Btn_OpenFile As System.Windows.Forms.Button
    Friend WithEvents Btn_OpenFolder As System.Windows.Forms.Button
    Friend WithEvents Btn_DeleteFile As System.Windows.Forms.Button
    Friend WithEvents Btn_Retry As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Lbl_FileSizeToFileCompleteSize As System.Windows.Forms.Label
    Friend WithEvents Lbl_TimeRemaining As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OuvrirLeFichierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SupprimerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RetirerDeLaListeDesTéléchargementsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OuvrirLemplacementDuFichierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RéessayerLeTéléchargementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
