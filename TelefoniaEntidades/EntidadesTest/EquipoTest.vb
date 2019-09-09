Imports System
Imports Entidades

Module EquipoModule
    Sub EquipoTest()
        Dim Equipo1 As Equipo
        Equipo1 = New Equipo()

        ''Prueba setters
        Equipo1.Serie = "Serie Equipo"


        ' Prueba Getters
        Console.WriteLine("Fecha Venta: " & Equipo1.FechaVenta)
        Console.WriteLine("Serie: " & Equipo1.Serie)
    End Sub



End Module
