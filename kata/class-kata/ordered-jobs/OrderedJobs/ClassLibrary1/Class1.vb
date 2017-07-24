

Imports NUnit.Framework
<TestFixture>
Public Class Tests
    Dim job As OrderedJobs.IOrderedJobs

    <SetUp>
    Public Sub setup()
        job = New OrderedJobs.OrderedJobs
    End Sub

    <Test>
    Public Sub test1()
        job.Register("a")
        Assert.AreEqual("a", job.Sort)
    End Sub
    <Test>
    <ExpectedException>
    Public Sub test2()
        job.Register("")
    End Sub

    <Test>
    Public Sub test3()
        job.Register("a")
        job.Register("b")
        job.Register("c")
        Assert.AreEqual("abc", job.Sort)
    End Sub

    <Test>
    Public Sub test4()
        job.Register("a")
        job.Register("b", "c")
        job.Register("c")
        Assert.AreEqual("acb", job.Sort)
    End Sub

    <Test>
    Public Sub test5()
        job.Register("a")
        job.Register("b", "c")
        job.Register("c", "f")
        job.Register("d", "a")
        job.Register("e", "b")
        job.Register("f")
        Assert.AreEqual("afcbde", job.Sort)
    End Sub

    <Test>
    <ExpectedException>
    Public Sub test6()
        job.Register("a")
        job.Register("b")
        job.Register("c", "c")
    End Sub

    <Test>
    <ExpectedException>
    Public Sub test7()
        job.Register("a")
        job.Register("b", "c")
        job.Register("c", "f")
        job.Register("d", "a")
        job.Register("e")
        job.Register("f", "b")
        job.Sort()
    End Sub

    <Test>
    Public Sub test8()
        ' test that joblist is empty in the beginning
        Assert.AreEqual("", job.Sort)
    End Sub

    <Test>
    Public Sub test9()
        job.Register("b", "a")

        job.Register("y", "x")

        job.Register("a", "x")

        Dim result As String = job.Sort
        Assert.IsTrue(result.IndexOf("a") > result.IndexOf("x"))
        Assert.IsTrue(result.IndexOf("b") > result.IndexOf("a"))
        Assert.IsTrue(result.IndexOf("y") > result.IndexOf("x"))
    End Sub

    <Test>
    Public Sub test10()
        job.Register("b", "a")
        job.Register("c", "b")

        job.Register("y", "x")
        job.Register("z", "y")

        job.Register("a", "x")

        Dim result As String = job.Sort
        Assert.IsTrue(result.IndexOf("a") > result.IndexOf("x"))
        Assert.IsTrue(result.IndexOf("b") > result.IndexOf("a"))
        Assert.IsTrue(result.IndexOf("y") > result.IndexOf("x"))
        Assert.IsTrue(result.IndexOf("c") > result.IndexOf("b"))
        Assert.IsTrue(result.IndexOf("z") > result.IndexOf("y"))
    End Sub

    <Test>
    Public Sub test11()
        job.Register("b", "a")
        job.Register("y", "x")
        job.Register("l", "k")

        job.Register("a", "x")
        job.Register("x", "k")

        Dim result As String = job.Sort
        Assert.IsTrue(result.IndexOf("b") > result.IndexOf("a"))
        Assert.IsTrue(result.IndexOf("y") > result.IndexOf("x"))
        Assert.IsTrue(result.IndexOf("l") > result.IndexOf("k"))
        Assert.IsTrue(result.IndexOf("a") > result.IndexOf("x"))
        Assert.IsTrue(result.IndexOf("x") > result.IndexOf("k"))
    End Sub

End Class
