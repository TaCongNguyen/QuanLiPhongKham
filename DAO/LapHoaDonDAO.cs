using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class LapHoaDonDAO
    {
        //private string connectionString;
        public LapHoaDonDAO()
        {
            //connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        //public string ConnectionString
        //{
        //    get
        //    {
        //        return connectionString;
        //    }
        //    set
        //    {
        //        connectionString = value;
        //    }
        //}


        //load du lieu
        //public List<LapHoaDonDTO> loadMaPK()
        //{
        //    string query = "select top 20 MaPK from PHIEUKHAM where TrangThai='1' order by NgayKham desc";
        //    List<LapHoaDonDTO> lstMaPK = new List<LapHoaDonDTO>();

        //    SqlConnection connection = new SqlConnection(connectionString);
        //    connection.Open();

        //    DataTable dt = DataProvider.LoadTable(query, connection);
        //    if (dt.Rows.Count == 0)
        //    {
        //        return null;
        //    }
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        LapHoaDonDTO dto = new LapHoaDonDTO();
        //        dto.Mapk = int.Parse(dt.Rows[i]["MaPK"].ToString());
        //        lstMaPK.Add(dto);
        //    }
        //    connection.Close();

        //    return lstMaPK;
        //}

        public List<LapHoaDonDTO> loadMaPK()
        {
            string query = "select top 20 MaPK from PHIEUKHAM where TrangThai='1' order by NgayKham desc";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if (dt.Rows.Count == 0)
                return null;
            List<LapHoaDonDTO> lstMaPK = new List<LapHoaDonDTO>();
            foreach (DataRow row in dt.Rows)
            {
                LapHoaDonDTO dto = new LapHoaDonDTO();
                dto.Mapk = int.Parse(row["MaPK"].ToString());
                lstMaPK.Add(dto);
            }
            return lstMaPK;
        }

        //public LapHoaDonDTO loadThongTin(LapHoaDonDTO a)
        //{

        //    string query = "select TenBN from BENHNHAN, PHIEUKHAM where BENHNHAN.MaBN = PHIEUKHAM.MaBN and MaPK='" + a.Mapk + "'and BENHNHAN.TrangThai='1'";
        //    LapHoaDonDTO ThongTinDto = new LapHoaDonDTO();
        //    SqlConnection connection = new SqlConnection(connectionString);

        //    connection.Open();

        //    DataTable dt = DataProvider.LoadTable(query, connection);

        //    if (dt.Rows.Count == 1)
        //    {
        //        ThongTinDto.Tenbn = dt.Rows[0]["TenBN"].ToString();
        //        connection.Close();
        //        return ThongTinDto;
        //    }
        //    connection.Close();
        //    return null;
        //}

        public LapHoaDonDTO loadThongTin(LapHoaDonDTO a)
        {
            string query = "select TenBN from BENHNHAN, PHIEUKHAM where BENHNHAN.MaBN = PHIEUKHAM.MaBN and MaPK='" + a.Mapk + "'and BENHNHAN.TrangThai='1'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            
            if (dt.Rows.Count == 1)
            {
                LapHoaDonDTO ThongTinDto = new LapHoaDonDTO();
                ThongTinDto.Tenbn = dt.Rows[0]["TenBN"].ToString();
                return ThongTinDto;
            }
           


            return null;
        }

        //public List<LapHoaDonDTO> loadCTTT(LapHoaDonDTO a)
        //{
        //    string query = "select CTTT.TenThuoc, CTTT.SoLuong, THUOC.DonViTinh, CTTT.DonGia from CTTT, THUOC  where CTTT.TenThuoc = THUOC.TenThuoc and CTTT.MaPK = '" + a.Mapk + "'and THUOC.TrangThai='1'";

        //    List<LapHoaDonDTO> lstCTTT = new List<LapHoaDonDTO>();
        //    SqlConnection connection = new SqlConnection(connectionString);

        //    connection.Open();
        //    DataTable dt = DataProvider.LoadTable(query, connection);
        //    if (dt.Rows.Count == 0)
        //    {
        //        return null;
        //    }
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        LapHoaDonDTO ThongTinDto = new LapHoaDonDTO();
        //        ThongTinDto.Tenthuoc = dt.Rows[i]["TenThuoc"].ToString();
        //        ThongTinDto.Soluong = int.Parse(dt.Rows[i]["SoLuong"].ToString());
        //        ThongTinDto.Donvitinh = dt.Rows[i]["DonViTinh"].ToString();
        //        ThongTinDto.Dongia = float.Parse(dt.Rows[i]["DonGia"].ToString());

        //        lstCTTT.Add(ThongTinDto);
        //    }
        //    connection.Close();

        //    return lstCTTT;
        //}

        public List<LapHoaDonDTO> loadCTTT(LapHoaDonDTO a)
        {
            string query = "select CTTT.TenThuoc, CTTT.SoLuong, THUOC.DonViTinh, CTTT.DonGia from CTTT, THUOC  where CTTT.TenThuoc = THUOC.TenThuoc and CTTT.MaPK = '" + a.Mapk + "'and THUOC.TrangThai='1'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if (dt.Rows.Count == 0)
                return null;
            List<LapHoaDonDTO> lstCTTT = new List<LapHoaDonDTO>();
            foreach (DataRow row in dt.Rows)
            {
                LapHoaDonDTO ThongTinDto = new LapHoaDonDTO();
                ThongTinDto.Tenthuoc = row["TenThuoc"].ToString();
                ThongTinDto.Soluong = int.Parse(row["SoLuong"].ToString());
                ThongTinDto.Donvitinh = row["DonViTinh"].ToString();
                ThongTinDto.Dongia = float.Parse(row["DonGia"].ToString());
                lstCTTT.Add(ThongTinDto);
            }
            return lstCTTT;
        }

        //loadHoaDon
        //public List<LapHoaDonDTO> loadHoaDon()
        //{
        //    string query = "SELECT MaHD,MaPK,TienKham,TienThuoc,TongTien FROM dbo.HOADON  where TrangThai='1'";

        //    List<LapHoaDonDTO> lstHoaDon = new List<LapHoaDonDTO>();
        //    SqlConnection connection = new SqlConnection(connectionString);

        //    connection.Open();
        //    DataTable dt = DataProvider.LoadTable(query, connection);
        //    if (dt.Rows.Count == 0)
        //    {
        //        return null;
        //    }
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        LapHoaDonDTO ThongTinDto = new LapHoaDonDTO();
        //        ThongTinDto.Mahd = int.Parse(dt.Rows[i]["MaHD"].ToString());
        //        ThongTinDto.Mapk = int.Parse(dt.Rows[i]["MaPK"].ToString());
        //        ThongTinDto.Chiphikham = float.Parse(dt.Rows[i]["TienKham"].ToString());
        //        ThongTinDto.Chiphithuoc = float.Parse(dt.Rows[i]["TienThuoc"].ToString());
        //        ThongTinDto.Tongtien = float.Parse(dt.Rows[i]["TongTien"].ToString());
        //        lstHoaDon.Add(ThongTinDto);
        //    }
        //    connection.Close();

        //    return lstHoaDon;
        //}
        public List<LapHoaDonDTO> loadHoaDon()
        {
            string query = "SELECT MaHD,MaPK,TienKham,TienThuoc,TongTien FROM dbo.HOADON  where TrangThai='1'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if (dt.Rows.Count == 0)
                return null;
            List<LapHoaDonDTO> lstHoaDon = new List<LapHoaDonDTO>();
            foreach (DataRow row in dt.Rows)
            {
                LapHoaDonDTO ThongTinDto = new LapHoaDonDTO();
                ThongTinDto.Mahd = int.Parse(row["MaHD"].ToString());
                ThongTinDto.Mapk = int.Parse(row["MaPK"].ToString());
                ThongTinDto.Chiphikham = float.Parse(row["TienKham"].ToString());
                ThongTinDto.Chiphithuoc = float.Parse(row["TienThuoc"].ToString());
                ThongTinDto.Tongtien = float.Parse(row["TongTien"].ToString());
                lstHoaDon.Add(ThongTinDto);
            }
            return lstHoaDon;
        }

        //xoa
        //public bool xoa(LapHoaDonDTO a)
        //{

        //    string query = "update HOADON set TrangThai='0' where MaHD='" + a.Mahd + "'";
        //    LapHoaDonDTO ThongTinDto = new LapHoaDonDTO();
        //    SqlConnection connection = new SqlConnection(connectionString);

        //    connection.Open();
        //    if (DataProvider.ThucThiNonQuery(query, connection) == true)
        //    {
        //        connection.Close();
        //        return true;
        //    }
        //    return false;
        //}

        public bool xoa(LapHoaDonDTO a)
        {
            string query = "update HOADON set TrangThai='0' where MaHD='" + a.Mahd + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        //public LapHoaDonDTO KtMaPK(LapHoaDonDTO a)
        //{

        //    string query = "select MaPK from PHIEUKHAM where MaPK='" + a.Mapk + "'and TrangThai='1'";
        //    LapHoaDonDTO ThongTinDto = new LapHoaDonDTO();
        //    SqlConnection connection = new SqlConnection(connectionString);

        //    connection.Open();
        //    DataTable dt = DataProvider.LoadTable(query, connection);

        //    if (dt.Rows.Count == 1)
        //    {
        //        ThongTinDto.Mapk = int.Parse(dt.Rows[0]["MaPK"].ToString());
        //        connection.Close();
        //        return ThongTinDto;
        //    }
        //    connection.Close();
        //    return null;
        //}
        public LapHoaDonDTO KtMaPK(LapHoaDonDTO a)
        {
            string query = "select MaPK from PHIEUKHAM where MaPK='" + a.Mapk + "'and TrangThai='1'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            if (dt.Rows.Count == 1)
            {
                LapHoaDonDTO ThongTinDto = new LapHoaDonDTO();
                ThongTinDto.Mapk = int.Parse(dt.Rows[0]["MaPK"].ToString());
                return ThongTinDto;
            }
            return null;
        }


        //public LapHoaDonDTO TinhTienThuoc(LapHoaDonDTO a)
        //{

        //    string query = "select sum(DonGia) as TienThuoc from CTTT where MaPK='" + a.Mapk + "'and TrangThai='1'";
        //    LapHoaDonDTO ThongTinDto = new LapHoaDonDTO();
        //    SqlConnection connection = new SqlConnection(connectionString);

        //    connection.Open();
        //    DataTable dt = DataProvider.LoadTable(query, connection);

        //    if (dt.Rows.Count == 1)
        //    {
        //        ThongTinDto.Chiphithuoc = float.Parse(dt.Rows[0]["TienThuoc"].ToString());
        //        connection.Close();
        //        return ThongTinDto;
        //    }
        //    connection.Close();
        //    return null;
        //}

        public LapHoaDonDTO TinhTienThuoc(LapHoaDonDTO a)
        {
            string query = "select sum(DonGia) as TienThuoc from CTTT where MaPK='" + a.Mapk + "'and TrangThai='1'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            if (dt.Rows.Count == 1)
            {
                LapHoaDonDTO ThongTinDto = new LapHoaDonDTO();
                ThongTinDto.Chiphithuoc = float.Parse(dt.Rows[0]["TienThuoc"].ToString());
                return ThongTinDto;
            }
            return null;
        }

        //public bool luu(LapHoaDonDTO a)
        //{

        //    string query = "INSERT INTO HOADON (MaPK, TienKham, TienThuoc, TongTien,TrangThai) VALUES('" + a.Mapk.ToString() + "', " + a.Chiphikham.ToString() + ", " + a.Chiphithuoc.ToString() + ", " + a.Tongtien.ToString() + ",'" + '1' + "')";
        //    LapHoaDonDTO ThongTinDto = new LapHoaDonDTO();
        //    SqlConnection connection = new SqlConnection(connectionString);

        //    connection.Open();
        //    if (DataProvider.ThucThiNonQuery(query, connection) == true)
        //    {
        //        connection.Close();
        //        return true;
        //    }
        //    return false;
        //}

        public bool luu(LapHoaDonDTO a)
        {
            string query = "INSERT INTO HOADON (MaPK, TienKham, TienThuoc, TongTien,TrangThai) VALUES('" + a.Mapk.ToString() + "', " + a.Chiphikham.ToString() + ", " + a.Chiphithuoc.ToString() + ", " + a.Tongtien.ToString() + ",'" + '1' + "')";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        //public LapHoaDonDTO LayMaHD()
        //{

        //    string query = "select top 1 MaHD from HOADON where TrangThai='1' order by MaHD desc";
        //    LapHoaDonDTO ThongTinDto = new LapHoaDonDTO();
        //    SqlConnection connection = new SqlConnection(connectionString);

        //    connection.Open();
        //    DataTable dt = DataProvider.LoadTable(query, connection);

        //    if (dt.Rows.Count == 1)
        //    {
        //        ThongTinDto.Mahd = int.Parse(dt.Rows[0]["MaHD"].ToString());
        //        connection.Close();
        //        return ThongTinDto;
        //    }
        //    connection.Close();
        //    return null;
        //}

        public LapHoaDonDTO LayMaHD()
        {
            string query = "select top 1 MaHD from HOADON where TrangThai='1' order by MaHD desc";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if (dt.Rows.Count == 1)
            {
                LapHoaDonDTO ThongTinDto = new LapHoaDonDTO();
                ThongTinDto.Mahd = int.Parse(dt.Rows[0]["MaHD"].ToString());
                return ThongTinDto;
            }
            return null;
        }
    }
}
