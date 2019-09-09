Public Class Linea

    Public Sub New(codigoArea, numero)
        Me.CodigoArea = codigoArea
        Me.Numero = numero
    End Sub

    Public Sub New()
        CodigoArea = 0
        Numero = 0



    End Sub
    Public Function Suspender()
        _estado = 0
        Return _estado
    End Function

    Public Function reactivar()
        _estado = 1
        Return _estado

    End Function

    ''falta to string''
    Private _codigoArea As UShort
    Public Property CodigoArea As UShort
        Get

            Return _codigoArea

        End Get
        Set(value As UShort)
            _codigoArea = value

        End Set
    End Property


    Private _numero As UInteger
    Public Property Numero As UInteger
        Get
            Return _numero
        End Get
        Set(value As UInteger)
            _numero = value
        End Set
    End Property

    Private _estado As String
    Public ReadOnly Property Estado As String
        Get
            If _estado = 1 Then
                Return "Activo"
            End If
            Return "Suspendido"
        End Get
    End Property

End Class
