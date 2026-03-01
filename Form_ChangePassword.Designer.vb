<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangePassword))
        Me.FileDecryption = New System.ComponentModel.BackgroundWorker()
        Me.FileEncryption = New System.ComponentModel.BackgroundWorker()
        Me.DebugLabel = New System.Windows.Forms.Label()
        Me.Progress = New Guna.UI.WinForms.GunaProgressBar()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FileDecryption
        '
        '
        'FileEncryption
        '
        '
        'DebugLabel
        '
        Me.DebugLabel.Font = New System.Drawing.Font("DM Sans", 9.75!)
        Me.DebugLabel.ForeColor = System.Drawing.Color.Silver
        Me.DebugLabel.Location = New System.Drawing.Point(97, 210)
        Me.DebugLabel.Name = "DebugLabel"
        Me.DebugLabel.Size = New System.Drawing.Size(403, 23)
        Me.DebugLabel.TabIndex = 24
        Me.DebugLabel.Text = "Cambio della password in corso..."
        Me.DebugLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Progress
        '
        Me.Progress.BackColor = System.Drawing.Color.Transparent
        Me.Progress.BorderColor = System.Drawing.Color.Black
        Me.Progress.ColorStyle = Guna.UI.WinForms.ColorStyle.[Default]
        Me.Progress.IdleColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Progress.Location = New System.Drawing.Point(100, 240)
        Me.Progress.Name = "Progress"
        Me.Progress.ProgressMaxColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Progress.ProgressMinColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Progress.Radius = 5
        Me.Progress.Size = New System.Drawing.Size(400, 10)
        Me.Progress.TabIndex = 23
        '
        'picLogo
        '
        Me.picLogo.Image = Global.Strongchest.My.Resources.Resources.logo
        Me.picLogo.Location = New System.Drawing.Point(0, 50)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(600, 140)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 22
        Me.picLogo.TabStop = False
        '
        'ChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(600, 300)
        Me.Controls.Add(Me.DebugLabel)
        Me.Controls.Add(Me.Progress)
        Me.Controls.Add(Me.picLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ChangePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambia password"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FileDecryption As System.ComponentModel.BackgroundWorker
    Friend WithEvents FileEncryption As System.ComponentModel.BackgroundWorker
    Friend WithEvents DebugLabel As Label
    Friend WithEvents Progress As Guna.UI.WinForms.GunaProgressBar
    Friend WithEvents picLogo As PictureBox
End Class
