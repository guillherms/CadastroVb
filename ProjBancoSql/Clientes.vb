Public Class Clientes
    Private _codcli As Integer
    Private _nomecli As String
    Private _enderecocli As String
    Private _telefonecli As String

    Public Property Codcli As Integer
        Get
            Return _codcli
        End Get
        Set(value As Integer)
            _codcli = value
        End Set
    End Property

    Public Property Nomecli As String
        Get
            Return _nomecli
        End Get
        Set(value As String)
            _nomecli = value
        End Set
    End Property

    Public Property Enderecocli As String
        Get
            Return _enderecocli
        End Get
        Set(value As String)
            _enderecocli = value
        End Set
    End Property

    Public Property Telefonecli As String
        Get
            Return _telefonecli
        End Get
        Set(value As String)
            _telefonecli = value
        End Set
    End Property
End Class
