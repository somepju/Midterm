Module Module1

    Function GetMax(ByRef box() As Integer) As Integer
        Dim max As Integer
        max = box(0)
        For i As Integer = 1 To box.GetUpperBound(0)
            If max < box(i) Then
                max = box(i)
            End If
        Next
        Return max
        '求最大值的函式
    End Function

    Function GetMix(ByRef box() As Integer) As Integer
        Dim mix As Integer
        mix = box(0)
        For i As Integer = 1 To box.GetUpperBound(0)
            If mix > box(i) Then
                mix = box(i)
            End If
        Next
        Return mix
        '求最小值得函式
    End Function

    Sub Main()
        Dim c, num, sum As Integer
        Console.WriteLine("請設輸入數字個數上限：")
        num = Val(Console.ReadLine())
        Dim AHQ(num - 1) As Integer
        For c = 0 To AHQ.GetUpperBound(0)
            Console.Write("輸入任意數字: ", (c + 1).ToString())
            AHQ(c) = Val(Console.ReadLine())

        Next

        For Each kkk As Integer In AHQ
            sum += kkk
            '將AHQ中所有元素加總指定給sum
        Next

        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("輸入數字中最大值 : {0}", GetMax(AHQ).ToString())
        '套回找最大值函式
        Console.WriteLine("輸入數字中最小值 : {0}", GetMix(AHQ).ToString())
        '套回找最小值函式
        Console.WriteLine("平均值: {0}", CInt((sum / num)).ToString())
        '求出平均值
        Console.ReadLine()
    End Sub

End Module
