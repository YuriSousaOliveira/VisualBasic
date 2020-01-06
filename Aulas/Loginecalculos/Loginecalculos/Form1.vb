Public Class Form1

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim login, senha As String
        login = Txtlogin.Text
        senha = Txtsenha.Text
        If (login = "Alunos") And (senha = "123") Then
            form2.show()
        Else
            MsgBox("login Invalido")


        End If
    End Sub
End Class
