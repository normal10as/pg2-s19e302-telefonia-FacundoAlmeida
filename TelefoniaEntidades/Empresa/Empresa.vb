Public Class Empresa
    Private _razonSocial As String
    Public Property RazonSocial As String
        Get
            Return _razonSocial

        End Get
        Set(value As String)
            _razonSocial = value
        End Set
    End Property


    Private _cuit As String
    Public Property Cuit As String
        Get
            Return _cuit

        End Get
        Set(value As String)
            _cuit = value
        End Set
    End Property
End Class
