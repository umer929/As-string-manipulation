Module Module1

    Sub Main()
        Dim Str1 As String
        Dim Char1 As Char
        Dim a, digitCounter, alphabetCounter As Integer


        Str1 = ""
        Char1 = ""
        a = 0
        digitCounter = 0
        alphabetCounter = 0


        Console.Write("Enter string : ")
        Str1 = Console.ReadLine


        For a = 1 To Len(Str1)
            Char1 = Mid(Str1, a, 1)
            Char1 = UCase(Char1)
            If Char1 >= "A" And Char1 <= "Z" Then
                alphabetCounter = alphabetCounter + 1
            ElseIf Char1 >= "0" And Char1 <= "9" Then
                digitCounter = digitCounter + 1
            End If
        Next


        Console.WriteLine("In this Alphabets are: " & alphabetCounter)
        Console.WriteLine("In this Digits are: " & digitCounter)


        Console.ReadKey()
    End Sub

End Module
