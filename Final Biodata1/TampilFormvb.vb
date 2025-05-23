Imports System.IO

Public Class TampilFormvb
    Public Sub New(nama As String, npm As String, alamat As String, tglLahir As Date, jk As String, jurusan As String, agama As String, telp As String, foto As Byte())
        InitializeComponent()

        lblNama.Text = nama
        lblNIK.Text = npm
        lblAlamat.Text = alamat
        lblTglLahir.Text = tglLahir.ToShortDateString()
        lblJK.Text = jk
        lblJurusan.Text = jurusan
        lblAgama.Text = agama
        lblTelp.Text = telp

        If foto IsNot Nothing Then
            Dim ms As New MemoryStream(foto)
            picFoto.Image = Image.FromStream(ms)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoginForm.Show()
        Me.Close()
    End Sub
End Class