Imports VIBlend.Utilities

Public Class FavHistList

    'Structure de l'historique:         TITRE|URL|DATE|HEURE

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
        VButton1.RoundedCornersMask = CByte(VIBlend.Utilities.RoundedCornersMask.TOP_RIGHT Or RoundedCornersMask.BOTTOM_RIGHT Or RoundedCornersMask.TOP_LEFT Or RoundedCornersMask.BOTTOM_LEFT)
        VButton1.Theme = theme

        VButton2.StyleKey = "XinDarkBlue"
        VButton2.RoundedCornersMask = CByte(VIBlend.Utilities.RoundedCornersMask.TOP_LEFT Or RoundedCornersMask.BOTTOM_LEFT)
        VButton2.Theme = theme

        VButton3.StyleKey = "XinDarkBlue"
        VButton3.RoundedCornersMask = CByte(VIBlend.Utilities.RoundedCornersMask.TOP_RIGHT Or RoundedCornersMask.BOTTOM_RIGHT)
        VButton3.Theme = theme

        VButton4.StyleKey = "XinDarkBlue"
        VButton4.RoundedCornersMask = CByte(VIBlend.Utilities.RoundedCornersMask.TOP_RIGHT Or RoundedCornersMask.BOTTOM_RIGHT Or RoundedCornersMask.TOP_LEFT Or RoundedCornersMask.BOTTOM_LEFT)
        VButton4.Theme = theme
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
        VButton1.RoundedCornersMask = CByte(VIBlend.Utilities.RoundedCornersMask.TOP_RIGHT Or RoundedCornersMask.BOTTOM_RIGHT Or RoundedCornersMask.TOP_LEFT Or RoundedCornersMask.BOTTOM_LEFT)
        VButton1.Theme = theme

        VButton2.StyleKey = "XinDarkOrange"
        VButton2.RoundedCornersMask = CByte(VIBlend.Utilities.RoundedCornersMask.TOP_LEFT Or RoundedCornersMask.BOTTOM_LEFT)
        VButton2.Theme = theme

        VButton3.StyleKey = "XinDarkOrange"
        VButton3.RoundedCornersMask = CByte(VIBlend.Utilities.RoundedCornersMask.TOP_RIGHT Or RoundedCornersMask.BOTTOM_RIGHT)
        VButton3.Theme = theme

        VButton4.StyleKey = "XinDarkOrange"
        VButton4.RoundedCornersMask = CByte(VIBlend.Utilities.RoundedCornersMask.TOP_RIGHT Or RoundedCornersMask.BOTTOM_RIGHT Or RoundedCornersMask.TOP_LEFT Or RoundedCornersMask.BOTTOM_LEFT)
        VButton4.Theme = theme
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
        VButton1.RoundedCornersMask = CByte(VIBlend.Utilities.RoundedCornersMask.TOP_RIGHT Or RoundedCornersMask.BOTTOM_RIGHT Or RoundedCornersMask.TOP_LEFT Or RoundedCornersMask.BOTTOM_LEFT)
        VButton1.Theme = theme

        VButton2.StyleKey = "XinDarkGreen"
        VButton2.RoundedCornersMask = CByte(VIBlend.Utilities.RoundedCornersMask.TOP_LEFT Or RoundedCornersMask.BOTTOM_LEFT)
        VButton2.Theme = theme

        VButton3.StyleKey = "XinDarkGreen"
        VButton3.RoundedCornersMask = CByte(VIBlend.Utilities.RoundedCornersMask.TOP_RIGHT Or RoundedCornersMask.BOTTOM_RIGHT)
        VButton3.Theme = theme

        VButton4.StyleKey = "XinDarkGreen"
        VButton4.RoundedCornersMask = CByte(VIBlend.Utilities.RoundedCornersMask.TOP_RIGHT Or RoundedCornersMask.BOTTOM_RIGHT Or RoundedCornersMask.TOP_LEFT Or RoundedCornersMask.BOTTOM_LEFT)
        VButton4.Theme = theme
    End Sub

