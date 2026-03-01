<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Export
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Export))
        Me.Progress = New Guna.UI.WinForms.GunaProgressBar()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.SaveExportDialog = New System.Windows.Forms.SaveFileDialog()
        Me.FileDecrypt = New System.ComponentModel.BackgroundWorker()
        Me.CreateZip = New System.ComponentModel.BackgroundWorker()
        Me.EncryptArchive = New System.ComponentModel.BackgroundWorker()
        Me.CreateData = New System.ComponentModel.BackgroundWorker()
        Me.DebugLabel = New System.Windows.Forms.Label()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Progress
        '
        Me.Progress.BackColor = System.Drawing.Color.Transparent
        Me.Progress.BorderColor = System.Drawing.Color.Black
        Me.Progress.ColorStyle = Guna.UI.WinForms.ColorStyle.[Default]
        Me.Progress.IdleColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Progress.Location = New System.Drawing.Point(100, 240)
        Me.Progress.Maximum = 200
        Me.Progress.Name = "Progress"
        Me.Progress.ProgressMaxColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Progress.ProgressMinColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Progress.Radius = 5
        Me.Progress.Size = New System.Drawing.Size(400, 10)
        Me.Progress.TabIndex = 20
        '
        'picLogo
        '
        Me.picLogo.Image = Global.Strongchest.My.Resources.Resources.logo
        Me.picLogo.Location = New System.Drawing.Point(0, 50)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(600, 140)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 19
        Me.picLogo.TabStop = False
        '
        'SaveExportDialog
        '
        Me.SaveExportDialog.Filter = "Spazio di Strongchest|*.chest"
        Me.SaveExportDialog.Title = "Seleziona dove salvare il tuo archivio"
        '
        'FileDecrypt
        '
        '
        'CreateZip
        '
        '
        'EncryptArchive
        '
        '
        'CreateData
        '
        '
        'DebugLabel
        '
        Me.DebugLabel.Font = New System.Drawing.Font("DM Sans", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DebugLabel.ForeColor = System.Drawing.Color.Silver
        Me.DebugLabel.Location = New System.Drawing.Point(97, 210)
        Me.DebugLabel.Name = "DebugLabel"
        Me.DebugLabel.Size = New System.Drawing.Size(403, 23)
        Me.DebugLabel.TabIndex = 21
        Me.DebugLabel.Text = "Salvataggio dello spazio protetto"
        Me.DebugLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Export
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
        Me.Name = "Export"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Esportazione dati"
        Me.TopMost = True
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Progress As Guna.UI.WinForms.GunaProgressBar
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents SaveExportDialog As SaveFileDialog
    Friend WithEvents FileDecrypt As System.ComponentModel.BackgroundWorker
    Friend WithEvents CreateZip As System.ComponentModel.BackgroundWorker
    Friend WithEvents EncryptArchive As System.ComponentModel.BackgroundWorker
    Friend WithEvents CreateData As System.ComponentModel.BackgroundWorker
    Friend WithEvents DebugLabel As Label
End Class
