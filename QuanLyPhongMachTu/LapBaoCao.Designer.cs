namespace QuanLyPhongMachTu
{
    partial class LapBaoCao
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LapBaoCao));
            this.BAOCAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLKBDataSet = new QuanLyPhongMachTu.QLKBDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BAOCAOTableAdapter = new QuanLyPhongMachTu.QLKBDataSetTableAdapters.BAOCAOTableAdapter();
            this.lblLapBaoCao = new System.Windows.Forms.Label();
            this.lblThang = new System.Windows.Forms.Label();
            this.lblNam = new System.Windows.Forms.Label();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BAOCAOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLKBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // BAOCAOBindingSource
            // 
            this.BAOCAOBindingSource.DataMember = "BAOCAO";
            this.BAOCAOBindingSource.DataSource = this.QLKBDataSet;
            // 
            // QLKBDataSet
            // 
            this.QLKBDataSet.DataSetName = "QLKBDataSet";
            this.QLKBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.BAOCAOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyPhongMachTu.BaoCao.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 88);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(811, 324);
            this.reportViewer1.TabIndex = 0;
            // 
            // BAOCAOTableAdapter
            // 
            this.BAOCAOTableAdapter.ClearBeforeFill = true;
            // 
            // lblLapBaoCao
            // 
            this.lblLapBaoCao.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLapBaoCao.Location = new System.Drawing.Point(1, 0);
            this.lblLapBaoCao.Name = "lblLapBaoCao";
            this.lblLapBaoCao.Size = new System.Drawing.Size(811, 45);
            this.lblLapBaoCao.TabIndex = 1;
            this.lblLapBaoCao.Text = "LẬP BÁO CÁO";
            this.lblLapBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThang.Location = new System.Drawing.Point(26, 58);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(59, 17);
            this.lblThang.TabIndex = 2;
            this.lblThang.Text = "Tháng :";
            this.lblThang.Click += new System.EventHandler(this.lblThang_Click);
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNam.Location = new System.Drawing.Point(231, 58);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(46, 17);
            this.lblNam.TabIndex = 3;
            this.lblNam.Text = "Năm :";
            this.lblNam.Click += new System.EventHandler(this.lblNam_Click);
            // 
            // txtThang
            // 
            this.txtThang.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThang.Location = new System.Drawing.Point(86, 57);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(100, 25);
            this.txtThang.TabIndex = 1;
            this.txtThang.TextChanged += new System.EventHandler(this.txtThang_TextChanged);
            // 
            // txtNam
            // 
            this.txtNam.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNam.Location = new System.Drawing.Point(281, 57);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(101, 25);
            this.txtNam.TabIndex = 2;
            this.txtNam.TextChanged += new System.EventHandler(this.txtNam_TextChanged);
            // 
            // btnNhap
            // 
            this.btnNhap.BackColor = System.Drawing.Color.PaleGreen;
            this.btnNhap.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.btnNhap.FlatAppearance.BorderSize = 0;
            this.btnNhap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhap.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhap.Location = new System.Drawing.Point(576, 48);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(104, 34);
            this.btnNhap.TabIndex = 3;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = false;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.IndianRed;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(347, 418);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(104, 34);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // LapBaoCao
            // 
            this.AcceptButton = this.btnNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(815, 460);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.lblNam);
            this.Controls.Add(this.lblThang);
            this.Controls.Add(this.lblLapBaoCao);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LapBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LapBaoCao";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LapBaoCao_FormClosing);
            this.Load += new System.EventHandler(this.LapBaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BAOCAOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLKBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BAOCAOBindingSource;
        private QLKBDataSet QLKBDataSet;
        private QLKBDataSetTableAdapters.BAOCAOTableAdapter BAOCAOTableAdapter;
        private System.Windows.Forms.Label lblLapBaoCao;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnThoat;
    }
}