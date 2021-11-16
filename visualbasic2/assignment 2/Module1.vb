Module Module1

    Sub Main()
        Dim line1, line2, Char1, char2, newchar As String
        Dim Counter As Integer

        line1 = ""
        line2 = ""
        Char1 = ""
        char2 = ""
        newchar = ""
        Counter = 0

        Console.Write("Enter String: ")
        line1 = Console.ReadLine

        Console.Write("Enter character to remove: ")
        Char1 = Console.ReadLine

        Console.Write("Enter character to replace: ")
        char2 = Console.ReadLine

        For Counter = 1 To Len(line1)
            newchar = Mid(line1, Counter, 1)
            If newchar = Char1 Then
                newchar = char2
            End If
            line2 = line2 & newchar
        Next

        Console.WriteLine("replaced string = " & line2)
        Console.ReadKey()

    End Sub

End Module


