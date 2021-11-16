Module Module1

    Sub Main()
        Dim str1, str2 As String
        Dim thischar1, thischar2 As Char
        Dim finalstr1, finalstr2 As String

        str1 = ""
        str2 = ""
        thischar1 = ""
        thischar2 = ""
        finalstr1 = ""
        finalstr2 = ""

        Console.Write(" Enter Sring 1 : ")
        str1 = Console.ReadLine
        Console.Write(" Enter String 2 : ")
        str2 = Console.ReadLine

        thischar1 = Left(str1, 2)
        thischar2 = Left(str2, 2)
        finalstr1 = Mid(str1, 3, Len(str1) - 2)
        finalstr2 = Mid(str2, 3, Len(str2) - 2)

        Console.Write(thischar2 & finalstr1)
        Console.ReadLine()
        Console.Write(thischar1 & finalstr2)
        Console.ReadLine()


    End Sub

End Module
