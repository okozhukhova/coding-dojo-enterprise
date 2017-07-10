Module Main

    Sub Main()
        Dim args As String() = Environment.GetCommandLineArgs()
        For Each Arg In args
            Console.WriteLine(Arg)
        Next
        Dim dateiname As String
        If UBound(args) + 1 <> 2 Then
            Console.WriteLine("Anzahl der Argumente stimmt nicht.")
            dateiname = Console.ReadLine()
            Console.WriteLine()
        Else
            dateiname = args(1)
        End If

        Dim tabelle As New csv_table.csv.tabellieren.CsvTable
        'tabelle.DrawCsvToTerminal(String.Format("VeryBasicSzenario;With{0}NoHard;Case", vbCrLf))
        tabelle.DrawCsvToTerminal(dateiname)

        Console.ReadKey() ' wait for user to end the program
    End Sub

End Module
