Public Class Media

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n1, n2, n3, n4 As Double
        n1 = TextBox1.Text
        n2 = TextBox2.Text
        n3 = TextBox3.Text
        n4 = TextBox4.Text
        TextBox5.Text = (n1 + n2 + n3 + n4) / 4

    End Sub
End Class