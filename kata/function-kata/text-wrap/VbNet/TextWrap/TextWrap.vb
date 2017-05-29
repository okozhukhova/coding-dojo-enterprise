
Namespace TextWrapProject

    Public Class TextWrap

        ''' <summary>
        ''' Wraps the text word wise. No line of the result will have more characters than 'maxTextLength'. 
        ''' 
        ''' Wrapping will be done by adding linebreaks into the string (vbcrlf)
        ''' </summary>
        ''' <param name="text">Text that should be wrapped</param>
        ''' <param name="maxTextLength">Max length of a line</param>
        Public Function WrapText(text As String, maxTextLength As Integer) As String

            ' Implement wrapping of the text with following logic
            ' - no line should have more characters than 'maxTextLength'
            ' - result should be a string 
            ' - wrapped will be at whitespaces
            ' - if one word is longer than 'maxTextLength' this Word will be wrapped letterwise
            ' - no characters are removed from the original string, only linebreaks - where needed - are added

            Return text
        End Function

    End Class
End Namespace