<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Control_NotificationTop
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
        Me.NotificationClick = New Guna.UI.WinForms.GunaButton()
        Me.SuspendLayout()
        '
        'NotificationClick
        '
        Me.NotificationClick.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NotificationClick.AnimationHoverSpeed = 0.07!
        Me.NotificationClick.AnimationSpeed = 0.03!
        Me.NotificationClick.BackColor = System.Drawing.Color.Transparent
        Me.NotificationClick.BaseColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.NotificationClick.BorderColor = System.Drawing.Color.Transparent
        Me.NotificationClick.DialogResult = System.Windows.Forms.DialogResult.None
        Me.NotificationClick.FocusedColor = System.Drawing.Color.Empty
        Me.NotificationClick.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.NotificationClick.ForeColor = System.Drawing.Color.Gainsboro
        Me.NotificationClick.Image = Global.Strongchest.My.Resources.Resources.new_update
        Me.NotificationClick.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NotificationClick.ImageSize = New System.Drawing.Size(22, 22)
        Me.NotificationClick.Location = New System.Drawing.Point(0, 0)
        Me.NotificationClick.Name = "NotificationClick"
        Me.NotificationClick.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.NotificationClick.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.NotificationClick.OnHoverForeColor = System.Drawing.Color.White
        Me.NotificationClick.OnHoverImage = Nothing
        Me.NotificationClick.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.NotificationClick.OnPressedDepth = 0
        Me.NotificationClick.Radius = 4
        Me.NotificationClick.Size = New System.Drawing.Size(600, 40)
        Me.NotificationClick.TabIndex = 0
        Me.NotificationClick.Text = "Nuovo aggiornamento disponibile. Premi qua per aggiornare."
        Me.NotificationClick.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Control_NotificationTop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Controls.Add(Me.NotificationClick)
        Me.Name = "Control_NotificationTop"
        Me.Size = New System.Drawing.Size(600, 40)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NotificationClick As Guna.UI.WinForms.GunaButton
End Class
