Module Module1

    Sub Main()
        Dim str1 As String
        Dim word1 As String
        Dim finalstring As String
        Dim word2 As String

        str1 = ""
        word1 = "ing"
        word2 = "ly"
        finalstring = ""

        Console.Write("enter string: ")
        str1 = Console.ReadLine
        str1 = LCase(str1)

        If Len(str1) < 3 Then
            finalstring = str1
        ElseIf Len(str1) >= 3 Then
            If Right(str1, 3) = word1 Then
                finalstring = str1 & word2
            Else
                finalstring = str1 & word1
            End If

        End If

        Console.WriteLine("final string is: " & finalstring)
        Console.ReadKey()

    End Sub

End Module
