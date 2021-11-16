Module Module1

    Sub Main()
        Dim str1 As String
        Dim thischar As Char
        Dim myChar As Char

        Console.Write("Enter String: ")
        str1 = Console.ReadLine
        thischar = Left(str1, 1)
        Console.Write(thischar)
        For COUNT = 1 To Len(str1) - 1
            myChar = Mid(str1, (COUNT + 1), 1)
            If myChar = thischar Then
                myChar = "*"
            End If
            Console.Write(myChar)
        Next
        Console.ReadKey()

    End Sub

End Module
