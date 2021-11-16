using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DTO_QLTV;
using DAL_QLTV;

namespace BUS_QLTV
{
   public class BUS_DG
   {
        DAL_DocGia_API dg_api = new DAL_DocGia_API();
        public DataTable GetTTSachMuon(string mathe)
        {
            HttpClient client = new HttpClient();
            StringBaseAdd s = new StringBaseAdd();
            client.BaseAddress = new Uri(s.Url());
            HttpResponseMessage response = client.GetAsync(String.Format("api/DocGia/{0}", mathe)).Result;
            List<TTSachMuon> data = response.Content.ReadAsAsync<List<TTSachMuon>>().Result;
            ListToDatatable convert = new ListToDatatable();
            return convert.ToDataTable(data);

        }
        public DataTable GetTTSachDangMuon(string mathe)
        {
            HttpClient client = new HttpClient();
            StringBaseAdd s = new StringBaseAdd();
            client.BaseAddress = new Uri(s.Url());
            HttpResponseMessage response = client.GetAsync(String.Format("api/DocGia/dangmuon/{0}", mathe)).Result;
            List<TTSachMuon> data = response.Content.ReadAsAsync<List<TTSachMuon>>().Result;
            ListToDatatable convert = new ListToDatatable();
            return convert.ToDataTable(data);

        }
        public DataTable GetTTSachQuaHan(string mathe)
        {
            HttpClient client = new HttpClient();
            StringBaseAdd s = new StringBaseAdd();
            client.BaseAddress = new Uri(s.Url());
            HttpResponseMessage response = client.GetAsync(String.Format("api/DocGia/quahan/{0}", mathe)).Result;
            List<TTSachMuon> data = response.Content.ReadAsAsync<List<TTSachMuon>>().Result;
            ListToDatatable convert = new ListToDatatable();
            return convert.ToDataTable(data);

        }
        public DataTable TraCuuSach_Ten(string tensach)
        {
            HttpClient client = new HttpClient();
            StringBaseAdd s = new StringBaseAdd();
            client.BaseAddress = new Uri(s.Url());
            HttpResponseMessage response = client.GetAsync(String.Format("api/DocGia/sach/{0}", tensach)).Result;
            List<SachTraCuu> data = response.Content.ReadAsAsync<List<SachTraCuu>>().Result;
            ListToDatatable convert = new ListToDatatable();
            return convert.ToDataTable(data);

        }
        public DataTable TraCuuSach_TacGia(string tacgia)
        {
            HttpClient client = new HttpClient();
            StringBaseAdd s = new StringBaseAdd();
            client.BaseAddress = new Uri(s.Url());
            HttpResponseMessage response = client.GetAsync(String.Format("api/DocGia/tacgia/{0}", tacgia)).Result;
            List<SachTraCuu> data = response.Content.ReadAsAsync<List<SachTraCuu>>().Result;
            ListToDatatable convert = new ListToDatatable();
            return convert.ToDataTable(data);

        }
        public string GetLogin(string username, string password)
        {
            HttpClient client = new HttpClient();
            StringBaseAdd s = new StringBaseAdd();
            client.BaseAddress = new Uri(s.Url());
            HttpResponseMessage response = client.GetAsync(String.Format("api/DocGia/{0}/{1}", username,password)).Result;
            string data = response.Content.ReadAsStringAsync().Result;
            return data;

        }
        public DataTable TTDocGia(string tendn)
        {
            return dg_api.TTDocGia(tendn);
        }
    }
}
