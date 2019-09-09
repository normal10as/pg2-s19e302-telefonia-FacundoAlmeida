Public Class Persona

    Public Sub New(Apellido, Nombre, Documento)
        Me.Apellido = Apellido
        Me.Nombre = Nombre
        Me.Documento = Documento

    End Sub

    Public Sub New()
        Apellido = " "
        Nombre = " "
        Documento = 0

    End Sub
    ''falta toString():String



    ''' '''''''''''

    Private _apellido As String

    Public Property Apellido As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            If value.Length > 0 And value.Length < 30 Then
                _apellido = value
            End If
        End Set
    End Property
    '''''''''''

    Private _nombre As String
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            If value.Length > 0 And value.Length < 50 Then
                _nombre = value
            End If
        End Set
    End Property

    ''''''''''''''''''''
    Private _documento As UInteger
    Public Property Documento As UInteger
        Get
            Return _documento
        End Get
        Set(value As UInteger)
            _documento = value
        End Set
    End Property


End Class
