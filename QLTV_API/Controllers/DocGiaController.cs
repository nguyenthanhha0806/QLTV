using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DAL_QLTV;
using DTO_QLTV;

namespace QLTV_API.Controllers
{
    public class DocGiaController : ApiController
    {
        DAL_DocGia_API dg  = new DAL_DocGia_API();
        [Route("api/DocGia/{mathe}")]
        public List<TTSachMuon> Get(string mathe)
        {
            return dg.GetSachTTMuon(mathe);
        }
        // lấy thông tin sách đang mượn
        [Route("api/DocGia/dangmuon/{mathe}")]
        public List<TTSachMuon> Get_DangMuon(string mathe)
        {
            return dg.GetSach_DangMuon(mathe);
        }
        // lấy thông tin sách mượn quá hạn
        [Route("api/DocGia/quahan/{mathe}")]
        public List<TTSachMuon> Get_Quahan(string mathe)
        {
            return dg.GetSach_QuaHan(mathe);
        }
        // tra cứu sách theo tên
        [Route("api/DocGia/sach/{tensach}")]
        [HttpGet]
        public List<SachTraCuu> TraCuuSach_Ten(string tensach)
        {
            return dg.TraCuSach_Ten(tensach);
        }
        // tra cứu sách theo tác giả
        [Route("api/DocGia/tacgia/{tentacgia}")]
        [HttpGet]
        public List<SachTraCuu> TraCuuSach_TacGia(string tentacgia)
        {
            return dg.TraCuSach_Tacgia(tentacgia);
        }
        // lấy thông tin đăng nhập
        [Route("api/DocGia/{username}/{password}")]
        public string GetLogin(string username, string password)
        {
            return dg.Login(username, password);
        }
        [Route("api/DocGia/Mobile/{tendn}")]
        public List<HOSODOCGIA_MB> Get_TTDG_Mobile(string tendn)
        {
            return dg.Get_TTDocGia_Mobile(tendn);
        }
    }
}
