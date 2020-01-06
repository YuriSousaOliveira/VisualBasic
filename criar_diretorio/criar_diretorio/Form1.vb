Imports System.IO

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim diretorio As String
        diretorio = "C:\Users\Aluno\Documents\Arquivos"
        If Directory.Exists(diretorio) Then
            lblmsg.Text = "O diretorio ja existe"
        Else
            Directory.CreateDirectory(diretorio)
            lblmsg.Text = "O diretorio" & diretorio & "foi criado"
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim diretorio As String
        diretorio = "C:\Users\Aluno\Documents\Arquivos"
        If Directory.Exists(diretorio) Then
            Directory.Delete(diretorio)
            lblmsg.Text = "O diretorio foi excluido!"
        Else
            lblmsg.Text = "o diretorio nao existe!"
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim diretorio As String
        diretorio = "C:\Users\Aluno\Documents"
        Dim listadiretorios As String() = Directory.GetDirectories(diretorio)
        Lblista.Items.Clear()
        For Each Dir As String In listadiretorios
            Lblista.Items.Add(Dir.ToString())
        Next
    End Sub
End Class
