Imports MySql.Data.MySqlClient

Public Class sql
    Dim Connection As MySqlConnection = Nothing

    Public Function Execute(Command As String) As Boolean
        Try
            Connection = New MySqlConnection
            Connection.ConnectionString = Config.Server
            Connection.Open()
            Using cmd As MySqlCommand = Connection.CreateCommand
                cmd.CommandText = Command
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            Return False
        Finally
            Connection.Close()
        End Try
    End Function

    Public Function Rows_Engine(Prodotto As String, Descrizione As String, Quantita As String, Barcode As String, ID As String, Action As String) As Boolean
        Try
            Dim Query = String.Empty
            If Action = "INSERT" Then
                Query = "INSERT INTO utensili (Prodotto,Descrizione,Quantita,Barcode) VALUES (@prod,@desc,@quant,@bar)"
            ElseIf Action = "UPDATE" Then
                Query = "update utensili set Prodotto = @prod,Descrizione = @desc, Quantita = @quant, Barcode = @bar where id = '" + ID + "';"
            End If
            Connection = New MySqlConnection()
            Connection.ConnectionString = Config.Server
            Connection.Open()
            Using cmd As MySqlCommand = Connection.CreateCommand
                cmd.CommandText = Query
                With cmd.Parameters
                    .AddWithValue("@prod", Prodotto)
                    .AddWithValue("@desc", Descrizione)
                    .AddWithValue("@quant", Quantita)
                    .AddWithValue("@bar", Barcode)
                End With

                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            Return False
        Finally
            Connection.Close()
        End Try
    End Function

End Class
