using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO { // Define namespace
    public class KeToaThuoc_DTO { // class KeToaThuoc_DTO belongs to namespace DTO
        private string tenThuoc;
        private int soLuong;
        private string donViTinh;
        private string cachDung;
    
        // tenThuoc getter + setter
        public string TenThuoc {
            get {
                return tenThuoc;
            }
            set {
                tenThuoc = value;
            }
        }
    
        // soLuong getter + setter
        public string SoLuong {
            get {
                return soLuong;
            }
            set {
                tenThuoc = value;
            }
        }

        // donViTinh getter + setter
        public string DonViTinh {
            get {
                return DonViTinh;
            }
            set {
                tenThuoc = value;
            }
        }

        // cachDung getter + setter
        public string CachDung {
            get {
                return cachDung;
            }
            set {
                cachDung = value;
            }
        }
    }
}

// namespace DTO
// {
//   public  class KeToaThuoc_DTO
//     {
//         private string tenThuoc;
//         private int soLuong;
//         private string donViTinh;
//         private string cachDung;
//         public string TenThuoc
//         {
//             get
//             {
//                 return tenThuoc;
//             }

//             set
//             {
//                 tenThuoc = value;
//             }
//         }

       

//         public string DonViTinh
//         {
//             get
//             {
//                 return donViTinh;
//             }

//             set
//             {
//                 donViTinh = value;
//             }
//         }

//         public string CachDung
//         {
//             get
//             {
//                 return cachDung;
//             }

//             set
//             {
//                 cachDung = value;
//             }
//         }

//         public int SoLuong
//         {
//             get
//             {
//                 return soLuong;
//             }

//             set
//             {
//                 soLuong = value;
//             }
//         }
//     }
// }
