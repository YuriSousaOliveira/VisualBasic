Public Class Form1
    Dim nome As String
    Dim vitorias As Short
    Dim total As Short
    Dim stotal As Short



    Sub digitarnome()

        nome = InputBox("digite seu nome")

    End Sub
    Sub somarnumeros(ByVal a As Integer, ByVal b As Integer, ByVal c As Integer)
        MsgBox(nome & " A Soma dos 3 Numeros é: " & a + b + c)



    End Sub
    Function percentualvitorias(ByVal Stotal As Short, ByVal svitorias As Short) As String
        Dim percentual As Single
        percentual = svitorias / Stotal
        Return Format(percentual, "0.0%")

    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Lbl4.Visible = False
        Lbl1.Text = CStr(Int(Rnd() * 10))
        Lbl2.Text = CStr(Int(Rnd() * 10))
        lbl3.Text = CStr(Int(Rnd() * 10))
        total += 1

        If (Lbl1.Text = "7") Or (Lbl2.Text = "7") Or (lbl3.Text = "7") Then
            Lbl4.Visible = True
            Beep()
            vitorias += 1

        End If
        'somarnumeros(CType(Lbl1.Text, Integer), CType(Lbl2.Text, Integer), CType(lbl3.Text, Integer))

        Lblmediavitorias.Text = percentualvitorias(total, vitorias)
        Lblvitorias.Text = vitorias.ToString


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        digitarnome()

    End Sub
End Class
