<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginPage
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
        Me.tmrPasswordChecker = New System.Windows.Forms.Timer(Me.components)
        Me.lblPasswordTips = New Guna.UI.WinForms.GunaLabel()
        Me.txtPassword = New Guna.UI.WinForms.GunaTextBox()
        Me.lblDisplayVersion = New Guna.UI.WinForms.GunaLabel()
        Me.lblOtherOptions = New Guna.UI.WinForms.GunaLabel()
        Me.StartInterface = New Guna.UI.WinForms.GunaGradientButton()
        Me.ProgressBar = New Guna.UI.WinForms.GunaCircleProgressBar()
        Me.pctLogoStrongchest = New System.Windows.Forms.PictureBox()
        CType(Me.pctLogoStrongchest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrPasswordChecker
        '
        '
        'lblPasswordTips
        '
        Me.lblPasswordTips.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPasswordTips.AutoSize = True
        Me.lblPasswordTips.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblPasswordTips.Font = New System.Drawing.Font("DM Sans", 9.0!)
        Me.lblPasswordTips.ForeColor = System.Drawing.Color.DarkGray
        Me.lblPasswordTips.Location = New System.Drawing.Point(282, 232)
        Me.lblPasswordTips.Name = "lblPasswordTips"
        Me.lblPasswordTips.Size = New System.Drawing.Size(61, 16)
        Me.lblPasswordTips.TabIndex = 26
        Me.lblPasswordTips.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPassword.BackColor = System.Drawing.Color.Transparent
        Me.txtPassword.BaseColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtPassword.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtPassword.BorderSize = 1
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtPassword.FocusedForeColor = System.Drawing.Color.White
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPassword.ForeColor = System.Drawing.Color.Gainsboro
        Me.txtPassword.Location = New System.Drawing.Point(275, 222)
        Me.txtPassword.MaximumSize = New System.Drawing.Size(460, 35)
        Me.txtPassword.MaxLength = 129
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPassword.Radius = 3
        Me.txtPassword.Size = New System.Drawing.Size(350, 35)
        Me.txtPassword.TabIndex = 25
        Me.txtPassword.TextOffsetX = 5
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'lblDisplayVersion
        '
        Me.lblDisplayVersion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblDisplayVersion.Font = New System.Drawing.Font("DM Sans", 9.0!)
        Me.lblDisplayVersion.ForeColor = System.Drawing.Color.DarkGray
        Me.lblDisplayVersion.Location = New System.Drawing.Point(0, 405)
        Me.lblDisplayVersion.Name = "lblDisplayVersion"
        Me.lblDisplayVersion.Size = New System.Drawing.Size(900, 45)
        Me.lblDisplayVersion.TabIndex = 28
        Me.lblDisplayVersion.Text = "Infomazioni su Strongchest"
        Me.lblDisplayVersion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblOtherOptions
        '
        Me.lblOtherOptions.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblOtherOptions.Font = New System.Drawing.Font("DM Sans", 9.0!)
        Me.lblOtherOptions.ForeColor = System.Drawing.Color.DarkGray
        Me.lblOtherOptions.Location = New System.Drawing.Point(0, 376)
        Me.lblOtherOptions.Name = "lblOtherOptions"
        Me.lblOtherOptions.Size = New System.Drawing.Size(900, 29)
        Me.lblOtherOptions.TabIndex = 31
        Me.lblOtherOptions.Text = "Altre opzioni"
        Me.lblOtherOptions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StartInterface
        '
        Me.StartInterface.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.StartInterface.Animated = True
        Me.StartInterface.AnimationHoverSpeed = 0.07!
        Me.StartInterface.AnimationSpeed = 0.03!
        Me.StartInterface.BackColor = System.Drawing.Color.Transparent
        Me.StartInterface.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.StartInterface.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.StartInterface.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.StartInterface.CausesValidation = False
        Me.StartInterface.DialogResult = System.Windows.Forms.DialogResult.None
        Me.StartInterface.FocusedColor = System.Drawing.Color.Empty
        Me.StartInterface.Font = New System.Drawing.Font("DM Sans", 10.1!)
        Me.StartInterface.ForeColor = System.Drawing.Color.White
        Me.StartInterface.Image = Nothing
        Me.StartInterface.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.StartInterface.ImageSize = New System.Drawing.Size(15, 15)
        Me.StartInterface.Location = New System.Drawing.Point(275, 272)
        Me.StartInterface.MaximumSize = New System.Drawing.Size(460, 40)
        Me.StartInterface.Name = "StartInterface"
        Me.StartInterface.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.StartInterface.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.StartInterface.OnHoverBorderColor = System.Drawing.Color.Black
        Me.StartInterface.OnHoverForeColor = System.Drawing.Color.White
        Me.StartInterface.OnHoverImage = Nothing
        Me.StartInterface.OnPressedColor = System.Drawing.Color.Black
        Me.StartInterface.OnPressedDepth = 40
        Me.StartInterface.Size = New System.Drawing.Size(350, 33)
        Me.StartInterface.TabIndex = 27
        Me.StartInterface.Text = "Start Button"
        Me.StartInterface.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ProgressBar
        '
        Me.ProgressBar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ProgressBar.Animated = True
        Me.ProgressBar.AnimationSpeed = 3.0!
        Me.ProgressBar.BaseColor = System.Drawing.Color.Transparent
        Me.ProgressBar.IdleColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ProgressBar.IdleOffset = 10
        Me.ProgressBar.IdleThickness = 4
        Me.ProgressBar.Image = Nothing
        Me.ProgressBar.ImageSize = New System.Drawing.Size(52, 52)
        Me.ProgressBar.Location = New System.Drawing.Point(430, 275)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.ProgressMaxColor = System.Drawing.SystemColors.ActiveCaption
        Me.ProgressBar.ProgressMinColor = System.Drawing.SystemColors.HotTrack
        Me.ProgressBar.ProgressOffset = 10
        Me.ProgressBar.ProgressThickness = 4
        Me.ProgressBar.Size = New System.Drawing.Size(40, 40)
        Me.ProgressBar.TabIndex = 32
        Me.ProgressBar.Value = 40
        Me.ProgressBar.Visible = False
        '
        'pctLogoStrongchest
        '
        Me.pctLogoStrongchest.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pctLogoStrongchest.Image = Global.Strongchest.My.Resources.Resources.logo
        Me.pctLogoStrongchest.Location = New System.Drawing.Point(12, 46)
        Me.pctLogoStrongchest.Name = "pctLogoStrongchest"
        Me.pctLogoStrongchest.Size = New System.Drawing.Size(876, 117)
        Me.pctLogoStrongchest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctLogoStrongchest.TabIndex = 30
        Me.pctLogoStrongchest.TabStop = False
        '
        'LoginPage
        '
        Me.AcceptButton = Me.StartInterface
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(900, 450)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.lblOtherOptions)
        Me.Controls.Add(Me.pctLogoStrongchest)
        Me.Controls.Add(Me.lblDisplayVersion)
        Me.Controls.Add(Me.lblPasswordTips)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.StartInterface)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginPage"
        Me.Opacity = 0.01R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LogOn"
        CType(Me.pctLogoStrongchest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrPasswordChecker As Timer
    Friend WithEvents lblPasswordTips As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtPassword As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents StartInterface As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents lblDisplayVersion As Guna.UI.WinForms.GunaLabel
    Friend WithEvents pctLogoStrongchest As PictureBox
    Friend WithEvents lblOtherOptions As Guna.UI.WinForms.GunaLabel
    Friend WithEvents ProgressBar As Guna.UI.WinForms.GunaCircleProgressBar
End Class
