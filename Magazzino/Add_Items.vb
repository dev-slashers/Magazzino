Imports MySql.Data.MySqlClient

Public Class Add_Items
    Dim Connessione As MySqlConnection = Nothing

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim inser As sql = New sql
        Connessione = New MySqlConnection
        If inser.Rows_Engine(Prodotto_txt.Text, Descrizione_txt.Text, Quantita_txt.Text, Barcode_TXT.Text, Nothing, "INSERT") Then
            Prodotto_txt.Text = String.Empty
            Descrizione_txt.Text = String.Empty
            Quantita_txt.Text = String.Empty
            Barcode_TXT.Text = String.Empty
            Form1.ListView1.Items.Clear()
            Form1.Load_list()
            Me.Close()
        End If
    End Sub
End Class