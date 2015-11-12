Module Module1

    Sub Main()
        Dim m, n As Integer
        For m = 1 To 9
            For n = 1 To 9
                Console.Write("{0} ", CInt((m * n)).ToString("00"))
                '寫出數字，個位數前補零，形成有十位數跟個位數二位
            Next
            Console.WriteLine()
            '強迫換列

        Next
        Console.Read()

    End Sub

End Module
