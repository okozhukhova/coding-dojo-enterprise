Module Main

    Sub Main()

        Dim tabelle As New csv_table.csv.tabellieren.CsvTable
        'tabelle.DrawCsvToTerminal(String.Format("VeryBasicSzenario;With{0}NoHard;Case", vbCrLf))
        tabelle.DrawCsvToTerminal("C:\Users\oleksandra\Desktop\test.txt")
       
        Console.ReadKey() ' wait for user to end the program
    End Sub

End Module
