<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Element
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.prDisplayName = New System.Windows.Forms.Label()
        Me.prSize = New System.Windows.Forms.Label()
        Me.prLastModify = New System.Windows.Forms.Label()
        Me.OpenFile = New System.ComponentModel.BackgroundWorker()
        Me.RightClick = New Guna.UI.WinForms.GunaContextMenuStrip()
        Me.cxtOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.cxtDeleteElement = New System.Windows.Forms.ToolStripMenuItem()
        Me.cxtRename = New System.Windows.Forms.ToolStripMenuItem()
        Me.cxtMove = New System.Windows.Forms.ToolStripMenuItem()
        Me.cxtExport = New System.Windows.Forms.ToolStripMenuItem()
        Me.cxtCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.Export_SelectLocation = New System.Windows.Forms.SaveFileDialog()
        Me.Export = New System.ComponentModel.BackgroundWorker()
        Me.ProgressBar = New Guna.UI.WinForms.GunaCircleProgressBar()
        Me.pctPictureIcon = New System.Windows.Forms.PictureBox()
        Me.RightClick.SuspendLayout()
        CType(Me.pctPictureIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'prDisplayName
        '
        Me.prDisplayName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.prDisplayName.Font = New System.Drawing.Font("DM Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prDisplayName.ForeColor = System.Drawing.Color.LightGray
        Me.prDisplayName.Location = New System.Drawing.Point(70, 0)
        Me.prDisplayName.Name = "prDisplayName"
        Me.prDisplayName.Size = New System.Drawing.Size(358, 42)
        Me.prDisplayName.TabIndex = 3
        Me.prDisplayName.Text = "nome"
        Me.prDisplayName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'prSize
        '
        Me.prSize.Dock = System.Windows.Forms.DockStyle.Right
        Me.prSize.Font = New System.Drawing.Font("DM Sans", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prSize.ForeColor = System.Drawing.Color.LightGray
        Me.prSize.Location = New System.Drawing.Point(561, 0)
        Me.prSize.Name = "prSize"
        Me.prSize.Size = New System.Drawing.Size(89, 42)
        Me.prSize.TabIndex = 4
        Me.prSize.Text = "247MB"
        Me.prSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'prLastModify
        '
        Me.prLastModify.Dock = System.Windows.Forms.DockStyle.Right
        Me.prLastModify.Font = New System.Drawing.Font("DM Sans", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prLastModify.ForeColor = System.Drawing.Color.LightGray
        Me.prLastModify.Location = New System.Drawing.Point(434, 0)
        Me.prLastModify.Name = "prLastModify"
        Me.prLastModify.Size = New System.Drawing.Size(127, 42)
        Me.prLastModify.TabIndex = 5
        Me.prLastModify.Text = "17/07/2020 14:23"
        Me.prLastModify.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OpenFile
        '
        '
        'RightClick
        '
        Me.RightClick.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RightClick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RightClick.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cxtOpen, Me.cxtDeleteElement, Me.cxtRename, Me.cxtMove, Me.cxtExport, Me.cxtCopy})
        Me.RightClick.Name = "contextMenu"
        Me.RightClick.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RightClick.RenderStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RightClick.RenderStyle.ColorTable = Nothing
        Me.RightClick.RenderStyle.RoundedEdges = True
        Me.RightClick.RenderStyle.SelectionArrowColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RightClick.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.RightClick.RenderStyle.SelectionForeColor = System.Drawing.Color.LightGray
        Me.RightClick.RenderStyle.SeparatorColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RightClick.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault
        Me.RightClick.Size = New System.Drawing.Size(140, 232)
        '
        'cxtOpen
        '
        Me.cxtOpen.AutoSize = False
        Me.cxtOpen.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cxtOpen.ForeColor = System.Drawing.Color.LightGray
        Me.cxtOpen.Name = "cxtOpen"
        Me.cxtOpen.Size = New System.Drawing.Size(220, 38)
        Me.cxtOpen.Text = "Apri"
        '
        'cxtDeleteElement
        '
        Me.cxtDeleteElement.AutoSize = False
        Me.cxtDeleteElement.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.cxtDeleteElement.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cxtDeleteElement.ForeColor = System.Drawing.Color.LightGray
        Me.cxtDeleteElement.Name = "cxtDeleteElement"
        Me.cxtDeleteElement.Size = New System.Drawing.Size(250, 38)
        Me.cxtDeleteElement.Text = "Elimina"
        '
        'cxtRename
        '
        Me.cxtRename.AutoSize = False
        Me.cxtRename.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cxtRename.ForeColor = System.Drawing.Color.LightGray
        Me.cxtRename.Name = "cxtRename"
        Me.cxtRename.Size = New System.Drawing.Size(250, 38)
        Me.cxtRename.Text = "Rinomina"
        '
        'cxtMove
        '
        Me.cxtMove.AutoSize = False
        Me.cxtMove.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cxtMove.ForeColor = System.Drawing.Color.LightGray
        Me.cxtMove.Name = "cxtMove"
        Me.cxtMove.Size = New System.Drawing.Size(250, 38)
        Me.cxtMove.Text = "Sposta"
        '
        'cxtExport
        '
        Me.cxtExport.AutoSize = False
        Me.cxtExport.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cxtExport.ForeColor = System.Drawing.Color.White
        Me.cxtExport.Name = "cxtExport"
        Me.cxtExport.Size = New System.Drawing.Size(220, 38)
        Me.cxtExport.Text = "Esporta"
        '
        'cxtCopy
        '
        Me.cxtCopy.AutoSize = False
        Me.cxtCopy.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cxtCopy.ForeColor = System.Drawing.Color.White
        Me.cxtCopy.Name = "cxtCopy"
        Me.cxtCopy.Size = New System.Drawing.Size(220, 38)
        Me.cxtCopy.Text = "Copia"
        '
        'Export_SelectLocation
        '
        Me.Export_SelectLocation.Filter = "File di Strongchest|*.*"
        Me.Export_SelectLocation.Title = "Scegli dove salvare il file"
        '
        'Export
        '
        '
        'ProgressBar
        '
        Me.ProgressBar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ProgressBar.Animated = True
        Me.ProgressBar.AnimationSpeed = 2.4!
        Me.ProgressBar.BaseColor = System.Drawing.Color.Transparent
        Me.ProgressBar.IdleColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ProgressBar.IdleOffset = 5
        Me.ProgressBar.IdleThickness = 4
        Me.ProgressBar.Image = Nothing
        Me.ProgressBar.ImageSize = New System.Drawing.Size(52, 52)
        Me.ProgressBar.Location = New System.Drawing.Point(31, 6)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.ProgressMaxColor = System.Drawing.SystemColors.ActiveCaption
        Me.ProgressBar.ProgressMinColor = System.Drawing.SystemColors.HotTrack
        Me.ProgressBar.ProgressOffset = 5
        Me.ProgressBar.ProgressThickness = 4
        Me.ProgressBar.Size = New System.Drawing.Size(30, 30)
        Me.ProgressBar.TabIndex = 33
        Me.ProgressBar.Value = 60
        Me.ProgressBar.Visible = False
        '
        'pctPictureIcon
        '
        Me.pctPictureIcon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pctPictureIcon.Location = New System.Drawing.Point(30, 0)
        Me.pctPictureIcon.Name = "pctPictureIcon"
        Me.pctPictureIcon.Size = New System.Drawing.Size(32, 42)
        Me.pctPictureIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctPictureIcon.TabIndex = 0
        Me.pctPictureIcon.TabStop = False
        '
        'Element
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ContextMenuStrip = Me.RightClick
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.pctPictureIcon)
        Me.Controls.Add(Me.prLastModify)
        Me.Controls.Add(Me.prSize)
        Me.Controls.Add(Me.prDisplayName)
        Me.MinimumSize = New System.Drawing.Size(650, 42)
        Me.Name = "Element"
        Me.Size = New System.Drawing.Size(650, 42)
        Me.RightClick.ResumeLayout(False)
        CType(Me.pctPictureIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents prDisplayName As Label
    Friend WithEvents prSize As Label
    Friend WithEvents prLastModify As Label
    Friend WithEvents pctPictureIcon As PictureBox
    Friend WithEvents OpenFile As System.ComponentModel.BackgroundWorker
    Friend WithEvents RightClick As Guna.UI.WinForms.GunaContextMenuStrip
    Friend WithEvents cxtDeleteElement As ToolStripMenuItem
    Friend WithEvents cxtRename As ToolStripMenuItem
    Friend WithEvents cxtMove As ToolStripMenuItem
    Friend WithEvents cxtCopy As ToolStripMenuItem
    Friend WithEvents cxtExport As ToolStripMenuItem
    Friend WithEvents Export_SelectLocation As SaveFileDialog
    Friend WithEvents Export As System.ComponentModel.BackgroundWorker
    Friend WithEvents cxtOpen As ToolStripMenuItem
    Friend WithEvents ProgressBar As Guna.UI.WinForms.GunaCircleProgressBar
End Class
