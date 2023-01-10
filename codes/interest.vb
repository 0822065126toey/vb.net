Imporst system
Module Module1
    Public deposit, rate As Double
    Sub Main()
        Dim year1, year2 As Double
        rate = 0.02
        deposit = 10000

        year1 = deposit * (1 + rate)
        REM Console.Writeline("First year={0}",year1)
        year2 = year1 * (1 + rate)
        Console.WriteLine("second year={0 d}", year2)
        Console.ReadLine()

    End Sub

End Module