#End Region

    Public Function GetTargetPath(ByVal filename As String) As String
        Dim myObj As Object = CreateObject("WScript.Shell")
        Dim myShortcut As Object = myObj.CreateShortcut(filename)
        GetTargetPath = myShortcut.TargetPath
    End Function

    Private Function getAllFolders(ByVal directory As String) As String()
        Dim fi As New IO.DirectoryInfo(directory)
        'Mémorisation des emplacements
        Dim path() As String = {}
        'Boucle pour obtenir tous les sous-dossiers
        For Each subfolder As IO.DirectoryInfo In fi.GetDirectories()
            Array.Resize(path, path.Length + 1)
            path(path.Length - 1) = subfolder.FullName
            'Ajout des dossiers
            Dim myDirNode As New TreeNode
            myDirNode.Text = subfolder.Name
            myDirNode.Tag = subfolder.FullName & "|FOLDER"
            myDirNode.StateImageIndex = 2
            myDirNode.SelectedImageIndex = 3
            Dim newdi As New IO.DirectoryInfo(subfolder.FullName)
            For Each fil As IO.FileInfo In newdi.GetFiles("*.url")
                'Ajout des fichiers du dossier traité actuellement
                Dim myFileNode As New TreeNode
                myFileNode.Text = IO.Path.GetFileNameWithoutExtension(fil.Name)
                myFileNode.Tag = fil.FullName & "|" & GetTargetPath(fil.FullName)
                myFileNode.StateImageIndex = 4
                myFileNode.SelectedImageIndex = 4
                myDirNode.Nodes.Add(myFileNode)
            Next
            TreeView1.Nodes.Add(myDirNode)
            'On recommence la fonction jsuqu'au dernier sous-dossier
            For Each s As String In getAllFolders(subfolder.FullName)
                Array.Resize(path, path.Length + 1)
                path(path.Length - 1) = s
                'Ajout des dossiers
                Dim DirNode As New TreeNode
                DirNode.Text = IO.Path.GetFileNameWithoutExtension(s)
                DirNode.Tag = s & "|FOLDER"
                DirNode.StateImageIndex = 2
                DirNode.SelectedImageIndex = 3
                Dim newdi2 As New IO.DirectoryInfo(s)
                For Each fil As IO.FileInfo In newdi2.GetFiles("*.url")
                    'Ajout des fichiers du dossier traité actuellement
                    Dim myFileNode As New TreeNode
                    myFileNode.Text = IO.Path.GetFileNameWithoutExtension(fil.Name)
                    myFileNode.Tag = fil.FullName & "|" & GetTargetPath(fil.FullName)
                    myFileNode.StateImageIndex = 4
                    myFileNode.SelectedImageIndex = 4
                    DirNode.Nodes.Add(myFileNode)
                Next
                TreeView1.Nodes.Add(DirNode)
            Next
        Next
        Return path
    End Function


    Public Sub LoadFavourites()
        TreeView1.Nodes.Clear()
        Dim favpath As String = IO.Path.GetDirectoryName(Environment.GetFolderPath(Environment.SpecialFolder.Personal))
        favpath = IO.Path.Combine(favpath, "Favorites")
        If IO.Directory.Exists(favpath) Then
            Dim di As New IO.DirectoryInfo(favpath)
            'Ajout des fichiers du dossier initial
            For Each fi As IO.FileInfo In di.GetFiles("*.url")
                'Ajout des fichiers du dossier traité actuellement
                Dim myFileNode As New TreeNode
                myFileNode.Text = IO.Path.GetFileNameWithoutExtension(fi.Name)
                myFileNode.Tag = fi.FullName & "|" & GetTargetPath(fi.FullName)
                myFileNode.StateImageIndex = 4
                myFileNode.SelectedImageIndex = 4
                TreeView1.Nodes.Add(myFileNode)
            Next
            getAllFolders(favpath)
        Else
            IO.Directory.CreateDirectory(favpath)
        End If
    End Sub

    Public Sub LoadHistory()
        ListView1.Items.Clear()
        If Not My.Settings.History.Count = 0 Then
            For Each myHistItem As String In My.Settings.History
                Dim myArray As Array = Strings.Split(myHistItem, "|")
                'Structure de l'historique:         TITRE|URL|DATE|HEURE
                Dim lstitem As New ListViewItem
                lstitem.Tag = myHistItem
                lstitem.Text = myArray(0)
                lstitem.SubItems.Add(myArray(2) & " - " & myArray(3))
                ListView1.Items.Add(lstitem)
            Next
        End If
    End Sub

    Private Sub FavHistList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Mise en place du thème choisi par l'utilisateur
        If My.Settings.CurrentTheme = "xinbrowser" Then
            SetOrangeTheme()
        ElseIf My.Settings.CurrentTheme = "modern" Then
            SetBlueTheme()
        ElseIf My.Settings.CurrentTheme = "classic" Then
            SetGreenTheme()
        End If
        'Chargement des favoris
        LoadFavourites()
        'Chargement de l'historique
        LoadHistory()
    End Sub

    Private Sub VButton4_Click(sender As Object, e As EventArgs) Handles VButton4.Click
        Me.Visible = False
    End Sub

    Private Sub VButton2_Click(sender As Object, e As EventArgs) Handles VButton2.Click
        Dim favpath As String = IO.Path.GetDirectoryName(Environment.GetFolderPath(Environment.SpecialFolder.Personal))
        favpath = IO.Path.Combine(favpath, "Favorites")

        Dim dlg As New MsgEraseFavourites
        If dlg.ShowDialog = DialogResult.OK Then
            Select Case dlg.OptionChoosen
                Case "ExportFavourites"
                    Dim dlgs As New FolderBrowserDialog
                    dlgs.Description = "Choisir un emplacement où exporter les favoris"
                    If dlgs.ShowDialog = DialogResult.OK Then
                        If Not dlgs.SelectedPath = Nothing Then
                            My.Computer.FileSystem.CopyDirectory(favpath, dlgs.SelectedPath)
                        Else
                            MsgBox("Export impossible: L'emplacement est vide", MsgBoxStyle.Critical, "Erreur")
                        End If
                    End If
                    LoadFavourites()
                Case "ExportAndEraseFavourites"
                    Dim dlgs As New FolderBrowserDialog
                    dlgs.Description = "Choisir un emplacement où exporter les favoris"
                    If dlgs.ShowDialog = DialogResult.OK Then
                        If Not dlgs.SelectedPath = Nothing Then
                            My.Computer.FileSystem.CopyDirectory(favpath, dlgs.SelectedPath)
                            My.Computer.FileSystem.DeleteDirectory(favpath, FileIO.DeleteDirectoryOption.DeleteAllContents, FileIO.RecycleOption.SendToRecycleBin)
                            My.Computer.FileSystem.CreateDirectory(favpath)
                        Else
                            MsgBox("Export impossible: L'emplacement est vide", MsgBoxStyle.Critical, "Erreur")
                        End If
                    End If
                    LoadFavourites()
                Case "EraseFavourites"
                    For Each foundFile As String In My.Computer.FileSystem.GetFiles(favpath, Microsoft.VisualBasic.FileIO.SearchOption.SearchAllSubDirectories, "*.*")
                        My.Computer.FileSystem.DeleteFile(foundFile, Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.RecycleOption.DeletePermanently)
                    Next
                    For Each foundDirectory As String In My.Computer.FileSystem.GetDirectories(favpath, Microsoft.VisualBasic.FileIO.SearchOption.SearchAllSubDirectories, "*.*")
                        My.Computer.FileSystem.DeleteDirectory(foundDirectory, FileIO.DeleteDirectoryOption.DeleteAllContents)
                    Next
                    LoadFavourites()
            End Select
        End If
    End Sub

    Private Sub VButton3_Click(sender As Object, e As EventArgs) Handles VButton3.Click
        Dim dlg As New MsgEraseHistory
        If dlg.ShowDialog = DialogResult.OK Then
            Select Case dlg.OptionChoosen
                Case "DeleteHist_LessThanOneHour"
                    'Supprimer l'historique de - d'1h
                    For Each i As String In My.Settings.History
                        Dim myArray As Array = Strings.Split(i, "|")
                        'Structure de l'historique:         TITRE|URL|DATE|HEURE
                        Dim timeDif As Long = DateDiff(DateInterval.Hour, Date.Now, myArray(2) & " " & myArray(3))
                        If timeDif > 1 Then
                            My.Settings.History.Remove(i)
                            My.Settings.Save()
                        End If
                    Next
                    LoadHistory()
                Case "DeleteHist_OfThisDay"
                    'Supprimer l'historique de la journée
                    For Each i As String In My.Settings.History
                        Dim myArray As Array = Strings.Split(i, "|")
                        'Structure de l'historique:         TITRE|URL|DATE|HEURE
                        Dim timeDif As Long = DateDiff(DateInterval.Day, Date.Now, myArray(2) & " " & myArray(3))
                        If timeDif > 1 Then
                            My.Settings.History.Remove(i)
                            My.Settings.Save()
                        End If
                    Next
                    LoadHistory()
                Case "DeleteHist_All"
                    'Supprimer tout l'historique
                    My.Settings.History.Clear()
                    My.Settings.Save()
                    LoadHistory()
            End Select
        End If
    End Sub

    Private Sub OuvrirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OuvrirToolStripMenuItem1.Click
        Dim F1 As Form1 = CType(Me.ParentForm, Form1)
        Dim F2 As TabWebBrowser = CType(F1.TabControl1.SelectedForm, TabWebBrowser)
        Dim myArray As Array = Strings.Split(TreeView1.SelectedNode.Tag, "|")
        'Le numéro myArray(1) correspond à l'url tandis que le numéro myArray(0) correspond à l'emplacement du favori sur le pc
        F2.MyWebBrowser.Source = New Uri(myArray(1))
        Me.Visible = False
    End Sub

    Private Sub OuvrirDansUnNouvelOngletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OuvrirDansUnNouvelOngletToolStripMenuItem.Click
        Dim ntab As New TabWebBrowser
        Dim myArray As Array = Strings.Split(TreeView1.SelectedNode.Tag, "|")
        'Le numéro myArray(1) correspond à l'url tandis que le numéro myArray(0) correspond à l'emplacement du favori sur le pc
        ntab.LoadUrl(myArray(1))
        CType(Me.ParentForm, Form1).TabControl1.TabPages.Add(ntab)
        Me.Visible = False
    End Sub

    Private Sub OuvrirEnModenavigationPrivéeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OuvrirEnModenavigationPrivéeToolStripMenuItem.Click
        Dim ntab As New TabWebBrowser
        ntab.IsInPrivateNavigation = True
        Dim myArray As Array = Strings.Split(TreeView1.SelectedNode.Tag, "|")
        'Le numéro myArray(1) correspond à l'url tandis que le numéro myArray(0) correspond à l'emplacement du favori sur le pc
        ntab.LoadUrl(myArray(1))
        CType(Me.ParentForm, Form1).TabControl1.TabPages.Add(ntab)
        Me.Visible = False
    End Sub

    Private Sub CopierLadresseWebToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CopierLadresseWebToolStripMenuItem1.Click

    End Sub

    Private Sub ModifierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifierToolStripMenuItem.Click
        Dim favform As New AddRemoveFavForm
        favform.Text = "Modifier un favori"
        Dim myArray As Array = Strings.Split(TreeView1.SelectedNode.Tag, "|")
        'Le numéro myArray(1) correspond à l'url tandis que le numéro myArray(0) correspond à l'emplacement du favori sur le pc
        favform.SetFavInfo(TreeView1.SelectedNode.Text, myArray(1))
        If favform.ShowDialog = DialogResult.OK Then
            'Le favori a été modifié, on collecte les infos
            Dim ftitle As String = favform.TextBox1.Text
            Dim furl As String = favform.TextBox2.Text
            'On prend les infos de l'emplacement de l'ancien favori
            Dim fpath As String = IO.Path.GetDirectoryName(myArray(0))
            fpath = fpath & "\" & ftitle
            'On supprime l'ancien favori
            If IO.File.Exists(myArray(0)) Then
                'Suppression du fichier, du favori
                IO.File.Delete(myArray(0))
                TreeView1.Nodes.Remove(TreeView1.SelectedNode)
            Else
                'On supprime le favori de la liste car il n'a pas lieu d'être puis on rafraîchit la liste
                TreeView1.Nodes.Remove(TreeView1.SelectedNode)
            End If
            'Ajout du nouveau favori
            Dim myObj As Object = CreateObject("WScript.Shell")
            Dim myNewShortcut As Object = myObj.CreateShortcut(fpath & ".url")
            myNewShortcut.TargetPath = myArray(1)
            myNewShortcut.Save()
            My.Computer.FileSystem.WriteAllText(fpath & ".url", String.Format("[InternetShortcut]{0}URL={1}{0}", vbCrLf, myArray(1)), False)
            'On rafraîchit la liste
            LoadFavourites()
        ElseIf favform.ShowDialog = DialogResult.Cancel Then
            'Rien ne se passe, le favori ne doit pas être modifié
            favform.Close()
        End If
    End Sub

    Private Sub SupprimerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupprimerToolStripMenuItem.Click
        Dim dlg As MsgBoxResult = MsgBox("Voulez-vous vraiment le favori '" & TreeView1.SelectedNode.Text & "' de vos favoris ?", MsgBoxStyle.YesNo, "Supprimer un favori")
        If dlg = MsgBoxResult.Yes Then
            'On supprime le favori via le raccourci url dans le dossier favori
            Dim myArray As Array = Strings.Split(TreeView1.SelectedNode.Tag, "|")
            'Le numéro myArray(1) correspond à l'url tandis que le numéro myArray(0) correspond à l'emplacement du favori sur le pc
            Try
                If IO.File.Exists(myArray(0)) Then
                    'Suppression du fichier, du favori, on rafraîchit la liste
                    IO.File.Delete(myArray(0))
                    TreeView1.Nodes.Remove(TreeView1.SelectedNode)
                    LoadFavourites()
                Else
                    'Le fichier n'existe pas, on vérifie si c'est un dossier
                    If IO.Directory.Exists(myArray(0)) Then
                        IO.Directory.Delete(myArray(0))
                        TreeView1.Nodes.Remove(TreeView1.SelectedNode)
                        LoadFavourites()
                    Else
                        'On supprime le favori de la liste car il n'a pas lieu d'être puis on rafraîchit la liste
                        TreeView1.Nodes.Remove(TreeView1.SelectedNode)
                        LoadFavourites()
                    End If
                End If
            Catch ex As Exception
                'Ce n'est pas un fichier mais un dossier (en cas d'erreur)
                If IO.Directory.Exists(myArray(0)) Then
                    IO.Directory.Delete(myArray(0))
                    TreeView1.Nodes.Remove(TreeView1.SelectedNode)
                    LoadFavourites()
                Else
                    'On supprime le favori de la liste car il n'a pas lieu d'être puis on rafraîchit la liste
                    TreeView1.Nodes.Remove(TreeView1.SelectedNode)
                    LoadFavourites()
                End If
            End Try
        ElseIf dlg = MsgBoxResult.No Then
            'On ne supprime pas le favori, il ne se passe rien.
        End If
    End Sub

    Private Sub DévelopperLeDossierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DévelopperLeDossierToolStripMenuItem.Click
        TreeView1.SelectedNode.Expand()
    End Sub

    Private Sub ReplierLeDossierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReplierLeDossierToolStripMenuItem.Click
        TreeView1.SelectedNode.Collapse()
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        Dim myArray As Array = Strings.Split(TreeView1.SelectedNode.Tag, "|")
        'Le numéro myArray(1) correspond à l'url OU contient l'élément FOLDER (pour signaler que c'est un dossier) tandis que le numéro myArray(0) correspond à l'emplacement du favori sur le pc
        If myArray(1) = "FOLDER" Then
            'C'est un dossier
            OuvrirToolStripMenuItem.Visible = False
            CopierLadresseWebToolStripMenuItem1.Visible = False
            ToolStripSeparator1.Visible = False
            ModifierToolStripMenuItem.Visible = False
            SupprimerToolStripMenuItem.Visible = False
            ToolStripSeparator2.Visible = False
            DévelopperLeDossierToolStripMenuItem.Visible = True
            ReplierLeDossierToolStripMenuItem.Visible = True
            SupprimerLeDossierToolStripMenuItem.Visible = True
            ToolStripSeparator6.Visible = True
            AfficherLeDossierToolStripMenuItem.Visible = True
            AfficherLeFavoriToolStripMenuItem.Visible = False
        ElseIf myArray(1).Contains("ftp") Or myArray(1).Contains("http") Then
            'C'est un favori
            OuvrirToolStripMenuItem.Visible = True
            CopierLadresseWebToolStripMenuItem1.Visible = True
            ToolStripSeparator1.Visible = True
            ModifierToolStripMenuItem.Visible = True
            SupprimerToolStripMenuItem.Visible = True
            ToolStripSeparator2.Visible = False
            DévelopperLeDossierToolStripMenuItem.Visible = False
            ReplierLeDossierToolStripMenuItem.Visible = False
            SupprimerLeDossierToolStripMenuItem.Visible = False
            ToolStripSeparator6.Visible = True
            AfficherLeDossierToolStripMenuItem.Visible = False
            AfficherLeFavoriToolStripMenuItem.Visible = True
        Else
            'On n'affiche pas le menu contextuel
            e.Cancel = True
        End If
    End Sub

    Private Sub SupprimerLeDossierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupprimerLeDossierToolStripMenuItem.Click
        Dim dlg As MsgBoxResult = MsgBox("Voulez-vous supprimer ce dossier et tous les favoris et sous-dossiers qu'il comporte ?", MsgBoxStyle.YesNo, "Supprimer un dossier")
        If dlg = MsgBoxResult.Yes Then
            'On supprime tout le contenu du dossier et le dossier
            Dim myArray As Array = Strings.Split(TreeView1.SelectedNode.Tag, "|")
            My.Computer.FileSystem.DeleteDirectory(myArray(0), FileIO.DeleteDirectoryOption.DeleteAllContents)
        End If
        'On rafraîchit les favoris
        LoadFavourites()
    End Sub

    Private Sub TreeView1_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseDoubleClick
        Dim myArray As Array = Strings.Split(e.Node.Tag, "|")
        'Le numéro myArray(1) correspond à l'url OU contient l'élément FOLDER (pour signaler que c'est un dossier) tandis que le numéro myArray(0) correspond à l'emplacement du favori sur le pc
        If myArray(1) = "FOLDER" Then
            'C'est un dossier, la manipulation se fait automatiquement dans le contrôle TreeView
        ElseIf myArray(1).Contains("ftp") Or myArray(1).Contains("http") Then
            'C'est un favori
            OuvrirToolStripMenuItem1.PerformClick()
        End If
    End Sub

    Private Sub VButton1_Click(sender As Object, e As EventArgs) Handles VButton1.Click
        Dim favform As New AddRemoveFavForm
        favform.Text = "Ajouter un favori"
        Dim F1 As Form1 = CType(Me.ParentForm, Form1)
        Dim F2 As TabWebBrowser = CType(F1.TabControl1.SelectedForm, TabWebBrowser)
        favform.SetFavInfo(F2.MyWebBrowser.Title, F2.MyWebBrowser.Source.ToString)
        If favform.ShowDialog = DialogResult.OK Then
            'On ajoute le favori.
            Dim favpath As String = IO.Path.GetDirectoryName(Environment.GetFolderPath(Environment.SpecialFolder.Personal))
            favpath = IO.Path.Combine(favpath, "Favorites")
            Dim myObj As Object = CreateObject("WScript.Shell")
            Dim myNewShortcut As Object = myObj.CreateShortcut(favpath & "\" & favform.TextBox1.Text & ".url")
            myNewShortcut.TargetPath = favform.TextBox2.Text
            myNewShortcut.Save()
            My.Computer.FileSystem.WriteAllText(favpath & "\" & favform.TextBox1.Text & ".url", String.Format("[InternetShortcut]{0}URL={1}{0}", vbCrLf, favform.TextBox2.Text), False)
            'On rafraîchit la liste.
            LoadFavourites()
        End If
    End Sub

    Private Sub OuvrirToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles OuvrirToolStripMenuItem2.Click
        Dim theSegment As ListView.SelectedListViewItemCollection
        theSegment = ListView1.SelectedItems
        For Each item In theSegment
            Dim F1 As Form1 = CType(Me.ParentForm, Form1)
            Dim F2 As TabWebBrowser = CType(F1.TabControl1.SelectedForm, TabWebBrowser)
            Dim myArray As Array = Strings.Split(item.Tag, "|")
            F2.MyWebBrowser.Source = New Uri(myArray(1))
            Me.Visible = False
        Next
    End Sub

    Private Sub OuvrirDansUnNouvelOngletToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OuvrirDansUnNouvelOngletToolStripMenuItem1.Click
        Dim theSegment As ListView.SelectedListViewItemCollection
        theSegment = ListView1.SelectedItems
        For Each item In theSegment
            Dim ntab As New TabWebBrowser
            Dim myArray As Array = Strings.Split(item.Tag, "|")
            ntab.LoadUrl(myArray(1))
            CType(Me.ParentForm, Form1).TabControl1.TabPages.Add(ntab)
            Me.Visible = False
        Next
    End Sub

    Private Sub OuvrirEnNavigationPrivéeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OuvrirEnNavigationPrivéeToolStripMenuItem.Click
        Dim theSegment As ListView.SelectedListViewItemCollection
        theSegment = ListView1.SelectedItems
        For Each item In theSegment
            Dim ntab As New TabWebBrowser
            ntab.IsInPrivateNavigation = True
            Dim myArray As Array = Strings.Split(item.Tag, "|")
            ntab.LoadUrl(myArray(1))
            CType(Me.ParentForm, Form1).TabControl1.TabPages.Add(ntab)
            Me.Visible = False
        Next
    End Sub

    Private Sub CopierLeTitreDeLaPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopierLeTitreDeLaPageToolStripMenuItem.Click
        Dim myArray As Array = Strings.Split(ListView1.SelectedItems(0).Tag, "|")
        Clipboard.SetText(myArray(0))
    End Sub

    Private Sub CopierLadresseWebToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopierLadresseWebToolStripMenuItem.Click
        Dim myArray As Array = Strings.Split(ListView1.SelectedItems(0).Tag, "|")
        Clipboard.SetText(myArray(1))
    End Sub

    Private Sub SupprimerToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SupprimerToolStripMenuItem1.Click
        Dim totalcount As Integer = ListView1.SelectedItems.Count
        For it = 0 To totalcount
            'On supprime la sélection
            Try
                My.Settings.History.Remove(ListView1.SelectedItems(totalcount - it).Tag)
                My.Settings.Save()
                ListView1.Items.Remove(ListView1.SelectedItems(totalcount - it))
            Catch ex As Exception

            End Try
        Next
    End Sub

    Private Sub HistoryContextMenuStrip_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles HistoryContextMenuStrip.Opening
        If ListView1.SelectedItems.Count = 0 Then
            'Aucun item n'est sélectionné, on n'affiche pas le menu contextuel
            e.Cancel = True
        End If
    End Sub

    Private Sub ListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDoubleClick
        If Not ListView1.SelectedItems.Count = 0 Then
            'Au moins un item est sélectionné, on peut donc effectuer l'action
            Dim F1 As Form1 = CType(Me.ParentForm, Form1)
            Dim F2 As TabWebBrowser = CType(F1.TabControl1.SelectedForm, TabWebBrowser)
            Dim myArray As Array = Strings.Split(ListView1.SelectedItems(0).Tag, "|")
            F2.MyWebBrowser.Source = New Uri(myArray(1))
            Me.Visible = False
        End If
    End Sub

    Dim sortColumn As Integer = -1

    Private Sub ListView1_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles ListView1.ColumnClick
        If e.Column <> sortColumn Then
            ' Set the sort column to the new column.
            sortColumn = e.Column
            ' Set the sort order to ascending by default.
            ListView1.Sorting = SortOrder.Ascending
        Else
            ' Determine what the last sort order was and change it.
            If ListView1.Sorting = SortOrder.Ascending Then
                ListView1.Sorting = SortOrder.Descending
            Else
                ListView1.Sorting = SortOrder.Ascending
            End If
        End If
        ' Call the sort method to manually sort.
        ListView1.Sort()
        ' Set the ListViewItemSorter property to a new ListViewItemComparer
        ' object.
        ListView1.ListViewItemSorter = New ListViewItemComparer(e.Column, ListView1.Sorting)
    End Sub
End Class

Class ListViewItemComparer
    Implements IComparer
    Private col As Integer
    Private order As SortOrder

    Public Sub New()
        col = 0
        order = SortOrder.Ascending
    End Sub

    Public Sub New(column As Integer, order As SortOrder)
        col = column
        Me.order = order
    End Sub

    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare
        Dim returnVal As Integer
        ' Determine whether the type being compared is a date type.
        Try
            ' Parse the two objects passed as a parameter as a DateTime.
            Dim firstDate As System.DateTime = DateTime.Parse(CType(x,  _
                                    ListViewItem).SubItems(col).Text)
            Dim secondDate As System.DateTime = DateTime.Parse(CType(y,  _
                                      ListViewItem).SubItems(col).Text)
            ' Compare the two dates.
            returnVal = DateTime.Compare(firstDate, secondDate)
            ' If neither compared object has a valid date format, 
            ' compare as a string.
        Catch
            ' Compare the two items as a string.
            returnVal = [String].Compare(CType(x,  _
                              ListViewItem).SubItems(col).Text, CType(y, ListViewItem).SubItems(col).Text)
        End Try

        ' Determine whether the sort order is descending.
        If order = SortOrder.Descending Then
            ' Invert the value returned by String.Compare.
            returnVal *= -1
        End If
        Return returnVal
    End Function
End Class
