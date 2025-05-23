Imports System.Data.OleDb
Imports System.IO

Public Class MainForm
    ' Koneksi ke database Access
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\agras\Documents\tesbiodata.accdb;"
    Dim conn As New OleDbConnection(connString)
    Dim fotoPath As String = String.Empty

    ' Button Simpan Data
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Try
            conn.Open()
            Dim query As String = "INSERT INTO Biodata (Nama, NIK, Alamat, TglLahir, JenisKelamin, Jurusan, Agama, NoTelp, Foto) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)"
            Dim cmd As New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("?", txtNama.Text)
            cmd.Parameters.AddWithValue("?", txtNIK.Text)
            cmd.Parameters.AddWithValue("?", txtAlamat.Text)
            cmd.Parameters.AddWithValue("?", dtpLahir.Value)
            cmd.Parameters.AddWithValue("?", cmbJK.SelectedItem?.ToString())
            cmd.Parameters.AddWithValue("?", cmbJurusan.Text)
            cmd.Parameters.AddWithValue("?", cmbAgama.SelectedItem?.ToString())
            cmd.Parameters.AddWithValue("?", txtTelp.Text)

            ' Menyimpan foto dalam bentuk binary
            If fotoPath <> String.Empty Then
                Dim fs As New FileStream(fotoPath, FileMode.Open, FileAccess.Read)
                Dim fotoData(fs.Length - 1) As Byte
                fs.Read(fotoData, 0, fotoData.Length)
                cmd.Parameters.AddWithValue("?", fotoData)
                fs.Close()
            Else
                cmd.Parameters.AddWithValue("?", DBNull.Value)
            End If

            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil disimpan.")
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Button Cari Data Berdasarkan NIK
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        Try
            conn.Open()
            Dim query As String = "SELECT * FROM Biodata WHERE NIK = ?"
            Dim cmd As New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("?", txtCariNIK.Text)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                ' Tampilkan di MainForm
                txtNIK.Text = reader("NIK").ToString()
                txtNama.Text = reader("Nama").ToString()
                txtAlamat.Text = reader("Alamat").ToString()
                dtpLahir.Value = Convert.ToDateTime(reader("TglLahir"))
                cmbJK.SelectedItem = reader("JenisKelamin").ToString()
                cmbJurusan.Text = reader("Jurusan").ToString()
                cmbAgama.SelectedItem = reader("Agama").ToString()
                txtTelp.Text = reader("NoTelp").ToString()

                ' Data untuk TampilFormvb
                Dim fotoData As Byte() = Nothing
                If Not IsDBNull(reader("Foto")) Then
                    fotoData = CType(reader("Foto"), Byte())
                    Dim ms As New MemoryStream(fotoData)
                    picFoto.Image = Image.FromStream(ms)
                Else
                    picFoto.Image = Nothing
                End If

                ' Tampilkan juga ke Form TampilFormvb
                Dim f2 As New TampilFormvb(
                reader("Nama").ToString(),
                reader("NIK").ToString(),
                reader("Alamat").ToString(),
                Convert.ToDateTime(reader("TglLahir")),
                reader("JenisKelamin").ToString(),
                reader("Jurusan").ToString(),
                reader("Agama").ToString(),
                reader("NoTelp").ToString(),
                fotoData
            )
                f2.Show()
            Else
                MessageBox.Show("Data tidak ditemukan.")
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Button Pilih Foto
    Private Sub btnPilihFoto_Click(sender As Object, e As EventArgs) Handles btnPilihFoto.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.jfif"
            If ofd.ShowDialog() = DialogResult.OK Then
                fotoPath = ofd.FileName
                picFoto.Image = Image.FromFile(fotoPath)
            End If
        End Using
    End Sub

    ' Validasi Hanya Huruf (Nama, Alamat, Jurusan)
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) AndAlso e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtJurusan_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) AndAlso e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    ' Validasi Hanya Angka (NIK, No Telp)
    Private Sub txtNIK_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNIK.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelp.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    ' Atur MaxLength untuk Pembatasan Karakter
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TesbiodataDataSet.Biodata' table. You can move, or remove it, as needed.
        Me.BiodataTableAdapter.Fill(Me.TesbiodataDataSet.Biodata)
        txtNama.MaxLength = 30
        txtAlamat.MaxLength = 100
        cmbJurusan.MaxLength = 25
        txtTelp.MaxLength = 13
        txtNIK.MaxLength = 10
        ' Atur properti DataGridView
        dgvHasilJurusan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvHasilJurusan.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvHasilJurusan.ReadOnly = True
    End Sub

    Private Sub txtCariNIK_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCariNIK.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnCari.PerformClick()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoginForm.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            conn.Open()
            Dim query As String = "UPDATE Biodata SET Nama=?, Alamat=?, TglLahir=?, JenisKelamin=?, Jurusan=?, Agama=?, NoTelp=?, Foto=? WHERE NIK=?"
            Dim cmd As New OleDbCommand(query, conn)

            cmd.Parameters.AddWithValue("?", txtNama.Text)
            cmd.Parameters.AddWithValue("?", txtAlamat.Text)
            cmd.Parameters.AddWithValue("?", dtpLahir.Value)
            cmd.Parameters.AddWithValue("?", cmbJK.SelectedItem?.ToString())
            cmd.Parameters.AddWithValue("?", cmbJurusan.Text)
            cmd.Parameters.AddWithValue("?", cmbAgama.SelectedItem?.ToString())
            cmd.Parameters.AddWithValue("?", txtTelp.Text)

            ' Foto
            If picFoto.Image IsNot Nothing Then
                Dim ms As New MemoryStream()
                picFoto.Image.Save(ms, picFoto.Image.RawFormat)
                Dim fotoData As Byte() = ms.ToArray()
                cmd.Parameters.AddWithValue("?", fotoData)
            Else
                cmd.Parameters.AddWithValue("?", DBNull.Value)
            End If

            ' Kunci: NIK
            cmd.Parameters.AddWithValue("?", txtNIK.Text)

            If cmd.ExecuteNonQuery() > 0 Then
                MessageBox.Show("Data berhasil diperbarui.")
            Else
                MessageBox.Show("Data gagal diperbarui.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error saat mengupdate: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                conn.Open()
                Dim query As String = "DELETE FROM Biodata WHERE NIK = ?"
                Dim cmd As New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("?", txtNIK.Text)
                Dim rowsAffected = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Data berhasil dihapus.")
                    ClearForm()
                Else
                    MessageBox.Show("Data tidak ditemukan.")
                End If
            Catch ex As Exception
                MessageBox.Show("Gagal menghapus data: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End If
    End Sub
    Private Sub ClearForm()
        txtNama.Clear()
        txtNIK.Clear()
        txtAlamat.Clear()
        cmbJurusan.SelectedIndex = -1
        txtTelp.Clear()
        cmbAgama.SelectedIndex = -1
        cmbJK.SelectedIndex = -1
        dtpLahir.Value = Date.Today
        picFoto.Image = Nothing
        fotoPath = String.Empty
    End Sub

    Private Sub txtCariNIK_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCariNIK.KeyPress
        ' Hanya izinkan angka dan tombol kontrol (seperti backspace)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnCariJurusan_Click(sender As Object, e As EventArgs) Handles btnCariJurusan.Click
        Try
            conn.Open()
            Dim query As String = "SELECT NIK, Nama, Alamat, TglLahir, JenisKelamin, Jurusan, Agama, NoTelp FROM Biodata WHERE Jurusan = ?"
            Dim cmd As New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("?", cmbCariJurusan.Text)

            Dim adapter As New OleDbDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            dgvHasilJurusan.DataSource = dt

            If dt.Rows.Count = 0 Then
                MessageBox.Show("Data dengan jurusan tersebut tidak ditemukan.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error saat pencarian: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        CleaForm() ' memanggil sub yang sudah kamu buat
        txtCariNIK.Clear() ' jika ingin juga menghapus textbox pencarian
        cmbCariJurusan.SelectedIndex = -1 ' jika ingin reset dropdown filter jurusan
    End Sub
    Private Sub CleaForm()
        txtNama.Clear()
        txtNIK.Clear()
        txtAlamat.Clear()
        txtNIK.Clear() ' Tambahan jika kamu punya input NPM
        cmbJurusan.SelectedIndex = -1
        txtTelp.Clear()
        cmbAgama.SelectedIndex = -1
        cmbJK.SelectedIndex = -1
        dtpLahir.Value = Date.Today
        picFoto.Image = Nothing
        fotoPath = String.Empty
    End Sub
End Class
