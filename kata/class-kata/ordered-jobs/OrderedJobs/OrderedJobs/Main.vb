Module Main
    Sub Main()
        Dim job As OrderedJobs = New OrderedJobs
        'Dim args As String() = Environment.GetCommandLineArgs()
        'For Each Arg In args
        '    Console.WriteLine(Arg)
        'Next
        'Dim jobs As String
        'jobs = Console.ReadLine()
        'Console.WriteLine()

        'tabelle.DrawCsvToTerminal(String.Format("VeryBasicSzenario;With{0}NoHard;Case", vbCrLf))
        job.Register("a")
        job.Register("b", "c")
        job.Register("c", "f")
        job.Register("d", "a")
        job.Register("e")
        job.Register("f", "b")
        Console.WriteLine(job.Sort())
        Console.ReadKey() ' wait for user to end the program
    End Sub


End Module
