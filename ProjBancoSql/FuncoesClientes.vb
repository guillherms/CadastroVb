Imports System.Data.SqlClient

Public Class FuncoesClientes
    Dim conexao As New SqlConnection(My.Settings.conexao)
    Dim comando As New SqlCommand()

    Public Function Excluir_Cliente(ByVal data As Clientes) As Boolean
        Try
            conexao.Open()
            comando = New SqlCommand("SP_ExcluirCliente", conexao)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@cod_cli", data.Codcli)

            If comando.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexao.Close()
        End Try


    End Function
End Class
