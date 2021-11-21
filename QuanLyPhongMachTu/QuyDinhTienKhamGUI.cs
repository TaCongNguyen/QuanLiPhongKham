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

namespace QuyDinhPhongMachTu { // Define namespace QuyDinhPhongMachTu
    public partial class QuyDinhTienKhamGUI : Form { // class QuyDinhTienKhamGUI belongs to namespace QuyDinhPhongMachTu
        public QuyDinhTienKhamGUI() {
            InitialComponent();
        }
        
        private void QuyDinhTienKhamGUI_Load(object sender, EventArgs e) { // When component load, get gia cu
            HienThiGiaCu();
        }

        void HienThiGiaCu() {
            txb_GiaCu.Text = QuyDinhTienKhamBUS.LayGiaCu().toString(); // Interact with QuyDinhTienKhamBUS and get gia cu
        }

        private void button_Sua_Click(object sender, EventArgs e) { // When user click on button_Sua
            float TienKham = float.Parse(txb_GiaMoi.Text); // Get new TienKham from txb_GiaMoi
            if (QuyDinhTienKhamBUS.Sua(TienKham) == true) { // Check if QuyDinhTienKhamBUS.Sua() return true means update successfull
                MessageBox.Show("Cập nhật tiền khám thành công !", "Thông báo", MessageBoxButton.OK);
            } else MessageBox.Show("Cập nhật không thành công !","Thông báo",MessageBoxButton.OK);
        }

        private void button_Thoat_Click(object sender, EventArgs e) {
            DialogResult dlr = MessageBox.Show("Bạn có thật sự muốn thoát không","Thông báo",MessageBoxButton.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes) {
                Form_Chinh x = new Form_Chinh();
                this.Hide();
                x.ShowDialog();
            }
        }

        public void txb_GiaMoi_TextChanged(object sender, EventArgs e) { // When user type in txb_GiaMoi, get that value
            
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
    }
}

// namespace QuanLyPhongMachTu
// {
//     public partial class QuyDinhTienKhamGUI : Form
//     {
//         public QuyDinhTienKhamGUI()
//         {
//             InitializeComponent();
//         }

//         private void QuyDinhTienKhamGUI_Load(object sender, EventArgs e)
//         {
//             HienThiGiaCu();
//         }

//         void HienThiGiaCu()
//         {
//             txb_GiaCu.Text = QuyDinhTienKhamBUS.LayGiaCu().ToString();
//         }

//         private void button_Sua_Click(object sender, EventArgs e)
//         {
//             float TienKham = float.Parse(txb_GiaMoi.Text);
//             if (QuyDinhTienKhamBUS.Sua(TienKham) == true)
//             {
//                 MessageBox.Show("Cập nhật tiền khám thành công!", "Thông Báo", MessageBoxButtons.OK);

//             }
//             else
//                 MessageBox.Show("Cập nhật tiền khám không thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
//         }

//         private void button_Thoat_Click(object sender, EventArgs e)
//         {
//             DialogResult dlr = MessageBox.Show("Bạn có thực sự muốn thoát không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

//             if (dlr == DialogResult.Yes)
//             {
//                 //Form_Chinh x = new Form_Chinh();

//                 this.Hide();

//                 //x.ShowDialog();
//             }
//         }

//         private void QuyDinhTienKhamGUI_FormClosing(object sender, FormClosingEventArgs e)
//         {
//             this.Hide();
//             Form_Chinh f = new Form_Chinh();
//             f.ShowDialog();
//         }

//         private void label2_Click(object sender, EventArgs e)
//         {

//         }

//         private void txb_GiaCu_TextChanged(object sender, EventArgs e)
//         {

//         }
//     }
// }
