Imports System
Imports Entidades

Module EmpresaModule
    Sub EmpresaTest()
        Dim TestEmpresa As Empresa
        TestEmpresa = New Empresa("", "")
        ''setters longitud
        TestEmpresa.RazonSocial = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
        TestEmpresa.Cuit = "masde13caracteresaca"
        ''getters longitud
        Console.WriteLine("Razon Social: " & TestEmpresa.RazonSocial)
        Console.WriteLine("Cuit: " & TestEmpresa.Cuit)

        ''setters 
        TestEmpresa.RazonSocial = "Prueba Razon Social1"
        TestEmpresa.Cuit = "Prueba Cuit"
        ''getters
        Console.WriteLine("Razon Social: " & TestEmpresa.RazonSocial)
        Console.WriteLine("Cuit: " & TestEmpresa.Cuit)







    End Sub
End Module
