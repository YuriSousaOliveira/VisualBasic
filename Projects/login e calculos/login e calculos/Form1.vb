Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim login, senha As String
        login = txtlogin.Text
        senha = txtsenha.Text
        If (login = "alunos") And (senha = "123") Then
            form2.show()
        Else
            MsgBox("Login invalido !")

        End If
    End Sub
End Class
