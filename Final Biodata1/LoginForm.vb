Imports System.Data.OleDb

Public Class LoginForm
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\agras\Documents\Users.accdb;")

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\agras\Documents\Users.accdb;")
        conn.Open()

        Dim cmd As New OleDbCommand("SELECT * FROM Users WHERE Username=? AND Password=?", conn)
        cmd.Parameters.AddWithValue("?", txtUsername.Text)
        cmd.Parameters.AddWithValue("?", txtPassword.Text)

        Dim reader As OleDbDataReader = cmd.ExecuteReader()

        If reader.HasRows Then
            MessageBox.Show("Login berhasil!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()              ' Sembunyikan form login
            MainForm.Show()       ' Tampilkan form utama
        Else
            MessageBox.Show("Username atau password salah!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        conn.Close()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        RegisterForm.Show()
    End Sub

    Private Sub btnForgotPassword_Click(sender As Object, e As EventArgs) Handles btnForgotPassword.Click
        ForgotPasswordForm.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class