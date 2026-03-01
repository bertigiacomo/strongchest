<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutStrongchest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutStrongchest))
        Me.lblWelcome = New Guna.UI.WinForms.GunaLabel()
        Me.IconsCredit = New Guna.UI.WinForms.GunaLabel()
        Me.pnlToolbar = New Guna.UI.WinForms.GunaPanel()
        Me.btnClose = New Guna.UI.WinForms.GunaButton()
        Me.ControlResize = New Guna.UI.WinForms.GunaResize(Me.components)
        Me.ControlDrag = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.lblSubtitle = New Guna.UI.WinForms.GunaLabel()
        Me.DataVersions = New Guna.UI.WinForms.GunaLabel()
        Me.pnlToolbar.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblWelcome.Font = New System.Drawing.Font("DM Sans Medium", 15.75!)
        Me.lblWelcome.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblWelcome.Location = New System.Drawing.Point(12, 68)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(654, 45)
        Me.lblWelcome.TabIndex = 22
        Me.lblWelcome.Text = "Strongchest v12"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'IconsCredit
        '
        Me.IconsCredit.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconsCredit.Font = New System.Drawing.Font("DM Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconsCredit.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconsCredit.Location = New System.Drawing.Point(12, 158)
        Me.IconsCredit.Name = "IconsCredit"
        Me.IconsCredit.Size = New System.Drawing.Size(654, 26)
        Me.IconsCredit.TabIndex = 24
        Me.IconsCredit.Text = "Icone fornite da Icons8"
        Me.IconsCredit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'pnlToolbar
        '
        Me.pnlToolbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.pnlToolbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlToolbar.Controls.Add(Me.btnClose)
        Me.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlToolbar.Location = New System.Drawing.Point(0, 0)
        Me.pnlToolbar.Name = "pnlToolbar"
        Me.pnlToolbar.Size = New System.Drawing.Size(678, 20)
        Me.pnlToolbar.TabIndex = 30
        '
        'btnClose
        '
        Me.btnClose.AnimationHoverSpeed = 0.07!
        Me.btnClose.AnimationSpeed = 0.03!
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BaseColor = System.Drawing.Color.Transparent
        Me.btnClose.BorderColor = System.Drawing.Color.Black
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.FocusedColor = System.Drawing.Color.Empty
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnClose.ImageSize = New System.Drawing.Size(12, 12)
        Me.btnClose.Location = New System.Drawing.Point(653, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.btnClose.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnClose.OnHoverForeColor = System.Drawing.Color.White
        Me.btnClose.OnHoverImage = Nothing
        Me.btnClose.OnPressedColor = System.Drawing.Color.Black
        Me.btnClose.OnPressedDepth = 0
        Me.btnClose.Size = New System.Drawing.Size(25, 20)
        Me.btnClose.TabIndex = 13
        '
        'ControlResize
        '
        Me.ControlResize.TargetForm = Me
        '
        'ControlDrag
        '
        Me.ControlDrag.TargetControl = Me.pnlToolbar
        '
        'lblSubtitle
        '
        Me.lblSubtitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSubtitle.Font = New System.Drawing.Font("DM Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtitle.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblSubtitle.Location = New System.Drawing.Point(12, 113)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(654, 34)
        Me.lblSubtitle.TabIndex = 23
        Me.lblSubtitle.Text = "Sviluppato con ❤️ da Giacomo Berti"
        Me.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DataVersions
        '
        Me.DataVersions.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataVersions.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.DataVersions.ForeColor = System.Drawing.Color.Gainsboro
        Me.DataVersions.Location = New System.Drawing.Point(12, 198)
        Me.DataVersions.Name = "DataVersions"
        Me.DataVersions.Size = New System.Drawing.Size(654, 71)
        Me.DataVersions.TabIndex = 31
        Me.DataVersions.Text = "Data" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Data" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Data" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.DataVersions.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'AboutStrongchest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(678, 332)
        Me.Controls.Add(Me.DataVersions)
        Me.Controls.Add(Me.pnlToolbar)
        Me.Controls.Add(Me.IconsCredit)
        Me.Controls.Add(Me.lblSubtitle)
        Me.Controls.Add(Me.lblWelcome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AboutStrongchest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Info"
        Me.pnlToolbar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblWelcome As Guna.UI.WinForms.GunaLabel
    Friend WithEvents IconsCredit As Guna.UI.WinForms.GunaLabel
    Friend WithEvents pnlToolbar As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btnClose As Guna.UI.WinForms.GunaButton
    Friend WithEvents ControlResize As Guna.UI.WinForms.GunaResize
    Friend WithEvents ControlDrag As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents lblSubtitle As Guna.UI.WinForms.GunaLabel
    Friend WithEvents DataVersions As Guna.UI.WinForms.GunaLabel
End Class
