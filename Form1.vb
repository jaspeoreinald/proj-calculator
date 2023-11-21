Imports Google.Protobuf.WellKnownTypes

Public Class Form1
    Dim firstNumber As Decimal
    Dim secondNumber As Decimal
    Dim thirdNumber As Decimal
    Dim operatorType As String
    Dim isEquals As String
    Dim posorneg As Integer

    Sub clearAnswer()
        If isEquals = "=" Then
            TextBox1.Clear()
            lblnumbers.Text = ""
            isEquals = ""
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Focus()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        TextBox1.Text += "0"
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        TextBox1.Text += "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        TextBox1.Text += "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        TextBox1.Text += "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        TextBox1.Text += "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        TextBox1.Text += "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        TextBox1.Text += "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        TextBox1.Text += "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        TextBox1.Text += "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        TextBox1.Text += "9"
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        firstNumber = Decimal.Parse(TextBox1.Text)
        operatorType = "+"
        Dim compile As String = firstNumber & " " & operatorType
        txtnumbers.Text = compile
        TextBox1.Text = ""
    End Sub

    Private Sub btnsubtract_Click(sender As Object, e As EventArgs) Handles btnsubtract.Click
        firstNumber = Decimal.Parse(TextBox1.Text)
        operatorType = "-"
        Dim compile As String = firstNumber & " " & operatorType
        txtnumbers.Text = compile
        TextBox1.Text = ""
    End Sub

    Private Sub btnmultiply_Click(sender As Object, e As EventArgs) Handles btnmultiply.Click
        firstNumber = Decimal.Parse(TextBox1.Text)
        operatorType = "*"
        Dim compile As String = firstNumber & " X "
        txtnumbers.Text = compile
        TextBox1.Text = ""
    End Sub

    Private Sub btndivide_Click(sender As Object, e As EventArgs) Handles btndivide.Click
        firstNumber = Decimal.Parse(TextBox1.Text)
        operatorType = "/"
        Dim compile As String = firstNumber & " " & operatorType
        txtnumbers.Text = compile
        TextBox1.Text = ""
    End Sub

    Private Sub btnperiod_Click(sender As Object, e As EventArgs) Handles btnperiod.Click
        TextBox1.Text += "."
    End Sub

    Private Sub btnbkspc_Click(sender As Object, e As EventArgs) Handles btnbkspc.Click
        Dim displayText = TextBox1.Text
        Dim newDisplayText As String = ""

        For index As Integer = 0 To displayText.Length - 2
            newDisplayText += displayText(index)
        Next

        TextBox1.Text = newDisplayText
    End Sub

    Private Sub btnc_Click(sender As Object, e As EventArgs) Handles btnc.Click
        TextBox1.Clear()
    End Sub

    Private Sub btnce_Click(sender As Object, e As EventArgs) Handles btnce.Click
        TextBox1.Clear()
        firstNumber = 0
        secondNumber = 0
        thirdNumber = 0
        txtnumbers.Text = ""
    End Sub

    Private Sub btnpercent_Click(sender As Object, e As EventArgs) Handles btnpercent.Click
        firstNumber = Decimal.Parse(TextBox1.Text)
        secondNumber = 100
        thirdNumber = firstNumber / secondNumber
        TextBox1.Text = thirdNumber
    End Sub

    Private Sub btn1overx_Click(sender As Object, e As EventArgs) Handles btn1overx.Click
        firstNumber = Decimal.Parse(TextBox1.Text)
        thirdNumber = 1 / firstNumber
        txtnumbers.Text = "1/(" & firstNumber & ")"
        TextBox1.Text = thirdNumber
    End Sub

    Private Sub btnexponent2_Click(sender As Object, e As EventArgs) Handles btnexponent2.Click
        firstNumber = Decimal.Parse(TextBox1.Text)
        secondNumber = Decimal.Parse(TextBox1.Text)
        thirdNumber = firstNumber * secondNumber
        txtnumbers.Text = "(" & firstNumber & ")^2"
        TextBox1.Text = thirdNumber
    End Sub

    Private Sub btnsqrt_Click(sender As Object, e As EventArgs) Handles btnsqrt.Click
        firstNumber = Decimal.Parse(TextBox1.Text)
        thirdNumber = Math.Sqrt(firstNumber)
        txtnumbers.Text = "sqrt(" & firstNumber & ")"
        TextBox1.Text = thirdNumber
    End Sub

    Private Sub btnchangesign_Click(sender As Object, e As EventArgs) Handles btnchangesign.Click
        If posorneg = 0 Then
            TextBox1.Text = thirdNumber
            posorneg = 1
        Else
            TextBox1.Text = "-" & thirdNumber
            posorneg = 0
        End If
    End Sub

    Private Sub btnequals_Click(sender As Object, e As EventArgs) Handles btnequals.Click
        secondNumber = Decimal.Parse(TextBox1.Text)
        Dim compile As String
        If operatorType = "+" Then
            thirdNumber = firstNumber + secondNumber
            compile = firstNumber & " + " & secondNumber & " = "
            txtnumbers.Text = compile
            posorneg = 1
        ElseIf operatorType = "-" Then
            thirdNumber = firstNumber - secondNumber
            compile = firstNumber & " - " & secondNumber & " = "
            txtnumbers.Text = compile
            posorneg = 0
        ElseIf operatorType = "*" Then
            thirdNumber = firstNumber * secondNumber
            compile = firstNumber & " X " & secondNumber & " = "
            txtnumbers.Text = compile
        ElseIf operatorType = "/" Then
            thirdNumber = firstNumber / secondNumber
            compile = firstNumber & " / " & secondNumber & " = "
            txtnumbers.Text = compile
        End If


        If firstNumber = 0 Then
            TextBox1.Text = secondNumber
        Else
            TextBox1.Text = thirdNumber
        End If

        isEquals = "="

    End Sub
End Class
