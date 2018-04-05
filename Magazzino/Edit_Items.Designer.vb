<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Items
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Barcode_TXT = New System.Windows.Forms.TextBox()
        Me.Quantita_txt = New System.Windows.Forms.TextBox()
        Me.Descrizione_txt = New System.Windows.Forms.TextBox()
        Me.Prodotto_txt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(69, 112)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Modifica"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Quantita:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Barcode:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(-3, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Descrizione:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Prodotto:"
        '
        'Barcode_TXT
        '
        Me.Barcode_TXT.Location = New System.Drawing.Point(68, 84)
        Me.Barcode_TXT.Name = "Barcode_TXT"
        Me.Barcode_TXT.Size = New System.Drawing.Size(140, 20)
        Me.Barcode_TXT.TabIndex = 12
        '
        'Quantita_txt
        '
        Me.Quantita_txt.Location = New System.Drawing.Point(68, 58)
        Me.Quantita_txt.Name = "Quantita_txt"
        Me.Quantita_txt.Size = New System.Drawing.Size(141, 20)
        Me.Quantita_txt.TabIndex = 11
        '
        'Descrizione_txt
        '
        Me.Descrizione_txt.Location = New System.Drawing.Point(68, 32)
        Me.Descrizione_txt.Name = "Descrizione_txt"
        Me.Descrizione_txt.Size = New System.Drawing.Size(142, 20)
        Me.Descrizione_txt.TabIndex = 10
        '
        'Prodotto_txt
        '
        Me.Prodotto_txt.Location = New System.Drawing.Point(68, 6)
        Me.Prodotto_txt.Name = "Prodotto_txt"
        Me.Prodotto_txt.Size = New System.Drawing.Size(142, 20)
        Me.Prodotto_txt.TabIndex = 9
        '
        'Edit_Items
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(211, 137)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Barcode_TXT)
        Me.Controls.Add(Me.Quantita_txt)
        Me.Controls.Add(Me.Descrizione_txt)
        Me.Controls.Add(Me.Prodotto_txt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Edit_Items"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modifica Campo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Barcode_TXT As TextBox
    Friend WithEvents Quantita_txt As TextBox
    Friend WithEvents Descrizione_txt As TextBox
    Friend WithEvents Prodotto_txt As TextBox
End Class
