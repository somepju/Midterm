Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim f = txt.Text
        Dim c As Double
        c = (f - 32) * 5 / 9
        '溫度轉換公式，c = 攝氏 ，f = 華氏
        txt.Text = c
        '按下攝氏，將輸入的華氏轉換成攝氏

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim c = txt.Text
        Dim f As Double
        f = c * (9 / 5) + 32
        '溫度轉換公式，c = 攝氏 ，f = 華氏
        txt.Text = f
        '按下華氏，將輸入的攝氏轉換成華氏

    End Sub
End Class
