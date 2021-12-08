namespace QuanLyPhongMachTu
{
    partial class QuyDinhTienKhamGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuyDinhTienKhamGUI));
            this.label1 = new System.Windows.Forms.Label();
            this.txb_GiaCu = new System.Windows.Forms.TextBox();
            this.txb_GiaMoi = new System.Windows.Forms.TextBox();
            this.button_Thoat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Sua = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thay Đổi Tiền Khám Bệnh";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txb_GiaCu
            // 
            this.txb_GiaCu.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_GiaCu.Location = new System.Drawing.Point(100, 84);
            this.txb_GiaCu.Name = "txb_GiaCu";
            this.txb_GiaCu.Size = new System.Drawing.Size(307, 26);
            this.txb_GiaCu.TabIndex = 1;
            this.txb_GiaCu.TextChanged += new System.EventHandler(this.txb_GiaCu_TextChanged);
            // 
            // txb_GiaMoi
            // 
            this.txb_GiaMoi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_GiaMoi.Location = new System.Drawing.Point(100, 164);
            this.txb_GiaMoi.Name = "txb_GiaMoi";
            this.txb_GiaMoi.Size = new System.Drawing.Size(307, 26);
            this.txb_GiaMoi.TabIndex = 1;
            this.txb_GiaMoi.TextChanged += new System.EventHandler(this.txb_GiaMoi_TextChanged);
            // 
            // button_Thoat
            // 
            this.button_Thoat.BackColor = System.Drawing.Color.IndianRed;
            this.button_Thoat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Thoat.FlatAppearance.BorderSize = 0;
            this.button_Thoat.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.button_Thoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_Thoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink;
            this.button_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Thoat.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Thoat.ForeColor = System.Drawing.Color.White;
            this.button_Thoat.Location = new System.Drawing.Point(228, 228);
            this.button_Thoat.Name = "button_Thoat";
            this.button_Thoat.Size = new System.Drawing.Size(75, 37);
            this.button_Thoat.TabIndex = 2;
            this.button_Thoat.Text = "Thoát";
            this.button_Thoat.UseVisualStyleBackColor = false;
            this.button_Thoat.Click += new System.EventHandler(this.button_Thoat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Giá Cũ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button_Sua
            // 
            this.button_Sua.BackColor = System.Drawing.Color.PaleGreen;
            this.button_Sua.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Sua.FlatAppearance.BorderSize = 0;
            this.button_Sua.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.button_Sua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_Sua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink;
            this.button_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Sua.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Sua.ForeColor = System.Drawing.Color.Black;
            this.button_Sua.Location = new System.Drawing.Point(134, 228);
            this.button_Sua.Name = "button_Sua";
            this.button_Sua.Size = new System.Drawing.Size(75, 37);
            this.button_Sua.TabIndex = 2;
            this.button_Sua.Text = "Sửa";
            this.button_Sua.UseVisualStyleBackColor = false;
            this.button_Sua.Click += new System.EventHandler(this.button_Sua_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giá Mới";
            // 
            // QuyDinhTienKhamGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 286);
            this.Controls.Add(this.button_Sua);
            this.Controls.Add(this.button_Thoat);
            this.Controls.Add(this.txb_GiaMoi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_GiaCu);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuyDinhTienKhamGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuyDinhTienKham";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuyDinhTienKhamGUI_FormClosing);
            this.Load += new System.EventHandler(this.QuyDinhTienKhamGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_GiaCu;
        private System.Windows.Forms.TextBox txb_GiaMoi;
        private System.Windows.Forms.Button button_Thoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Sua;
        private System.Windows.Forms.Label label3;
    }
}