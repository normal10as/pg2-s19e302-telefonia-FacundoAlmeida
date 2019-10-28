Public Class Linea
    Inherits Equipo
    Public Sub New(NombreMarca As String, NombreModelo As String, Serie As String, CodigoArea As UShort, Numero As UInteger)
        MyBase.New(NombreMarca, NombreModelo, Serie)
        Me.CodigoArea = CodigoArea
        Me.Numero = Numero
    End Sub


    Public Function Suspender()
        _estado = 0
        Return _estado
    End Function

    Public Function reactivar()
        _estado = 1
        Return _estado

    End Function


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

    Public Overrides Function ToString() As String
        If _estado = 1 Then
            Return " " & CodigoArea & Numero & "Activado."
        Else
            Return " " & CodigoArea & Numero & "Suspendido."
        End If


    End Function

End Class
