Public Class Form1

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim login, senha As String
        login = Txtlogin.Text
        senha = Txtsenha.Text
        If (login = "ADmin") And (senha = "ADmin") Then
            Form2.Show()
            Me.Hide()

        Else
            MsgBox("LOgin inválido.")
        End If
    End Sub
End Class
