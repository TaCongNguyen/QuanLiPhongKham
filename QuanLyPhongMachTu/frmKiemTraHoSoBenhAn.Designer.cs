namespace QuanLyPhongMachTu
{
    partial class frmKiemTraHoSoBenhAn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKiemTraHoSoBenhAn));
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayKham = new System.Windows.Forms.DateTimePicker();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.txtChuanDoan = new System.Windows.Forms.TextBox();
            this.txtTrieuChung = new System.Windows.Forms.TextBox();
            this.txtBacSiKham = new System.Windows.Forms.TextBox();
            this.txtTenBN = new System.Windows.Forms.TextBox();
            this.lblChuanDoan = new System.Windows.Forms.Label();
            this.lblTrieuChung = new System.Windows.Forms.Label();
            this.lblBacSiKham = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblTenBN = new System.Windows.Forms.Label();
            this.lblChiTietPK = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvThongTinToaThuoc = new System.Windows.Forms.DataGridView();
            this.dgvLichSuKhamBenh = new System.Windows.Forms.DataGridView();
            this.lblLichSuKhamBenh = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtMaBenhNhan = new System.Windows.Forms.TextBox();
            this.lblMaBenhNhan = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinToaThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuKhamBenh)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CalendarFont = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Enabled = false;
            this.dtpNgaySinh.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Location = new System.Drawing.Point(129, 38);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(293, 25);
            this.dtpNgaySinh.TabIndex = 58;
            this.dtpNgaySinh.ValueChanged += new System.EventHandler(this.dtpNgaySinh_ValueChanged);
            // 
            // dtpNgayKham
            // 
            this.dtpNgayKham.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKham.Enabled = false;
            this.dtpNgayKham.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKham.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKham.Location = new System.Drawing.Point(613, 79);
            this.dtpNgayKham.Name = "dtpNgayKham";
            this.dtpNgayKham.Size = new System.Drawing.Size(147, 28);
            this.dtpNgayKham.TabIndex = 57;
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Enabled = false;
            this.rdbNu.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNu.Location = new System.Drawing.Point(216, 83);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(45, 21);
            this.rdbNu.TabIndex = 56;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Enabled = false;
            this.rdbNam.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNam.Location = new System.Drawing.Point(129, 83);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(55, 21);
            this.rdbNam.TabIndex = 55;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // txtChuanDoan
            // 
            this.txtChuanDoan.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChuanDoan.Location = new System.Drawing.Point(129, 184);
            this.txtChuanDoan.Name = "txtChuanDoan";
            this.txtChuanDoan.ReadOnly = true;
            this.txtChuanDoan.Size = new System.Drawing.Size(293, 25);
            this.txtChuanDoan.TabIndex = 54;
            // 
            // txtTrieuChung
            // 
            this.txtTrieuChung.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrieuChung.Location = new System.Drawing.Point(129, 149);
            this.txtTrieuChung.Name = "txtTrieuChung";
            this.txtTrieuChung.ReadOnly = true;
            this.txtTrieuChung.Size = new System.Drawing.Size(293, 25);
            this.txtTrieuChung.TabIndex = 53;
            // 
            // txtBacSiKham
            // 
            this.txtBacSiKham.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBacSiKham.Location = new System.Drawing.Point(129, 114);
            this.txtBacSiKham.Name = "txtBacSiKham";
            this.txtBacSiKham.ReadOnly = true;
            this.txtBacSiKham.Size = new System.Drawing.Size(293, 25);
            this.txtBacSiKham.TabIndex = 52;
            // 
            // txtTenBN
            // 
            this.txtTenBN.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenBN.Location = new System.Drawing.Point(129, 7);
            this.txtTenBN.Name = "txtTenBN";
            this.txtTenBN.ReadOnly = true;
            this.txtTenBN.Size = new System.Drawing.Size(293, 25);
            this.txtTenBN.TabIndex = 51;
            // 
            // lblChuanDoan
            // 
            this.lblChuanDoan.AutoSize = true;
            this.lblChuanDoan.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuanDoan.Location = new System.Drawing.Point(9, 186);
            this.lblChuanDoan.Name = "lblChuanDoan";
            this.lblChuanDoan.Size = new System.Drawing.Size(81, 17);
            this.lblChuanDoan.TabIndex = 49;
            this.lblChuanDoan.Text = "Chuẩn đoán";
            this.lblChuanDoan.Click += new System.EventHandler(this.lblChuanDoan_Click);
            // 
            // lblTrieuChung
            // 
            this.lblTrieuChung.AutoSize = true;
            this.lblTrieuChung.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrieuChung.Location = new System.Drawing.Point(9, 149);
            this.lblTrieuChung.Name = "lblTrieuChung";
            this.lblTrieuChung.Size = new System.Drawing.Size(83, 17);
            this.lblTrieuChung.TabIndex = 48;
            this.lblTrieuChung.Text = "Triệu chứng";
            // 
            // lblBacSiKham
            // 
            this.lblBacSiKham.AutoSize = true;
            this.lblBacSiKham.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBacSiKham.Location = new System.Drawing.Point(9, 114);
            this.lblBacSiKham.Name = "lblBacSiKham";
            this.lblBacSiKham.Size = new System.Drawing.Size(82, 17);
            this.lblBacSiKham.TabIndex = 50;
            this.lblBacSiKham.Text = "Bác sĩ khám";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.Location = new System.Drawing.Point(9, 83);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(62, 17);
            this.lblGioiTinh.TabIndex = 47;
            this.lblGioiTinh.Text = "Giới tính";
            this.lblGioiTinh.Click += new System.EventHandler(this.lblGioiTinh_Click);
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.Location = new System.Drawing.Point(9, 38);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(69, 17);
            this.lblNgaySinh.TabIndex = 46;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // lblTenBN
            // 
            this.lblTenBN.AutoSize = true;
            this.lblTenBN.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenBN.Location = new System.Drawing.Point(9, 7);
            this.lblTenBN.Name = "lblTenBN";
            this.lblTenBN.Size = new System.Drawing.Size(99, 17);
            this.lblTenBN.TabIndex = 45;
            this.lblTenBN.Text = "Tên bệnh nhân";
            // 
            // lblChiTietPK
            // 
            this.lblChiTietPK.AutoSize = true;
            this.lblChiTietPK.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietPK.Location = new System.Drawing.Point(333, 86);
            this.lblChiTietPK.Name = "lblChiTietPK";
            this.lblChiTietPK.Size = new System.Drawing.Size(230, 22);
            this.lblChiTietPK.TabIndex = 44;
            this.lblChiTietPK.Text = "Chi Tiết Phiếu Khám ngày";
            this.lblChiTietPK.Click += new System.EventHandler(this.lblChiTietPK_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.IndianRed;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(641, 449);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(152, 29);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvThongTinToaThuoc
            // 
            this.dgvThongTinToaThuoc.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvThongTinToaThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinToaThuoc.GridColor = System.Drawing.Color.White;
            this.dgvThongTinToaThuoc.Location = new System.Drawing.Point(9, 335);
            this.dgvThongTinToaThuoc.Name = "dgvThongTinToaThuoc";
            this.dgvThongTinToaThuoc.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongTinToaThuoc.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThongTinToaThuoc.RowHeadersWidth = 62;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvThongTinToaThuoc.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvThongTinToaThuoc.Size = new System.Drawing.Size(784, 108);
            this.dgvThongTinToaThuoc.TabIndex = 43;
            // 
            // dgvLichSuKhamBenh
            // 
            this.dgvLichSuKhamBenh.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLichSuKhamBenh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLichSuKhamBenh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLichSuKhamBenh.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLichSuKhamBenh.GridColor = System.Drawing.Color.White;
            this.dgvLichSuKhamBenh.Location = new System.Drawing.Point(9, 110);
            this.dgvLichSuKhamBenh.Name = "dgvLichSuKhamBenh";
            this.dgvLichSuKhamBenh.ReadOnly = true;
            this.dgvLichSuKhamBenh.RowHeadersWidth = 62;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvLichSuKhamBenh.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvLichSuKhamBenh.Size = new System.Drawing.Size(322, 219);
            this.dgvLichSuKhamBenh.TabIndex = 3;
            this.dgvLichSuKhamBenh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichSuKhamBenh_CellContentClick);
            this.dgvLichSuKhamBenh.Click += new System.EventHandler(this.dgvLichSuKhamBenh_Click);
            // 
            // lblLichSuKhamBenh
            // 
            this.lblLichSuKhamBenh.AutoSize = true;
            this.lblLichSuKhamBenh.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLichSuKhamBenh.Location = new System.Drawing.Point(9, 86);
            this.lblLichSuKhamBenh.Name = "lblLichSuKhamBenh";
            this.lblLichSuKhamBenh.Size = new System.Drawing.Size(176, 22);
            this.lblLichSuKhamBenh.TabIndex = 42;
            this.lblLichSuKhamBenh.Text = "Lịch Sử Khám Bệnh";
            this.lblLichSuKhamBenh.Click += new System.EventHandler(this.lblLichSuKhamBenh_Click);
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTim.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTim.FlatAppearance.BorderSize = 0;
            this.btnTim.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnTim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(425, 24);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(131, 29);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtMaBenhNhan
            // 
            this.txtMaBenhNhan.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBenhNhan.Location = new System.Drawing.Point(175, 24);
            this.txtMaBenhNhan.Name = "txtMaBenhNhan";
            this.txtMaBenhNhan.Size = new System.Drawing.Size(234, 29);
            this.txtMaBenhNhan.TabIndex = 1;
            this.txtMaBenhNhan.Text = "1";
            // 
            // lblMaBenhNhan
            // 
            this.lblMaBenhNhan.AutoSize = true;
            this.lblMaBenhNhan.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaBenhNhan.ForeColor = System.Drawing.Color.Black;
            this.lblMaBenhNhan.Location = new System.Drawing.Point(9, 27);
            this.lblMaBenhNhan.Name = "lblMaBenhNhan";
            this.lblMaBenhNhan.Size = new System.Drawing.Size(133, 22);
            this.lblMaBenhNhan.TabIndex = 41;
            this.lblMaBenhNhan.Text = "Mã Bệnh Nhân";
            this.lblMaBenhNhan.Click += new System.EventHandler(this.lblMaBenhNhan_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpNgaySinh);
            this.panel1.Controls.Add(this.rdbNu);
            this.panel1.Controls.Add(this.rdbNam);
            this.panel1.Controls.Add(this.txtChuanDoan);
            this.panel1.Controls.Add(this.txtTrieuChung);
            this.panel1.Controls.Add(this.txtBacSiKham);
            this.panel1.Controls.Add(this.txtTenBN);
            this.panel1.Controls.Add(this.lblChuanDoan);
            this.panel1.Controls.Add(this.lblTrieuChung);
            this.panel1.Controls.Add(this.lblBacSiKham);
            this.panel1.Controls.Add(this.lblGioiTinh);
            this.panel1.Controls.Add(this.lblNgaySinh);
            this.panel1.Controls.Add(this.lblTenBN);
            this.panel1.Location = new System.Drawing.Point(337, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 218);
            this.panel1.TabIndex = 59;
            // 
            // frmKiemTraHoSoBenhAn
            // 
            this.AcceptButton = this.btnTim;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(805, 490);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpNgayKham);
            this.Controls.Add(this.lblChiTietPK);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvThongTinToaThuoc);
            this.Controls.Add(this.dgvLichSuKhamBenh);
            this.Controls.Add(this.lblLichSuKhamBenh);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtMaBenhNhan);
            this.Controls.Add(this.lblMaBenhNhan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKiemTraHoSoBenhAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kiểm Tra Hồ Sơ Bệnh Án";
            this.Load += new System.EventHandler(this.KiemTraHoSoBenhAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinToaThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuKhamBenh)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgayKham;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.TextBox txtChuanDoan;
        private System.Windows.Forms.TextBox txtTrieuChung;
        private System.Windows.Forms.TextBox txtBacSiKham;
        private System.Windows.Forms.TextBox txtTenBN;
        private System.Windows.Forms.Label lblChuanDoan;
        private System.Windows.Forms.Label lblTrieuChung;
        private System.Windows.Forms.Label lblBacSiKham;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblTenBN;
        private System.Windows.Forms.Label lblChiTietPK;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvThongTinToaThuoc;
        private System.Windows.Forms.DataGridView dgvLichSuKhamBenh;
        private System.Windows.Forms.Label lblLichSuKhamBenh;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtMaBenhNhan;
        private System.Windows.Forms.Label lblMaBenhNhan;
        private System.Windows.Forms.Panel panel1;
    }
}

