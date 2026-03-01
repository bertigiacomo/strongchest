<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectNewPassword
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
        Me.BackgroundPanel = New Guna.UI.WinForms.GunaElipsePanel()
        Me.ErrorLabel = New Guna.UI.WinForms.GunaLabel()
        Me.AdvertLabel = New Guna.UI.WinForms.GunaLabel()
        Me.ConfirmButton = New Guna.UI.WinForms.GunaGradientButton()
        Me.PasswordBox = New Guna.UI.WinForms.GunaTextBox()
        Me.ConfirmNewPasswordLabel = New Guna.UI.WinForms.GunaLabel()
        Me.PasswordConfirm = New Guna.UI.WinForms.GunaTextBox()
        Me.CloseForm = New Guna.UI.WinForms.GunaButton()
        Me.NewPasswordLabel = New Guna.UI.WinForms.GunaLabel()
        Me.lblHeading = New Guna.UI.WinForms.GunaLabel()
        Me.BackgroundPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'BackgroundPanel
        '
        Me.BackgroundPanel.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundPanel.BaseColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.BackgroundPanel.Controls.Add(Me.ErrorLabel)
        Me.BackgroundPanel.Controls.Add(Me.AdvertLabel)
        Me.BackgroundPanel.Controls.Add(Me.ConfirmButton)
        Me.BackgroundPanel.Controls.Add(Me.PasswordBox)
        Me.BackgroundPanel.Controls.Add(Me.ConfirmNewPasswordLabel)
        Me.BackgroundPanel.Controls.Add(Me.PasswordConfirm)
        Me.BackgroundPanel.Controls.Add(Me.CloseForm)
        Me.BackgroundPanel.Controls.Add(Me.NewPasswordLabel)
        Me.BackgroundPanel.Controls.Add(Me.lblHeading)
        Me.BackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BackgroundPanel.Location = New System.Drawing.Point(0, 0)
        Me.BackgroundPanel.Name = "BackgroundPanel"
        Me.BackgroundPanel.Radius = 4
        Me.BackgroundPanel.Size = New System.Drawing.Size(450, 450)
        Me.BackgroundPanel.TabIndex = 1
        '
        'ErrorLabel
        '
        Me.ErrorLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ErrorLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ErrorLabel.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.ErrorLabel.ForeColor = System.Drawing.Color.LightGray
        Me.ErrorLabel.Location = New System.Drawing.Point(12, 250)
        Me.ErrorLabel.Name = "ErrorLabel"
        Me.ErrorLabel.Size = New System.Drawing.Size(426, 35)
        Me.ErrorLabel.TabIndex = 85
        Me.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'AdvertLabel
        '
        Me.AdvertLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AdvertLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.AdvertLabel.Font = New System.Drawing.Font("DM Sans", 8.5!)
        Me.AdvertLabel.ForeColor = System.Drawing.Color.LightGray
        Me.AdvertLabel.Location = New System.Drawing.Point(43, 300)
        Me.AdvertLabel.Name = "AdvertLabel"
        Me.AdvertLabel.Size = New System.Drawing.Size(360, 70)
        Me.AdvertLabel.TabIndex = 84
        Me.AdvertLabel.Text = "Il cambio password a volte può richiedere davvero molto tempo. La durata dell'ope" &
    "razione varia in base alla potenza del computer e alla quantità di dati memorizz" &
    "ati."
        Me.AdvertLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ConfirmButton
        '
        Me.ConfirmButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ConfirmButton.Animated = True
        Me.ConfirmButton.AnimationHoverSpeed = 0.07!
        Me.ConfirmButton.AnimationSpeed = 0.03!
        Me.ConfirmButton.BackColor = System.Drawing.Color.Transparent
        Me.ConfirmButton.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ConfirmButton.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ConfirmButton.BorderColor = System.Drawing.Color.Black
        Me.ConfirmButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.ConfirmButton.FocusedColor = System.Drawing.Color.Empty
        Me.ConfirmButton.Font = New System.Drawing.Font("DM Sans", 10.0!)
        Me.ConfirmButton.ForeColor = System.Drawing.Color.LightGray
        Me.ConfirmButton.Image = Nothing
        Me.ConfirmButton.ImageSize = New System.Drawing.Size(20, 20)
        Me.ConfirmButton.Location = New System.Drawing.Point(62, 388)
        Me.ConfirmButton.Name = "ConfirmButton"
        Me.ConfirmButton.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ConfirmButton.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ConfirmButton.OnHoverBorderColor = System.Drawing.Color.Black
        Me.ConfirmButton.OnHoverForeColor = System.Drawing.Color.White
        Me.ConfirmButton.OnHoverImage = Nothing
        Me.ConfirmButton.OnPressedColor = System.Drawing.Color.Black
        Me.ConfirmButton.Radius = 2
        Me.ConfirmButton.Size = New System.Drawing.Size(326, 39)
        Me.ConfirmButton.TabIndex = 83
        Me.ConfirmButton.Text = "Conferma cambio password"
        Me.ConfirmButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PasswordBox
        '
        Me.PasswordBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PasswordBox.BackColor = System.Drawing.Color.Transparent
        Me.PasswordBox.BaseColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.PasswordBox.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.PasswordBox.BorderSize = 1
        Me.PasswordBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PasswordBox.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.PasswordBox.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.PasswordBox.FocusedForeColor = System.Drawing.Color.White
        Me.PasswordBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PasswordBox.ForeColor = System.Drawing.Color.Gainsboro
        Me.PasswordBox.Location = New System.Drawing.Point(69, 206)
        Me.PasswordBox.MaximumSize = New System.Drawing.Size(460, 35)
        Me.PasswordBox.MaxLength = 129
        Me.PasswordBox.Name = "PasswordBox"
        Me.PasswordBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.PasswordBox.Radius = 3
        Me.PasswordBox.Size = New System.Drawing.Size(298, 35)
        Me.PasswordBox.TabIndex = 82
        Me.PasswordBox.Text = "passwor"
        Me.PasswordBox.TextOffsetX = 5
        Me.PasswordBox.UseSystemPasswordChar = True
        '
        'ConfirmNewPasswordLabel
        '
        Me.ConfirmNewPasswordLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ConfirmNewPasswordLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ConfirmNewPasswordLabel.Font = New System.Drawing.Font("DM Sans Medium", 11.0!)
        Me.ConfirmNewPasswordLabel.ForeColor = System.Drawing.Color.LightGray
        Me.ConfirmNewPasswordLabel.Location = New System.Drawing.Point(69, 167)
        Me.ConfirmNewPasswordLabel.Name = "ConfirmNewPasswordLabel"
        Me.ConfirmNewPasswordLabel.Size = New System.Drawing.Size(298, 36)
        Me.ConfirmNewPasswordLabel.TabIndex = 81
        Me.ConfirmNewPasswordLabel.Text = "Conferma password"
        Me.ConfirmNewPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordConfirm
        '
        Me.PasswordConfirm.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PasswordConfirm.BackColor = System.Drawing.Color.Transparent
        Me.PasswordConfirm.BaseColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.PasswordConfirm.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.PasswordConfirm.BorderSize = 1
        Me.PasswordConfirm.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PasswordConfirm.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.PasswordConfirm.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.PasswordConfirm.FocusedForeColor = System.Drawing.Color.White
        Me.PasswordConfirm.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PasswordConfirm.ForeColor = System.Drawing.Color.Gainsboro
        Me.PasswordConfirm.Location = New System.Drawing.Point(68, 112)
        Me.PasswordConfirm.MaximumSize = New System.Drawing.Size(460, 35)
        Me.PasswordConfirm.MaxLength = 129
        Me.PasswordConfirm.Name = "PasswordConfirm"
        Me.PasswordConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.PasswordConfirm.Radius = 3
        Me.PasswordConfirm.Size = New System.Drawing.Size(298, 35)
        Me.PasswordConfirm.TabIndex = 80
        Me.PasswordConfirm.Text = "passwor"
        Me.PasswordConfirm.TextOffsetX = 5
        Me.PasswordConfirm.UseSystemPasswordChar = True
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
        'NewPasswordLabel
        '
        Me.NewPasswordLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NewPasswordLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.NewPasswordLabel.Font = New System.Drawing.Font("DM Sans Medium", 11.0!)
        Me.NewPasswordLabel.ForeColor = System.Drawing.Color.LightGray
        Me.NewPasswordLabel.Location = New System.Drawing.Point(69, 73)
        Me.NewPasswordLabel.Name = "NewPasswordLabel"
        Me.NewPasswordLabel.Size = New System.Drawing.Size(297, 36)
        Me.NewPasswordLabel.TabIndex = 73
        Me.NewPasswordLabel.Text = "Nuova password"
        Me.NewPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHeading
        '
        Me.lblHeading.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lblHeading.Font = New System.Drawing.Font("DM Sans Medium", 13.0!)
        Me.lblHeading.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblHeading.Location = New System.Drawing.Point(14, 14)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(311, 36)
        Me.lblHeading.TabIndex = 72
        Me.lblHeading.Text = "Cambia chiave di cifratura"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SelectNewPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(450, 450)
        Me.Controls.Add(Me.BackgroundPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SelectNewPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleziona una nuova passoword"
        Me.BackgroundPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BackgroundPanel As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents CloseForm As Guna.UI.WinForms.GunaButton
    Friend WithEvents NewPasswordLabel As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblHeading As Guna.UI.WinForms.GunaLabel
    Friend WithEvents PasswordBox As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents ConfirmNewPasswordLabel As Guna.UI.WinForms.GunaLabel
    Friend WithEvents PasswordConfirm As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents AdvertLabel As Guna.UI.WinForms.GunaLabel
    Friend WithEvents ConfirmButton As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents ErrorLabel As Guna.UI.WinForms.GunaLabel
End Class
