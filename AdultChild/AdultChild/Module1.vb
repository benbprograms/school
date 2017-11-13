Module Module1
    Dim theName As String 'make a variable for the name'
    Dim TheAge As Integer 'make a variable for the name'
    Sub Main()
        Console.Title = "Adult Child"
        Console.WriteLine("What is your name?: ")
        theName = Console.ReadLine
        Console.WriteLine("Hello " & theName & " How old are you?: ")
        TheAge = Console.ReadLine
        If TheAge >= 17 Then
            Console.WriteLine(theName & " you are an adult")
        Else
            Console.WriteLine(theName & " you are a child")
        End If
        Console.ReadLine()


    End Sub

End Module
