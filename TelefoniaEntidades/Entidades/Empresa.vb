Public Class Empresa

    Public Sub New(RazonSocial, Cuit)
        Me.RazonSocial = RazonSocial
        Me.Cuit = Cuit
    End Sub

    'falta ToString():String

    Private _razonSocial As String
    Public Property RazonSocial As String
        Get
            Return _razonSocial
        End Get
        Set(value As String)
            If value.Length > 0 And value.Length < 80 Then
                _razonSocial = value
            End If
        End Set
    End Property

    Private _cuit As String
    Public Property Cuit As String
        Get
            Return _cuit
        End Get
        Set(value As String)
            If value.Length > 0 And value.Length < 13 Then
                _cuit = value
            End If

        End Set
    End Property


End Class
