
Imports NUnit.Framework

<TestFixture()>
Class Test
    Dim sut As New TextWrapProject.TextWrap

    <Test>
    Public Sub TestInvalidValueArguments()
        sut.WrapText(Nothing, 2)
        sut.WrapText("", -2)
    End Sub

    <Test>
    Public Sub TestNoWrap()
        Dim text = "Hi this is a test"
        Dim expected = text
        Dim length = 100
        Assert.AreEqual(expected, sut.WrapText(text, length))
    End Sub

    <Test>
    Public Sub TestNoWrap_ExactLength()
        Dim text = "Hi this is a test"
        Dim expected = text
        Dim length = 17
        Assert.AreEqual(expected, sut.WrapText(text, length))
    End Sub

    <Test>
    Public Sub TestWrap()
        Dim text = "Hi this is a test"
        Dim expected = String.Format("Hi {0}this{0} is {0}a {0}test", vbCrLf)
        Dim length = 4
        Assert.AreEqual(expected, sut.WrapText(text, length))
    End Sub

    <Test>
    Public Sub TestWrap_OneWord()
        Dim text = "CogitoErgoSum"
        Dim expected = String.Format("Cog{0}ito{0}Erg{0}oSu{0}m", vbCrLf)
        Dim length = 3
        Assert.AreEqual(expected, sut.WrapText(text, length))
    End Sub



    <Test>
    Public Sub TestWrap_WithExistingLineBreak()
        Dim text = String.Format("Hi this is{0} a test", vbCrLf)
        Dim expected = text
        Dim length = 10
        Assert.AreEqual(expected, sut.WrapText(text, length))
    End Sub

End Class
