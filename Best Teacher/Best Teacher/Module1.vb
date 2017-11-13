Module Module1
    Dim answer As String
    Dim newans As String
    Dim herd As String
    Dim game As String
    Dim hamilton As String
    Dim peters As String

    Sub Main()
        herd = UCase("mr herd")
        game = UCase("mr game")
        hamilton = ("mr hamilton")
        peters = UCase("mr peters")



        Console.WriteLine("Who is the best teacher at LPSB")
        answer = Console.ReadLine
        newans = UCase(answer)

        If Not newans = herd Or game Or hamilton Or peters Then
            Console.WriteLine("incorrect, you are misguided")
            Console.ReadKey()
        Else
            Console.WriteLine("correct")
            Console.ReadKey()
        End If

    End Sub

End Module
