<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ImportDataControl
    Inherits System.Windows.Forms.UserControl

    'UserControl esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ProgressBar = New Guna.UI.WinForms.GunaCircleProgressBar()
        Me.lblBig = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ProgressBar
        '
        Me.ProgressBar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ProgressBar.Animated = True
        Me.ProgressBar.AnimationSpeed = 2.4!
        Me.ProgressBar.BaseColor = System.Drawing.Color.Transparent
        Me.ProgressBar.IdleColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ProgressBar.IdleOffset = 5
        Me.ProgressBar.IdleThickness = 4
        Me.ProgressBar.Image = Nothing
        Me.ProgressBar.ImageSize = New System.Drawing.Size(52, 52)
        Me.ProgressBar.Location = New System.Drawing.Point(31, 6)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.ProgressMaxColor = System.Drawing.SystemColors.MenuHighlight
        Me.ProgressBar.ProgressMinColor = System.Drawing.SystemColors.ActiveCaption
        Me.ProgressBar.ProgressOffset = 5
        Me.ProgressBar.ProgressThickness = 4
        Me.ProgressBar.Size = New System.Drawing.Size(30, 30)
        Me.ProgressBar.TabIndex = 38
        Me.ProgressBar.Value = 60
        '
        'lblBig
        '
        Me.lblBig.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBig.Font = New System.Drawing.Font("DM Sans Medium", 11.25!)
        Me.lblBig.ForeColor = System.Drawing.Color.LightGray
        Me.lblBig.Location = New System.Drawing.Point(70, 0)
        Me.lblBig.Name = "lblBig"
        Me.lblBig.Size = New System.Drawing.Size(577, 42)
        Me.lblBig.TabIndex = 35
        Me.lblBig.Text = "caricamento in corso..."
        Me.lblBig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ImportDataControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Controls.Add(Me.lblBig)
        Me.Controls.Add(Me.ProgressBar)
        Me.Name = "ImportDataControl"
        Me.Size = New System.Drawing.Size(650, 42)
        Me.Tag = "persistent"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ProgressBar As Guna.UI.WinForms.GunaCircleProgressBar
    Friend WithEvents lblBig As Label
End Class
