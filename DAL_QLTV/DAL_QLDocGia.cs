using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO_QLTV;

namespace DAL_QLTV
{
    public class DAL_QLDocGia:DBConnect
    {
        public DataTable GetHoSoDocGia()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ThongTinDocGia";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = _conn;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dsDocgia = new DataTable();
            da.Fill(dsDocgia);
            return dsDocgia;
        }
        public List<ThongTinDG> GetHoSoDocGia_List()
        {
            List<ThongTinDG> ttdg = new List<ThongTinDG>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ThongTinDocGia";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = _conn;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dsDocgia = new DataTable();
            da.Fill(dsDocgia);
            foreach(DataRow dr in dsDocgia.Rows)
            {
                ThongTinDG dg = new ThongTinDG();
                dg.Mathe = dr["MaThe"].ToString();
                dg.Masodocgia = dr["Masodocgia"].ToString();
                dg.Nhomdocgia = dr["Nhomdocgia"].ToString();
                dg.HoTen = dr["HoTen"].ToString();
                dg.NgaySinh = (DateTime) dr["NgaySinh"];
                dg.GioiTinh = dr["GioiTinh"].ToString();
                dg.Lop = dr["Lop"].ToString();
                dg.Khoa = dr["Khoa"].ToString();
                dg.Donvi = dr["Donvi"].ToString();
                dg.Tinhtrang = dr["Tinhtrang"].ToString();
                ttdg.Add(dg);
            }
            return ttdg;
        }
        // Lấy hồ sơ độc giả theo mã
        public DataTable GetHoSoDocGia(string Mathe)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "GetDocGia_Ma";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = _conn;
            cmd.Parameters.Add("@mathe", SqlDbType.Char).Value = Mathe;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable docgia = new DataTable();
            da.Fill(docgia);
            return docgia;
        }
        public DataTable GetNhomDocgia()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select *from NHOMDOCGIA", _conn);
            DataTable dsNhomdocgia = new DataTable();
            da.Fill(dsNhomdocgia);
            return dsNhomdocgia;
        }
        public DataTable TimKiem_Ma(string Mathe)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "TimKiem_Ma";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = _conn;
            cmd.Parameters.Add("@mathe", SqlDbType.Char).Value = Mathe;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable docgia = new DataTable();
            da.Fill(docgia);
            return docgia;
        }
        public DataTable TimKiem_Ten(string Ten)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "TimKiem_Ten";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = _conn;
            cmd.Parameters.Add("@ten", SqlDbType.NVarChar).Value = Ten;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable docgia = new DataTable();
            da.Fill(docgia);
            return docgia;
        }
        public DataTable TimKiem_Madocgia(string Maso)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "TimKiem_Madocgia";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = _conn;
            cmd.Parameters.Add("@maso", SqlDbType.Char).Value = Maso;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable docgia = new DataTable();
            da.Fill(docgia);
            return docgia;
        }
        public DataTable TimKiem_ChuaIn()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "TimKiem_ChuaIn";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = _conn;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable docgia = new DataTable();
            da.Fill(docgia);
            return docgia;
        }
        public DataTable TimKiem_HetHan()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "TimKiem_HetHan";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = _conn;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable docgia = new DataTable();
            da.Fill(docgia);
            return docgia;
        }
        public DataTable TimKiem_Nhomdocgia(string Nhom)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "TimKiem_Nhomdocgia";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = _conn;
            cmd.Parameters.Add("@nhom", SqlDbType.NVarChar).Value = Nhom;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable docgia = new DataTable();
            da.Fill(docgia);
            return docgia;
        }
        public DataTable ThongkeDocGia(DateTime ngaybatdau, DateTime ngayketthuc)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Thongkedocgia";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = _conn;
            cmd.Parameters.Add("@ngaybatdau", SqlDbType.Date).Value = ngaybatdau;
            cmd.Parameters.Add("@ngayketthuc", SqlDbType.Date).Value = ngayketthuc;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable thongke = new DataTable();
            da.Fill(thongke);
            return thongke;
        }
        /// <summary>
        /// Thêm hồ sơ độc giả
        /// </summary>
        /// <param name="hsdg"></param>
        /// <returns></returns>
        public bool ThemDocGia(HOSODOCGIA hsdg, string Nhomdocgia)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ThemDocGia";
                cmd.Connection = _conn;
                cmd.Parameters.Add("@mathe", SqlDbType.Char).Value = hsdg.MaThe;
                cmd.Parameters.Add("@Hoten", SqlDbType.NVarChar).Value = hsdg.HoTen;
                cmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = hsdg.GioiTinh;
                cmd.Parameters.Add("@trinhdovanhoa", SqlDbType.NVarChar).Value = hsdg.TrinhDoVanhoa;
                cmd.Parameters.Add("@ngaysinh", SqlDbType.Date).Value = hsdg.NgaySinh;
                cmd.Parameters.Add("@lop", SqlDbType.VarChar).Value = hsdg.Lop;
                cmd.Parameters.Add("@khoahoc", SqlDbType.VarChar).Value = hsdg.KhoaHoc;
                cmd.Parameters.Add("@Socmnd", SqlDbType.Char).Value = hsdg.SoCMND;
                cmd.Parameters.Add("@masodocgia", SqlDbType.Char).Value = hsdg.Masodocgia;
                cmd.Parameters.Add("@khoa", SqlDbType.NVarChar).Value = hsdg.Khoa;
                cmd.Parameters.Add("@donvi", SqlDbType.NVarChar).Value = hsdg.Donvi;
                cmd.Parameters.Add("@chucvu", SqlDbType.NVarChar).Value = hsdg.Chucvu;
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = hsdg.Email;
                cmd.Parameters.Add("@anh", SqlDbType.VarChar).Value = hsdg.Anh;
                cmd.Parameters.Add("@somavach", SqlDbType.Char).Value = hsdg.Somavach;
                cmd.Parameters.Add("@ngayhethan", SqlDbType.Date).Value = hsdg.NgayHetHan;
                cmd.Parameters.Add("@ngaycap", SqlDbType.Date).Value = hsdg.Ngaycap;
                cmd.Parameters.Add("@tinhtrang", SqlDbType.NVarChar).Value = hsdg.Tinhtrang;
                cmd.Parameters.Add("@nhomdocgia", SqlDbType.NVarChar).Value = Nhomdocgia;
                cmd.Parameters.Add("@idnguoidung", SqlDbType.Char).Value = hsdg.Idnguoidung;
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
        public int GetMaxDocGia()
        {
            SqlDataAdapter da = new SqlDataAdapter("select top 1 (MaThe) from HOSODOCGIA order by MaThe desc", _conn);
            DataTable temp = new DataTable();
            da.Fill(temp);
            int max = int.Parse(temp.Rows[0]["MaThe"].ToString());
            return max;
        }
        public string MaThe()
        {
            string Mathe;
            int maxsl = this.GetMaxDocGia() + 1;
            if(maxsl<10)
            {
                Mathe = "0000000" + maxsl.ToString();
                return Mathe;
            }
            else if(maxsl<100)
            {
                Mathe = "000000" + maxsl.ToString();
                return Mathe;
            }
            else if(maxsl <1000)
            {
                Mathe = "00000" + maxsl.ToString();
                return Mathe;
            }
            return "";
        }
        // Sửa thông tin độc giả
        public bool UpDateDocgia(string mathe, string gioitinh, string chucvu, string donvi, string lop, string khoa, string mavach,string email, string anh, string tinhtrang, DateTime ngaycap, DateTime ngayhethan)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "UpDate_Docgia";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _conn;
                cmd.Parameters.Add("@mathe", SqlDbType.Char).Value = mathe;
                cmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = gioitinh;
                cmd.Parameters.Add("@chucvu", SqlDbType.NVarChar).Value = chucvu;
                cmd.Parameters.Add("@donvi", SqlDbType.NVarChar).Value = donvi;
                cmd.Parameters.Add("@lop", SqlDbType.VarChar).Value = lop;
                cmd.Parameters.Add("@khoa", SqlDbType.NVarChar).Value = khoa;
                cmd.Parameters.Add("@mavach", SqlDbType.Char).Value = mavach;
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                cmd.Parameters.Add("@anh", SqlDbType.VarChar).Value = anh;
                cmd.Parameters.Add("@tinhtrang", SqlDbType.NVarChar).Value = tinhtrang;
                cmd.Parameters.Add("@ngaycap", SqlDbType.Date).Value = ngaycap;
                cmd.Parameters.Add("@ngayhethan", SqlDbType.Date).Value = ngayhethan;
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
        // Xóa thông tin độc giả
        public bool DeleteDocgia (string mathe)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "DeleteDocgia";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _conn;
                cmd.Parameters.Add("@mathe", SqlDbType.Char).Value = mathe;
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

    }
}
