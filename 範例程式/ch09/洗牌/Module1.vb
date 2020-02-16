Module Module1
    Sub Main()
        Dim Clubs(12), Spades(12), Diamonds(12), Hearts(12) As Integer
        Dim card As Integer
        Clubs = Shuffle()
        Spades = Shuffle()
        Diamonds = Shuffle()
        Hearts = Shuffle()
        Console.Write("Clubs：")
        For Each card In Clubs
            Console.Write(card & " ")
        Next
        Console.WriteLine()
        Console.Write("Spades：")
        For Each card In Spades
            Console.Write(card & " ")
        Next
        Console.WriteLine()
        Console.Write("Diamonds：")
        For Each card In Diamonds
            Console.Write(card & " ")
        Next
        Console.WriteLine()
        Console.Write("Hearts：")
        For Each card In Hearts
            Console.Write(card & " ")
        Next
        Console.WriteLine()
        Console.Read() '暫停
    End Sub

    Function Shuffle() As Integer()
        Dim card As Integer
        Dim CardArray(12) As Integer
        Dim CardNum As Integer
        Randomize()
        For card = 1 To 13
            Do
                CardNum = CInt((13 * Rnd() + 1)) Mod 13
            Loop While (CardArray(CardNum) <> 0)
            CardArray(CardNum) = card
        Next

        Return CardArray
    End Function
End Module
