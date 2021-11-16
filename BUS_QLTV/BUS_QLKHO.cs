using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLTV;
namespace BUS_QLTV
{
    public class BUS_QLKHO
    {
        DAL_DTL qlk = new DAL_DTL();
        public DataTable GetNCC()
        {
            return qlk.GetNCC();
        }
        public DataTable GetDauTaiLieu(string txt)
        {
            return qlk.GetDauTaiLieu(txt);
        }
        public DataTable GetTheoMaTaiLieu(string txt)
        {
            return qlk.GetTheoMaTaiLieu(txt);
        }
        public DataTable GetTaiLieu()
        {
            return qlk.GetTaiLieu();
        }
        public DataTable GetBaoCao(string txt)
        {
            return qlk.GetBaoCao(txt);
        }
        public DataTable GetThanhLy(string txt)
        {
            return qlk.GetThanhLy(txt);
        }
        public DataTable GetHoaDon(string txt)
        {
            return qlk.GetHoaDon(txt);
        }
        public DataTable GetDonHang(string txt)
        {
            return qlk.GetDonHang(txt);
        }
        public DataTable GeTaiLieuBC(string txt)
        {
            return qlk.GetTaiLieuBC(txt);
        }
        public DataTable GetTaiLieuTL(string txt)
        {
            return qlk.GetTaiLieuTL(txt);
        }
        public DataTable GetTaiLieuHD(string txt)
        {
            return qlk.GetTaiLieuHD(txt);
        }
        public DataTable GetTaiLieuDH(string txt)
        {
            return qlk.GetTaiLieuDH(txt);
        }
        public DataTable TimKiemTLTheoMa(string txt)
        {
            return qlk.TimKiemTLTheoMa(txt);
        }
        public DataTable TimKiemTLTheoTen(string txt)
        {
            return qlk.TimKiemTLTheoTen(txt);
        }
        public DataTable TimMaTL(string txt)
        {
            return qlk.TimMaTL(txt);
        }
        public DataTable ThongKeHong(int txt)
        {
            return qlk.ThongKeHong(txt);
        }
        public DataTable ThongKeMat(int txt)
        {
            return qlk.ThongKeMat(txt);
        }
        public DataTable GetBC()
        {
            return qlk.GetBC();
        }
        public DataTable GetHD()
        {
            return qlk.GetHD();
        }
        public DataTable GetTL()
        {
            return qlk.GetTL();
        }
        public void InsertBC(DataTable tb)
        {
            qlk.InsertBC(tb);
        }
        public void InsertD_TL(DataTable tb)
        {
            qlk.InsertD_TL(tb);
        }
        public void InsertHD(DataTable tb)
        {
            qlk.InsertHD(tb);
        }
        public DataTable GetViTri()
        {
           return qlk.GetViTri();
        }
        public void UpdateVT(string trangthai, string ma)
        {
            qlk.UpdateVT(trangthai, ma);
        }
        public void InsertDTL(string ma, string ten, string gc, int slk, string kg, int st, string nn)
        {
            qlk.InsertDTL(ma, ten, gc, slk, kg, st, nn);
        }
        public void InsertTL(string ma, string tennv, int tt, string nxn)
        {
            qlk.InsertTL(ma, tennv, tt, nxn);
        }
    }
}
