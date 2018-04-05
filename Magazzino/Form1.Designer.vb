<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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
        Me.components = New System.ComponentModel.Container()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnProdotto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnDescrizione = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnQuantita = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnBarcode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TastoDx = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RicaricaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InserisciToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.EliminaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.EsciToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TastoDx.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnID, Me.ColumnProdotto, Me.ColumnDescrizione, Me.ColumnQuantita, Me.ColumnBarcode})
        Me.ListView1.ContextMenuStrip = Me.TastoDx
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(922, 518)
        Me.ListView1.TabIndex = 3
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnID
        '
        Me.ColumnID.Text = "ID"
        '
        'ColumnProdotto
        '
        Me.ColumnProdotto.Text = "Prodotto"
        Me.ColumnProdotto.Width = 150
        '
        'ColumnDescrizione
        '
        Me.ColumnDescrizione.Text = "Descrizione"
        Me.ColumnDescrizione.Width = 300
        '
        'ColumnQuantita
        '
        Me.ColumnQuantita.Text = "Quantita"
        Me.ColumnQuantita.Width = 100
        '
        'ColumnBarcode
        '
        Me.ColumnBarcode.Text = "Barcode"
        Me.ColumnBarcode.Width = 250
        '
        'TastoDx
        '
        Me.TastoDx.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RicaricaToolStripMenuItem, Me.InserisciToolStripMenuItem1, Me.ToolStripMenuItem2, Me.EliminaToolStripMenuItem, Me.ModificaToolStripMenuItem, Me.ToolStripMenuItem3, Me.EsciToolStripMenuItem1})
        Me.TastoDx.Name = "TastoDx"
        Me.TastoDx.Size = New System.Drawing.Size(122, 126)
        '
        'RicaricaToolStripMenuItem
        '
        Me.RicaricaToolStripMenuItem.Name = "RicaricaToolStripMenuItem"
        Me.RicaricaToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.RicaricaToolStripMenuItem.Text = "Carica"
        '
        'InserisciToolStripMenuItem1
        '
        Me.InserisciToolStripMenuItem1.Name = "InserisciToolStripMenuItem1"
        Me.InserisciToolStripMenuItem1.Size = New System.Drawing.Size(121, 22)
        Me.InserisciToolStripMenuItem1.Text = "Inserisci"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(118, 6)
        '
        'EliminaToolStripMenuItem
        '
        Me.EliminaToolStripMenuItem.Name = "EliminaToolStripMenuItem"
        Me.EliminaToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.EliminaToolStripMenuItem.Text = "Elimina"
        '
        'ModificaToolStripMenuItem
        '
        Me.ModificaToolStripMenuItem.Name = "ModificaToolStripMenuItem"
        Me.ModificaToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.ModificaToolStripMenuItem.Text = "Modifica"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(118, 6)
        '
        'EsciToolStripMenuItem1
        '
        Me.EsciToolStripMenuItem1.Name = "EsciToolStripMenuItem1"
        Me.EsciToolStripMenuItem1.Size = New System.Drawing.Size(121, 22)
        Me.EsciToolStripMenuItem1.Text = "Esci"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 518)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestionale Slim"
        Me.TastoDx.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnProdotto As ColumnHeader
    Friend WithEvents ColumnDescrizione As ColumnHeader
    Friend WithEvents ColumnQuantita As ColumnHeader
    Friend WithEvents ColumnBarcode As ColumnHeader
    Friend WithEvents TastoDx As ContextMenuStrip
    Friend WithEvents EliminaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InserisciToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents ModificaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents EsciToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RicaricaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColumnID As ColumnHeader
End Class
