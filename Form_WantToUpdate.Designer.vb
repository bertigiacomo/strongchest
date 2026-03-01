<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateSelector
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateSelector))
        Me.lblActionDescription = New Guna.UI.WinForms.GunaLabel()
        Me.lblHeading = New Guna.UI.WinForms.GunaLabel()
        Me.UpdateNO = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.DownloadUpdate = New System.ComponentModel.BackgroundWorker()
        Me.UpdateFAST = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.UpdateOK = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.DownloadUpdateFast = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'lblActionDescription
        '
        Me.lblActionDescription.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblActionDescription.Font = New System.Drawing.Font("DM Sans", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActionDescription.ForeColor = System.Drawing.Color.LightGray
        Me.lblActionDescription.Location = New System.Drawing.Point(82, 107)
        Me.lblActionDescription.Margin = New System.Windows.Forms.Padding(24)
        Me.lblActionDescription.Name = "lblActionDescription"
        Me.lblActionDescription.Size = New System.Drawing.Size(481, 124)
        Me.lblActionDescription.TabIndex = 87
        Me.lblActionDescription.Text = resources.GetString("lblActionDescription.Text")
        Me.lblActionDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblHeading
        '
        Me.lblHeading.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHeading.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lblHeading.Font = New System.Drawing.Font("DM Sans Medium", 14.0!)
        Me.lblHeading.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblHeading.Location = New System.Drawing.Point(12, 58)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(616, 36)
        Me.lblHeading.TabIndex = 86
        Me.lblHeading.Text = "Aggiornamento per Strongchest disponibile"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'UpdateNO
        '
        Me.UpdateNO.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UpdateNO.Animated = True
        Me.UpdateNO.AnimationHoverSpeed = 0.07!
        Me.UpdateNO.AnimationSpeed = 0.03!
        Me.UpdateNO.BackColor = System.Drawing.Color.Transparent
        Me.UpdateNO.BaseColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.UpdateNO.BorderColor = System.Drawing.Color.Black
        Me.UpdateNO.CheckedBaseColor = System.Drawing.Color.Gray
        Me.UpdateNO.CheckedBorderColor = System.Drawing.Color.Black
        Me.UpdateNO.CheckedForeColor = System.Drawing.Color.White
        Me.UpdateNO.CheckedImage = Global.Strongchest.My.Resources.Resources.reset_space
        Me.UpdateNO.CheckedLineColor = System.Drawing.Color.DimGray
        Me.UpdateNO.DialogResult = System.Windows.Forms.DialogResult.None
        Me.UpdateNO.FocusedColor = System.Drawing.Color.Empty
        Me.UpdateNO.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.UpdateNO.ForeColor = System.Drawing.Color.LightGray
        Me.UpdateNO.Image = Nothing
        Me.UpdateNO.ImageSize = New System.Drawing.Size(40, 40)
        Me.UpdateNO.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.UpdateNO.Location = New System.Drawing.Point(37, 331)
        Me.UpdateNO.Name = "UpdateNO"
        Me.UpdateNO.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.UpdateNO.OnHoverBorderColor = System.Drawing.Color.Black
        Me.UpdateNO.OnHoverForeColor = System.Drawing.Color.White
        Me.UpdateNO.OnHoverImage = Nothing
        Me.UpdateNO.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.UpdateNO.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.UpdateNO.OnPressedDepth = 100
        Me.UpdateNO.Radius = 2
        Me.UpdateNO.Size = New System.Drawing.Size(570, 21)
        Me.UpdateNO.TabIndex = 89
        Me.UpdateNO.Text = "Ignora aggiornamento (sconsigliato)"
        Me.UpdateNO.TextImageOffsetY = 3
        '
        'DownloadUpdate
        '
        '
        'UpdateFAST
        '
        Me.UpdateFAST.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UpdateFAST.Animated = True
        Me.UpdateFAST.AnimationHoverSpeed = 0.07!
        Me.UpdateFAST.AnimationSpeed = 0.03!
        Me.UpdateFAST.BackColor = System.Drawing.Color.Transparent
        Me.UpdateFAST.BaseColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.UpdateFAST.BorderColor = System.Drawing.Color.Black
        Me.UpdateFAST.CheckedBaseColor = System.Drawing.Color.Gray
        Me.UpdateFAST.CheckedBorderColor = System.Drawing.Color.Black
        Me.UpdateFAST.CheckedForeColor = System.Drawing.Color.White
        Me.UpdateFAST.CheckedImage = Global.Strongchest.My.Resources.Resources.reset_space
        Me.UpdateFAST.CheckedLineColor = System.Drawing.Color.DimGray
        Me.UpdateFAST.DialogResult = System.Windows.Forms.DialogResult.None
        Me.UpdateFAST.FocusedColor = System.Drawing.Color.Empty
        Me.UpdateFAST.Font = New System.Drawing.Font("DM Sans", 12.0!)
        Me.UpdateFAST.ForeColor = System.Drawing.Color.White
        Me.UpdateFAST.Image = Nothing
        Me.UpdateFAST.ImageSize = New System.Drawing.Size(40, 40)
        Me.UpdateFAST.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.UpdateFAST.Location = New System.Drawing.Point(37, 242)
        Me.UpdateFAST.Name = "UpdateFAST"
        Me.UpdateFAST.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.UpdateFAST.OnHoverBorderColor = System.Drawing.Color.Black
        Me.UpdateFAST.OnHoverForeColor = System.Drawing.Color.White
        Me.UpdateFAST.OnHoverImage = Nothing
        Me.UpdateFAST.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.UpdateFAST.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.UpdateFAST.OnPressedDepth = 100
        Me.UpdateFAST.Radius = 2
        Me.UpdateFAST.Size = New System.Drawing.Size(570, 50)
        Me.UpdateFAST.TabIndex = 90
        Me.UpdateFAST.Text = "Installazione veloce"
        Me.UpdateFAST.TextImageOffsetY = 3
        '
        'UpdateOK
        '
        Me.UpdateOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UpdateOK.Animated = True
        Me.UpdateOK.AnimationHoverSpeed = 0.07!
        Me.UpdateOK.AnimationSpeed = 0.03!
        Me.UpdateOK.BackColor = System.Drawing.Color.Transparent
        Me.UpdateOK.BaseColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.UpdateOK.BorderColor = System.Drawing.Color.Black
        Me.UpdateOK.CheckedBaseColor = System.Drawing.Color.Gray
        Me.UpdateOK.CheckedBorderColor = System.Drawing.Color.Black
        Me.UpdateOK.CheckedForeColor = System.Drawing.Color.WhiteSmoke
        Me.UpdateOK.CheckedImage = Global.Strongchest.My.Resources.Resources.reset_space
        Me.UpdateOK.CheckedLineColor = System.Drawing.Color.DimGray
        Me.UpdateOK.DialogResult = System.Windows.Forms.DialogResult.None
        Me.UpdateOK.FocusedColor = System.Drawing.Color.Empty
        Me.UpdateOK.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.UpdateOK.ForeColor = System.Drawing.Color.LightGray
        Me.UpdateOK.Image = Nothing
        Me.UpdateOK.ImageSize = New System.Drawing.Size(40, 40)
        Me.UpdateOK.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.UpdateOK.Location = New System.Drawing.Point(37, 304)
        Me.UpdateOK.Name = "UpdateOK"
        Me.UpdateOK.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.UpdateOK.OnHoverBorderColor = System.Drawing.Color.Black
        Me.UpdateOK.OnHoverForeColor = System.Drawing.Color.White
        Me.UpdateOK.OnHoverImage = Nothing
        Me.UpdateOK.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.UpdateOK.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.UpdateOK.OnPressedDepth = 100
        Me.UpdateOK.Radius = 2
        Me.UpdateOK.Size = New System.Drawing.Size(570, 25)
        Me.UpdateOK.TabIndex = 91
        Me.UpdateOK.Text = "Configura con Windows Installer"
        Me.UpdateOK.TextImageOffsetY = 3
        '
        'DownloadUpdateFast
        '
        '
        'UpdateSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(640, 400)
        Me.Controls.Add(Me.UpdateOK)
        Me.Controls.Add(Me.UpdateFAST)
        Me.Controls.Add(Me.UpdateNO)
        Me.Controls.Add(Me.lblActionDescription)
        Me.Controls.Add(Me.lblHeading)
        Me.Font = New System.Drawing.Font("DM Sans", 9.0!)
        Me.ForeColor = System.Drawing.Color.Gainsboro
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "UpdateSelector"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Strongchest"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblActionDescription As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblHeading As Guna.UI.WinForms.GunaLabel
    Friend WithEvents UpdateNO As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents DownloadUpdate As System.ComponentModel.BackgroundWorker
    Friend WithEvents UpdateFAST As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents UpdateOK As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents DownloadUpdateFast As System.ComponentModel.BackgroundWorker
End Class
