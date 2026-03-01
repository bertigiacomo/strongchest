<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VoidControl
    Inherits System.Windows.Forms.UserControl

    'UserControl esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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
        Me.lblBig = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblBig
        '
        Me.lblBig.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblBig.Font = New System.Drawing.Font("DM Sans", 11.0!)
        Me.lblBig.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblBig.Location = New System.Drawing.Point(0, 0)
        Me.lblBig.Name = "lblBig"
        Me.lblBig.Size = New System.Drawing.Size(400, 60)
        Me.lblBig.TabIndex = 3
        Me.lblBig.Text = "La tua strongchest è vuota" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Trascina qua dei file per aggiungerli all'archivio"
        Me.lblBig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'VoidControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Controls.Add(Me.lblBig)
        Me.Name = "VoidControl"
        Me.Size = New System.Drawing.Size(400, 60)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblBig As Label
End Class
