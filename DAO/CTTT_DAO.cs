using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class CTTT_DAO
    {
        //static SqlConnection Con;

        //public static List<CTTT> LoadCTTT()
        //{
        //    // khai bao truy van sql
        //    string sTruyVan = "select * from CTTT";
        //    // Mo ket noi
        //    Con = DataProvider_1.KetNoi();
        //    // Tien hanh truy van
        //    DataTable dt = DataProvider_1.LayDataTable(sTruyVan, Con);
        //    if (dt.Rows.Count == 0)
        //    {
        //        return null;
        //    }
        //    // tao List PHIEUKHAM_DTO
        //    List<CTTT> listb = new List<CTTT>();
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {

        //        CTTT b = new CTTT();
        //        b.MaPK1 = int.Parse(dt.Rows[i]["MaPK"].ToString());
        //        b.MaThuoc1 = int.Parse(dt.Rows[i]["MaThuoc"].ToString());
        //        b.SoLuong1 = int.Parse(dt.Rows[i]["SoLuong"].ToString());
        //        b.DonGia1 = float.Parse(dt.Rows[i]["DonGia"].ToString());
        //        b.CachDung1 = dt.Rows[i]["CachDung"].ToString();
               
        //        listb.Add(b);
        //    }
        //    DataProvider_1.DongKetNoi(Con);
        //    return listb;
        //}

        public static List<CTTT> LoadCTTT()
        {
            string query = "select * from CTTT";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if (dt.Rows.Count == 0)
                return null;
            List<CTTT> listb = new List<CTTT>();
            foreach(DataRow row in dt.Rows)
            {
                CTTT b = new CTTT();
                b.MaPK1 = Convert.ToInt32(row["MaPK"]);
                b.MaThuoc1 = Convert.ToInt32(row["MaThuoc"]);
                b.SoLuong1 = Convert.ToInt32(row["SoLuong"]);
                b.DonGia1 = float.Parse(row["DonGia"].ToString());
                b.CachDung1 = row["CachDung"].ToString();
                listb.Add(b);
            }
            return listb;
        }


        // xoa benh nhan
        //public static bool XoaCTTT(CTTT CTTTDTO)
        //{


        //    String sTruyVan = string.Format("delete from CTTT where MaBN ='{0}'", CTTTDTO.MaPK1);
        //    Con = DataProvider_1.KetNoi();
        //    try
        //    {
        //        // thuc thi truy van
        //        DataProvider_1.ThucThiTruyVanNonQuery(sTruyVan, Con);
        //        // dong truy van
        //        DataProvider_1.DongKetNoi(Con);
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.StackTrace);
        //        DataProvider_1.DongKetNoi(Con);
        //        return false;
        //    }
        //}

        public static bool XoaCTTT(CTTT CTTTDTO)
        {
            string query = string.Format("delete from CTTT where MaBN ='{0}'", CTTTDTO.MaPK1);
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
