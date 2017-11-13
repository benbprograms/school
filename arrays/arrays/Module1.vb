Module Module1
    Dim names(9) As String
    Dim TargetName As String
    Sub findArrayItem()
        Console.WriteLine("enter a name to search for: ")
        TargetName = Console.ReadLine

        For looper = 0 To 9
            If names(looper) = TargetName Then
                Console.WriteLine("found " & TargetName & " at line " & looper + 1)
            End If

        Next
    End Sub

    Sub showArrayContents()
        For looper = 0 To 9
            Console.WriteLine(names(looper))
        Next
    End Sub

    Sub fillArray()
        names(0) = "Ben"
        names(1) = "Bob"
        names(2) = "Bill"
        names(3) = "Rob"
        names(4) = "Tom"
        names(5) = "Sam"
        names(6) = "Peter"
        names(7) = "Andy"
        names(8) = "Harry"
        names(9) = "Alex"
    End Sub
    Sub Main()
        Call fillArray()
        Call showArrayContents()
        Call findArrayItem()
        Console.ReadKey()
    End Sub

End Module
