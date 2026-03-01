<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RelaseNotes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RelaseNotes))
        Me.lblSubtitle = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.pnlToolbar = New Guna.UI.WinForms.GunaPanel()
        Me.btnClose = New Guna.UI.WinForms.GunaButton()
        Me.ResizeControl = New Guna.UI.WinForms.GunaResize(Me.components)
        Me.DragControl = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.pnlToolbar.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSubtitle
        '
        Me.lblSubtitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSubtitle.Font = New System.Drawing.Font("DM Sans Medium", 12.75!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblSubtitle.Location = New System.Drawing.Point(12, 37)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(685, 33)
        Me.lblSubtitle.TabIndex = 23
        Me.lblSubtitle.Text = "Novità della nuova versione"
        Me.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'GunaLabel1
        '
        Me.GunaLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaLabel1.Font = New System.Drawing.Font("DM Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.LightGray
        Me.GunaLabel1.Location = New System.Drawing.Point(17, 83)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(680, 290)
        Me.GunaLabel1.TabIndex = 24
        Me.GunaLabel1.Text = resources.GetString("GunaLabel1.Text")
        '
        'pnlToolbar
        '
        Me.pnlToolbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.pnlToolbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlToolbar.Controls.Add(Me.btnClose)
        Me.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlToolbar.Location = New System.Drawing.Point(0, 0)
        Me.pnlToolbar.Name = "pnlToolbar"
        Me.pnlToolbar.Size = New System.Drawing.Size(709, 20)
        Me.pnlToolbar.TabIndex = 25
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
        Me.btnClose.Image = Global.Strongchest.My.Resources.Resources.ui_close
        Me.btnClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnClose.ImageSize = New System.Drawing.Size(12, 12)
        Me.btnClose.Location = New System.Drawing.Point(684, 0)
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
        'ResizeControl
        '
        Me.ResizeControl.TargetForm = Me
        '
        'DragControl
        '
        Me.DragControl.TargetControl = Me.pnlToolbar
        '
        'RelaseNotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(709, 402)
        Me.Controls.Add(Me.pnlToolbar)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.lblSubtitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RelaseNotes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Novità dell'ultima versione"
        Me.pnlToolbar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblSubtitle As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents pnlToolbar As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btnClose As Guna.UI.WinForms.GunaButton
    Friend WithEvents ResizeControl As Guna.UI.WinForms.GunaResize
    Friend WithEvents DragControl As Guna.UI.WinForms.GunaDragControl
End Class
