<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Items
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
        Me.Prodotto_txt = New System.Windows.Forms.TextBox()
        Me.Descrizione_txt = New System.Windows.Forms.TextBox()
        Me.Quantita_txt = New System.Windows.Forms.TextBox()
        Me.Barcode_TXT = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Prodotto_txt
        '
        Me.Prodotto_txt.Location = New System.Drawing.Point(68, 9)
        Me.Prodotto_txt.Name = "Prodotto_txt"
        Me.Prodotto_txt.Size = New System.Drawing.Size(142, 20)
        Me.Prodotto_txt.TabIndex = 0
        '
        'Descrizione_txt
        '
        Me.Descrizione_txt.Location = New System.Drawing.Point(68, 35)
        Me.Descrizione_txt.Name = "Descrizione_txt"
        Me.Descrizione_txt.Size = New System.Drawing.Size(142, 20)
        Me.Descrizione_txt.TabIndex = 1
        '
        'Quantita_txt
        '
        Me.Quantita_txt.Location = New System.Drawing.Point(68, 61)
        Me.Quantita_txt.Name = "Quantita_txt"
        Me.Quantita_txt.Size = New System.Drawing.Size(141, 20)
        Me.Quantita_txt.TabIndex = 2
        '
        'Barcode_TXT
        '
        Me.Barcode_TXT.Location = New System.Drawing.Point(68, 87)
        Me.Barcode_TXT.Name = "Barcode_TXT"
        Me.Barcode_TXT.Size = New System.Drawing.Size(140, 20)
        Me.Barcode_TXT.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Prodotto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(-3, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Descrizione:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Barcode:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Quantita:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(69, 115)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Aggiungi"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Add_Items
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(216, 150)
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
        Me.Name = "Add_Items"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inserisci Prodotto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Prodotto_txt As TextBox
    Friend WithEvents Descrizione_txt As TextBox
    Friend WithEvents Quantita_txt As TextBox
    Friend WithEvents Barcode_TXT As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
End Class
