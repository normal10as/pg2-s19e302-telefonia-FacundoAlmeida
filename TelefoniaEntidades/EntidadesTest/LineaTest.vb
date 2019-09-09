Imports System
Imports Entidades

Module LineaModule
    Sub LineaTest()
        Dim Linea1 As Linea
        Linea1 = New Linea(0, 0)
        'test setters
        Linea1.CodigoArea = "3764"
        Linea1.Numero = "257623"

        'test getters
        Console.WriteLine("Codigo area: " & Linea1.CodigoArea)
        Console.WriteLine("Numero: " & Linea1.Numero)
        ' Console.WriteLine("Estado: " & Linea1.Estado)


    End Sub



End Module
