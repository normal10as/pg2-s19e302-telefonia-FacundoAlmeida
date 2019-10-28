Public Class Equipo
    Inherits Modelo
    Public Sub New(NombreModelo As String, NombreMarca As String, Serie As String)
        MyBase.New(NombreModelo, NombreMarca)
        Me.Serie = Serie


    End Sub
    Public Function Vender() As Date
        Return Date.Now

    End Function

    Private _serie As String
    Public Property Serie As String
        Get
            Return _serie
        End Get
        Set(value As String)
            If value.Length > 0 And value.Length < 15 Then
                _serie = value
            End If
        End Set
    End Property

    Private _fechaVenta As Date
    Public ReadOnly Property FechaVenta As Date
        Get
            Return Vender()
        End Get
    End Property

End Class
