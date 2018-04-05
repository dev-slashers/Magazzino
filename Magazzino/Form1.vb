Imports MySql.Data.MySqlClient

Public Class Form1

    Dim Connessione As MySqlConnection = Nothing

    Public Function Load_list() As Boolean
        Dim ID As Integer = 0
        Connessione = New MySqlConnection
        Connessione.ConnectionString = Config.Server
        Dim Query As String = "SELECT * FROM utensili"
        Dim cmd As MySqlCommand = New MySqlCommand(Query, Connessione)
        Try
            Connessione.Open()
            Dim read As MySqlDataReader = cmd.ExecuteReader
            While read.Read
                ListView1.Items.Add(read.GetString(0))
                ListView1.Items(ID).SubItems.Add(read.GetString(1))
                ListView1.Items(ID).SubItems.Add(read.GetString(2))
                ListView1.Items(ID).SubItems.Add(read.GetString(3))
                ListView1.Items(ID).SubItems.Add(read.GetString(4))
                ID += 1
            End While
            read.Close()
            Return True
        Catch ex As Exception
            Return False
        Finally
            Connessione.Close()
        End Try
    End Function


    Public Function Check_Connection() As Boolean
        Try
            Connessione.ConnectionString = Server
            Connessione.Open()
            Return True
        Catch ex As Exception
            Return False
        Finally
            Connessione.Close()
        End Try
    End Function

    Public Sub Edit()
        Try
            Dim Elemento As String = ListView1.SelectedItems(0).Text
            Dim Edit As Edit_Items = New Edit_Items
            With ListView1.SelectedItems(0)
                Edit.Prodotto = .SubItems(1).Text
                Edit.Descrizione = .SubItems(2).Text
                Edit.Quantita = .SubItems(3).Text
                Edit.Barcode = .SubItems(4).Text
                Edit.ID = .SubItems(0).Text
            End With

            Edit.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Selezionare una voce", "errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_list()
    End Sub


    Private Sub InserisciToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles InserisciToolStripMenuItem1.Click
        Add_Items.ShowDialog()
    End Sub

    Private Sub RicaricaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RicaricaToolStripMenuItem.Click
        ListView1.Items.Clear()
        Load_list()
    End Sub

    Private Sub EsciToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EsciToolStripMenuItem1.Click
        Application.Exit()
    End Sub

    Private Sub EliminaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminaToolStripMenuItem.Click
        Dim Delete As sql = New sql
        Try
            Delete.Execute("DELETE FROM utensili WHERE id = '" + ListView1.SelectedItems(0).Text + "';")
        Catch ex As Exception
            MessageBox.Show("Selezionare una voce", "errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ListView1.Items.Clear()
            Load_list()
        End Try
    End Sub

    Private Sub ModificaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificaToolStripMenuItem.Click
        Edit()
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        Edit()
    End Sub
End Class


