Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        TextBox1.Text = TextBox1.Text + "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        TextBox1.Text = TextBox1.Text + "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        TextBox1.Text = TextBox1.Text + "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        TextBox1.Text = TextBox1.Text + "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        TextBox1.Text = TextBox1.Text + "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        TextBox1.Text = TextBox1.Text + "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        TextBox1.Text = TextBox1.Text + "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        TextBox1.Text = TextBox1.Text + "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        TextBox1.Text = TextBox1.Text + "9"
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        TextBox1.Text = TextBox1.Text + "0"
    End Sub

    Private Sub btnplus_Click(sender As Object, e As EventArgs) Handles btnplus.Click
        Label1.Text = TextBox1.Text
        Label2.Text = "+"
        TextBox1.Text = ""
    End Sub

    Private Sub btntimes_Click(sender As Object, e As EventArgs) Handles btntimes.Click
        Label1.Text = TextBox1.Text
        Label2.Text = "*"
        TextBox1.Text = ""
    End Sub

    Private Sub btndivide_Click(sender As Object, e As EventArgs) Handles btndivide.Click
        Label1.Text = TextBox1.Text
        Label2.Text = "/"
        TextBox1.Text = ""
    End Sub

    Private Sub btnminus_Click(sender As Object, e As EventArgs) Handles btnminus.Click
        Label1.Text = TextBox1.Text
        Label2.Text = "-"
        TextBox1.Text = ""
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        TextBox1.Text = ""
        Label2.Text = ""
        Label1.Text = ""
    End Sub

    Private Sub btnequals_Click(sender As Object, e As EventArgs) Handles btnequals.Click
        If Label2.Text = "+" Then
            TextBox1.Text = Val(Label1.Text) + Val(TextBox1.Text)
            Label1.Text = ""
            Label2.Text = "="
        End If

        If Label2.Text = "*" Then
            TextBox1.Text = Val(Label1.Text) * Val(TextBox1.Text)
            Label1.Text = ""
            Label2.Text = "="
        End If

        If Label2.Text = "/" Then
            TextBox1.Text = Val(Label1.Text) / Val(TextBox1.Text)
            Label1.Text = ""
            Label2.Text = "="
        End If

        If Label2.Text = "-" Then
            TextBox1.Text = Val(Label1.Text) - Val(TextBox1.Text)
            Label1.Text = ""
            Label2.Text = "="
        End If
    End Sub
End Class
