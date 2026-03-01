<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainContainer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainContainer))
        Me.DragControl = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.pnlToolbar = New Guna.UI.WinForms.GunaPanel()
        Me.btnMinimize = New Guna.UI.WinForms.GunaButton()
        Me.btnMaximize = New Guna.UI.WinForms.GunaButton()
        Me.btnClose = New Guna.UI.WinForms.GunaButton()
        Me.pnlContainer = New System.Windows.Forms.Panel()
        Me.pnlToolbar.SuspendLayout()
        Me.SuspendLayout()
        '
        'DragControl
        '
        Me.DragControl.TargetControl = Me.pnlToolbar
        '
        'pnlToolbar
        '
        Me.pnlToolbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.pnlToolbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlToolbar.Controls.Add(Me.btnMinimize)
        Me.pnlToolbar.Controls.Add(Me.btnMaximize)
        Me.pnlToolbar.Controls.Add(Me.btnClose)
        Me.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlToolbar.Location = New System.Drawing.Point(0, 0)
        Me.pnlToolbar.Name = "pnlToolbar"
        Me.pnlToolbar.Size = New System.Drawing.Size(1200, 21)
        Me.pnlToolbar.TabIndex = 1
        '
        'btnMinimize
        '
        Me.btnMinimize.AnimationHoverSpeed = 0.07!
        Me.btnMinimize.AnimationSpeed = 0.03!
        Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.BaseColor = System.Drawing.Color.Transparent
        Me.btnMinimize.BorderColor = System.Drawing.Color.Black
        Me.btnMinimize.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMinimize.FocusedColor = System.Drawing.Color.Empty
        Me.btnMinimize.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnMinimize.ForeColor = System.Drawing.Color.White
        Me.btnMinimize.Image = Global.Strongchest.My.Resources.Resources.ui_minimize
        Me.btnMinimize.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnMinimize.ImageSize = New System.Drawing.Size(12, 14)
        Me.btnMinimize.Location = New System.Drawing.Point(1125, 0)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.btnMinimize.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnMinimize.OnHoverForeColor = System.Drawing.Color.White
        Me.btnMinimize.OnHoverImage = Nothing
        Me.btnMinimize.OnPressedColor = System.Drawing.Color.Black
        Me.btnMinimize.OnPressedDepth = 0
        Me.btnMinimize.Size = New System.Drawing.Size(25, 21)
        Me.btnMinimize.TabIndex = 15
        '
        'btnMaximize
        '
        Me.btnMaximize.AnimationHoverSpeed = 0.07!
        Me.btnMaximize.AnimationSpeed = 0.03!
        Me.btnMaximize.BackColor = System.Drawing.Color.Transparent
        Me.btnMaximize.BaseColor = System.Drawing.Color.Transparent
        Me.btnMaximize.BorderColor = System.Drawing.Color.Black
        Me.btnMaximize.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMaximize.FocusedColor = System.Drawing.Color.Empty
        Me.btnMaximize.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnMaximize.ForeColor = System.Drawing.Color.White
        Me.btnMaximize.Image = Global.Strongchest.My.Resources.Resources.ui_maximize
        Me.btnMaximize.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnMaximize.ImageSize = New System.Drawing.Size(12, 10)
        Me.btnMaximize.Location = New System.Drawing.Point(1150, 0)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.btnMaximize.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnMaximize.OnHoverForeColor = System.Drawing.Color.White
        Me.btnMaximize.OnHoverImage = Nothing
        Me.btnMaximize.OnPressedColor = System.Drawing.Color.Black
        Me.btnMaximize.OnPressedDepth = 0
        Me.btnMaximize.Size = New System.Drawing.Size(25, 21)
        Me.btnMaximize.TabIndex = 14
        '
        'btnClose
        '
        Me.btnClose.AnimationHoverSpeed = 0.07!
        Me.btnClose.AnimationSpeed = 0.03!
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BaseColor = System.Drawing.Color.Transparent
        Me.btnClose.BorderColor = System.Drawing.Color.Black
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.FocusedColor = System.Drawing.Color.Empty
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Image = Global.Strongchest.My.Resources.Resources.ui_close
        Me.btnClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnClose.ImageSize = New System.Drawing.Size(18, 18)
        Me.btnClose.Location = New System.Drawing.Point(1175, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.btnClose.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnClose.OnHoverForeColor = System.Drawing.Color.White
        Me.btnClose.OnHoverImage = Nothing
        Me.btnClose.OnPressedColor = System.Drawing.Color.Black
        Me.btnClose.OnPressedDepth = 0
        Me.btnClose.Size = New System.Drawing.Size(25, 21)
        Me.btnClose.TabIndex = 13
        '
        'pnlContainer
        '
        Me.pnlContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.pnlContainer.Location = New System.Drawing.Point(0, 21)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Size = New System.Drawing.Size(1200, 779)
        Me.pnlContainer.TabIndex = 2
        '
        'MainContainer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1200, 800)
        Me.Controls.Add(Me.pnlToolbar)
        Me.Controls.Add(Me.pnlContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(650, 600)
        Me.Name = "MainContainer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Strongchest"
        Me.pnlToolbar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DragControl As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents pnlContainer As Panel
    Friend WithEvents pnlToolbar As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btnMaximize As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnClose As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnMinimize As Guna.UI.WinForms.GunaButton
End Class
