Module Module1

    Sub Main()
        Dim str1 As String
        Dim thischar1, thischar2, thischar3, thischar4, thischar5 As Char

        Dim counter As Integer
        Dim Acount As Integer
        Dim Ecount As Integer
        Dim Icount As Integer
        Dim Ocount As Integer
        Dim Ucount As Integer
        Dim nextchar As Char
        str1 = ""
        nextchar = ""
        thischar1 = "a"
        thischar2 = "e"
        thischar3 = "i"
        thischar4 = "o"
        thischar5 = "u"
        counter = 0
        Acount = 0
        Ecount = 0
        Icount = 0
        Ocount = 0
        Ucount = 0

        Console.Write("Enter String :  ")
        str1 = Console.ReadLine

        For counter = 1 To Len(str1)
            nextchar = LCase(Mid(str1, counter, 1))
            If nextchar = thischar1 Then
                Acount = Acount + 1
            Else

                If nextchar = thischar2 Then
                    Ecount = Ecount + 1
                Else

                    If nextchar = thischar3 Then

                        Icount = Icount + 1
                    Else

                        If nextchar = thischar4 Then

                            Ocount = Ocount + 1
                        Else

                            If nextchar = thischar5 Then

                                Ucount = Ucount + 1
                            End If
                        End If
                    End If
                End If
            End If


        Next
        Console.WriteLine("number of a are:  " & Acount)
        Console.WriteLine("number of e are:  " & Ecount)
        Console.WriteLine("number of i are:  " & Icount)
        Console.WriteLine("number of o are:  " & Ocount)
        Console.WriteLine("number of u are:  " & Ucount)
        Console.ReadKey()



    End Sub

End Module
