Imports System.Data.OleDb

Public Class RegisterForm
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\agras\Documents\Users.accdb;")

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Or txtEmail.Text = "" Or cmbSecurityQuestion.Text = "" Or txtSecurityAnswer.Text = "" Then
            MessageBox.Show("Semua field harus diisi.")
            Exit Sub
        End If

        conn.Open()
        Dim cmd As New OleDbCommand("INSERT INTO Users ([Username], [Password], [Email], [SecurityQuestion], [SecurityAnswer]) VALUES (?, ?, ?, ?, ?)", conn)
        cmd.Parameters.AddWithValue("?", txtUsername.Text)
        cmd.Parameters.AddWithValue("?", txtPassword.Text)
        cmd.Parameters.AddWithValue("?", txtEmail.Text)
        cmd.Parameters.AddWithValue("?", cmbSecurityQuestion.Text)
        cmd.Parameters.AddWithValue("?", txtSecurityAnswer.Text)
        cmd.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("Akun berhasil dibuat.")
        Me.Close()
    End Sub
End Class