Public Class ScientificCalculator

    Dim str1 As Double
    Dim str2 As Double
    Dim str As String


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtscreen.Text += btn0.Text

    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtscreen.Text += btn1.Text

    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtscreen.Text += btn2.Text

    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtscreen.Text += btn3.Text

    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtscreen.Text += btn4.Text
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtscreen.Text += btn5.Text

    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtscreen.Text += btn6.Text
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtscreen.Text += btn7.Text
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtscreen.Text += btn8.Text

    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtscreen.Text += btn9.Text
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        str1 = Val(txtscreen.Text)
        txtscreen.Text = ""
        str = btnadd.Text
    End Sub

    Private Sub btnminus_Click(sender As Object, e As EventArgs) Handles btnminus.Click
        str1 = Val(txtscreen.Text)
        txtscreen.Text = ""
        str = btnminus.Text
    End Sub

    Private Sub btnmul_Click(sender As Object, e As EventArgs) Handles btnmul.Click
        str1 = Val(txtscreen.Text)
        txtscreen.Text = ""
        str = btnmul.Text
    End Sub

    Private Sub btndiv_Click(sender As Object, e As EventArgs) Handles btndiv.Click
        str1 = Val(txtscreen.Text)
        txtscreen.Text = ""
        str = btndiv.Text
    End Sub

    Private Sub btneql_Click(sender As Object, e As EventArgs) Handles btneql.Click
        'str = Val(Txtscreen.Text)
        str2 = Val(txtscreen.Text)
        If str = "-" Then
            txtscreen.Text = str1 - str2
        ElseIf str = "+" Then
            txtscreen.Text = str1 + str2
        ElseIf str = "*" Then
            txtscreen.Text = str1 * str2
        ElseIf str = "/" Then
            txtscreen.Text = str1 / str2
        End If
    End Sub

    Private Sub btnclr_Click(sender As Object, e As EventArgs) Handles btnclr.Click
        txtscreen.Text = ""
        str = ""
    End Sub

    Private Sub btndec_Click(sender As Object, e As EventArgs) Handles btndec.Click
        txtscreen.Text += btndec.Text
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnpi.Click
        txtscreen.Text = 3.14159
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnrecipro.Click
        str1 = Val(txtscreen.Text)
        txtscreen.Text = 1 / str1
    End Sub

    Private Sub btnbacksp_Click(sender As Object, e As EventArgs) Handles btnbacksp.Click
        txtscreen.Text = txtscreen.Text.Remove(txtscreen.Text.Length - 1)
        If (txtscreen.Text = "") Then btnbacksp.Enabled = False

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles btnsin.Click
        str1 = Val(txtscreen.Text)
        txtscreen.Text = Math.Sin(str1 * (Math.PI / 180.0))
    End Sub

    Private Sub btncos_Click(sender As Object, e As EventArgs) Handles btncos.Click
        str1 = Val(txtscreen.Text)
        txtscreen.Text = Math.Cos(str1 * (Math.PI / 180.0))
    End Sub

    Private Sub btntan_Click(sender As Object, e As EventArgs) Handles btntan.Click
        str1 = Val(txtscreen.Text)
        txtscreen.Text = Math.Tan(str1 * (Math.PI / 180.0))
    End Sub

    Private Sub btnsinh_Click(sender As Object, e As EventArgs) Handles btnsinh.Click
        str1 = Val(txtscreen.Text)
        txtscreen.Text = Math.Sinh(str1 * (Math.PI / 180.0))
    End Sub

    Private Sub btncosh_Click(sender As Object, e As EventArgs) Handles btncosh.Click
        str1 = Val(txtscreen.Text)
        txtscreen.Text = Math.Cosh(str1 * (Math.PI / 180.0))
    End Sub

    Private Sub btntanh_Click(sender As Object, e As EventArgs) Handles btntanh.Click
        str1 = Val(txtscreen.Text)
        txtscreen.Text = Math.Tanh(str1 * (Math.PI / 180.0))
    End Sub

    Private Sub btnsqroot_Click(sender As Object, e As EventArgs) Handles btnsqroot.Click
        str1 = Val(txtscreen.Text)
        txtscreen.Text = Math.Sqrt(str1)
    End Sub

    Private Sub btnsqr_Click(sender As Object, e As EventArgs) Handles btnsqr.Click
        str1 = Val(txtscreen.Text)
        txtscreen.Text = str1 * str1
    End Sub

    Private Sub btncube_Click(sender As Object, e As EventArgs) Handles btncube.Click
        str1 = Val(txtscreen.Text)
        txtscreen.Text = str1 * str1 * str1
    End Sub

    Private Sub btnlog_Click(sender As Object, e As EventArgs) Handles btnlog.Click
        str1 = Val(txtscreen.Text)
        txtscreen.Text = Math.Log10(str1)
    End Sub
End Class
