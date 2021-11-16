using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLTV;
using DTO_QLTV;

namespace BUS_QLTV
{
    public class BUS_QLDOCGIA
    {
        DAL_QLDocGia qldg = new DAL_QLDocGia();
        public DataTable GetDocGia()
        {
            return qldg.GetHoSoDocGia();
        }
        // lấy thông tin độc giả theo mã
        public DataTable GetDocGia( string mathe)
        {
            return qldg.GetHoSoDocGia(mathe);
        }
        public DataTable GetNhomDocGia()
        {
            return qldg.GetNhomDocgia();
        }
        // Tìm kiếm theo mã
        public DataTable TimKiem_Ma(string Mathe)
        {
            return qldg.TimKiem_Ma(Mathe);
        }
        // tìm kiếm theo tên
        public DataTable TimKiem_Ten(string Ten)
        {
            return qldg.TimKiem_Ten(Ten);
        }
        public DataTable TimKiem_Madocgia(string Maso)
        {
            return qldg.TimKiem_Madocgia(Maso);
        }
        public DataTable TimKiem_Nhomdocgia(string Nhom)
        {
            return qldg.TimKiem_Nhomdocgia(Nhom);
        }
        public DataTable TimKiem_ChuaIn()
        {
            return qldg.TimKiem_ChuaIn();
        }
        public DataTable TimKiem_HetHan()
        {
            return qldg.TimKiem_HetHan();
        }
        public DataTable ThongkeDocGia(DateTime ngaybatdau, DateTime ngayketthuc)
        {
            return qldg.ThongkeDocGia(ngaybatdau, ngayketthuc);
        }
        public bool ThemDocGia( HOSODOCGIA hsdg,string Nhomdocgia)
        {
            return qldg.ThemDocGia(hsdg, Nhomdocgia);
        }
        public string SinhMaDocgia()
        {
            return qldg.MaThe();
        }
        public bool UpDate_Docgia(string mathe, string gioitinh, string chucvu, string donvi, string lop, string khoa, string mavach, string email, string anh, string tinhtrang, DateTime ngaycap, DateTime ngayhethan)
        {
            return qldg.UpDateDocgia(mathe, gioitinh, chucvu, donvi, lop, khoa, mavach, email, anh, tinhtrang, ngaycap, ngayhethan);
        }
        public bool DeleteDocgia(string mathe)
        {
            return qldg.DeleteDocgia(mathe);
        }
    }
}
