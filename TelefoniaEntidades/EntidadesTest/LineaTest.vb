Imports System
Imports Entidades

Module LineaModule
    Sub LineaTest()
        Dim Linea1 As Linea
        Linea1 = New Linea("LG", "Stylus", "999999", "3764", "257623")


        'test getters
        Console.WriteLine("Codigo area: " & Linea1.CodigoArea)
        Console.WriteLine("Numero telefono: " & Linea1.Numero)
        Linea1.Suspender()
        Console.WriteLine("Estado Linea: " & Linea1.Estado())
        Linea1.reactivar()
        Console.WriteLine("Estado Linea: " & Linea1.Estado())


    End Sub



End Module
