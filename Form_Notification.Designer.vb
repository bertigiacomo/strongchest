<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Notification
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
        Me.lblHeading = New Guna.UI.WinForms.GunaLabel()
        Me.lblCorp = New Guna.UI.WinForms.GunaLabel()
        Me.PicIcon = New System.Windows.Forms.PictureBox()
        CType(Me.PicIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblHeading.BackColor = System.Drawing.Color.Transparent
        Me.lblHeading.Font = New System.Drawing.Font("DM Sans Medium", 12.0!)
        Me.lblHeading.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblHeading.Location = New System.Drawing.Point(94, 11)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(319, 36)
        Me.lblHeading.TabIndex = 73
        Me.lblHeading.Text = "Modifiche salvate"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCorp
        '
        Me.lblCorp.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblCorp.BackColor = System.Drawing.Color.Transparent
        Me.lblCorp.Font = New System.Drawing.Font("DM Sans", 11.0!)
        Me.lblCorp.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblCorp.Location = New System.Drawing.Point(94, 41)
        Me.lblCorp.Name = "lblCorp"
        Me.lblCorp.Size = New System.Drawing.Size(319, 53)
        Me.lblCorp.TabIndex = 74
        Me.lblCorp.Text = "Le modifiche a ""file.txt"" sono state salvate con successo nella libreria."
        '
        'PicIcon
        '
        Me.PicIcon.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PicIcon.Image = Global.Strongchest.My.Resources.Resources.fl_tick
        Me.PicIcon.Location = New System.Drawing.Point(18, 24)
        Me.PicIcon.Margin = New System.Windows.Forms.Padding(20)
        Me.PicIcon.Name = "PicIcon"
        Me.PicIcon.Size = New System.Drawing.Size(61, 50)
        Me.PicIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicIcon.TabIndex = 0
        Me.PicIcon.TabStop = False
        '
        'Notification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(425, 103)
        Me.Controls.Add(Me.lblCorp)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.PicIcon)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Notification"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "LowerNotification"
        CType(Me.PicIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PicIcon As PictureBox
    Friend WithEvents lblHeading As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblCorp As Guna.UI.WinForms.GunaLabel
End Class
