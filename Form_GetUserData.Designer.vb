<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MsgBoxGetData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MsgBoxGetData))
        Me.pnlEllipsePanel = New Guna.UI.WinForms.GunaElipsePanel()
        Me.CloseForm = New Guna.UI.WinForms.GunaButton()
        Me.btnSubmitData = New Guna.UI.WinForms.GunaButton()
        Me.txtDataRequest = New Guna.UI.WinForms.GunaTextBox()
        Me.lblActionDesc = New Guna.UI.WinForms.GunaLabel()
        Me.pnlEllipsePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlEllipsePanel
        '
        Me.pnlEllipsePanel.BackColor = System.Drawing.Color.Transparent
        Me.pnlEllipsePanel.BaseColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.pnlEllipsePanel.Controls.Add(Me.CloseForm)
        Me.pnlEllipsePanel.Controls.Add(Me.btnSubmitData)
        Me.pnlEllipsePanel.Controls.Add(Me.txtDataRequest)
        Me.pnlEllipsePanel.Controls.Add(Me.lblActionDesc)
        Me.pnlEllipsePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlEllipsePanel.Location = New System.Drawing.Point(0, 0)
        Me.pnlEllipsePanel.Name = "pnlEllipsePanel"
        Me.pnlEllipsePanel.Radius = 4
        Me.pnlEllipsePanel.Size = New System.Drawing.Size(531, 165)
        Me.pnlEllipsePanel.TabIndex = 0
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
        Me.CloseForm.Location = New System.Drawing.Point(483, 12)
        Me.CloseForm.Name = "CloseForm"
        Me.CloseForm.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.CloseForm.OnHoverBorderColor = System.Drawing.Color.Black
        Me.CloseForm.OnHoverForeColor = System.Drawing.Color.White
        Me.CloseForm.OnHoverImage = Nothing
        Me.CloseForm.OnPressedColor = System.Drawing.Color.Black
        Me.CloseForm.Size = New System.Drawing.Size(36, 36)
        Me.CloseForm.TabIndex = 80
        '
        'btnSubmitData
        '
        Me.btnSubmitData.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSubmitData.AnimationHoverSpeed = 0.07!
        Me.btnSubmitData.AnimationSpeed = 0.03!
        Me.btnSubmitData.BackColor = System.Drawing.Color.Transparent
        Me.btnSubmitData.BaseColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSubmitData.BorderColor = System.Drawing.Color.Black
        Me.btnSubmitData.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSubmitData.FocusedColor = System.Drawing.Color.Empty
        Me.btnSubmitData.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSubmitData.ForeColor = System.Drawing.Color.White
        Me.btnSubmitData.Image = Nothing
        Me.btnSubmitData.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSubmitData.Location = New System.Drawing.Point(428, 91)
        Me.btnSubmitData.Margin = New System.Windows.Forms.Padding(10)
        Me.btnSubmitData.Name = "btnSubmitData"
        Me.btnSubmitData.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSubmitData.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSubmitData.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSubmitData.OnHoverImage = Nothing
        Me.btnSubmitData.OnPressedColor = System.Drawing.Color.Black
        Me.btnSubmitData.Radius = 3
        Me.btnSubmitData.Size = New System.Drawing.Size(70, 35)
        Me.btnSubmitData.TabIndex = 30
        Me.btnSubmitData.Text = "OK"
        Me.btnSubmitData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDataRequest
        '
        Me.txtDataRequest.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDataRequest.BackColor = System.Drawing.Color.Transparent
        Me.txtDataRequest.BaseColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDataRequest.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDataRequest.BorderSize = 0
        Me.txtDataRequest.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDataRequest.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDataRequest.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDataRequest.FocusedForeColor = System.Drawing.Color.White
        Me.txtDataRequest.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtDataRequest.ForeColor = System.Drawing.Color.Gainsboro
        Me.txtDataRequest.Location = New System.Drawing.Point(35, 91)
        Me.txtDataRequest.MaximumSize = New System.Drawing.Size(460, 35)
        Me.txtDataRequest.MaxLength = 129
        Me.txtDataRequest.Name = "txtDataRequest"
        Me.txtDataRequest.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDataRequest.Radius = 3
        Me.txtDataRequest.Size = New System.Drawing.Size(380, 35)
        Me.txtDataRequest.TabIndex = 29
        Me.txtDataRequest.TextOffsetX = 5
        '
        'lblActionDesc
        '
        Me.lblActionDesc.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblActionDesc.Font = New System.Drawing.Font("DM Sans", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActionDesc.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblActionDesc.Location = New System.Drawing.Point(12, 22)
        Me.lblActionDesc.Name = "lblActionDesc"
        Me.lblActionDesc.Size = New System.Drawing.Size(507, 45)
        Me.lblActionDesc.TabIndex = 28
        Me.lblActionDesc.Text = "Azione richiesta all'utente"
        Me.lblActionDesc.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'MsgBoxGetData
        '
        Me.AcceptButton = Me.btnSubmitData
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(531, 165)
        Me.Controls.Add(Me.pnlEllipsePanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MsgBoxGetData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Strongchest: inserisci dati"
        Me.TopMost = True
        Me.pnlEllipsePanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlEllipsePanel As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents btnSubmitData As Guna.UI.WinForms.GunaButton
    Friend WithEvents txtDataRequest As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents lblActionDesc As Guna.UI.WinForms.GunaLabel
    Friend WithEvents CloseForm As Guna.UI.WinForms.GunaButton
End Class
