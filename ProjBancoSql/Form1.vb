Imports System.Data.SqlClient

Public Class Form1
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection(My.Settings.conexao)
        Dim consultaSql As String = "select * from clientes"
        Dim comando As New SqlCommand(consultaSql, con)

        Try
            Dim da As New SqlDataAdapter(comando)
            Dim ds As New DataSet
            da.Fill(ds, "clientes")
            Me.DataGridView1.DataSource = ds.Tables("clientes")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class
