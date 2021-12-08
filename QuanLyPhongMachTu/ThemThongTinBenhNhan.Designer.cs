namespace QuanLyPhongMachTu
{
    partial class ThemThongTinBenhNhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemThongTinBenhNhan));
            this.dtp_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_Them = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txb_DienThoai = new System.Windows.Forms.TextBox();
            this.txb_DiaChi = new System.Windows.Forms.TextBox();
            this.txb_HoTen = new System.Windows.Forms.TextBox();
            this.lb_DienThoai = new System.Windows.Forms.Label();
            this.lb_DiaChi = new System.Windows.Forms.Label();
            this.lb_NgaySinh = new System.Windows.Forms.Label();
            this.lb_GioiTinh = new System.Windows.Forms.Label();
            this.lb_HoTen = new System.Windows.Forms.Label();
            this.lb_ThongTinBenhNhan = new System.Windows.Forms.Label();
            this.dgv_ThongTinBenhNhan = new System.Windows.Forms.DataGridView();
            this.lb_MaBenhNhan = new System.Windows.Forms.Label();
            this.txb_MaBN = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.rdb_Nam = new System.Windows.Forms.RadioButton();
            this.rdb_Nu = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongTinBenhNhan)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_NgaySinh
            // 
            this.dtp_NgaySinh.CustomFormat = "dd/mm/yyyy";
            this.dtp_NgaySinh.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgaySinh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtp_NgaySinh.Location = new System.Drawing.Point(210, 161);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.Size = new System.Drawing.Size(181, 23);
            this.dtp_NgaySinh.TabIndex = 6;
            // 
            // button_Xoa
            // 
            this.button_Xoa.BackColor = System.Drawing.Color.Red;
            this.button_Xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Xoa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Xoa.FlatAppearance.BorderSize = 0;
            this.button_Xoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button_Xoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.button_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Xoa.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Xoa.ForeColor = System.Drawing.Color.White;
            this.button_Xoa.Location = new System.Drawing.Point(663, 199);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(89, 47);
            this.button_Xoa.TabIndex = 5;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = false;
            this.button_Xoa.Click += new System.EventHandler(this.button1_Click);
            this.button_Xoa.MouseEnter += new System.EventHandler(this.button_Xoa_MouseEnter);
            this.button_Xoa.MouseLeave += new System.EventHandler(this.button_Xoa_MouseLeave);
            // 
            // button_Them
            // 
            this.button_Them.BackColor = System.Drawing.Color.PaleGreen;
            this.button_Them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Them.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Them.FlatAppearance.BorderSize = 0;
            this.button_Them.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_Them.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.button_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Them.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Them.ForeColor = System.Drawing.Color.Black;
            this.button_Them.Location = new System.Drawing.Point(546, 199);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(89, 47);
            this.button_Them.TabIndex = 5;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = false;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.PaleGreen;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(546, 275);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 47);
            this.button5.TabIndex = 5;
            this.button5.Text = "Sửa";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txb_DienThoai
            // 
            this.txb_DienThoai.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_DienThoai.Location = new System.Drawing.Point(571, 103);
            this.txb_DienThoai.Name = "txb_DienThoai";
            this.txb_DienThoai.Size = new System.Drawing.Size(181, 23);
            this.txb_DienThoai.TabIndex = 4;
            // 
            // txb_DiaChi
            // 
            this.txb_DiaChi.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_DiaChi.Location = new System.Drawing.Point(571, 158);
            this.txb_DiaChi.Name = "txb_DiaChi";
            this.txb_DiaChi.Size = new System.Drawing.Size(181, 23);
            this.txb_DiaChi.TabIndex = 3;
            // 
            // txb_HoTen
            // 
            this.txb_HoTen.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_HoTen.Location = new System.Drawing.Point(210, 108);
            this.txb_HoTen.Name = "txb_HoTen";
            this.txb_HoTen.Size = new System.Drawing.Size(181, 23);
            this.txb_HoTen.TabIndex = 1;
            // 
            // lb_DienThoai
            // 
            this.lb_DienThoai.AutoSize = true;
            this.lb_DienThoai.BackColor = System.Drawing.Color.Transparent;
            this.lb_DienThoai.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DienThoai.ForeColor = System.Drawing.Color.Black;
            this.lb_DienThoai.Location = new System.Drawing.Point(422, 110);
            this.lb_DienThoai.Name = "lb_DienThoai";
            this.lb_DienThoai.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_DienThoai.Size = new System.Drawing.Size(76, 16);
            this.lb_DienThoai.TabIndex = 0;
            this.lb_DienThoai.Text = "Điện Thoại";
            // 
            // lb_DiaChi
            // 
            this.lb_DiaChi.AutoSize = true;
            this.lb_DiaChi.BackColor = System.Drawing.Color.Transparent;
            this.lb_DiaChi.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DiaChi.ForeColor = System.Drawing.Color.Black;
            this.lb_DiaChi.Location = new System.Drawing.Point(422, 161);
            this.lb_DiaChi.Name = "lb_DiaChi";
            this.lb_DiaChi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_DiaChi.Size = new System.Drawing.Size(52, 16);
            this.lb_DiaChi.TabIndex = 0;
            this.lb_DiaChi.Text = "Địa Chỉ";
            // 
            // lb_NgaySinh
            // 
            this.lb_NgaySinh.AutoSize = true;
            this.lb_NgaySinh.BackColor = System.Drawing.Color.Transparent;
            this.lb_NgaySinh.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NgaySinh.ForeColor = System.Drawing.Color.Black;
            this.lb_NgaySinh.Location = new System.Drawing.Point(41, 161);
            this.lb_NgaySinh.Name = "lb_NgaySinh";
            this.lb_NgaySinh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_NgaySinh.Size = new System.Drawing.Size(69, 16);
            this.lb_NgaySinh.TabIndex = 0;
            this.lb_NgaySinh.Text = "Ngày Sinh";
            // 
            // lb_GioiTinh
            // 
            this.lb_GioiTinh.AutoSize = true;
            this.lb_GioiTinh.BackColor = System.Drawing.Color.Transparent;
            this.lb_GioiTinh.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_GioiTinh.ForeColor = System.Drawing.Color.Black;
            this.lb_GioiTinh.Location = new System.Drawing.Point(422, 60);
            this.lb_GioiTinh.Name = "lb_GioiTinh";
            this.lb_GioiTinh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_GioiTinh.Size = new System.Drawing.Size(66, 16);
            this.lb_GioiTinh.TabIndex = 0;
            this.lb_GioiTinh.Text = "Giới Tính";
            // 
            // lb_HoTen
            // 
            this.lb_HoTen.AutoSize = true;
            this.lb_HoTen.BackColor = System.Drawing.Color.Transparent;
            this.lb_HoTen.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_HoTen.ForeColor = System.Drawing.Color.Black;
            this.lb_HoTen.Location = new System.Drawing.Point(41, 110);
            this.lb_HoTen.Name = "lb_HoTen";
            this.lb_HoTen.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_HoTen.Size = new System.Drawing.Size(71, 16);
            this.lb_HoTen.TabIndex = 0;
            this.lb_HoTen.Text = "Họ Và Tên";
            // 
            // lb_ThongTinBenhNhan
            // 
            this.lb_ThongTinBenhNhan.BackColor = System.Drawing.Color.Transparent;
            this.lb_ThongTinBenhNhan.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ThongTinBenhNhan.ForeColor = System.Drawing.Color.SteelBlue;
            this.lb_ThongTinBenhNhan.Location = new System.Drawing.Point(-2, 0);
            this.lb_ThongTinBenhNhan.Name = "lb_ThongTinBenhNhan";
            this.lb_ThongTinBenhNhan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_ThongTinBenhNhan.Size = new System.Drawing.Size(773, 38);
            this.lb_ThongTinBenhNhan.TabIndex = 0;
            this.lb_ThongTinBenhNhan.Text = " Thông Tin Bệnh Nhân";
            this.lb_ThongTinBenhNhan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_ThongTinBenhNhan
            // 
            this.dgv_ThongTinBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThongTinBenhNhan.Location = new System.Drawing.Point(9, 200);
            this.dgv_ThongTinBenhNhan.Name = "dgv_ThongTinBenhNhan";
            this.dgv_ThongTinBenhNhan.ReadOnly = true;
            this.dgv_ThongTinBenhNhan.RowHeadersWidth = 62;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_ThongTinBenhNhan.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ThongTinBenhNhan.Size = new System.Drawing.Size(524, 200);
            this.dgv_ThongTinBenhNhan.TabIndex = 4;
            this.dgv_ThongTinBenhNhan.Click += new System.EventHandler(this.dgv_ThongTinBenhNhan_Click);
            // 
            // lb_MaBenhNhan
            // 
            this.lb_MaBenhNhan.AutoSize = true;
            this.lb_MaBenhNhan.BackColor = System.Drawing.Color.Transparent;
            this.lb_MaBenhNhan.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaBenhNhan.ForeColor = System.Drawing.Color.Black;
            this.lb_MaBenhNhan.Location = new System.Drawing.Point(41, 58);
            this.lb_MaBenhNhan.Name = "lb_MaBenhNhan";
            this.lb_MaBenhNhan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_MaBenhNhan.Size = new System.Drawing.Size(98, 16);
            this.lb_MaBenhNhan.TabIndex = 0;
            this.lb_MaBenhNhan.Text = "Mã Bệnh Nhân";
            // 
            // txb_MaBN
            // 
            this.txb_MaBN.BackColor = System.Drawing.Color.LightYellow;
            this.txb_MaBN.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_MaBN.Location = new System.Drawing.Point(210, 56);
            this.txb_MaBN.Name = "txb_MaBN";
            this.txb_MaBN.ReadOnly = true;
            this.txb_MaBN.Size = new System.Drawing.Size(181, 23);
            this.txb_MaBN.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.PaleGreen;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(546, 352);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(209, 47);
            this.button4.TabIndex = 5;
            this.button4.Text = "Lập Phiếu Khám Bệnh";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.IndianRed;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(663, 275);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 47);
            this.button6.TabIndex = 5;
            this.button6.Text = "Thoát";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            this.button6.MouseEnter += new System.EventHandler(this.button_Xoa_MouseEnter);
            this.button6.MouseLeave += new System.EventHandler(this.button_Xoa_MouseLeave);
            // 
            // rdb_Nam
            // 
            this.rdb_Nam.AutoSize = true;
            this.rdb_Nam.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Nam.Location = new System.Drawing.Point(575, 60);
            this.rdb_Nam.Name = "rdb_Nam";
            this.rdb_Nam.Size = new System.Drawing.Size(55, 20);
            this.rdb_Nam.TabIndex = 7;
            this.rdb_Nam.TabStop = true;
            this.rdb_Nam.Text = "Nam";
            this.rdb_Nam.UseVisualStyleBackColor = true;
            // 
            // rdb_Nu
            // 
            this.rdb_Nu.AutoSize = true;
            this.rdb_Nu.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Nu.Location = new System.Drawing.Point(706, 60);
            this.rdb_Nu.Name = "rdb_Nu";
            this.rdb_Nu.Size = new System.Drawing.Size(46, 20);
            this.rdb_Nu.TabIndex = 8;
            this.rdb_Nu.TabStop = true;
            this.rdb_Nu.Text = "Nữ";
            this.rdb_Nu.UseVisualStyleBackColor = true;
            // 
            // ThemThongTinBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(769, 424);
            this.Controls.Add(this.rdb_Nu);
            this.Controls.Add(this.rdb_Nam);
            this.Controls.Add(this.button_Xoa);
            this.Controls.Add(this.dtp_NgaySinh);
            this.Controls.Add(this.button_Them);
            this.Controls.Add(this.dgv_ThongTinBenhNhan);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.lb_DienThoai);
            this.Controls.Add(this.txb_DienThoai);
            this.Controls.Add(this.lb_ThongTinBenhNhan);
            this.Controls.Add(this.txb_DiaChi);
            this.Controls.Add(this.lb_DiaChi);
            this.Controls.Add(this.lb_MaBenhNhan);
            this.Controls.Add(this.txb_MaBN);
            this.Controls.Add(this.txb_HoTen);
            this.Controls.Add(this.lb_NgaySinh);
            this.Controls.Add(this.lb_HoTen);
            this.Controls.Add(this.lb_GioiTinh);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThemThongTinBenhNhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemThongTinBenhNhan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ThemThongTinBenhNhan_FormClosing);
            this.Load += new System.EventHandler(this.ThemThongTinBenhNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongTinBenhNhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txb_DienThoai;
        private System.Windows.Forms.TextBox txb_DiaChi;
        private System.Windows.Forms.TextBox txb_HoTen;
        private System.Windows.Forms.Label lb_DienThoai;
        private System.Windows.Forms.Label lb_DiaChi;
        private System.Windows.Forms.Label lb_NgaySinh;
        private System.Windows.Forms.Label lb_GioiTinh;
        private System.Windows.Forms.Label lb_HoTen;
        private System.Windows.Forms.Label lb_ThongTinBenhNhan;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.DataGridView dgv_ThongTinBenhNhan;
        private System.Windows.Forms.DateTimePicker dtp_NgaySinh;
        private System.Windows.Forms.TextBox txb_MaBN;
        private System.Windows.Forms.Label lb_MaBenhNhan;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.RadioButton rdb_Nam;
        private System.Windows.Forms.RadioButton rdb_Nu;
    }
}