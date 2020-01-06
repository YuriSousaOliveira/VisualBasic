Imports System.Math

Public Class Form1

    Private Sub Buttoncalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttoncalc.Click
        Dim co, ca, r, h As Double
        co = TextBoxco.Text
        ca = TextBoxca.Text

        r = co ^ 2 + ca ^ 2
        h = Math.Sqrt(r)
        MsgBox("a Hipotenusa é:" & h)

    End Sub
End Class
