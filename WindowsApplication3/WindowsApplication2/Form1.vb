Public Class F

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtondivisao.CheckedChanged

    End Sub

    Private Sub buttoncalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttoncalc.Click
        Dim n1, n2 As Double
        n1 = TextBoxnum1.Text
        n2 = TextBoxnum2.Text
        If RadioButtonadicao.Checked = True Then
            TextBoxresult.Text = n1 + n2
        End If
        If RadioButtonsubtracao.Checked = True Then
            TextBoxresult.Text = n1 - n2
        End If
        If RadioButtonmultiplicacao.Checked = True Then
            TextBoxresult.Text = n1 * n2
        End If

        If RadioButtondivisao.Checked = True Then
            TextBoxresult.Text = n1 / n2

        End If



    End Sub
End Class
