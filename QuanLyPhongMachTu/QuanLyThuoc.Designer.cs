namespace QuanLyPhongMachTu
{
    partial class QuanLyThuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyThuoc));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbb_DVT = new System.Windows.Forms.ComboBox();
            this.txb_Gia = new System.Windows.Forms.TextBox();
            this.txb_TenThuoc = new System.Windows.Forms.TextBox();
            this.lb_Gia = new System.Windows.Forms.Label();
            this.lb_DonViTinh = new System.Windows.Forms.Label();
            this.lb_TenThuoc = new System.Windows.Forms.Label();
            this.lb_QuanLyThuoc = new System.Windows.Forms.Label();
            this.button_Sua = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_Thuoc = new System.Windows.Forms.DataGridView();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_Them = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Thuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbb_DVT);
            this.panel1.Controls.Add(this.txb_Gia);
            this.panel1.Controls.Add(this.txb_TenThuoc);
            this.panel1.Controls.Add(this.lb_Gia);
            this.panel1.Controls.Add(this.lb_DonViTinh);
            this.panel1.Controls.Add(this.lb_TenThuoc);
            this.panel1.Location = new System.Drawing.Point(30, 78);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 302);
            this.panel1.TabIndex = 0;
            // 
            // cbb_DVT
            // 
            this.cbb_DVT.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_DVT.FormattingEnabled = true;
            this.cbb_DVT.Items.AddRange(new object[] {
            "Viên",
            "Hộp",
            "Vỉ",
            "Chai"});
            this.cbb_DVT.Location = new System.Drawing.Point(196, 115);
            this.cbb_DVT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbb_DVT.Name = "cbb_DVT";
            this.cbb_DVT.Size = new System.Drawing.Size(180, 27);
            this.cbb_DVT.TabIndex = 2;
            this.cbb_DVT.Text = "Viên";
            // 
            // txb_Gia
            // 
            this.txb_Gia.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Gia.Location = new System.Drawing.Point(196, 188);
            this.txb_Gia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_Gia.Name = "txb_Gia";
            this.txb_Gia.Size = new System.Drawing.Size(180, 26);
            this.txb_Gia.TabIndex = 0;
            // 
            // txb_TenThuoc
            // 
            this.txb_TenThuoc.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_TenThuoc.Location = new System.Drawing.Point(196, 32);
            this.txb_TenThuoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_TenThuoc.Name = "txb_TenThuoc";
            this.txb_TenThuoc.Size = new System.Drawing.Size(180, 26);
            this.txb_TenThuoc.TabIndex = 0;
            // 
            // lb_Gia
            // 
            this.lb_Gia.AutoSize = true;
            this.lb_Gia.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Gia.Location = new System.Drawing.Point(21, 185);
            this.lb_Gia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Gia.Name = "lb_Gia";
            this.lb_Gia.Size = new System.Drawing.Size(49, 28);
            this.lb_Gia.TabIndex = 1;
            this.lb_Gia.Text = "Giá";
            // 
            // lb_DonViTinh
            // 
            this.lb_DonViTinh.AutoSize = true;
            this.lb_DonViTinh.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DonViTinh.Location = new System.Drawing.Point(21, 109);
            this.lb_DonViTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_DonViTinh.Name = "lb_DonViTinh";
            this.lb_DonViTinh.Size = new System.Drawing.Size(143, 28);
            this.lb_DonViTinh.TabIndex = 1;
            this.lb_DonViTinh.Text = "Đơn Vị Tính";
            // 
            // lb_TenThuoc
            // 
            this.lb_TenThuoc.AutoSize = true;
            this.lb_TenThuoc.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenThuoc.Location = new System.Drawing.Point(21, 29);
            this.lb_TenThuoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_TenThuoc.Name = "lb_TenThuoc";
            this.lb_TenThuoc.Size = new System.Drawing.Size(126, 28);
            this.lb_TenThuoc.TabIndex = 1;
            this.lb_TenThuoc.Text = "Tên Thuốc";
            // 
            // lb_QuanLyThuoc
            // 
            this.lb_QuanLyThuoc.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_QuanLyThuoc.ForeColor = System.Drawing.Color.SteelBlue;
            this.lb_QuanLyThuoc.Location = new System.Drawing.Point(0, 0);
            this.lb_QuanLyThuoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_QuanLyThuoc.Name = "lb_QuanLyThuoc";
            this.lb_QuanLyThuoc.Size = new System.Drawing.Size(1280, 74);
            this.lb_QuanLyThuoc.TabIndex = 1;
            this.lb_QuanLyThuoc.Text = "Quản Lý Thuốc";
            this.lb_QuanLyThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Sua
            // 
            this.button_Sua.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_Sua.BackColor = System.Drawing.Color.PaleGreen;
            this.button_Sua.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Sua.FlatAppearance.BorderSize = 0;
            this.button_Sua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_Sua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.button_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Sua.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Sua.Location = new System.Drawing.Point(660, 408);
            this.button_Sua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Sua.Name = "button_Sua";
            this.button_Sua.Size = new System.Drawing.Size(118, 43);
            this.button_Sua.TabIndex = 2;
            this.button_Sua.Text = "Sửa";
            this.button_Sua.UseVisualStyleBackColor = false;
            this.button_Sua.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(471, 78);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(808, 302);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dgv_Thuoc
            // 
            this.dgv_Thuoc.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgv_Thuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Thuoc.Location = new System.Drawing.Point(494, 95);
            this.dgv_Thuoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_Thuoc.Name = "dgv_Thuoc";
            this.dgv_Thuoc.RowHeadersWidth = 62;
            this.dgv_Thuoc.Size = new System.Drawing.Size(748, 268);
            this.dgv_Thuoc.TabIndex = 0;
            this.dgv_Thuoc.Click += new System.EventHandler(this.dgv_Thuoc_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_Xoa.BackColor = System.Drawing.Color.Red;
            this.button_Xoa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Xoa.FlatAppearance.BorderSize = 0;
            this.button_Xoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_Xoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.button_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Xoa.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Xoa.ForeColor = System.Drawing.Color.White;
            this.button_Xoa.Location = new System.Drawing.Point(824, 408);
            this.button_Xoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(118, 43);
            this.button_Xoa.TabIndex = 2;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = false;
            this.button_Xoa.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_Them
            // 
            this.button_Them.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_Them.BackColor = System.Drawing.Color.PaleGreen;
            this.button_Them.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Them.FlatAppearance.BorderSize = 0;
            this.button_Them.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_Them.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.button_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Them.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Them.Location = new System.Drawing.Point(494, 408);
            this.button_Them.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(118, 43);
            this.button_Them.TabIndex = 2;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = false;
            this.button_Them.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel3
            // 
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(32, 389);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(90, 92);
            this.panel3.TabIndex = 4;
            // 
            // button5
            // 
            this.button5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button5.BackColor = System.Drawing.Color.IndianRed;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(1124, 408);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 43);
            this.button5.TabIndex = 6;
            this.button5.Text = "Thoát";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // QuanLyThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 483);
            this.Controls.Add(this.dgv_Thuoc);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button_Xoa);
            this.Controls.Add(this.button_Them);
            this.Controls.Add(this.button_Sua);
            this.Controls.Add(this.lb_QuanLyThuoc);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "QuanLyThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyThuoc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuanLyThuoc_FormClosing);
            this.Load += new System.EventHandler(this.QuanLyThuoc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Thuoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txb_Gia;
        private System.Windows.Forms.TextBox txb_TenThuoc;
        private System.Windows.Forms.Label lb_Gia;
        private System.Windows.Forms.Label lb_DonViTinh;
        private System.Windows.Forms.Label lb_TenThuoc;
        private System.Windows.Forms.Label lb_QuanLyThuoc;
        private System.Windows.Forms.Button button_Sua;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_Thuoc;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.ComboBox cbb_DVT;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button5;
    }
}