Public Class Edit_Items

    Public Property Prodotto As String
    Public Property Descrizione As String
    Public Property Quantita As String
    Public Property Barcode As String
    Public Property ID As String

    Private Sub Edit_Items_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Prodotto_txt.Text = Prodotto
        Descrizione_txt.Text = Descrizione
        Quantita_txt.Text = Quantita
        Barcode_TXT.Text = Barcode
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Update As sql = New sql
        If Update.Rows_Engine(Prodotto_txt.Text, Descrizione_txt.Text, Quantita_txt.Text, Barcode_TXT.Text, ID, "UPDATE") = True Then
            Form1.ListView1.Items.Clear()
            Form1.Load_list()
            Me.Close()
        End If
    End Sub
End Class