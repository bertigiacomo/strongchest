<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CompanyGUI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CompanyGUI))
        Me.CompanyPanel = New Guna.UI.WinForms.GunaElipsePanel()
        Me.lblCompanyName = New Guna.UI.WinForms.GunaLabel()
        Me.lblCompanyHelp = New Guna.UI.WinForms.GunaLabel()
        Me.lblCompanyLink = New Guna.UI.WinForms.GunaLabel()
        Me.CloseForm = New Guna.UI.WinForms.GunaButton()
        Me.CompanyPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'CompanyPanel
        '
        Me.CompanyPanel.BackColor = System.Drawing.Color.Transparent
        Me.CompanyPanel.BaseColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.CompanyPanel.Controls.Add(Me.lblCompanyLink)
        Me.CompanyPanel.Controls.Add(Me.lblCompanyHelp)
        Me.CompanyPanel.Controls.Add(Me.lblCompanyName)
        Me.CompanyPanel.Controls.Add(Me.CloseForm)
        Me.CompanyPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CompanyPanel.Location = New System.Drawing.Point(0, 0)
        Me.CompanyPanel.Name = "CompanyPanel"
        Me.CompanyPanel.Radius = 4
        Me.CompanyPanel.Size = New System.Drawing.Size(600, 330)
        Me.CompanyPanel.TabIndex = 1
        '
        'lblCompanyName
        '
        Me.lblCompanyName.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lblCompanyName.Font = New System.Drawing.Font("DM Sans Medium", 19.0!)
        Me.lblCompanyName.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblCompanyName.Location = New System.Drawing.Point(0, 65)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(600, 39)
        Me.lblCompanyName.TabIndex = 80
        Me.lblCompanyName.Text = "Corloborns Inc."
        Me.lblCompanyName.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblCompanyHelp
        '
        Me.lblCompanyHelp.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lblCompanyHelp.Font = New System.Drawing.Font("DM Sans", 11.0!)
        Me.lblCompanyHelp.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblCompanyHelp.Location = New System.Drawing.Point(29, 113)
        Me.lblCompanyHelp.Margin = New System.Windows.Forms.Padding(20)
        Me.lblCompanyHelp.Name = "lblCompanyHelp"
        Me.lblCompanyHelp.Size = New System.Drawing.Size(542, 110)
        Me.lblCompanyHelp.TabIndex = 81
        Me.lblCompanyHelp.Text = resources.GetString("lblCompanyHelp.Text")
        Me.lblCompanyHelp.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblCompanyLink
        '
        Me.lblCompanyLink.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lblCompanyLink.Font = New System.Drawing.Font("DM Sans", 10.75!, System.Drawing.FontStyle.Underline)
        Me.lblCompanyLink.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblCompanyLink.Location = New System.Drawing.Point(0, 268)
        Me.lblCompanyLink.Name = "lblCompanyLink"
        Me.lblCompanyLink.Size = New System.Drawing.Size(600, 38)
        Me.lblCompanyLink.TabIndex = 82
        Me.lblCompanyLink.Text = "Visita il sito web della tua azienda per maggiori informazioni"
        Me.lblCompanyLink.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me.CloseForm.Location = New System.Drawing.Point(554, 14)
        Me.CloseForm.Name = "CloseForm"
        Me.CloseForm.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.CloseForm.OnHoverBorderColor = System.Drawing.Color.Black
        Me.CloseForm.OnHoverForeColor = System.Drawing.Color.White
        Me.CloseForm.OnHoverImage = Nothing
        Me.CloseForm.OnPressedColor = System.Drawing.Color.Black
        Me.CloseForm.Size = New System.Drawing.Size(36, 36)
        Me.CloseForm.TabIndex = 79
        '
        'CompanyGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(600, 330)
        Me.Controls.Add(Me.CompanyPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CompanyGUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Company"
        Me.CompanyPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CompanyPanel As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents CloseForm As Guna.UI.WinForms.GunaButton
    Friend WithEvents lblCompanyLink As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblCompanyHelp As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblCompanyName As Guna.UI.WinForms.GunaLabel
End Class
