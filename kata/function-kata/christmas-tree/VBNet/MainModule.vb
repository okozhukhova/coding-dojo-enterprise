
Module MainModule

    Public Sub Main()
        Dim args As String() = Environment.GetCommandLineArgs()
        For Each Arg In args
            Console.WriteLine(Arg)
        Next
        Dim hoehe As Integer

        Dim mitStern As Boolean

        If UBound(args) + 1 <> 3 Then
            Console.WriteLine("Anzahl der Argumente stimmt nicht.")
            hoehe = Console.ReadLine()
            Console.WriteLine()
            mitStern = Console.ReadLine()
        Else
            hoehe = args(1)
            mitStern = args(2)
        End If





        Dim christmasTree As New ChristmasTree()
        christmasTree.DrawChristmasTree(hoehe, mitStern)
        Console.ReadKey() ' wait till next key so the user can see the tree

    End Sub
End Module
