<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsGUI
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SettingsPanel = New Guna.UI.WinForms.GunaElipsePanel()
        Me.AdminSpace = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.ManangeInterface = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.ReloadStrongchest = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.DeleteChest = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.ExportSpace = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.ChangePassword = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.CloseForm = New Guna.UI.WinForms.GunaButton()
        Me.lblHeading = New Guna.UI.WinForms.GunaLabel()
        Me.SettingsPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'SettingsPanel
        '
        Me.SettingsPanel.BackColor = System.Drawing.Color.Transparent
        Me.SettingsPanel.BaseColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.SettingsPanel.Controls.Add(Me.AdminSpace)
        Me.SettingsPanel.Controls.Add(Me.ManangeInterface)
        Me.SettingsPanel.Controls.Add(Me.ReloadStrongchest)
        Me.SettingsPanel.Controls.Add(Me.DeleteChest)
        Me.SettingsPanel.Controls.Add(Me.ExportSpace)
        Me.SettingsPanel.Controls.Add(Me.ChangePassword)
        Me.SettingsPanel.Controls.Add(Me.CloseForm)
        Me.SettingsPanel.Controls.Add(Me.lblHeading)
        Me.SettingsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SettingsPanel.Location = New System.Drawing.Point(0, 0)
        Me.SettingsPanel.Name = "SettingsPanel"
        Me.SettingsPanel.Radius = 4
        Me.SettingsPanel.Size = New System.Drawing.Size(450, 450)
        Me.SettingsPanel.TabIndex = 0
        '
        'AdminSpace
        '
        Me.AdminSpace.Animated = True
        Me.AdminSpace.AnimationHoverSpeed = 0.07!
        Me.AdminSpace.AnimationSpeed = 0.03!
        Me.AdminSpace.BackColor = System.Drawing.Color.Transparent
        Me.AdminSpace.BaseColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.AdminSpace.BorderColor = System.Drawing.Color.Black
        Me.AdminSpace.CheckedBaseColor = System.Drawing.Color.Gray
        Me.AdminSpace.CheckedBorderColor = System.Drawing.Color.Black
        Me.AdminSpace.CheckedForeColor = System.Drawing.Color.White
        Me.AdminSpace.CheckedImage = Global.Strongchest.My.Resources.Resources.reset_space
        Me.AdminSpace.CheckedLineColor = System.Drawing.Color.DimGray
        Me.AdminSpace.DialogResult = System.Windows.Forms.DialogResult.None
        Me.AdminSpace.FocusedColor = System.Drawing.Color.Empty
        Me.AdminSpace.Font = New System.Drawing.Font("DM Sans", 11.25!)
        Me.AdminSpace.ForeColor = System.Drawing.Color.White
        Me.AdminSpace.Image = Global.Strongchest.My.Resources.Resources.installation_box
        Me.AdminSpace.ImageSize = New System.Drawing.Size(40, 40)
        Me.AdminSpace.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.AdminSpace.Location = New System.Drawing.Point(231, 315)
        Me.AdminSpace.Margin = New System.Windows.Forms.Padding(12)
        Me.AdminSpace.Name = "AdminSpace"
        Me.AdminSpace.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.AdminSpace.OnHoverBorderColor = System.Drawing.Color.Black
        Me.AdminSpace.OnHoverForeColor = System.Drawing.Color.White
        Me.AdminSpace.OnHoverImage = Nothing
        Me.AdminSpace.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.AdminSpace.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.AdminSpace.OnPressedDepth = 100
        Me.AdminSpace.Radius = 2
        Me.AdminSpace.Size = New System.Drawing.Size(198, 110)
        Me.AdminSpace.TabIndex = 88
        Me.AdminSpace.Text = "Gestione spazio"
        Me.AdminSpace.TextImageOffsetY = 3
        '
        'ManangeInterface
        '
        Me.ManangeInterface.Animated = True
        Me.ManangeInterface.AnimationHoverSpeed = 0.07!
        Me.ManangeInterface.AnimationSpeed = 0.03!
        Me.ManangeInterface.BackColor = System.Drawing.Color.Transparent
        Me.ManangeInterface.BaseColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ManangeInterface.BorderColor = System.Drawing.Color.Black
        Me.ManangeInterface.CheckedBaseColor = System.Drawing.Color.Gray
        Me.ManangeInterface.CheckedBorderColor = System.Drawing.Color.Black
        Me.ManangeInterface.CheckedForeColor = System.Drawing.Color.White
        Me.ManangeInterface.CheckedImage = Global.Strongchest.My.Resources.Resources.ui_aspect
        Me.ManangeInterface.CheckedLineColor = System.Drawing.Color.DimGray
        Me.ManangeInterface.DialogResult = System.Windows.Forms.DialogResult.None
        Me.ManangeInterface.FocusedColor = System.Drawing.Color.Empty
        Me.ManangeInterface.Font = New System.Drawing.Font("DM Sans", 11.25!)
        Me.ManangeInterface.ForeColor = System.Drawing.Color.White
        Me.ManangeInterface.Image = Global.Strongchest.My.Resources.Resources.ui_aspect
        Me.ManangeInterface.ImageSize = New System.Drawing.Size(40, 40)
        Me.ManangeInterface.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.ManangeInterface.Location = New System.Drawing.Point(19, 315)
        Me.ManangeInterface.Margin = New System.Windows.Forms.Padding(12)
        Me.ManangeInterface.Name = "ManangeInterface"
        Me.ManangeInterface.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.ManangeInterface.OnHoverBorderColor = System.Drawing.Color.Black
        Me.ManangeInterface.OnHoverForeColor = System.Drawing.Color.White
        Me.ManangeInterface.OnHoverImage = Nothing
        Me.ManangeInterface.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.ManangeInterface.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ManangeInterface.OnPressedDepth = 100
        Me.ManangeInterface.Radius = 2
        Me.ManangeInterface.Size = New System.Drawing.Size(198, 110)
        Me.ManangeInterface.TabIndex = 87
        Me.ManangeInterface.Text = "Interfaccia"
        Me.ManangeInterface.TextImageOffsetY = 3
        '
        'ReloadStrongchest
        '
        Me.ReloadStrongchest.Animated = True
        Me.ReloadStrongchest.AnimationHoverSpeed = 0.07!
        Me.ReloadStrongchest.AnimationSpeed = 0.03!
        Me.ReloadStrongchest.BackColor = System.Drawing.Color.Transparent
        Me.ReloadStrongchest.BaseColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ReloadStrongchest.BorderColor = System.Drawing.Color.Black
        Me.ReloadStrongchest.CheckedBaseColor = System.Drawing.Color.Gray
        Me.ReloadStrongchest.CheckedBorderColor = System.Drawing.Color.Black
        Me.ReloadStrongchest.CheckedForeColor = System.Drawing.Color.White
        Me.ReloadStrongchest.CheckedImage = Global.Strongchest.My.Resources.Resources.reset_space
        Me.ReloadStrongchest.CheckedLineColor = System.Drawing.Color.DimGray
        Me.ReloadStrongchest.DialogResult = System.Windows.Forms.DialogResult.None
        Me.ReloadStrongchest.FocusedColor = System.Drawing.Color.Empty
        Me.ReloadStrongchest.Font = New System.Drawing.Font("DM Sans", 11.25!)
        Me.ReloadStrongchest.ForeColor = System.Drawing.Color.White
        Me.ReloadStrongchest.Image = Global.Strongchest.My.Resources.Resources.reset_space
        Me.ReloadStrongchest.ImageSize = New System.Drawing.Size(40, 40)
        Me.ReloadStrongchest.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.ReloadStrongchest.Location = New System.Drawing.Point(231, 190)
        Me.ReloadStrongchest.Margin = New System.Windows.Forms.Padding(12)
        Me.ReloadStrongchest.Name = "ReloadStrongchest"
        Me.ReloadStrongchest.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.ReloadStrongchest.OnHoverBorderColor = System.Drawing.Color.Black
        Me.ReloadStrongchest.OnHoverForeColor = System.Drawing.Color.White
        Me.ReloadStrongchest.OnHoverImage = Nothing
        Me.ReloadStrongchest.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.ReloadStrongchest.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ReloadStrongchest.OnPressedDepth = 100
        Me.ReloadStrongchest.Radius = 2
        Me.ReloadStrongchest.Size = New System.Drawing.Size(198, 110)
        Me.ReloadStrongchest.TabIndex = 86
        Me.ReloadStrongchest.Text = "Riavvio pulito"
        Me.ReloadStrongchest.TextImageOffsetY = 3
        '
        'DeleteChest
        '
        Me.DeleteChest.Animated = True
        Me.DeleteChest.AnimationHoverSpeed = 0.07!
        Me.DeleteChest.AnimationSpeed = 0.03!
        Me.DeleteChest.BackColor = System.Drawing.Color.Transparent
        Me.DeleteChest.BaseColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.DeleteChest.BorderColor = System.Drawing.Color.Black
        Me.DeleteChest.CheckedBaseColor = System.Drawing.Color.Gray
        Me.DeleteChest.CheckedBorderColor = System.Drawing.Color.Black
        Me.DeleteChest.CheckedForeColor = System.Drawing.Color.White
        Me.DeleteChest.CheckedImage = Global.Strongchest.My.Resources.Resources.reset_space
        Me.DeleteChest.CheckedLineColor = System.Drawing.Color.DimGray
        Me.DeleteChest.DialogResult = System.Windows.Forms.DialogResult.None
        Me.DeleteChest.FocusedColor = System.Drawing.Color.Empty
        Me.DeleteChest.Font = New System.Drawing.Font("DM Sans", 11.25!)
        Me.DeleteChest.ForeColor = System.Drawing.Color.White
        Me.DeleteChest.Image = Global.Strongchest.My.Resources.Resources.delete_data
        Me.DeleteChest.ImageSize = New System.Drawing.Size(40, 40)
        Me.DeleteChest.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.DeleteChest.Location = New System.Drawing.Point(19, 190)
        Me.DeleteChest.Margin = New System.Windows.Forms.Padding(12)
        Me.DeleteChest.Name = "DeleteChest"
        Me.DeleteChest.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.DeleteChest.OnHoverBorderColor = System.Drawing.Color.Black
        Me.DeleteChest.OnHoverForeColor = System.Drawing.Color.White
        Me.DeleteChest.OnHoverImage = Nothing
        Me.DeleteChest.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.DeleteChest.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.DeleteChest.OnPressedDepth = 100
        Me.DeleteChest.Radius = 2
        Me.DeleteChest.Size = New System.Drawing.Size(198, 110)
        Me.DeleteChest.TabIndex = 85
        Me.DeleteChest.Text = "Elimina tutto"
        Me.DeleteChest.TextImageOffsetY = 3
        '
        'ExportSpace
        '
        Me.ExportSpace.Animated = True
        Me.ExportSpace.AnimationHoverSpeed = 0.07!
        Me.ExportSpace.AnimationSpeed = 0.03!
        Me.ExportSpace.BackColor = System.Drawing.Color.Transparent
        Me.ExportSpace.BaseColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ExportSpace.BorderColor = System.Drawing.Color.Black
        Me.ExportSpace.CheckedBaseColor = System.Drawing.Color.Gray
        Me.ExportSpace.CheckedBorderColor = System.Drawing.Color.Black
        Me.ExportSpace.CheckedForeColor = System.Drawing.Color.White
        Me.ExportSpace.CheckedImage = Global.Strongchest.My.Resources.Resources.reset_space
        Me.ExportSpace.CheckedLineColor = System.Drawing.Color.DimGray
        Me.ExportSpace.DialogResult = System.Windows.Forms.DialogResult.None
        Me.ExportSpace.FocusedColor = System.Drawing.Color.Empty
        Me.ExportSpace.Font = New System.Drawing.Font("DM Sans", 11.25!)
        Me.ExportSpace.ForeColor = System.Drawing.Color.White
        Me.ExportSpace.Image = Global.Strongchest.My.Resources.Resources.export_from
        Me.ExportSpace.ImageSize = New System.Drawing.Size(40, 40)
        Me.ExportSpace.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.ExportSpace.Location = New System.Drawing.Point(231, 65)
        Me.ExportSpace.Margin = New System.Windows.Forms.Padding(4)
        Me.ExportSpace.Name = "ExportSpace"
        Me.ExportSpace.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.ExportSpace.OnHoverBorderColor = System.Drawing.Color.Black
        Me.ExportSpace.OnHoverForeColor = System.Drawing.Color.White
        Me.ExportSpace.OnHoverImage = Nothing
        Me.ExportSpace.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.ExportSpace.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ExportSpace.OnPressedDepth = 100
        Me.ExportSpace.Radius = 2
        Me.ExportSpace.Size = New System.Drawing.Size(198, 110)
        Me.ExportSpace.TabIndex = 84
        Me.ExportSpace.Text = "Esporta dati"
        Me.ExportSpace.TextImageOffsetY = 3
        '
        'ChangePassword
        '
        Me.ChangePassword.Animated = True
        Me.ChangePassword.AnimationHoverSpeed = 0.07!
        Me.ChangePassword.AnimationSpeed = 0.03!
        Me.ChangePassword.BackColor = System.Drawing.Color.Transparent
        Me.ChangePassword.BaseColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ChangePassword.BorderColor = System.Drawing.Color.Black
        Me.ChangePassword.CheckedBaseColor = System.Drawing.Color.Gray
        Me.ChangePassword.CheckedBorderColor = System.Drawing.Color.Black
        Me.ChangePassword.CheckedForeColor = System.Drawing.Color.White
        Me.ChangePassword.CheckedImage = Global.Strongchest.My.Resources.Resources.reset_space
        Me.ChangePassword.CheckedLineColor = System.Drawing.Color.DimGray
        Me.ChangePassword.DialogResult = System.Windows.Forms.DialogResult.None
        Me.ChangePassword.FocusedColor = System.Drawing.Color.Empty
        Me.ChangePassword.Font = New System.Drawing.Font("DM Sans", 11.25!)
        Me.ChangePassword.ForeColor = System.Drawing.Color.White
        Me.ChangePassword.Image = Global.Strongchest.My.Resources.Resources.password
        Me.ChangePassword.ImageSize = New System.Drawing.Size(40, 40)
        Me.ChangePassword.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.ChangePassword.Location = New System.Drawing.Point(19, 65)
        Me.ChangePassword.Margin = New System.Windows.Forms.Padding(4)
        Me.ChangePassword.Name = "ChangePassword"
        Me.ChangePassword.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.ChangePassword.OnHoverBorderColor = System.Drawing.Color.Black
        Me.ChangePassword.OnHoverForeColor = System.Drawing.Color.White
        Me.ChangePassword.OnHoverImage = Nothing
        Me.ChangePassword.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.ChangePassword.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ChangePassword.OnPressedDepth = 100
        Me.ChangePassword.Radius = 2
        Me.ChangePassword.Size = New System.Drawing.Size(198, 110)
        Me.ChangePassword.TabIndex = 83
        Me.ChangePassword.Text = "Cambia password"
        Me.ChangePassword.TextImageOffsetY = 3
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
        Me.lblHeading.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lblHeading.Font = New System.Drawing.Font("DM Sans Medium", 12.75!)
        Me.lblHeading.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblHeading.Location = New System.Drawing.Point(14, 14)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(384, 36)
        Me.lblHeading.TabIndex = 72
        Me.lblHeading.Text = "Impostazioni"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SettingsGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(450, 450)
        Me.Controls.Add(Me.SettingsPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SettingsGUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SettingsHome"
        Me.SettingsPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SettingsPanel As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents CloseForm As Guna.UI.WinForms.GunaButton
    Friend WithEvents lblHeading As Guna.UI.WinForms.GunaLabel
    Friend WithEvents ReloadStrongchest As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents ExportSpace As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents ChangePassword As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents DeleteChest As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents AdminSpace As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents ManangeInterface As Guna.UI.WinForms.GunaAdvenceTileButton
End Class
