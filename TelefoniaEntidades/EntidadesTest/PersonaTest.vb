Imports System
Imports Entidades

Module PersonaModule
    Sub PersonaTest()
        Dim Persona1 As Persona
        Persona1 = New Persona("", "", 0)



        'test setters longitud
        Persona1.Apellido = "Apellido maximo de treinta caracteresAAAAAAAAAAA"
        Persona1.Nombre = "Nombre 1 maximo de cincuenta caracteresAAAAAAAAAAAAAAAAAAAAAAAA"
        Persona1.Documento = "422322441"


        'test getters
        Console.WriteLine("Apellido: " & Persona1.Apellido)
        Console.WriteLine("Nombre: " & Persona1.Nombre)
        Console.WriteLine("Documento: " & Persona1.Documento)






        'test setters
        Persona1.Apellido = "Apellido1"
        Persona1.Nombre = "Nombre1"
        Persona1.Documento = "422322441"


        'test getters
        Console.WriteLine("Apellido: " & Persona1.Apellido)
        Console.WriteLine("Nombre: " & Persona1.Nombre)
        Console.WriteLine("Documento: " & Persona1.Documento)



    End Sub



End Module
