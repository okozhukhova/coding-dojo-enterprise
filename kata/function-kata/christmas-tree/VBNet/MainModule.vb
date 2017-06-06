
Module MainModule

    Public Sub Main()

        Dim christmasTree As New ChristmasTree()
        christmasTree.DrawChristmasTree(hoehe:=13, mitStern:=False)
        Console.ReadKey() ' wait till next key so the user can see the tree

    End Sub
End Module
