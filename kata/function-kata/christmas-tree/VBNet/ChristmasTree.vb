


Class ChristmasTree

    ' Sub DrawChristmasTree()
    'Dim args As String() = Environment.GetCommandLineArgs()

    ' Implement a nice christmas tree
    ' - check command line args for integer parameter for the tree size
    ' - write tree to terminal
    ' Console.WriteLine("Tree with height 2:")
    ' Console.WriteLine(" X")
    'Console.WriteLine("XXX")
    'Console.WriteLine(" I")
    ' End Sub
    Sub DrawChristmasTree(hoehe As Integer, mitStern As Boolean)
        Dim args As String() = Environment.GetCommandLineArgs()
        'i - Anzahl der Zeilen, j - Anzahl der Spalten
        Dim i As Integer
        Dim j As Integer
        If mitStern = True Then
            For i = 0 To hoehe - 1
                'Anzahl = 2*i + 1
                For j = 5 To hoehe - i + 6
                    Console.Write(" ")
                Next j
                'For j = 0 To 2 * i + 2
                'MsgBox("X")
                Console.Write("*")
                For j = 0 To 2 * i + 1
                    Console.Write("X")
                Next j
                'Console.Write("& vbCrLf &") 
                Console.WriteLine()
            Next i
            For i = hoehe To hoehe + (hoehe - 1) / 2
                For j = 0 To hoehe + 1
                    Console.Write(" ")
                Next j
                Console.WriteLine("I")
            Next i
        Else
            For i = 0 To hoehe - 1
                'Anzahl = 2*i +1
                For j = 5 To hoehe - i + 6
                    Console.Write(" ")
                Next j
                For j = 0 To 2 * i + 1
                    Console.Write("X")
                Next j
                Console.WriteLine()
            Next i
            'Stamm einzeichnen
            'For i = 0 To hoehe - 2
            'Console.Write(" ")
            ' Console.WriteLine("I")
            ' Next i
            For i = hoehe To hoehe + (hoehe - 1) / 2
                For j = 0 To hoehe + 1
                    Console.Write(" ")
                Next j
                Console.Write("I")
                Console.WriteLine()
            Next i
        End If
    End Sub
    Public Function mitStern(response As MsgBoxResult) As Boolean
        response = MsgBox("Wollen Sie den Weihnachtsbaum mit oder ohne Stern anzeigen?", 4)
        If response = MsgBoxResult.Yes Then
            Return True
        End If
        Return False
    End Function
    Public Function hoehe() As Integer
        hoehe = InputBox("Bitte die Hoehe des Tannenbaums eintragen:")
        If Not IsNumeric(hoehe) Then
            MsgBox("Bitte eine Zahl eingeben")
        End If
    End Function
    ' Sub Main()
    ' Dim testBaum As Tannenbaum
    'Dim response As MsgBoxResult
    ' mitStern(response)
    'hoehe()
    'zeichnen(hoehe, mitStern(response))
    ' End Sub


End Class
