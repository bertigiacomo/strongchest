<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdvBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdvBox))
        Me.pnlEllipsePanel = New Guna.UI.WinForms.GunaElipsePanel()
        Me.CorpLabel = New Guna.UI.WinForms.GunaLabel()
        Me.CloseForm = New Guna.UI.WinForms.GunaButton()
        Me.lblHeading = New Guna.UI.WinForms.GunaLabel()
        Me.pnlEllipsePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlEllipsePanel
        '
        Me.pnlEllipsePanel.BackColor = System.Drawing.Color.Transparent
        Me.pnlEllipsePanel.BaseColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.pnlEllipsePanel.Controls.Add(Me.CorpLabel)
        Me.pnlEllipsePanel.Controls.Add(Me.CloseForm)
        Me.pnlEllipsePanel.Controls.Add(Me.lblHeading)
        Me.pnlEllipsePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlEllipsePanel.Location = New System.Drawing.Point(0, 0)
        Me.pnlEllipsePanel.Name = "pnlEllipsePanel"
        Me.pnlEllipsePanel.Radius = 4
        Me.pnlEllipsePanel.Size = New System.Drawing.Size(339, 211)
        Me.pnlEllipsePanel.TabIndex = 1
        '
        'CorpLabel
        '
        Me.CorpLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.CorpLabel.Font = New System.Drawing.Font("DM Sans", 13.5!)
        Me.CorpLabel.ForeColor = System.Drawing.Color.LightGray
        Me.CorpLabel.Location = New System.Drawing.Point(22, 81)
        Me.CorpLabel.Name = "CorpLabel"
        Me.CorpLabel.Size = New System.Drawing.Size(294, 96)
        Me.CorpLabel.TabIndex = 82
        Me.CorpLabel.Text = "Messaggio da Strongchest"
        Me.CorpLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me.CloseForm.Location = New System.Drawing.Point(280, 18)
        Me.CloseForm.Name = "CloseForm"
        Me.CloseForm.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.CloseForm.OnHoverBorderColor = System.Drawing.Color.Black
        Me.CloseForm.OnHoverForeColor = System.Drawing.Color.White
        Me.CloseForm.OnHoverImage = Nothing
        Me.CloseForm.OnPressedColor = System.Drawing.Color.Black
        Me.CloseForm.Size = New System.Drawing.Size(36, 36)
        Me.CloseForm.TabIndex = 81
        '
        'lblHeading
        '
        Me.lblHeading.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lblHeading.Font = New System.Drawing.Font("DM Sans Medium", 12.75!)
        Me.lblHeading.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblHeading.Location = New System.Drawing.Point(22, 18)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(252, 36)
        Me.lblHeading.TabIndex = 80
        Me.lblHeading.Text = "Messaggio"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AdvBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(339, 211)
        Me.Controls.Add(Me.pnlEllipsePanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AdvBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Strongchest"
        Me.pnlEllipsePanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlEllipsePanel As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents CloseForm As Guna.UI.WinForms.GunaButton
    Friend WithEvents lblHeading As Guna.UI.WinForms.GunaLabel
    Friend WithEvents CorpLabel As Guna.UI.WinForms.GunaLabel
End Class
