Module Main

    Sub Main()

        Dim csvTable As New CsvTable()
        csvTable.DrawCsvToTerminal(String.Format("VeryBasicSzenario;With{0}NoHard;Case", vbCrLf))

        Console.ReadKey() ' wait for user to end the program
    End Sub

End Module
