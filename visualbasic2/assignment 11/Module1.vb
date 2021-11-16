Module Module1

    Sub Main()
        Dim str1, firstpart, secondpart As String
        Dim badpos, notpos As Integer

        str1 = ""
        firstpart = ""
        secondpart = ""
        badpos = 0
        notpos = 0

        Console.Write("Enter String: ")
        str1 = Console.ReadLine
        badpos = InStr(str1, "bad")
        notpos = InStr(str1, "not")

        If notpos < badpos Then
            firstpart = Left(str1, notpos - 1)
            secondpart = Right(str1, Len(str1) - (badpos + 2))

        End If
        Console.WriteLine(firstpart & "good" & secondpart)
        Console.ReadKey()




    End Sub

End Module
