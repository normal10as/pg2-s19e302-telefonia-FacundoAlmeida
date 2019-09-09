Public Class Equipo
    Public Sub New(Marca, Modelo, Serie)
        Me.Serie = Serie

    End Sub
    'Public Sub Vender(as Date)
    '
    '    End Sub

    Public Sub New()
        _fechaVenta = #10-20-2019#
        _serie = " "
    End Sub
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
            Return _fechaVenta
        End Get
    End Property

End Class
