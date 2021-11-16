using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QLTV;

namespace BUS_QLTV
{
    public class BUS_QLMUONTRA
    {
        DAL_QLMuonTra qlmt = new DAL_QLMuonTra();
        public DataTable GetThe_Muon(string mathe)
        {
           return qlmt.GetThe_Muon(mathe);
        }
        // lấy thông tin tên sách
        public DataTable GetSach(string masach)
        {
            return qlmt.GetSach(masach);
        }
        // lấy thông tin sách mượn để trả
        public DataTable GetTTSach_Muon(string masach)
        {
            return qlmt.GetTTSach_Muon(masach);
        }
        // lấy thông tin sách mượn theo thẻ
        public DataTable GetSach_Muon(string mathe)
        {
            return qlmt.GetSach_Muon(mathe);
        }
        public DataTable GetSach_Phat(string masach, DateTime ngaytra)
        {
            return qlmt.GetSach_Phat(masach, ngaytra);
        }
        public DataTable ThongkeLuotMuon(int nam)
        {
            return qlmt.ThongkeLuotMuon(nam);
        }
        public DataTable ThongkeLuotDocGia(int nam)
        {
            return qlmt.ThongkeLuotDocGia(nam);
        }
        public DataTable ThongkeSachMuonNhieu(int thang, int nam)
        {
            return qlmt.ThongkeSachMuonNhieu(thang, nam);
        }
        // thêm sách mượn
        public bool ThemSachMuon(string mamuon, string matailieu, DateTime ngaymuon, DateTime hantra, string mathe, string idnguoidung, bool datra)
        {
            return qlmt.ThemSachMuon(mamuon, matailieu, ngaymuon, hantra, mathe, idnguoidung, datra);
        }
        public bool ThemSachTra(string matra, string matailieu, DateTime ngaytra, int quahan, string idnguoidung, string mathe, string mamuon, string tinhtrang)
        {
            return qlmt.ThemSachTra(matra, matailieu, ngaytra, quahan, idnguoidung, mathe, mamuon,tinhtrang);
        }
        public bool ThemPhieuPhat(string maphieu, string matailieu, bool hongsach, bool matsach, bool quahan, int sotranghong, string idnguoidung, int thanhtien, string mathe)
        {
            return qlmt.ThemPhieuPhat(maphieu, matailieu, hongsach, matsach, quahan, sotranghong, idnguoidung, thanhtien, mathe);
        }
        public bool Delete_Muon(string mamuon)
        {
            return qlmt.Delete_Muon(mamuon);
        }
        public bool Update_The()
        {
            return qlmt.Update_The();
        }
        public DataTable TimKiem_TheMuon(string mathe, DateTime ngaybatdau, DateTime ngayketthuc)
        {
            return qlmt.TimKiem_TheMuon(mathe, ngaybatdau, ngayketthuc);
        }
        public DataTable TimKiem_TheMuon_Ten(string ten, DateTime ngaybatdau, DateTime ngayketthuc)
        {
            return qlmt.TimKiem_TheMuon_Ten(ten, ngaybatdau, ngayketthuc);
        }
        //Sinh mã mượn
        public string MaMuon()
        {
            return qlmt.MaMuon();
        }
        // sinh mã trả
        public string MaTra()
        {
            return qlmt.MaTra();
        }
        // Sinh mã phiếu phatj
        public string MaPhieuPhat()
        {
            return qlmt.MaPhieuPhat();
        }
    }
}
