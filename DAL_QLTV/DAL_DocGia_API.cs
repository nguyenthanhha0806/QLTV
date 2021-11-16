using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLTV;
using System.Data;
using System.Data.SqlClient;
namespace DAL_QLTV
{
   public class DAL_DocGia_API:DBConnect
   { 
        public List<TTSachMuon> GetSachTTMuon(string mathe)
        {
            List<TTSachMuon> sachmuon = new List<TTSachMuon>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "TimSach_DocGia";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = _conn;
            cmd.Parameters.Add("@mathe", SqlDbType.Char).Value = mathe;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable sach = new DataTable();
            da.Fill(sach);
            foreach(DataRow dr in sach.Rows)
            {
                TTSachMuon ttsm = new TTSachMuon();
                ttsm.MaSach = dr["MaTaiLieu"].ToString();
                ttsm.TenSach = dr["TenTaiLieu"].ToString();
                ttsm.NgayMuon = (DateTime)dr["NgayMuon"];
                ttsm.HanTra = (DateTime)dr["HanTra"];
                int quahan = int.Parse(dr["Quahan"].ToString());
                if(quahan<0)
                {
                    ttsm.Quahan = 0;
                } 
                else
                {
                    ttsm.Quahan = quahan;
                }    
                
                sachmuon.Add(ttsm);

            }
            return sachmuon;          
        }
        public List<TTSachMuon> GetSach_DangMuon(string mathe)
        {
            List<TTSachMuon> sachmuon = new List<TTSachMuon>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "TimSach_DocGia_DangMuon";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = _conn;
            cmd.Parameters.Add("@mathe", SqlDbType.Char).Value = mathe;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable sach = new DataTable();
            da.Fill(sach);
            foreach (DataRow dr in sach.Rows)
            {
                TTSachMuon ttsm = new TTSachMuon();
                ttsm.MaSach = dr["MaTaiLieu"].ToString();
                ttsm.TenSach = dr["TenTaiLieu"].ToString();
                ttsm.NgayMuon = (DateTime)dr["NgayMuon"];
                ttsm.HanTra = (DateTime)dr["HanTra"];
                int quahan = int.Parse(dr["Quahan"].ToString());
                if (quahan < 0)
                {
                    ttsm.Quahan = 0;
                }
                else
                {
                    ttsm.Quahan = quahan;
                }

                sachmuon.Add(ttsm);

            }
            return sachmuon;
        }
        // lấy thông tin sách mượn quá hạn
        public List<TTSachMuon> GetSach_QuaHan(string mathe)
        {
            List<TTSachMuon> sachmuon = new List<TTSachMuon>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "TimSach_DocGia_QuaHan";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = _conn;
            cmd.Parameters.Add("@mathe", SqlDbType.Char).Value = mathe;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable sach = new DataTable();
            da.Fill(sach);
            foreach (DataRow dr in sach.Rows)
            {
                TTSachMuon ttsm = new TTSachMuon();
                ttsm.MaSach = dr["MaTaiLieu"].ToString();
                ttsm.TenSach = dr["TenTaiLieu"].ToString();
                ttsm.NgayMuon = (DateTime)dr["NgayMuon"];
                ttsm.HanTra = (DateTime)dr["HanTra"];
                ttsm.Quahan = int.Parse(dr["Quahan"].ToString());

                sachmuon.Add(ttsm);

            }
            return sachmuon;
        }
        // Tra cứu thông tin sách theo tên
        public List<SachTraCuu> TraCuSach_Ten(string tensach)
        {
            List<SachTraCuu> listsach = new List<SachTraCuu>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "TraCuuSach_Ten";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = _conn;
            cmd.Parameters.Add("@tensach", SqlDbType.NVarChar).Value = tensach;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable sach = new DataTable();
            da.Fill(sach);
            foreach (DataRow dr in sach.Rows)
            {
                SachTraCuu ttsach = new SachTraCuu();
                ttsach.MaDauTaiLieu = dr["MaDauTaiLieu"].ToString();
                ttsach.TenTaiLieu = dr["TenTaiLieu"].ToString();
                ttsach.TenTacGia = dr["TenTacGia"].ToString();
                ttsach.TenNXB = dr["TenNXB"].ToString();
                ttsach.Soluongkho = int.Parse(dr["Soluongkho"].ToString());
                
                listsach.Add(ttsach);

            }
            return listsach;
        }
        // tra cứu sách theo tác giả
        public List<SachTraCuu> TraCuSach_Tacgia(string tentacgia)
        {
            List<SachTraCuu> listsach = new List<SachTraCuu>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "TraCuuSach_TacGia";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = _conn;
            cmd.Parameters.Add("@tentacgia", SqlDbType.NVarChar).Value = tentacgia;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable sach = new DataTable();
            da.Fill(sach);
            foreach (DataRow dr in sach.Rows)
            {
                SachTraCuu ttsach = new SachTraCuu();
                ttsach.MaDauTaiLieu = dr["MaDauTaiLieu"].ToString();
                ttsach.TenTaiLieu = dr["TenTaiLieu"].ToString();
                ttsach.TenTacGia = dr["TenTacGia"].ToString();
                ttsach.TenNXB = dr["TenNXB"].ToString();
                ttsach.Soluongkho = int.Parse(dr["Soluongkho"].ToString());

                listsach.Add(ttsach);

            }
            return listsach;
        }
        // lấy thông tin đăng nhập
        public string Login(string username, string password)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DangNhap";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = _conn;
            cmd.Parameters.Add("@username", SqlDbType.Char).Value = username;
            cmd.Parameters.Add("@password", SqlDbType.Char).Value = password;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable nguoidung = new DataTable();
            da.Fill(nguoidung);
            if(nguoidung.Rows.Count<=0)
            {
                return "False";
            }
            else
            {
                return username;
            }
        }
        public DataTable TTDocGia(string tendn)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "GetDocGia_API";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = _conn;
            cmd.Parameters.Add("@tendn", SqlDbType.Char).Value = tendn;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable docgia = new DataTable();
            da.Fill(docgia);
            return docgia;
        }
        public List<HOSODOCGIA_MB> Get_TTDocGia_Mobile(string tendn)
        {
            List<HOSODOCGIA_MB> Listhosodocgia = new List<HOSODOCGIA_MB>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Get_TTDocGa_Mobile";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = _conn;
            cmd.Parameters.Add("@tendn", SqlDbType.Char).Value = tendn;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable hsdg = new DataTable();
            da.Fill(hsdg);
            foreach (DataRow dr in hsdg.Rows)
            {
                HOSODOCGIA_MB hosodocgia = new HOSODOCGIA_MB();
                hosodocgia.ngaycap = (DateTime)dr["ngaycap"];
                hosodocgia.ngayhethan = (DateTime)dr["ngayhethan"];
                hosodocgia.tinhtrang = dr["tinhtrang"].ToString();
                hosodocgia.gioitinh = dr["gioitinh"].ToString();
                hosodocgia.ngaysinh = (DateTime)dr["ngaysinh"];
                hosodocgia.Hoten = dr["Hoten"].ToString();
                hosodocgia.mathe = dr["mathe"].ToString();
                Listhosodocgia.Add(hosodocgia);

            }
            return Listhosodocgia;
        }
   }
}
