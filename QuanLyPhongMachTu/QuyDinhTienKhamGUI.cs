using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using QuanLyPhongKham;

namespace QuanLyPhongMachTu
{
    public partial class QuyDinhTienKhamGUI : Form
    {
        public QuyDinhTienKhamGUI()
        {
            InitializeComponent();
    
        }

        
        private void QuyDinhTienKhamGUI_Load(object sender, EventArgs e)
        {
            HienThiGiaCu();
            if(txb_GiaMoi.Text == "")
            {
                button_Sua.Enabled = false;
            }
        }

        void HienThiGiaCu()
        {
            txb_GiaCu.Text = QuyDinhTienKhamBUS.LayGiaCu().ToString();
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            float TienKham = float.Parse(txb_GiaMoi.Text);
            if (QuyDinhTienKhamBUS.Sua(TienKham) == true)
            {
                MessageBox.Show("Cập nhật tiền khám thành công!", "Thông Báo", MessageBoxButtons.OK);

            }
            else
                MessageBox.Show("Cập nhật tiền khám không thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có thực sự muốn thoát không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlr == DialogResult.Yes)
            {
                Form_Chinh x = new Form_Chinh();

                this.Hide();

                x.ShowDialog();
            }
        }

        private void QuyDinhTienKhamGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Form_Chinh f = new Form_Chinh();
            f.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txb_GiaCu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_GiaMoi_TextChanged(object sender, EventArgs e)
        {
            if (CheckPhoneNumber(txb_GiaMoi.Text))
            {
                button_Sua.Enabled = true;
            }
            else
            {
                button_Sua.Enabled = false;
            }
           
        }
        private bool CheckPhoneNumber(String Numberphone)
        {
            if (Numberphone.Length == 0)
            {
                return false;
            }
            else if (!Int32.TryParse(Numberphone, out int a))
            {
                return false;
            }
          
            return true;
        }
    }
}
