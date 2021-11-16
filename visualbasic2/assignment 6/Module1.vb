Module Module1

    Sub Main()
        Dim donutcount As Integer

        Console.Write("Enter no. of Donuts : ")
        donutcount = Console.ReadLine

        If donutcount >= 10 Then
            Console.Write(" Many Donuts ")
            Console.ReadLine()
        Else
            Console.Write(" The number of Donuts are : " & donutcount)

            Console.ReadLine()

        End If
    End Sub

End Module
