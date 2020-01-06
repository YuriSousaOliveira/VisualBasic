Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxid.TextChanged

    End Sub

    Private Sub Buttonve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonve.Click
        Dim id As Integer
        id = TextBoxid.Text
        If id <= 9 Then
            TextBoxverifica.Text = "criança"
        Else
            If id > 9 And id <= 18 Then
                TextBoxverifica.Text = "jovem"
            Else
                If id > 18 And id <= 40 Then
                    TextBoxverifica.Text = "adulto"
                Else
                    TextBoxverifica.Text = "idoso"

                End If
            End If
        End If
    End Sub
End Class
