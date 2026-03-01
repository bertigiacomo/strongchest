<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManangeSpace
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
        Me.components = New System.ComponentModel.Container()
        Me.tmrLimiterConfig = New System.Windows.Forms.Timer(Me.components)
        Me.ManangeSpacePanel = New Guna.UI.WinForms.GunaElipsePanel()
        Me.lblFreeSpace = New Guna.UI.WinForms.GunaLabel()
        Me.lblAppUse = New Guna.UI.WinForms.GunaLabel()
        Me.lblUserUse = New Guna.UI.WinForms.GunaLabel()
        Me.CircularGraph = New Guna.UI.WinForms.GunaCircleProgressBar()
        Me.lblPar_UsedSpace = New Guna.UI.WinForms.GunaLabel()
        Me.lblLimitSet = New Guna.UI.WinForms.GunaLabel()
        Me.lblPar_Limit = New Guna.UI.WinForms.GunaLabel()
        Me.LimitBar = New Guna.UI.WinForms.GunaTrackBar()
        Me.CloseForm = New Guna.UI.WinForms.GunaButton()
        Me.lblHeading = New Guna.UI.WinForms.GunaLabel()
        Me.ManangeSpacePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrLimiterConfig
        '
        '
        'ManangeSpacePanel
        '
        Me.ManangeSpacePanel.BackColor = System.Drawing.Color.Transparent
        Me.ManangeSpacePanel.BaseColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ManangeSpacePanel.Controls.Add(Me.lblFreeSpace)
        Me.ManangeSpacePanel.Controls.Add(Me.lblAppUse)
        Me.ManangeSpacePanel.Controls.Add(Me.lblUserUse)
        Me.ManangeSpacePanel.Controls.Add(Me.CircularGraph)
        Me.ManangeSpacePanel.Controls.Add(Me.lblPar_UsedSpace)
        Me.ManangeSpacePanel.Controls.Add(Me.lblLimitSet)
        Me.ManangeSpacePanel.Controls.Add(Me.lblPar_Limit)
        Me.ManangeSpacePanel.Controls.Add(Me.LimitBar)
        Me.ManangeSpacePanel.Controls.Add(Me.CloseForm)
        Me.ManangeSpacePanel.Controls.Add(Me.lblHeading)
        Me.ManangeSpacePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ManangeSpacePanel.Location = New System.Drawing.Point(0, 0)
        Me.ManangeSpacePanel.Name = "ManangeSpacePanel"
        Me.ManangeSpacePanel.Radius = 4
        Me.ManangeSpacePanel.Size = New System.Drawing.Size(600, 320)
        Me.ManangeSpacePanel.TabIndex = 91
        '
        'lblFreeSpace
        '
        Me.lblFreeSpace.AutoSize = True
        Me.lblFreeSpace.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lblFreeSpace.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lblFreeSpace.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblFreeSpace.Location = New System.Drawing.Point(129, 146)
        Me.lblFreeSpace.Name = "lblFreeSpace"
        Me.lblFreeSpace.Size = New System.Drawing.Size(142, 20)
        Me.lblFreeSpace.TabIndex = 100
        Me.lblFreeSpace.Text = "Spazio Libero: 92GB"
        Me.lblFreeSpace.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblAppUse
        '
        Me.lblAppUse.AutoSize = True
        Me.lblAppUse.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lblAppUse.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lblAppUse.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblAppUse.Location = New System.Drawing.Point(129, 121)
        Me.lblAppUse.Name = "lblAppUse"
        Me.lblAppUse.Size = New System.Drawing.Size(166, 20)
        Me.lblAppUse.TabIndex = 99
        Me.lblAppUse.Text = "File applicazione: 28MB"
        Me.lblAppUse.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblUserUse
        '
        Me.lblUserUse.AutoSize = True
        Me.lblUserUse.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lblUserUse.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lblUserUse.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblUserUse.Location = New System.Drawing.Point(129, 96)
        Me.lblUserUse.Name = "lblUserUse"
        Me.lblUserUse.Size = New System.Drawing.Size(147, 20)
        Me.lblUserUse.TabIndex = 98
        Me.lblUserUse.Text = "Utilizzo utente: 28Gb"
        Me.lblUserUse.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'CircularGraph
        '
        Me.CircularGraph.AnimationSpeed = 0.6!
        Me.CircularGraph.BaseColor = System.Drawing.Color.Transparent
        Me.CircularGraph.IdleColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.CircularGraph.IdleOffset = 10
        Me.CircularGraph.IdleThickness = 10
        Me.CircularGraph.Image = Nothing
        Me.CircularGraph.ImageSize = New System.Drawing.Size(52, 52)
        Me.CircularGraph.Location = New System.Drawing.Point(29, 86)
        Me.CircularGraph.Name = "CircularGraph"
        Me.CircularGraph.ProgressMaxColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.CircularGraph.ProgressMinColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.CircularGraph.ProgressOffset = 10
        Me.CircularGraph.ProgressThickness = 10
        Me.CircularGraph.Size = New System.Drawing.Size(90, 90)
        Me.CircularGraph.TabIndex = 97
        Me.CircularGraph.Value = 66
        '
        'lblPar_UsedSpace
        '
        Me.lblPar_UsedSpace.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lblPar_UsedSpace.Font = New System.Drawing.Font("DM Sans", 11.0!)
        Me.lblPar_UsedSpace.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblPar_UsedSpace.Location = New System.Drawing.Point(14, 56)
        Me.lblPar_UsedSpace.Name = "lblPar_UsedSpace"
        Me.lblPar_UsedSpace.Size = New System.Drawing.Size(556, 24)
        Me.lblPar_UsedSpace.TabIndex = 96
        Me.lblPar_UsedSpace.Text = "Spazio utilizzato:"
        '
        'lblLimitSet
        '
        Me.lblLimitSet.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lblLimitSet.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lblLimitSet.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblLimitSet.Location = New System.Drawing.Point(18, 266)
        Me.lblLimitSet.Name = "lblLimitSet"
        Me.lblLimitSet.Size = New System.Drawing.Size(565, 36)
        Me.lblLimitSet.TabIndex = 95
        Me.lblLimitSet.Text = "Limite attuale: nessuno"
        Me.lblLimitSet.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPar_Limit
        '
        Me.lblPar_Limit.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lblPar_Limit.Font = New System.Drawing.Font("DM Sans", 11.0!)
        Me.lblPar_Limit.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblPar_Limit.Location = New System.Drawing.Point(14, 196)
        Me.lblPar_Limit.Name = "lblPar_Limit"
        Me.lblPar_Limit.Size = New System.Drawing.Size(556, 36)
        Me.lblPar_Limit.TabIndex = 94
        Me.lblPar_Limit.Text = "Imposta un limite dati:"
        Me.lblPar_Limit.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'LimitBar
        '
        Me.LimitBar.Location = New System.Drawing.Point(18, 241)
        Me.LimitBar.Name = "LimitBar"
        Me.LimitBar.Size = New System.Drawing.Size(567, 23)
        Me.LimitBar.TabIndex = 93
        Me.LimitBar.TrackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.LimitBar.TrackHoverColor = System.Drawing.Color.Gray
        Me.LimitBar.TrackIdleColor = System.Drawing.Color.Silver
        Me.LimitBar.TrackPressedColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.LimitBar.Value = 0
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
        Me.CloseForm.Location = New System.Drawing.Point(551, 14)
        Me.CloseForm.Name = "CloseForm"
        Me.CloseForm.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.CloseForm.OnHoverBorderColor = System.Drawing.Color.Black
        Me.CloseForm.OnHoverForeColor = System.Drawing.Color.White
        Me.CloseForm.OnHoverImage = Nothing
        Me.CloseForm.OnPressedColor = System.Drawing.Color.Black
        Me.CloseForm.Size = New System.Drawing.Size(36, 36)
        Me.CloseForm.TabIndex = 92
        '
        'lblHeading
        '
        Me.lblHeading.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lblHeading.Font = New System.Drawing.Font("DM Sans Medium", 12.75!)
        Me.lblHeading.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblHeading.Location = New System.Drawing.Point(14, 14)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(446, 36)
        Me.lblHeading.TabIndex = 91
        Me.lblHeading.Text = "Utilizzo disco"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ManangeSpace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(600, 320)
        Me.Controls.Add(Me.ManangeSpacePanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ManangeSpace"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage space"
        Me.ManangeSpacePanel.ResumeLayout(False)
        Me.ManangeSpacePanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmrLimiterConfig As Timer
    Friend WithEvents ManangeSpacePanel As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents lblFreeSpace As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblAppUse As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblUserUse As Guna.UI.WinForms.GunaLabel
    Friend WithEvents CircularGraph As Guna.UI.WinForms.GunaCircleProgressBar
    Friend WithEvents lblPar_UsedSpace As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblLimitSet As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblPar_Limit As Guna.UI.WinForms.GunaLabel
    Friend WithEvents LimitBar As Guna.UI.WinForms.GunaTrackBar
    Friend WithEvents CloseForm As Guna.UI.WinForms.GunaButton
    Friend WithEvents lblHeading As Guna.UI.WinForms.GunaLabel
End Class
