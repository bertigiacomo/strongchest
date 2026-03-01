<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteAllData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeleteAllData))
        Me.pnlEllipsePanel = New Guna.UI.WinForms.GunaElipsePanel()
        Me.lblActionDescription = New Guna.UI.WinForms.GunaLabel()
        Me.btnDeleteAllData = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.CloseForm = New Guna.UI.WinForms.GunaButton()
        Me.lblHeading = New Guna.UI.WinForms.GunaLabel()
        Me.pnlEllipsePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlEllipsePanel
        '
        Me.pnlEllipsePanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlEllipsePanel.BackColor = System.Drawing.Color.Transparent
        Me.pnlEllipsePanel.BaseColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.pnlEllipsePanel.Controls.Add(Me.lblActionDescription)
        Me.pnlEllipsePanel.Controls.Add(Me.btnDeleteAllData)
        Me.pnlEllipsePanel.Controls.Add(Me.CloseForm)
        Me.pnlEllipsePanel.Controls.Add(Me.lblHeading)
        Me.pnlEllipsePanel.Location = New System.Drawing.Point(0, 0)
        Me.pnlEllipsePanel.Name = "pnlEllipsePanel"
        Me.pnlEllipsePanel.Radius = 4
        Me.pnlEllipsePanel.Size = New System.Drawing.Size(450, 350)
        Me.pnlEllipsePanel.TabIndex = 2
        '
        'lblActionDescription
        '
        Me.lblActionDescription.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblActionDescription.Font = New System.Drawing.Font("DM Sans", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActionDescription.ForeColor = System.Drawing.Color.LightGray
        Me.lblActionDescription.Location = New System.Drawing.Point(29, 64)
        Me.lblActionDescription.Name = "lblActionDescription"
        Me.lblActionDescription.Size = New System.Drawing.Size(391, 175)
        Me.lblActionDescription.TabIndex = 85
        Me.lblActionDescription.Text = resources.GetString("lblActionDescription.Text")
        '
        'btnDeleteAllData
        '
        Me.btnDeleteAllData.Animated = True
        Me.btnDeleteAllData.AnimationHoverSpeed = 0.07!
        Me.btnDeleteAllData.AnimationSpeed = 0.03!
        Me.btnDeleteAllData.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteAllData.BaseColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnDeleteAllData.BorderColor = System.Drawing.Color.Black
        Me.btnDeleteAllData.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnDeleteAllData.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnDeleteAllData.CheckedForeColor = System.Drawing.Color.White
        Me.btnDeleteAllData.CheckedImage = Global.Strongchest.My.Resources.Resources.reset_space
        Me.btnDeleteAllData.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnDeleteAllData.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnDeleteAllData.FocusedColor = System.Drawing.Color.Empty
        Me.btnDeleteAllData.Font = New System.Drawing.Font("DM Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteAllData.ForeColor = System.Drawing.Color.White
        Me.btnDeleteAllData.Image = Nothing
        Me.btnDeleteAllData.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnDeleteAllData.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnDeleteAllData.Location = New System.Drawing.Point(29, 264)
        Me.btnDeleteAllData.Name = "btnDeleteAllData"
        Me.btnDeleteAllData.OnHoverBaseColor = System.Drawing.Color.Firebrick
        Me.btnDeleteAllData.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnDeleteAllData.OnHoverForeColor = System.Drawing.Color.White
        Me.btnDeleteAllData.OnHoverImage = Nothing
        Me.btnDeleteAllData.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnDeleteAllData.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnDeleteAllData.OnPressedDepth = 100
        Me.btnDeleteAllData.Radius = 2
        Me.btnDeleteAllData.Size = New System.Drawing.Size(391, 49)
        Me.btnDeleteAllData.TabIndex = 84
        Me.btnDeleteAllData.Text = "Conferma eliminazione dei dati"
        Me.btnDeleteAllData.TextImageOffsetY = 3
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
        Me.lblHeading.Size = New System.Drawing.Size(349, 36)
        Me.lblHeading.TabIndex = 72
        Me.lblHeading.Text = "Elimina impostazioni e contenuti"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DeleteAllData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(450, 350)
        Me.Controls.Add(Me.pnlEllipsePanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DeleteAllData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delete all data"
        Me.pnlEllipsePanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlEllipsePanel As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents CloseForm As Guna.UI.WinForms.GunaButton
    Friend WithEvents lblHeading As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnDeleteAllData As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents lblActionDescription As Guna.UI.WinForms.GunaLabel
End Class
