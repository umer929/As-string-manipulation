Module Module1

    Sub Main()
        Dim str1, str2, thischar1, thischar2 As String
        str1 = ""
        str2 = ""
        thischar1 = ""
        thischar2 = ""

        Console.Write("Enter String: ")
        str1 = Console.ReadLine

        If Len(str1) < 2 Then
            Console.WriteLine(str1)
            Console.ReadKey()

        Else
            thischar1 = Right(str1, 2)
            thischar2 = Left(str1, 2)

            Console.WriteLine(thischar2 & thischar1)
            Console.ReadLine()


        End If





    End Sub

End Module
