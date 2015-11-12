Module Module1

    Sub Main()
        Dim a, b As Double
        Console.Write("請輸入身高(公分) ： ")
        a = Val(Console.ReadLine())
        'a = 身高(公分)
        Console.Write("請輸入體重(公斤) ： ")
        b = Val(Console.ReadLine())
        'b = 體重(公斤)
        Console.Write("您的BMI ： {0}", CDbl((b / (a / 100) ^ 2).ToString()))
        '計算出BMI值
        Console.ReadLine()
    End Sub

End Module
