Imports System
Imports Entidades

Module MarcaModule
    Sub MarcaTest()
        Dim Marca1 As Marca
        Marca1 = New Marca("")

        'test setters longitud
        Marca1.NombreMarca = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"
        ' test getters
        Console.WriteLine("Marca: " & Marca1.NombreMarca)


        'test setters 
        Marca1.NombreMarca = "Marca Uno"
        ' test getters
        Console.WriteLine("Marca: " & Marca1.NombreMarca)



    End Sub

End Module
