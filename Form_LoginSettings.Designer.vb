<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginSettings
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LoginSettingsPanel = New Guna.UI.WinForms.GunaElipsePanel()
        Me.btnGetOnlineHelp = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.btnImportSpace = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.btnChangePassword = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.CloseForm = New Guna.UI.WinForms.GunaButton()
        Me.lblHeading = New Guna.UI.WinForms.GunaLabel()
        Me.LoginSettingsPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'LoginSettingsPanel
        '
        Me.LoginSettingsPanel.BackColor = System.Drawing.Color.Transparent
        Me.LoginSettingsPanel.BaseColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LoginSettingsPanel.Controls.Add(Me.btnGetOnlineHelp)
        Me.LoginSettingsPanel.Controls.Add(Me.btnImportSpace)
        Me.LoginSettingsPanel.Controls.Add(Me.btnChangePassword)
        Me.LoginSettingsPanel.Controls.Add(Me.CloseForm)
        Me.LoginSettingsPanel.Controls.Add(Me.lblHeading)
        Me.LoginSettingsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LoginSettingsPanel.Location = New System.Drawing.Point(0, 0)
        Me.LoginSettingsPanel.Name = "LoginSettingsPanel"
        Me.LoginSettingsPanel.Radius = 4
        Me.LoginSettingsPanel.Size = New System.Drawing.Size(450, 275)
        Me.LoginSettingsPanel.TabIndex = 1
        '
        'btnGetOnlineHelp
        '
        Me.btnGetOnlineHelp.Animated = True
        Me.btnGetOnlineHelp.AnimationHoverSpeed = 0.07!
        Me.btnGetOnlineHelp.AnimationSpeed = 0.03!
        Me.btnGetOnlineHelp.BackColor = System.Drawing.Color.Transparent
        Me.btnGetOnlineHelp.BaseColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnGetOnlineHelp.BorderColor = System.Drawing.Color.Black
        Me.btnGetOnlineHelp.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnGetOnlineHelp.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnGetOnlineHelp.CheckedForeColor = System.Drawing.Color.White
        Me.btnGetOnlineHelp.CheckedImage = Global.Strongchest.My.Resources.Resources.reset_space
        Me.btnGetOnlineHelp.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnGetOnlineHelp.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnGetOnlineHelp.FocusedColor = System.Drawing.Color.Empty
        Me.btnGetOnlineHelp.Font = New System.Drawing.Font("DM Sans", 11.0!)
        Me.btnGetOnlineHelp.ForeColor = System.Drawing.Color.White
        Me.btnGetOnlineHelp.Image = Nothing
        Me.btnGetOnlineHelp.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnGetOnlineHelp.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnGetOnlineHelp.Location = New System.Drawing.Point(29, 203)
        Me.btnGetOnlineHelp.Name = "btnGetOnlineHelp"
        Me.btnGetOnlineHelp.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnGetOnlineHelp.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnGetOnlineHelp.OnHoverForeColor = System.Drawing.Color.White
        Me.btnGetOnlineHelp.OnHoverImage = Nothing
        Me.btnGetOnlineHelp.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnGetOnlineHelp.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnGetOnlineHelp.OnPressedDepth = 100
        Me.btnGetOnlineHelp.Radius = 2
        Me.btnGetOnlineHelp.Size = New System.Drawing.Size(391, 45)
        Me.btnGetOnlineHelp.TabIndex = 83
        Me.btnGetOnlineHelp.Text = "Cerca aiuto online"
        Me.btnGetOnlineHelp.TextImageOffsetY = 3
        '
        'btnImportSpace
        '
        Me.btnImportSpace.Animated = True
        Me.btnImportSpace.AnimationHoverSpeed = 0.07!
        Me.btnImportSpace.AnimationSpeed = 0.03!
        Me.btnImportSpace.BackColor = System.Drawing.Color.Transparent
        Me.btnImportSpace.BaseColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnImportSpace.BorderColor = System.Drawing.Color.Black
        Me.btnImportSpace.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnImportSpace.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnImportSpace.CheckedForeColor = System.Drawing.Color.White
        Me.btnImportSpace.CheckedImage = Global.Strongchest.My.Resources.Resources.reset_space
        Me.btnImportSpace.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnImportSpace.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnImportSpace.FocusedColor = System.Drawing.Color.Empty
        Me.btnImportSpace.Font = New System.Drawing.Font("DM Sans", 11.0!)
        Me.btnImportSpace.ForeColor = System.Drawing.Color.White
        Me.btnImportSpace.Image = Global.Strongchest.My.Resources.Resources.import_from
        Me.btnImportSpace.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnImportSpace.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnImportSpace.Location = New System.Drawing.Point(235, 67)
        Me.btnImportSpace.Name = "btnImportSpace"
        Me.btnImportSpace.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnImportSpace.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnImportSpace.OnHoverForeColor = System.Drawing.Color.White
        Me.btnImportSpace.OnHoverImage = Nothing
        Me.btnImportSpace.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnImportSpace.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnImportSpace.OnPressedDepth = 100
        Me.btnImportSpace.Radius = 2
        Me.btnImportSpace.Size = New System.Drawing.Size(185, 117)
        Me.btnImportSpace.TabIndex = 81
        Me.btnImportSpace.Text = "Importa spazio"
        Me.btnImportSpace.TextImageOffsetY = 3
        '
        'btnChangePassword
        '
        Me.btnChangePassword.Animated = True
        Me.btnChangePassword.AnimationHoverSpeed = 0.07!
        Me.btnChangePassword.AnimationSpeed = 0.03!
        Me.btnChangePassword.BackColor = System.Drawing.Color.Transparent
        Me.btnChangePassword.BaseColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnChangePassword.BorderColor = System.Drawing.Color.Black
        Me.btnChangePassword.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnChangePassword.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnChangePassword.CheckedForeColor = System.Drawing.Color.White
        Me.btnChangePassword.CheckedImage = Global.Strongchest.My.Resources.Resources.reset_space
        Me.btnChangePassword.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnChangePassword.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnChangePassword.FocusedColor = System.Drawing.Color.Empty
        Me.btnChangePassword.Font = New System.Drawing.Font("DM Sans", 11.0!)
        Me.btnChangePassword.ForeColor = System.Drawing.Color.White
        Me.btnChangePassword.Image = Global.Strongchest.My.Resources.Resources.reset_space
        Me.btnChangePassword.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnChangePassword.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnChangePassword.Location = New System.Drawing.Point(29, 67)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnChangePassword.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnChangePassword.OnHoverForeColor = System.Drawing.Color.White
        Me.btnChangePassword.OnHoverImage = Nothing
        Me.btnChangePassword.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnChangePassword.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnChangePassword.OnPressedDepth = 100
        Me.btnChangePassword.Radius = 2
        Me.btnChangePassword.Size = New System.Drawing.Size(185, 117)
        Me.btnChangePassword.TabIndex = 80
        Me.btnChangePassword.Text = "Resetta spazio"
        Me.btnChangePassword.TextImageOffsetY = 3
        '
        'CloseForm
        '
        Me.CloseForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseForm.AnimationHoverSpeed = 0.07!
        Me.CloseForm.AnimationSpeed = 0.03!
        Me.CloseForm.BaseColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.CloseForm.BorderColor = System.Drawing.Color.Black
        Me.CloseForm.DialogResult = System.Windows.Forms.DialogResult.None
        Me.CloseForm.FocusedColor = System.Drawing.Color.Empty
        Me.CloseForm.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CloseForm.ForeColor = System.Drawing.Color.White
        Me.CloseForm.Image = Global.Strongchest.My.Resources.Resources.ui_close
        Me.CloseForm.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CloseForm.ImageSize = New System.Drawing.Size(24, 24)
        Me.CloseForm.Location = New System.Drawing.Point(404, 14)
        Me.CloseForm.Name = "CloseForm"
        Me.CloseForm.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.CloseForm.OnHoverBorderColor = System.Drawing.Color.Black
        Me.CloseForm.OnHoverForeColor = System.Drawing.Color.White
        Me.CloseForm.OnHoverImage = Nothing
        Me.CloseForm.OnPressedColor = System.Drawing.Color.Black
        Me.CloseForm.Size = New System.Drawing.Size(36, 36)
        Me.CloseForm.TabIndex = 79
        '
        'lblHeading
        '
        Me.lblHeading.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblHeading.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lblHeading.Font = New System.Drawing.Font("DM Sans Medium", 12.75!)
        Me.lblHeading.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblHeading.Location = New System.Drawing.Point(14, 14)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(349, 36)
        Me.lblHeading.TabIndex = 72
        Me.lblHeading.Text = "Opzioni di accesso"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LoginSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(450, 275)
        Me.Controls.Add(Me.LoginSettingsPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login Settings"
        Me.LoginSettingsPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LoginSettingsPanel As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents lblHeading As Guna.UI.WinForms.GunaLabel
    Friend WithEvents CloseForm As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnImportSpace As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents btnChangePassword As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents btnGetOnlineHelp As Guna.UI.WinForms.GunaAdvenceTileButton
End Class
