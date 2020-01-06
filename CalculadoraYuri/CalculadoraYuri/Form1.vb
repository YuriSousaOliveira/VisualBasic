Public Class Form1

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim n1 As Integer
        n1 = Button3.CanSelect
        n1 = 1
        If TextBox1.Text = "" Then
            TextBox1.Text = n1
        Else
            TextBox3.Text = n1
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim n2 As Integer
        n2 = Button7.CanSelect
        n2 = 2
        If TextBox1.Text = "" Then
            TextBox1.Text = n2
        Else
            TextBox3.Text = n2
        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Dim n3 As Integer
        n3 = Button11.CanSelect
        n3 = 3
        If TextBox1.Text = "" Then
            TextBox1.Text = n3
        Else
            TextBox3.Text = n3
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim n4 As Integer
        n4 = Button2.CanSelect
        n4 = 4
        If TextBox1.Text = "" Then
            TextBox1.Text = n4
        Else
            TextBox3.Text = n4
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim n5 As Integer
        n5 = Button6.CanSelect
        n5 = 5
        If TextBox1.Text = "" Then
            TextBox1.Text = n5
        Else
            TextBox3.Text = n5
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Dim n6 As Integer
        n6 = Button10.CanSelect
        n6 = 6
        If TextBox1.Text = "" Then
            TextBox1.Text = n6
        Else
            TextBox3.Text = n6
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n7 As Integer
        n7 = Button1.CanSelect
        n7 = 7
        If TextBox1.Text = "" Then
            TextBox1.Text = n7
        Else
            TextBox3.Text = n7
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim n8 As Integer
        n8 = Button5.CanSelect
        n8 = 8
        If TextBox1.Text = "" Then
            TextBox1.Text = n8
        Else
            TextBox3.Text = n8
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim n9 As Integer
        n9 = Button9.CanSelect
        n9 = 9
        If TextBox1.Text = "" Then
            TextBox1.Text = n9
        Else
            TextBox3.Text = n9
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim n0 As Integer
        n0 = Button4.CanSelect
        n0 = 0
        If TextBox1.Text = "" Then
            TextBox1.Text = n0
        Else
            TextBox3.Text = n0
        End If
    End Sub

    Private Sub Calcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calcular.Click
        Dim a, b As Double
        a = TextBox1.Text
        b = TextBox3.Text
        If TextBox2.Text = "+" Then

            TextBox4.Text = a + b
        Else
            If TextBox2.Text = "-" Then
                TextBox4.Text = a - b
            Else

                If TextBox2.Text = "x" Then
                    TextBox4.Text = a * b
                Else

                    If TextBox2.Text = "/" Then
                        TextBox4.Text = a / b
                    Else
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Adição_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Adição.Click
        TextBox2.Text = "+"
    End Sub

    Private Sub Subtração_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Subtração.Click
        TextBox2.Text = "-"
    End Sub

    Private Sub Multiplicação_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Multiplicação.Click
        TextBox2.Text = "x"
    End Sub

    Private Sub Divisão_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Divisão.Click
        TextBox2.Text = "/"
    End Sub

    Private Sub ac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ac.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""

    End Sub
End Class
