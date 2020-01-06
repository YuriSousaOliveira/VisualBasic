Public Class Form1

    Private Sub Buttoncalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttoncalc.Click
        Dim n1, n2, t, g As Double
        n1 = TextBoxtempo.Text
        n2 = TextBoxespaco.Text
        t = n1 / 60
        g = n2 / t
        MsgBox("a velocidade é:" & g)

    End Sub
End Class
