<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.AddFiles = New System.ComponentModel.BackgroundWorker()
        Me.ElementsPanel = New System.Windows.Forms.Panel()
        Me.ExplorerOptions = New Guna.UI.WinForms.GunaContextMenuStrip()
        Me.cxtNewFolder = New System.Windows.Forms.ToolStripMenuItem()
        Me.cxtOpenExplorer = New System.Windows.Forms.ToolStripMenuItem()
        Me.cxtUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.HomeScrollBars = New Guna.UI.WinForms.GunaVScrollBar()
        Me.ChangeLocationPanel = New System.Windows.Forms.Panel()
        Me.btnAbort = New Guna.UI.WinForms.GunaGradientButton()
        Me.btnConfirm = New Guna.UI.WinForms.GunaGradientButton()
        Me.lblConfirmMoveOrCopy = New System.Windows.Forms.Label()
        Me.NavBar = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.DirectoryLabel = New System.Windows.Forms.Label()
        Me.HamburgerMenu = New Guna.UI.WinForms.GunaContextMenuStrip()
        Me.menuOpenSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuSync = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuCompany = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuManage = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuInfoAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrUpdateData = New System.Windows.Forms.Timer(Me.components)
        Me.FileEdit = New System.ComponentModel.BackgroundWorker()
        Me.NavBarSettings = New System.Windows.Forms.PictureBox()
        Me.goBack = New System.Windows.Forms.PictureBox()
        Me.ExplorerOptions.SuspendLayout()
        Me.ChangeLocationPanel.SuspendLayout()
        Me.NavBar.SuspendLayout()
        Me.HamburgerMenu.SuspendLayout()
        CType(Me.NavBarSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.goBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AddFiles
        '
        '
        'ElementsPanel
        '
        Me.ElementsPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ElementsPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ElementsPanel.ContextMenuStrip = Me.ExplorerOptions
        Me.ElementsPanel.Location = New System.Drawing.Point(0, 50)
        Me.ElementsPanel.Name = "ElementsPanel"
        Me.ElementsPanel.Size = New System.Drawing.Size(890, 400)
        Me.ElementsPanel.TabIndex = 11
        '
        'ExplorerOptions
        '
        Me.ExplorerOptions.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ExplorerOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ExplorerOptions.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ExplorerOptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cxtNewFolder, Me.cxtOpenExplorer, Me.cxtUpdate})
        Me.ExplorerOptions.Name = "contextMenu"
        Me.ExplorerOptions.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExplorerOptions.RenderStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ExplorerOptions.RenderStyle.ColorTable = Nothing
        Me.ExplorerOptions.RenderStyle.RoundedEdges = True
        Me.ExplorerOptions.RenderStyle.SelectionArrowColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ExplorerOptions.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ExplorerOptions.RenderStyle.SelectionForeColor = System.Drawing.Color.LightGray
        Me.ExplorerOptions.RenderStyle.SeparatorColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ExplorerOptions.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault
        Me.ExplorerOptions.Size = New System.Drawing.Size(173, 118)
        '
        'cxtNewFolder
        '
        Me.cxtNewFolder.AutoSize = False
        Me.cxtNewFolder.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.cxtNewFolder.ForeColor = System.Drawing.Color.LightGray
        Me.cxtNewFolder.Name = "cxtNewFolder"
        Me.cxtNewFolder.Size = New System.Drawing.Size(220, 38)
        Me.cxtNewFolder.Text = "Nuova cartella"
        '
        'cxtOpenExplorer
        '
        Me.cxtOpenExplorer.AutoSize = False
        Me.cxtOpenExplorer.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.cxtOpenExplorer.ForeColor = System.Drawing.Color.LightGray
        Me.cxtOpenExplorer.Name = "cxtOpenExplorer"
        Me.cxtOpenExplorer.Size = New System.Drawing.Size(220, 38)
        Me.cxtOpenExplorer.Text = "Apri explorer"
        '
        'cxtUpdate
        '
        Me.cxtUpdate.AutoSize = False
        Me.cxtUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.cxtUpdate.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.cxtUpdate.ForeColor = System.Drawing.Color.LightGray
        Me.cxtUpdate.Name = "cxtUpdate"
        Me.cxtUpdate.Size = New System.Drawing.Size(250, 38)
        Me.cxtUpdate.Text = "Aggiorna"
        '
        'HomeScrollBars
        '
        Me.HomeScrollBars.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HomeScrollBars.BackColor = System.Drawing.Color.Transparent
        Me.HomeScrollBars.LargeChange = 10
        Me.HomeScrollBars.Location = New System.Drawing.Point(890, 50)
        Me.HomeScrollBars.Maximum = 100
        Me.HomeScrollBars.Name = "HomeScrollBars"
        Me.HomeScrollBars.Radius = 3
        Me.HomeScrollBars.ScrollIdleColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.HomeScrollBars.Size = New System.Drawing.Size(10, 380)
        Me.HomeScrollBars.TabIndex = 3
        Me.HomeScrollBars.ThumbColor = System.Drawing.Color.Silver
        Me.HomeScrollBars.ThumbHoverColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.HomeScrollBars.ThumbPressedColor = System.Drawing.Color.Gainsboro
        '
        'ChangeLocationPanel
        '
        Me.ChangeLocationPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChangeLocationPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ChangeLocationPanel.Controls.Add(Me.btnAbort)
        Me.ChangeLocationPanel.Controls.Add(Me.btnConfirm)
        Me.ChangeLocationPanel.Controls.Add(Me.lblConfirmMoveOrCopy)
        Me.ChangeLocationPanel.Location = New System.Drawing.Point(0, 360)
        Me.ChangeLocationPanel.Name = "ChangeLocationPanel"
        Me.ChangeLocationPanel.Size = New System.Drawing.Size(900, 90)
        Me.ChangeLocationPanel.TabIndex = 13
        Me.ChangeLocationPanel.Visible = False
        '
        'btnAbort
        '
        Me.btnAbort.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAbort.Animated = True
        Me.btnAbort.AnimationHoverSpeed = 0.07!
        Me.btnAbort.AnimationSpeed = 0.03!
        Me.btnAbort.BackColor = System.Drawing.Color.Transparent
        Me.btnAbort.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnAbort.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnAbort.BorderColor = System.Drawing.Color.Black
        Me.btnAbort.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAbort.FocusedColor = System.Drawing.Color.Empty
        Me.btnAbort.Font = New System.Drawing.Font("DM Sans", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbort.ForeColor = System.Drawing.Color.LightGray
        Me.btnAbort.Image = Nothing
        Me.btnAbort.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAbort.Location = New System.Drawing.Point(257, 44)
        Me.btnAbort.Name = "btnAbort"
        Me.btnAbort.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.btnAbort.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.btnAbort.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnAbort.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAbort.OnHoverImage = Nothing
        Me.btnAbort.OnPressedColor = System.Drawing.Color.Black
        Me.btnAbort.Radius = 2
        Me.btnAbort.Size = New System.Drawing.Size(170, 30)
        Me.btnAbort.TabIndex = 18
        Me.btnAbort.Text = "Annulla"
        Me.btnAbort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnConfirm
        '
        Me.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnConfirm.Animated = True
        Me.btnConfirm.AnimationHoverSpeed = 0.07!
        Me.btnConfirm.AnimationSpeed = 0.03!
        Me.btnConfirm.BackColor = System.Drawing.Color.Transparent
        Me.btnConfirm.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnConfirm.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnConfirm.BorderColor = System.Drawing.Color.Black
        Me.btnConfirm.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnConfirm.FocusedColor = System.Drawing.Color.Empty
        Me.btnConfirm.Font = New System.Drawing.Font("DM Sans", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnConfirm.Image = Nothing
        Me.btnConfirm.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnConfirm.Location = New System.Drawing.Point(460, 44)
        Me.btnConfirm.Margin = New System.Windows.Forms.Padding(60, 3, 3, 3)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnConfirm.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnConfirm.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnConfirm.OnHoverForeColor = System.Drawing.Color.White
        Me.btnConfirm.OnHoverImage = Nothing
        Me.btnConfirm.OnPressedColor = System.Drawing.Color.Black
        Me.btnConfirm.Radius = 2
        Me.btnConfirm.Size = New System.Drawing.Size(170, 30)
        Me.btnConfirm.TabIndex = 17
        Me.btnConfirm.Text = "Conferma"
        Me.btnConfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblConfirmMoveOrCopy
        '
        Me.lblConfirmMoveOrCopy.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblConfirmMoveOrCopy.Font = New System.Drawing.Font("DM Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmMoveOrCopy.ForeColor = System.Drawing.Color.LightGray
        Me.lblConfirmMoveOrCopy.Location = New System.Drawing.Point(10, 10)
        Me.lblConfirmMoveOrCopy.Name = "lblConfirmMoveOrCopy"
        Me.lblConfirmMoveOrCopy.Size = New System.Drawing.Size(880, 24)
        Me.lblConfirmMoveOrCopy.TabIndex = 3
        Me.lblConfirmMoveOrCopy.Text = "Entra nella cartella dove vuoi trasferire il file"
        Me.lblConfirmMoveOrCopy.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'NavBar
        '
        Me.NavBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.NavBar.Controls.Add(Me.FlowLayoutPanel1)
        Me.NavBar.Controls.Add(Me.DirectoryLabel)
        Me.NavBar.Controls.Add(Me.NavBarSettings)
        Me.NavBar.Controls.Add(Me.goBack)
        Me.NavBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.NavBar.Location = New System.Drawing.Point(0, 0)
        Me.NavBar.Name = "NavBar"
        Me.NavBar.Size = New System.Drawing.Size(900, 45)
        Me.NavBar.TabIndex = 14
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(822, 9)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(66, 24)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'DirectoryLabel
        '
        Me.DirectoryLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DirectoryLabel.Font = New System.Drawing.Font("DM Sans", 9.5!)
        Me.DirectoryLabel.ForeColor = System.Drawing.Color.LightGray
        Me.DirectoryLabel.Location = New System.Drawing.Point(95, 9)
        Me.DirectoryLabel.Name = "DirectoryLabel"
        Me.DirectoryLabel.Size = New System.Drawing.Size(795, 26)
        Me.DirectoryLabel.TabIndex = 19
        Me.DirectoryLabel.Text = "Benvenuto in Strongchest"
        Me.DirectoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HamburgerMenu
        '
        Me.HamburgerMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.HamburgerMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HamburgerMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.HamburgerMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuOpenSettings, Me.menuSync, Me.menuCompany, Me.menuManage, Me.menuInfoAbout})
        Me.HamburgerMenu.Name = "contextMenu"
        Me.HamburgerMenu.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.HamburgerMenu.RenderStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.HamburgerMenu.RenderStyle.ColorTable = Nothing
        Me.HamburgerMenu.RenderStyle.RoundedEdges = True
        Me.HamburgerMenu.RenderStyle.SelectionArrowColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.HamburgerMenu.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.HamburgerMenu.RenderStyle.SelectionForeColor = System.Drawing.Color.LightGray
        Me.HamburgerMenu.RenderStyle.SeparatorColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.HamburgerMenu.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault
        Me.HamburgerMenu.Size = New System.Drawing.Size(188, 194)
        '
        'menuOpenSettings
        '
        Me.menuOpenSettings.AutoSize = False
        Me.menuOpenSettings.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.menuOpenSettings.ForeColor = System.Drawing.Color.LightGray
        Me.menuOpenSettings.Name = "menuOpenSettings"
        Me.menuOpenSettings.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.menuOpenSettings.ShowShortcutKeys = False
        Me.menuOpenSettings.Size = New System.Drawing.Size(180, 38)
        Me.menuOpenSettings.Text = "Impostazioni"
        '
        'menuSync
        '
        Me.menuSync.AutoSize = False
        Me.menuSync.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.menuSync.ForeColor = System.Drawing.Color.White
        Me.menuSync.Name = "menuSync"
        Me.menuSync.Size = New System.Drawing.Size(180, 38)
        Me.menuSync.Text = "Sincronizzazione"
        '
        'menuCompany
        '
        Me.menuCompany.AutoSize = False
        Me.menuCompany.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.menuCompany.ForeColor = System.Drawing.Color.White
        Me.menuCompany.Name = "menuCompany"
        Me.menuCompany.Size = New System.Drawing.Size(180, 38)
        Me.menuCompany.Text = "Info sull'Azienda"
        '
        'menuManage
        '
        Me.menuManage.AutoSize = False
        Me.menuManage.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.menuManage.ForeColor = System.Drawing.Color.White
        Me.menuManage.Name = "menuManage"
        Me.menuManage.Size = New System.Drawing.Size(180, 38)
        Me.menuManage.Text = "Gestisci spazio"
        '
        'menuInfoAbout
        '
        Me.menuInfoAbout.AutoSize = False
        Me.menuInfoAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.menuInfoAbout.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.menuInfoAbout.ForeColor = System.Drawing.Color.LightGray
        Me.menuInfoAbout.Name = "menuInfoAbout"
        Me.menuInfoAbout.ShowShortcutKeys = False
        Me.menuInfoAbout.Size = New System.Drawing.Size(180, 38)
        Me.menuInfoAbout.Text = "Informazioni"
        '
        'tmrUpdateData
        '
        '
        'FileEdit
        '
        '
        'NavBarSettings
        '
        Me.NavBarSettings.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.NavBarSettings.Image = Global.Strongchest.My.Resources.Resources.ui_settings
        Me.NavBarSettings.Location = New System.Drawing.Point(60, 9)
        Me.NavBarSettings.Margin = New System.Windows.Forms.Padding(10)
        Me.NavBarSettings.Name = "NavBarSettings"
        Me.NavBarSettings.Size = New System.Drawing.Size(22, 26)
        Me.NavBarSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.NavBarSettings.TabIndex = 4
        Me.NavBarSettings.TabStop = False
        '
        'goBack
        '
        Me.goBack.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.goBack.Image = Global.Strongchest.My.Resources.Resources.ui_return
        Me.goBack.Location = New System.Drawing.Point(25, 9)
        Me.goBack.Name = "goBack"
        Me.goBack.Size = New System.Drawing.Size(22, 26)
        Me.goBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.goBack.TabIndex = 3
        Me.goBack.TabStop = False
        '
        'Home
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(900, 450)
        Me.Controls.Add(Me.ChangeLocationPanel)
        Me.Controls.Add(Me.ElementsPanel)
        Me.Controls.Add(Me.HomeScrollBars)
        Me.Controls.Add(Me.NavBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HomeForm"
        Me.ExplorerOptions.ResumeLayout(False)
        Me.ChangeLocationPanel.ResumeLayout(False)
        Me.NavBar.ResumeLayout(False)
        Me.HamburgerMenu.ResumeLayout(False)
        CType(Me.NavBarSettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.goBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AddFiles As System.ComponentModel.BackgroundWorker
    Friend WithEvents ElementsPanel As Panel
    Friend WithEvents HomeScrollBars As Guna.UI.WinForms.GunaVScrollBar
    Friend WithEvents ExplorerOptions As Guna.UI.WinForms.GunaContextMenuStrip
    Friend WithEvents cxtNewFolder As ToolStripMenuItem
    Friend WithEvents cxtOpenExplorer As ToolStripMenuItem
    Friend WithEvents cxtUpdate As ToolStripMenuItem
    Friend WithEvents ChangeLocationPanel As Panel
    Friend WithEvents lblConfirmMoveOrCopy As Label
    Friend WithEvents btnAbort As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents btnConfirm As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents goBack As PictureBox
    Friend WithEvents NavBar As Panel
    Friend WithEvents NavBarSettings As PictureBox
    Friend WithEvents HamburgerMenu As Guna.UI.WinForms.GunaContextMenuStrip
    Friend WithEvents menuOpenSettings As ToolStripMenuItem
    Friend WithEvents menuInfoAbout As ToolStripMenuItem
    Friend WithEvents tmrUpdateData As Timer
    Friend WithEvents menuManage As ToolStripMenuItem
    Friend WithEvents FileEdit As System.ComponentModel.BackgroundWorker
    Friend WithEvents DirectoryLabel As Label
    Friend WithEvents menuSync As ToolStripMenuItem
    Friend WithEvents menuCompany As ToolStripMenuItem
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
