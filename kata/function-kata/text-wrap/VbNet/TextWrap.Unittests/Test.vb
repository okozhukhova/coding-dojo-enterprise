
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

End Class
