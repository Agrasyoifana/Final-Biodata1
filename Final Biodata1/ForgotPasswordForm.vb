Imports System.Data.OleDb

Public Class ForgotPasswordForm
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\agras\Documents\Users.accdb;")

    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click
        conn.Open()
        Dim cmd As New OleDbCommand("SELECT * FROM Users WHERE Username=? AND SecurityAnswer=?", conn)
        cmd.Parameters.AddWithValue("?", txtUsername.Text)
        cmd.Parameters.AddWithValue("?", txtSecurityAnswer.Text)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()

        If reader.Read() Then
            lblQuestion.Text = "Pertanyaan: " & reader("SecurityQuestion").ToString()
            lblPassword.Text = "Password Anda: " & reader("Password").ToString()
        Else
            MessageBox.Show("Jawaban salah atau username tidak ditemukan.")
        End If
        conn.Close()
    End Sub
End Class