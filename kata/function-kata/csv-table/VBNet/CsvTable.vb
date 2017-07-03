Imports System
Imports System.IO
Imports System.Text

Namespace csv.tabellieren

    Public Class CsvTable

        Public Sub DrawCsvToTerminal(dateiname As String)
            Dim columnAmount As Integer
            Dim rowsAmount As Integer

            ' dateiname = "C:\Users\oleksandra\Desktop\test.txt"
            'column amount search
            Dim filecontent As String = File.ReadAllText(dateiname)

            For Each c As Char In filecontent
                If c = ";" Then
                    columnAmount = columnAmount + 1
                End If
            Next


            'rows amount search

            For Each c As Char In filecontent
                If c = vbCr Then
                    rowsAmount += 1
                End If
            Next
            rowsAmount += 1
            columnAmount = (columnAmount / rowsAmount) + 1
            'Reading words from file to Array
            Dim array(rowsAmount - 1, columnAmount - 1) As String

            Dim i As Integer = 0
            Dim j As Integer = 0
            Dim wordToWrite As String = ""
            For Each c As Char In filecontent
                If c = ";" Then
                    array(i, j) = wordToWrite
                    wordToWrite = ""
                    j += 1
                ElseIf c = vbCr Then
                    array(i, j) = wordToWrite
                    wordToWrite = ""
                    i += 1
                    j = 0
                Else : wordToWrite = wordToWrite + c
                End If
            Next
            array(i, j) = wordToWrite

            For i = 1 To columnAmount - 1
                array(i, 0) = array(i, 0).Trim()
            Next

            'Maxlength		
            Dim maxLength(columnAmount - 1) As Integer
            For j = 0 To columnAmount - 1
                maxLength(j) = 0
                For i = 0 To rowsAmount - 1
                    If (maxLength(j) < array(i, j).Length()) Then
                        maxLength(j) = array(i, j).Length()
                    End If
                Next
            Next

            'Output
            'Size of upper row horizontal lines 
            Dim horizontalLine As Integer = 0
            For j = 0 To columnAmount - 1
                horizontalLine += maxLength(j)
            Next

            'Making of first horizontal line
            For i = 0 To (horizontalLine + columnAmount)
                Console.Write("-")
            Next
            Console.WriteLine()


            For j = 0 To columnAmount - 1
                Console.Write("|")
                Console.Write(array(0, j))
                If array(0, j).Length < maxLength(j) Then
                    For i = 0 To (maxLength(j) - array(0, j).Length()) - 1
                        Console.Write(" ")
                    Next
                End If
            Next
            Console.Write("|")
            Console.WriteLine()

            For j = 0 To columnAmount - 1
                Console.Write("+")
                For i = 0 To maxLength(j) - 1
                    Console.Write("-")
                Next
            Next
            Console.Write("+")


            'Making of second horizontal line
            ' For i = 0 To horizontalLine + columnAmount
            'Console.Write("-")
            'For j = 0 To columnAmount - 1
            'Console.Write("|")
            ' For k = 0 To maxLength(j) - 2
            'Console.Write(" ")
            ' Next
            ' Next
            ' Next
            Console.WriteLine()

            'Write of other rows
            For i = 1 To rowsAmount - 1
                For j = 0 To columnAmount - 1
                    'Console.Write("|")
                    Console.Write("|" + array(i, j))
                    If array(i, j).Length() < maxLength(j) Then
                        For k = 0 To (maxLength(j) - array(i, j).Length()) - 1
                            Console.Write(" ")
                        Next
                    End If
                Next
                Console.Write("|")
                Console.WriteLine()
            Next


            'Making last horisontal line
            For i = 0 To horizontalLine + columnAmount
                Console.Write("-")

            Next
        End Sub
    End Class
End Namespace
