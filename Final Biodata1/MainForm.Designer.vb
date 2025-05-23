<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnPilihFoto = New System.Windows.Forms.Button()
        Me.picFoto = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNIK = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTelp = New System.Windows.Forms.TextBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.txtCariNIK = New System.Windows.Forms.TextBox()
        Me.cmbJK = New System.Windows.Forms.ComboBox()
        Me.dtpLahir = New System.Windows.Forms.DateTimePicker()
        Me.cmbAgama = New System.Windows.Forms.ComboBox()
        Me.dgvHasilJurusan = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NIKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlamatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglLahirDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JenisKelaminDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JurusanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgamaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoTelpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FotoDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.BiodataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TesbiodataDataSet = New Final_Biodata1.tesbiodataDataSet()
        Me.BiodataTableAdapter = New Final_Biodata1.tesbiodataDataSetTableAdapters.BiodataTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.cmbJurusan = New System.Windows.Forms.ComboBox()
        Me.btnCariJurusan = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbCariJurusan = New System.Windows.Forms.ComboBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvHasilJurusan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BiodataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TesbiodataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnPilihFoto)
        Me.Panel1.Controls.Add(Me.picFoto)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(313, 729)
        Me.Panel1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(93, 601)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 38)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "LogOut"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnPilihFoto
        '
        Me.btnPilihFoto.Location = New System.Drawing.Point(93, 248)
        Me.btnPilihFoto.Name = "btnPilihFoto"
        Me.btnPilihFoto.Size = New System.Drawing.Size(118, 43)
        Me.btnPilihFoto.TabIndex = 4
        Me.btnPilihFoto.Text = "Pilih Foto"
        Me.btnPilihFoto.UseVisualStyleBackColor = True
        '
        'picFoto
        '
        Me.picFoto.Image = Global.Final_Biodata1.My.Resources.Resources.icons8_test_account_96
        Me.picFoto.Location = New System.Drawing.Point(76, 67)
        Me.picFoto.Name = "picFoto"
        Me.picFoto.Size = New System.Drawing.Size(150, 170)
        Me.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFoto.TabIndex = 3
        Me.picFoto.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(355, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nama"
        '
        'txtNama
        '
        Me.txtNama.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.txtNama.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtNama.Location = New System.Drawing.Point(434, 56)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(349, 30)
        Me.txtNama.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(355, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 23)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "NPM"
        '
        'txtNIK
        '
        Me.txtNIK.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.txtNIK.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNIK.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtNIK.Location = New System.Drawing.Point(434, 96)
        Me.txtNIK.Name = "txtNIK"
        Me.txtNIK.Size = New System.Drawing.Size(349, 30)
        Me.txtNIK.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label9.Location = New System.Drawing.Point(355, 139)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 23)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Alamat"
        '
        'txtAlamat
        '
        Me.txtAlamat.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.txtAlamat.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlamat.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtAlamat.Location = New System.Drawing.Point(434, 136)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(349, 30)
        Me.txtAlamat.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(355, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 23)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Jenis Kelamin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(355, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 23)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Tanggal Lahir"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label5.Location = New System.Drawing.Point(355, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 23)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Jurusan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Location = New System.Drawing.Point(355, 284)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 23)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Agama"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label7.Location = New System.Drawing.Point(355, 324)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 23)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "No. Telp"
        '
        'txtTelp
        '
        Me.txtTelp.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.txtTelp.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelp.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtTelp.Location = New System.Drawing.Point(433, 318)
        Me.txtTelp.Name = "txtTelp"
        Me.txtTelp.Size = New System.Drawing.Size(350, 30)
        Me.txtTelp.TabIndex = 26
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnSimpan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSimpan.Location = New System.Drawing.Point(814, 56)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(118, 43)
        Me.btnSimpan.TabIndex = 5
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'btnCari
        '
        Me.btnCari.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnCari.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCari.Location = New System.Drawing.Point(1141, 236)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(103, 42)
        Me.btnCari.TabIndex = 27
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = False
        '
        'txtCariNIK
        '
        Me.txtCariNIK.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.txtCariNIK.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCariNIK.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtCariNIK.Location = New System.Drawing.Point(814, 241)
        Me.txtCariNIK.Name = "txtCariNIK"
        Me.txtCariNIK.Size = New System.Drawing.Size(321, 30)
        Me.txtCariNIK.TabIndex = 28
        '
        'cmbJK
        '
        Me.cmbJK.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.cmbJK.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbJK.ForeColor = System.Drawing.Color.White
        Me.cmbJK.FormattingEnabled = True
        Me.cmbJK.Items.AddRange(New Object() {"Laki-Laki", "Perempuan"})
        Me.cmbJK.Location = New System.Drawing.Point(474, 174)
        Me.cmbJK.Name = "cmbJK"
        Me.cmbJK.Size = New System.Drawing.Size(309, 31)
        Me.cmbJK.TabIndex = 29
        '
        'dtpLahir
        '
        Me.dtpLahir.Location = New System.Drawing.Point(474, 215)
        Me.dtpLahir.Name = "dtpLahir"
        Me.dtpLahir.Size = New System.Drawing.Size(309, 22)
        Me.dtpLahir.TabIndex = 30
        '
        'cmbAgama
        '
        Me.cmbAgama.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.cmbAgama.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAgama.ForeColor = System.Drawing.Color.White
        Me.cmbAgama.FormattingEnabled = True
        Me.cmbAgama.Items.AddRange(New Object() {"Islam", "Hindu", "Budha", "Kristen", "Katolik"})
        Me.cmbAgama.Location = New System.Drawing.Point(434, 281)
        Me.cmbAgama.Name = "cmbAgama"
        Me.cmbAgama.Size = New System.Drawing.Size(349, 31)
        Me.cmbAgama.TabIndex = 31
        '
        'dgvHasilJurusan
        '
        Me.dgvHasilJurusan.AutoGenerateColumns = False
        Me.dgvHasilJurusan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHasilJurusan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NamaDataGridViewTextBoxColumn, Me.NIKDataGridViewTextBoxColumn, Me.AlamatDataGridViewTextBoxColumn, Me.TglLahirDataGridViewTextBoxColumn, Me.JenisKelaminDataGridViewTextBoxColumn, Me.JurusanDataGridViewTextBoxColumn, Me.AgamaDataGridViewTextBoxColumn, Me.NoTelpDataGridViewTextBoxColumn, Me.FotoDataGridViewImageColumn})
        Me.dgvHasilJurusan.DataSource = Me.BiodataBindingSource
        Me.dgvHasilJurusan.Location = New System.Drawing.Point(359, 366)
        Me.dgvHasilJurusan.Name = "dgvHasilJurusan"
        Me.dgvHasilJurusan.RowHeadersWidth = 51
        Me.dgvHasilJurusan.RowTemplate.Height = 24
        Me.dgvHasilJurusan.Size = New System.Drawing.Size(897, 333)
        Me.dgvHasilJurusan.TabIndex = 32
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Width = 125
        '
        'NamaDataGridViewTextBoxColumn
        '
        Me.NamaDataGridViewTextBoxColumn.DataPropertyName = "Nama"
        Me.NamaDataGridViewTextBoxColumn.HeaderText = "Nama"
        Me.NamaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NamaDataGridViewTextBoxColumn.Name = "NamaDataGridViewTextBoxColumn"
        Me.NamaDataGridViewTextBoxColumn.Width = 125
        '
        'NIKDataGridViewTextBoxColumn
        '
        Me.NIKDataGridViewTextBoxColumn.DataPropertyName = "NIK"
        Me.NIKDataGridViewTextBoxColumn.HeaderText = "NIK"
        Me.NIKDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NIKDataGridViewTextBoxColumn.Name = "NIKDataGridViewTextBoxColumn"
        Me.NIKDataGridViewTextBoxColumn.Width = 125
        '
        'AlamatDataGridViewTextBoxColumn
        '
        Me.AlamatDataGridViewTextBoxColumn.DataPropertyName = "Alamat"
        Me.AlamatDataGridViewTextBoxColumn.HeaderText = "Alamat"
        Me.AlamatDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AlamatDataGridViewTextBoxColumn.Name = "AlamatDataGridViewTextBoxColumn"
        Me.AlamatDataGridViewTextBoxColumn.Width = 125
        '
        'TglLahirDataGridViewTextBoxColumn
        '
        Me.TglLahirDataGridViewTextBoxColumn.DataPropertyName = "TglLahir"
        Me.TglLahirDataGridViewTextBoxColumn.HeaderText = "TglLahir"
        Me.TglLahirDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TglLahirDataGridViewTextBoxColumn.Name = "TglLahirDataGridViewTextBoxColumn"
        Me.TglLahirDataGridViewTextBoxColumn.Width = 125
        '
        'JenisKelaminDataGridViewTextBoxColumn
        '
        Me.JenisKelaminDataGridViewTextBoxColumn.DataPropertyName = "JenisKelamin"
        Me.JenisKelaminDataGridViewTextBoxColumn.HeaderText = "JenisKelamin"
        Me.JenisKelaminDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.JenisKelaminDataGridViewTextBoxColumn.Name = "JenisKelaminDataGridViewTextBoxColumn"
        Me.JenisKelaminDataGridViewTextBoxColumn.Width = 125
        '
        'JurusanDataGridViewTextBoxColumn
        '
        Me.JurusanDataGridViewTextBoxColumn.DataPropertyName = "Jurusan"
        Me.JurusanDataGridViewTextBoxColumn.HeaderText = "Jurusan"
        Me.JurusanDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.JurusanDataGridViewTextBoxColumn.Name = "JurusanDataGridViewTextBoxColumn"
        Me.JurusanDataGridViewTextBoxColumn.Width = 125
        '
        'AgamaDataGridViewTextBoxColumn
        '
        Me.AgamaDataGridViewTextBoxColumn.DataPropertyName = "Agama"
        Me.AgamaDataGridViewTextBoxColumn.HeaderText = "Agama"
        Me.AgamaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AgamaDataGridViewTextBoxColumn.Name = "AgamaDataGridViewTextBoxColumn"
        Me.AgamaDataGridViewTextBoxColumn.Width = 125
        '
        'NoTelpDataGridViewTextBoxColumn
        '
        Me.NoTelpDataGridViewTextBoxColumn.DataPropertyName = "NoTelp"
        Me.NoTelpDataGridViewTextBoxColumn.HeaderText = "NoTelp"
        Me.NoTelpDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NoTelpDataGridViewTextBoxColumn.Name = "NoTelpDataGridViewTextBoxColumn"
        Me.NoTelpDataGridViewTextBoxColumn.Width = 125
        '
        'FotoDataGridViewImageColumn
        '
        Me.FotoDataGridViewImageColumn.DataPropertyName = "Foto"
        Me.FotoDataGridViewImageColumn.HeaderText = "Foto"
        Me.FotoDataGridViewImageColumn.MinimumWidth = 6
        Me.FotoDataGridViewImageColumn.Name = "FotoDataGridViewImageColumn"
        Me.FotoDataGridViewImageColumn.Width = 125
        '
        'BiodataBindingSource
        '
        Me.BiodataBindingSource.DataMember = "Biodata"
        Me.BiodataBindingSource.DataSource = Me.TesbiodataDataSet
        '
        'TesbiodataDataSet
        '
        Me.TesbiodataDataSet.DataSetName = "tesbiodataDataSet"
        Me.TesbiodataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BiodataTableAdapter
        '
        Me.BiodataTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(814, 105)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 43)
        Me.Button2.TabIndex = 33
        Me.Button2.Text = "Edit"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(814, 154)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(118, 43)
        Me.Button3.TabIndex = 34
        Me.Button3.Text = "Hapus"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'cmbJurusan
        '
        Me.cmbJurusan.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.cmbJurusan.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbJurusan.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.cmbJurusan.FormattingEnabled = True
        Me.cmbJurusan.Items.AddRange(New Object() {"Manajemen", "Akuntansi", "Ekonomi Syariah"})
        Me.cmbJurusan.Location = New System.Drawing.Point(434, 244)
        Me.cmbJurusan.Name = "cmbJurusan"
        Me.cmbJurusan.Size = New System.Drawing.Size(349, 31)
        Me.cmbJurusan.TabIndex = 35
        '
        'btnCariJurusan
        '
        Me.btnCariJurusan.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnCariJurusan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCariJurusan.Location = New System.Drawing.Point(1141, 313)
        Me.btnCariJurusan.Name = "btnCariJurusan"
        Me.btnCariJurusan.Size = New System.Drawing.Size(103, 42)
        Me.btnCariJurusan.TabIndex = 37
        Me.btnCariJurusan.Text = "Cari"
        Me.btnCariJurusan.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label8.Location = New System.Drawing.Point(812, 214)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(227, 23)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Pencarian Berdasarkan NPM"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label10.Location = New System.Drawing.Point(812, 291)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(247, 23)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Pencarian Berdasarkan Jurusan"
        '
        'cmbCariJurusan
        '
        Me.cmbCariJurusan.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.cmbCariJurusan.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCariJurusan.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.cmbCariJurusan.FormattingEnabled = True
        Me.cmbCariJurusan.Items.AddRange(New Object() {"Manajemen", "Akuntansi", "Ekonomi Syariah"})
        Me.cmbCariJurusan.Location = New System.Drawing.Point(814, 317)
        Me.cmbCariJurusan.Name = "cmbCariJurusan"
        Me.cmbCariJurusan.Size = New System.Drawing.Size(319, 31)
        Me.cmbCariJurusan.TabIndex = 40
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClear.Location = New System.Drawing.Point(941, 154)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(118, 43)
        Me.btnClear.TabIndex = 41
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1285, 729)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.cmbCariJurusan)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnCariJurusan)
        Me.Controls.Add(Me.cmbJurusan)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.dgvHasilJurusan)
        Me.Controls.Add(Me.cmbAgama)
        Me.Controls.Add(Me.dtpLahir)
        Me.Controls.Add(Me.cmbJK)
        Me.Controls.Add(Me.txtCariNIK)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.txtTelp)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtNIK)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.Panel1.ResumeLayout(False)
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvHasilJurusan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BiodataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TesbiodataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNIK As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents picFoto As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTelp As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnPilihFoto As Button
    Friend WithEvents btnCari As Button
    Friend WithEvents txtCariNIK As TextBox
    Friend WithEvents cmbJK As ComboBox
    Friend WithEvents dtpLahir As DateTimePicker
    Friend WithEvents cmbAgama As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents dgvHasilJurusan As DataGridView
    Friend WithEvents TesbiodataDataSet As tesbiodataDataSet
    Friend WithEvents BiodataBindingSource As BindingSource
    Friend WithEvents BiodataTableAdapter As tesbiodataDataSetTableAdapters.BiodataTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NIKDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlamatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TglLahirDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JenisKelaminDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JurusanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AgamaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoTelpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FotoDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents cmbJurusan As ComboBox
    Friend WithEvents btnCariJurusan As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbCariJurusan As ComboBox
    Friend WithEvents btnClear As Button
End Class
