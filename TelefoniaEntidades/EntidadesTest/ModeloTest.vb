Imports System
Imports Entidades

Module ModeloModule
    Sub ModeloTest()
        Dim Modelo1 As Modelo
        Modelo1 = New Modelo("")

        'test setters longitud
        Modelo1.NombreModelo = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"
        ' test getters
        Console.WriteLine("Modelo: " & Modelo1.NombreModelo)


        'test setters 
        Modelo1.NombreModelo = "Modelo Uno"
        ' test getters
        Console.WriteLine("Modelo: " & Modelo1.NombreModelo)



    End Sub

End Module
