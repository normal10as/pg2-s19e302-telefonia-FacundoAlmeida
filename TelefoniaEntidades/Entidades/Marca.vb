﻿Public Class Marca

    Private _nombreMarca As String

    Public Sub New(NombreMarca)
        Me.NombreMarca = NombreMarca
    End Sub

    Public Property NombreMarca As String
        Get
            Return _nombreMarca
        End Get
        Set(value As String)
            If value.Length > 0 And value.Length < 30 Then
                _nombreMarca = value

            End If
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return NombreMarca & "  "
    End Function

End Class
