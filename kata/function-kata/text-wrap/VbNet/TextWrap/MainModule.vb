
Module MainModule

    Public Sub Main()
        Dim args As String() = Environment.GetCommandLineArgs()
        For Each Arg In args
            Console.WriteLine(Arg)
        Next
        Dim text As String

        Dim maxTextLength As Integer

        If UBound(args) + 1 <> 3 Then
            Console.WriteLine("Anzahl der Argumente stimmt nicht.")
            text = Console.ReadLine()
            Console.WriteLine()
            maxTextLength = Console.ReadLine()
        Else
            text = args(1)
            maxTextLength = args(2)
        End If

        Dim test As New TextWrapProject.TextWrap()
        Console.WriteLine(test.wrapText(text, maxTextLength))
        Console.ReadKey() ' wait till next key so the user can see the tree


    End Sub
End Module
