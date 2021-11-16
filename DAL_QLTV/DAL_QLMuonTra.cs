using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLTV
{
    public class DAL_QLMuonTra:DBConnect
    {
        public DataTable GetThe_Muon(string mathe)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ThongTinThe_Muon";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = _conn;
            cmd.Parameters.Add("@mathe", SqlDbType.Char).Value = mathe;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable the = new DataTable();
            da.Fill(the);
            return the;
        }
        public DataTable GetSach(string masach)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "GetSach";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = _conn;
            cmd.Parameters.Add("@masach", SqlDbType.Char).Value = masach;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable sach = new DataTable();
            da.Fill(sach);
            return sach;
        }
        // Lấy thông tin sách mượn
        public DataTable GetTTSach_Muon(string masach)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Tra_Sach";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = _conn;
            cmd.Parameters.Add("@masach", SqlDbType.Char).Value = masach;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable sach = new DataTable();
            da.Fill(sach);
            return sach;
        }
        // lấy thông tin các sách đã mượn của độc giả mà chưa trả
        public DataTable GetSach_Muon(string mathe)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SachMuon_The";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = _conn;
            cmd.Parameters.Add("@mathe", SqlDbType.Char).Value = mathe;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable sachmuon = new DataTable();
            da.Fill(sachmuon);
            return sachmuon;
        }
        public DataTable GetSach_Phat(string masach, DateTime ngaytra)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Sach_Phat";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = _conn;
            cmd.Parameters.Add("@masach", SqlDbType.Char).Value = masach;
            cmd.Parameters.Add("@ngaytra", SqlDbType.Date).Value = ngaytra;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable sachphat = new DataTable();
            da.Fill(sachphat);
            return sachphat;
        }
        public DataTable ThongkeLuotMuon(int nam)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select *from ThongKeMuonThang(@nam)";
            cmd.Connection = _conn;
            cmd.Parameters.Add("@nam", SqlDbType.Int).Value = nam;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable temp = new DataTable();
            da.Fill(temp);
            return temp;
        }
        public DataTable ThongkeLuotDocGia(int nam)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select *from ThongKeDocGia_Thang(@nam)";
            cmd.Connection = _conn;
            cmd.Parameters.Add("@nam", SqlDbType.Int).Value = nam;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable temp = new DataTable();
            da.Fill(temp);
            return temp;
        }
        public DataTable ThongkeSachMuonNhieu(int thang, int nam)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ThongKeSach_MuonNhieu";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = _conn;
            cmd.Parameters.Add("@nam", SqlDbType.Int).Value = nam;
            cmd.Parameters.Add("@thang", SqlDbType.Int).Value = thang;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable temp = new DataTable();
            da.Fill(temp);
            return temp;
        }
        public bool ThemPhieuPhat(string maphieu, string matailieu, bool hongsach, bool matsach, bool quahan, int sotranghong, string idnguoidung, int thanhtien, string mathe)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "ThemPhieuPhat";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _conn;
                cmd.Parameters.Add("@maphieu", SqlDbType.Char).Value = maphieu;
                cmd.Parameters.Add("@matailieu", SqlDbType.Char).Value = matailieu;
                cmd.Parameters.Add("@hongsach", SqlDbType.Bit).Value = hongsach;
                cmd.Parameters.Add("@matsach", SqlDbType.Bit).Value = matsach;
                cmd.Parameters.Add("@quahan", SqlDbType.Bit).Value = quahan;
                cmd.Parameters.Add("@sotranghong", SqlDbType.Int).Value = sotranghong;
                cmd.Parameters.Add("@thanhtien", SqlDbType.Int).Value = thanhtien;
                cmd.Parameters.Add("@mathe", SqlDbType.Char).Value = mathe;
                cmd.Parameters.Add("@idnguoidung", SqlDbType.Char).Value = idnguoidung;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;

        }
        public bool ThemSachMuon(string mamuon, string matailieu, DateTime ngaymuon, DateTime hantra, string mathe, string idnguoidung, bool datra)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Insert_Muon";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _conn;
                cmd.Parameters.Add("@mamuon", SqlDbType.Char).Value = mamuon;
                cmd.Parameters.Add("@matailieu", SqlDbType.Char).Value = matailieu;
                cmd.Parameters.Add("@ngaymuon", SqlDbType.Date).Value = ngaymuon;
                cmd.Parameters.Add("@hantra", SqlDbType.Date).Value = hantra;
                cmd.Parameters.Add("@mathe", SqlDbType.Char).Value = mathe;
                cmd.Parameters.Add("@idnguoidung", SqlDbType.Char).Value = idnguoidung;
                cmd.Parameters.Add("@datra", SqlDbType.Bit).Value = datra;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch(Exception)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;

        }
        public bool ThemSachTra(string matra, string matailieu, DateTime ngaytra, int quahan,string idnguoidung, string mathe, string mamuon, string tinhtrang)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Insert_Tra";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _conn;
                cmd.Parameters.Add("@matra", SqlDbType.Char).Value = matra;
                cmd.Parameters.Add("@matailieu", SqlDbType.Char).Value = matailieu;
                cmd.Parameters.Add("@ngaytra", SqlDbType.Date).Value = ngaytra;
                cmd.Parameters.Add("@quahan", SqlDbType.Int).Value = quahan;
                cmd.Parameters.Add("@mathe", SqlDbType.Char).Value = mathe;
                cmd.Parameters.Add("@idnguoidung", SqlDbType.Char).Value = idnguoidung;
                cmd.Parameters.Add("@mamuon", SqlDbType.Char).Value = mamuon;
                cmd.Parameters.Add("@tinhtrang", SqlDbType.NVarChar).Value = tinhtrang;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;

        }
        public DataTable TimKiem_TheMuon(string mathe, DateTime ngaybatdau, DateTime ngayketthuc)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "TimKiem_SachMuon";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = _conn;
            cmd.Parameters.Add("@mathe", SqlDbType.Char).Value = mathe;
            cmd.Parameters.Add("@ngaybatdau", SqlDbType.Date).Value = ngaybatdau;
            cmd.Parameters.Add("@ngayketthuc", SqlDbType.Date).Value = ngayketthuc;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable sachmuon = new DataTable();
            da.Fill(sachmuon);
            return sachmuon;
        }
        public DataTable TimKiem_TheMuon_Ten(string ten, DateTime ngaybatdau, DateTime ngayketthuc)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "TimKiem_SachMuon_Ten";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = _conn;
            cmd.Parameters.Add("@ten", SqlDbType.NVarChar).Value = ten;
            cmd.Parameters.Add("@ngaybatdau", SqlDbType.Date).Value = ngaybatdau;
            cmd.Parameters.Add("@ngayketthuc", SqlDbType.Date).Value = ngayketthuc;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable sachmuon_ten = new DataTable();
            da.Fill(sachmuon_ten);
            return sachmuon_ten;
        }
        public bool Delete_Muon(string mamuon)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Delete_Muon";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _conn;
                cmd.Parameters.Add("@mamuon", SqlDbType.Char).Value = mamuon;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch(Exception)
            {
                
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool Update_The()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Update_The";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _conn;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch(Exception)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
          
        }
        // sinh mã mượn
        public int GetMaxMa()
        {
            SqlDataAdapter da = new SqlDataAdapter("select top 1 (MaMuon) from MUON order by MaMuon desc", _conn);
            DataTable temp = new DataTable();
            da.Fill(temp);
            int max = int.Parse(temp.Rows[0]["MaMuon"].ToString());
            return max;
        }
        public string MaMuon()
        {
            string Mamuon;
            int maxsl = this.GetMaxMa() + 1;
            if (maxsl < 10)
            {
                Mamuon = "00" + maxsl.ToString();
                return Mamuon;
            }
            else if (maxsl < 100)
            {
                Mamuon = "0" + maxsl.ToString();
                return Mamuon;
            }
            else if (maxsl < 1000)
            {
                Mamuon =  maxsl.ToString();
                return Mamuon;
            }
            return "";
        }
        //sinh ma muon
        //sinh mã trả
        public int GetMaxMa_Tra()
        {
            SqlDataAdapter da = new SqlDataAdapter("select top 1 (MaTra) from TRA order by MaTra desc", _conn);
            DataTable temp = new DataTable();
            da.Fill(temp);
            int max = int.Parse(temp.Rows[0]["MaTra"].ToString());
            return max;
        }
        public string MaTra()
        {
            string Mamuon;
            int maxsl = this.GetMaxMa_Tra() + 1;
            if (maxsl < 10)
            {
                Mamuon = "00" + maxsl.ToString();
                return Mamuon;
            }
            else if (maxsl < 100)
            {
                Mamuon = "0" + maxsl.ToString();
                return Mamuon;
            }
            else if (maxsl < 1000)
            {
                Mamuon = maxsl.ToString();
                return Mamuon;
            }
            return "";
        }
        // sinh mã trả
        // sinh mã phiếu phạt
        public int GetMaxMa_PhieuPhat()
        {
            SqlDataAdapter da = new SqlDataAdapter("select top 1 (MaPhieuPhat) from PHIEUPHAT order by MaPhieuPhat desc", _conn);
            DataTable temp = new DataTable();
            da.Fill(temp);
            int max = int.Parse(temp.Rows[0]["MaPhieuPhat"].ToString());
            return max;
        }
        public string MaPhieuPhat()
        {
            string Mapp;
            int maxsl = this.GetMaxMa_PhieuPhat() + 1;
            if (maxsl < 10)
            {
                Mapp = "00" + maxsl.ToString();
                return Mapp;
            }
            else if (maxsl < 100)
            {
                Mapp = "0" + maxsl.ToString();
                return Mapp;
            }
            else if (maxsl < 1000)
            {
                Mapp = maxsl.ToString();
                return Mapp;
            }
            return "";
        }
    }
}
