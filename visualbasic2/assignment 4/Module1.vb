Module Module1

    Sub Main()
        Dim myChar, thisChar, nextChar As Char
        Dim Highest, Count, i, j As Integer
        Dim str1 As String

        myChar = ""
        Highest = 0
        Count = 0

        Console.Write("Enter string : ")
        str1 = Console.ReadLine

        For i = 1 To Len(str1)
            nextChar = Mid(str1, i, 1)
            Count = 0
            For j = 1 To Len(str1)
                thisChar = Mid(str1, j, 1)
                If thisChar = nextChar Then Count = Count + 1
            Next

            If Count > Highest Then
                Highest = Count
                myChar = nextChar
            End If
        Next
        Console.WriteLine(myChar & " appeared the most,  " & Highest & " times.")
        Console.ReadKey()

    End Sub

End Module
