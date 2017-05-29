
Module MainModule

    Public Sub Main()
        If Not (Environment.GetCommandLineArgs().Length = 3) Then
            Console.WriteLine("USAGE: text-wrap 'text that should be wrapped' <maxTextLength>")
        End If
        Dim text As String = Environment.GetCommandLineArgs(1)
        Dim maxTextLength As Integer = CInt(Environment.GetCommandLineArgs()(2))

        Dim textWrap As New TextWrapProject.TextWrap()
        Console.WriteLine(textWrap.WrapText(text, maxTextLength))
        'textWrap.wrapText()
        Console.ReadKey() ' wait till next key so the user can see the tree

    End Sub
End Module
