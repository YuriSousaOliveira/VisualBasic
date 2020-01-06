Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim t, s, km, ms As Double
        t = Txttempo.Text
        s = Txtespaco.Text
        km = s / t
        Txtkm.Text = km
        ms = km / 3.6
        Txtms.Text = ms


    End Sub
End Class
