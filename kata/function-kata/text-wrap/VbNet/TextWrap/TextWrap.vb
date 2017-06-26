
Namespace TextWrapProject

    Public Class TextWrap

        ''' <summary>
        ''' Wraps the text word wise. No line of the result will have more characters than 'maxTextLength'. 
        ''' 
        ''' Wrapping will be done by adding linebreaks into the string (vbcrlf)
        ''' </summary>
        ''' <param name="text">Text that should be wrapped</param>
        ''' <param name="maxTextLength">Max length of a line</param>
        Public Function wrapText(text As String, maxTextLength As Integer) As String
            text = text.Trim()

            If Len(text) < maxTextLength Then
                Return text
            End If
            If text.Substring(0, maxTextLength).Contains(vbCrLf) Then
                Return text.Substring(0, text.IndexOf(vbCrLf)).Trim() + vbCrLf +
                    wrapText(text.Substring(text.IndexOf(vbCrLf) + 1), Len(text))
            End If

            Dim place As Integer = text.LastIndexOf(" ", maxTextLength)
            If place = -1 Then place = maxTextLength

            Return text.Substring(0, place).Trim() + vbCrLf + wrapText(text.Substring(place), maxTextLength)

            ' Implement wrapping of the text with following logic
            ' - no line should have more characters than 'maxTextLength'
            ' - result should be a string 
            ' - wrapped will be at whitespaces
            ' - if one word is longer than 'maxTextLength' this Word will be wrapped letterwise
            ' - no characters are removed from the original string, only linebreaks - where neeed - are added

            Return text
        End Function

    End Class
End Namespace