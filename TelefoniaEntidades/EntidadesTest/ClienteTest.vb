Imports System
Imports Entidades


Module ClienteModule
    Sub ClienteTest()
        'instancia
        Dim Cliente1 As Cliente
        'inicia
        Cliente1 = New Cliente()
        'test de setters
        Cliente1.Cuenta = 123


        'test de getters
        Console.WriteLine("Cliente: " & Cliente1.Cuenta)







    End Sub
End Module
