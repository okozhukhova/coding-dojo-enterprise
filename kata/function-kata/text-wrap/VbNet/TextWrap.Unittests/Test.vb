
Imports NUnit.Framework

<TestFixture()>
Class Test
    Dim sut As New TextWrapProject.TextWrap

    <Test>
    Public Sub TestNoWrap()
        Dim text = "Hi this is a test"
        Dim expected = text
        Dim length = 100
        Assert.AreEqual(expected, sut.WrapText(text, length))
    End Sub
    <Test>
    Public Sub TestDivideLongWord()
        Dim text = "ThisIsAVeryLongWordThisIsAVeryLongWordThisIsAVeryLongWordThisIsAVeryLongWord"
        Dim expected = "ThisIsAVer" + vbCrLf + "yLongWordT" + vbCrLf + "hisIsAVery" + vbCrLf + "LongWordTh" + vbCrLf + "isIsAVeryL" + vbCrLf + "ongWordThi" + vbCrLf + "sIsAVeryLo" + vbCrLf + "ngWord"
        Dim length = 10
        Assert.AreEqual(expected, sut.wrapText(text, length))
    End Sub

    <Test>
    Public Sub TestDivideAtNamespaces()
        Dim text = "     This function should divide a text at the namespaces     "
        Dim expected = "This" + vbCrLf + "functio" + vbCrLf + "n" + vbCrLf + "should" + vbCrLf + "divide" + vbCrLf + "a text" + vbCrLf + "at the" + vbCrLf + "namespa" + vbCrLf + "ces"
        Dim length = 7
        Assert.AreEqual(expected, sut.wrapText(text, length))
    End Sub

    <Test>
    Public Sub TestForTextWithWraps()
        Dim text = "This" + vbCrLf + "text" + vbCrLf + "includes" + vbCrLf + "4" + vbCrLf + "wraps"
        Dim expected = "This" + vbCrLf + "text" + vbCrLf + "inclu" + vbCrLf + "des" + vbCrLf + "4" + vbCrLf + "wraps"
        Dim length = 5
        Assert.AreEqual(expected, sut.wrapText(text, length))
    End Sub

End Class
