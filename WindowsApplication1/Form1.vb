Public Class Form1

    Private Sub txtUserName_TextChanged(sender As Object, e As EventArgs) Handles txtUserName.TextChanged, txtPassword.TextChanged

        Dim GD As TextBox = CType(sender, TextBox)
        If (String.IsNullOrEmpty(GD.Text)) Then
            MessageBox.Show("未輸入帳號或密碼")
            '當使用者帳號、密碼輸入處為空白，跑出提示方塊
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If txtUserName.Text = "login" Then
            If txtPassword.Text = "abc123" Then
                MessageBox.Show("帳戶密碼正確!!!")
                End
            End If
        End If
        '按下登入時，帳號密碼符合，跑出提示方塊

        If txtUserName.Text = "" Then
            txtUserName.BackColor = Color.MistyRose
        End If
        '按下登入時，帳號輸入處空白，將白色改成玫瑰色

        If txtPassword.Text = "" Then
            txtPassword.BackColor = Color.MistyRose
        End If
        '按下登入時，密碼輸入處空白，將白色改成玫瑰色

        If txtUserName.Text <> "login" Then
            txtUserName.BackColor = Color.MistyRose
        End If
        '按下登入時，帳號輸入錯誤，將白色改成玫瑰色

        If txtPassword.Text <> "abc123" Then
            txtPassword.BackColor = Color.MistyRose
        End If
        '按下登入時，密碼輸入錯誤，將白色改成玫瑰色
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        End
    End Sub
End Class
