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
    public class DAL_DTL : DBConnect
     {
          public DataTable GetNCC()
          {
               _conn.Open();
               SqlDataAdapter da = new SqlDataAdapter("Select *from NHACUNGCAP", _conn);
               DataTable ncc1 = new DataTable();
               da.Fill(ncc1);
               _conn.Close();
               return ncc1;
          }
          public DataTable GetDauTaiLieu(string txt)
          {
               _conn.Open();
               SqlCommand cmd = new SqlCommand();
               //Thiết lập các thuộc tính cho đối tượng Command
               cmd.Connection = _conn;
               cmd.CommandType = CommandType.StoredProcedure;
               cmd.CommandText = "TimKiemTheoMaDTL";
               //B3. Gắn các Parameter và giá trị cho đối tượng Command
               cmd.Parameters.Add(new SqlParameter("@Ma", txt)) ;
               //B4. Thực thi Stored Procedure
               System.Data.SqlClient.SqlDataReader Dl = cmd.ExecuteReader();
               DataTable a = new DataTable();
               a.Load(Dl);
               _conn.Close();
               return a;
          }
          public DataTable GetTheoMaTaiLieu(string txt)
          {
               _conn.Open();
               SqlCommand cmd = new SqlCommand();
               //Thiết lập các thuộc tính cho đối tượng Command
               cmd.Connection = _conn;
               cmd.CommandType = CommandType.StoredProcedure;
               cmd.CommandText = "TimKiemTheoMaTL";
               //B3. Gắn các Parameter và giá trị cho đối tượng Command
               cmd.Parameters.Add(new SqlParameter("@Ma", txt));
               //B4. Thực thi Stored Procedure
               System.Data.SqlClient.SqlDataReader Dl = cmd.ExecuteReader();
               DataTable a = new DataTable();
               a.Load(Dl);
               _conn.Close();
               return a;
          }
          public DataTable GetTaiLieu()
          {
               _conn.Open();

               SqlDataAdapter da = new SqlDataAdapter("select * from dbo.TAILIEU ", _conn);
               DataTable tl1 = new DataTable();
               da.Fill(tl1);
               return tl1;
          }
          public DataTable GetBaoCao(string txt)
          {
               _conn.Open();
               SqlCommand cmd = new SqlCommand();
               //Thiết lập các thuộc tính cho đối tượng Command
               cmd.Connection = _conn;
               cmd.CommandType = CommandType.StoredProcedure;
               cmd.CommandText = "ThongKeBaoCao";
               //B3. Gắn các Parameter và giá trị cho đối tượng Command
               cmd.Parameters.Add(new SqlParameter("@Ma", txt));
               //B4. Thực thi Stored Procedure
               System.Data.SqlClient.SqlDataReader Dl = cmd.ExecuteReader();
               DataTable a = new DataTable();
               a.Load(Dl);
               _conn.Close();
               return a;

          }
          public DataTable GetThanhLy(string txt)
          {
               _conn.Open();
               SqlCommand cmd = new SqlCommand();
               //Thiết lập các thuộc tính cho đối tượng Command
               cmd.Connection = _conn;
               cmd.CommandType = CommandType.StoredProcedure;
               cmd.CommandText = "ThongKeThanhLY";
               //B3. Gắn các Parameter và giá trị cho đối tượng Command
               cmd.Parameters.Add(new SqlParameter("@Ma", txt));
               //B4. Thực thi Stored Procedure
               System.Data.SqlClient.SqlDataReader Dl = cmd.ExecuteReader();
               DataTable a = new DataTable();
               a.Load(Dl);
               _conn.Close();
               return a;

          }
          public DataTable GetHoaDon(string txt)
          {
               _conn.Open();
               SqlCommand cmd = new SqlCommand();
               //Thiết lập các thuộc tính cho đối tượng Command
               cmd.Connection = _conn;
               cmd.CommandType = CommandType.StoredProcedure;
               cmd.CommandText = "ThongKeHoaDon";
               //B3. Gắn các Parameter và giá trị cho đối tượng Command
               cmd.Parameters.Add(new SqlParameter("@Ma", txt));
               //B4. Thực thi Stored Procedure
               System.Data.SqlClient.SqlDataReader Dl = cmd.ExecuteReader();
               DataTable a = new DataTable();
               a.Load(Dl);
               _conn.Close();
               return a;

          }
          public DataTable GetDonHang(string txt)
          {
               _conn.Open();
               SqlCommand cmd = new SqlCommand();
               //Thiết lập các thuộc tính cho đối tượng Command
               cmd.Connection = _conn;
               cmd.CommandType = CommandType.StoredProcedure;
               cmd.CommandText = "ThongKeHoaDon";
               //B3. Gắn các Parameter và giá trị cho đối tượng Command
               cmd.Parameters.Add(new SqlParameter("@Ma", txt));
               //B4. Thực thi Stored Procedure
               System.Data.SqlClient.SqlDataReader Dl = cmd.ExecuteReader();
               DataTable a = new DataTable();
               a.Load(Dl);
               _conn.Close();
               return a;

          }
          public DataTable GetTaiLieuBC(string txt)
          {
               _conn.Open();
               SqlCommand cmd = new SqlCommand();
               //Thiết lập các thuộc tính cho đối tượng Command
               cmd.Connection = _conn;
               cmd.CommandType = CommandType.StoredProcedure;
               cmd.CommandText = "ThongKeTaiLieu";
               //B3. Gắn các Parameter và giá trị cho đối tượng Command
               cmd.Parameters.Add(new SqlParameter("@Ma", txt));
               //B4. Thực thi Stored Procedure
               System.Data.SqlClient.SqlDataReader Dl = cmd.ExecuteReader();
               DataTable a = new DataTable();
               a.Load(Dl);
               _conn.Close();
               return a;

          }
          public DataTable GetTaiLieuTL(string txt)
          {
               _conn.Open();
               SqlCommand cmd = new SqlCommand();
               //Thiết lập các thuộc tính cho đối tượng Command
               cmd.Connection = _conn;
               cmd.CommandType = CommandType.StoredProcedure;
               cmd.CommandText = "ThongKeTaiLieuTL";
               //B3. Gắn các Parameter và giá trị cho đối tượng Command
               cmd.Parameters.Add(new SqlParameter("@Ma", txt));
               //B4. Thực thi Stored Procedure
               System.Data.SqlClient.SqlDataReader Dl = cmd.ExecuteReader();
               DataTable a = new DataTable();
               a.Load(Dl);
               _conn.Close();
               return a;
          }
          public DataTable GetTaiLieuHD(string txt)
          {
               _conn.Open();
               SqlCommand cmd = new SqlCommand();
               //Thiết lập các thuộc tính cho đối tượng Command
               cmd.Connection = _conn;
               cmd.CommandType = CommandType.StoredProcedure;
               cmd.CommandText = "ThongKeTaiLieuHD";
               //B3. Gắn các Parameter và giá trị cho đối tượng Command
               cmd.Parameters.Add(new SqlParameter("@Ma", txt));
               //B4. Thực thi Stored Procedure
               System.Data.SqlClient.SqlDataReader Dl = cmd.ExecuteReader();
               DataTable a = new DataTable();
               a.Load(Dl);
               _conn.Close();
               return a;

          }
          public DataTable GetTaiLieuDH(string txt)
          {
               _conn.Open();
               SqlCommand cmd = new SqlCommand();
               //Thiết lập các thuộc tính cho đối tượng Command
               cmd.Connection = _conn;
               cmd.CommandType = CommandType.StoredProcedure;
               cmd.CommandText = "ThongKeTaiLieuDH";
               //B3. Gắn các Parameter và giá trị cho đối tượng Command
               cmd.Parameters.Add(new SqlParameter("@Ma", txt));
               //B4. Thực thi Stored Procedure
               System.Data.SqlClient.SqlDataReader Dl = cmd.ExecuteReader();
               DataTable a = new DataTable();
               a.Load(Dl);
               _conn.Close();
               return a;

          }
          public DataTable TimKiemTLTheoMa(string txt)
          {
               _conn.Open();
               SqlCommand cmd = new SqlCommand();
               //Thiết lập các thuộc tính cho đối tượng Command
               cmd.Connection = _conn;
               cmd.CommandType = CommandType.StoredProcedure;
               cmd.CommandText = "TimKiemTL";
               //B3. Gắn các Parameter và giá trị cho đối tượng Command
               cmd.Parameters.Add(new SqlParameter("@Ma", txt));
               //B4. Thực thi Stored Procedure
               System.Data.SqlClient.SqlDataReader Dl = cmd.ExecuteReader();
               DataTable a = new DataTable();
               a.Load(Dl);
               _conn.Close();
               return a;

          }
          public DataTable TimKiemTLTheoTen(string txt)
          {
               _conn.Open();
               SqlCommand cmd = new SqlCommand();
               //Thiết lập các thuộc tính cho đối tượng Command
               cmd.Connection = _conn;
               cmd.CommandType = CommandType.StoredProcedure;
               cmd.CommandText = "TimKiemTLTheoTen";
               //B3. Gắn các Parameter và giá trị cho đối tượng Command
               cmd.Parameters.Add(new SqlParameter("@Ten", txt));
               //B4. Thực thi Stored Procedure
               System.Data.SqlClient.SqlDataReader Dl = cmd.ExecuteReader();
               DataTable a = new DataTable();
               a.Load(Dl);
               _conn.Close();
               return a;

          }
          public DataTable TimMaTL(string txt)
          {
               _conn.Open();
               SqlCommand cmd = new SqlCommand();
               //Thiết lập các thuộc tính cho đối tượng Command
               cmd.Connection = _conn;
               cmd.CommandType = CommandType.StoredProcedure;
               cmd.CommandText = "TimMaTl";
               //B3. Gắn các Parameter và giá trị cho đối tượng Command
               cmd.Parameters.Add(new SqlParameter("@ma", txt));
               //B4. Thực thi Stored Procedure
               System.Data.SqlClient.SqlDataReader Dl = cmd.ExecuteReader();
               DataTable a = new DataTable();
               a.Load(Dl);
               _conn.Close();
               return a;

          }
          public DataTable ThongKeHong(int txt)
          {
  
               _conn.Open();
               SqlCommand cmd = new SqlCommand("select * from ThongKe_Hong(@nam)", _conn);
               cmd.Parameters.Add("@nam",SqlDbType.Int).Value =txt;
               SqlDataAdapter da = new SqlDataAdapter(cmd);
               DataTable dt = new DataTable();
               da.Fill(dt);
               return dt;

          }
          public DataTable ThongKeMat(int txt)
          {
               _conn.Open();
               SqlCommand cmd = new SqlCommand();
               //Thiết lập các thuộc tính cho đối tượng Command
               cmd.Connection = _conn;
               cmd.CommandType = CommandType.StoredProcedure;
               cmd.CommandText = "ThongKe_Mat";
               //B3. Gắn các Parameter và giá trị cho đối tượng Command
               cmd.Parameters.Add(new SqlParameter("@nam", txt));
               //B4. Thực thi Stored Procedure
               System.Data.SqlClient.SqlDataReader Dl = cmd.ExecuteReader();
               DataTable a = new DataTable();
               a.Load(Dl);
               _conn.Close();
               return a;

          }
          public DataTable GetBC()
          {
               _conn.Open();
               SqlDataAdapter da = new SqlDataAdapter("select MaBaoCao from dbo.BAOCAOKIEMKE group by MaBaoCao", _conn);
               DataTable bc1 = new DataTable();
               da.Fill(bc1);
               _conn.Close();
               return bc1;
          }
          public DataTable GetHD()
          {
               _conn.Open();

               SqlDataAdapter da = new SqlDataAdapter("select MaHoaDon from dbo.HOADON group by MaHoaDon", _conn);
               DataTable bc1 = new DataTable();
               da.Fill(bc1);
               _conn.Close();
               return bc1;
          }
          public DataTable GetTL()
          {
               _conn.Open();
               SqlDataAdapter da = new SqlDataAdapter("select MaThanhLy from dbo.THANHLYTAILIEU group by MaThanhLy", _conn);
               DataTable bc1 = new DataTable();
               da.Fill(bc1);
               _conn.Close();
               return bc1;
          }
          public void InsertBC(DataTable tb )
          {
               _conn.Open();
               SqlCommand cmd = new SqlCommand("InsertBBKK", _conn);
               cmd.CommandType = CommandType.StoredProcedure;
               SqlParameter sqlParam = cmd.Parameters.AddWithValue("@TempTable", tb);
               sqlParam.SqlDbType = SqlDbType.Structured;
               cmd.ExecuteNonQuery();
               _conn.Close();
          }
          public void InsertD_TL(DataTable tb)
          {
               _conn.Open();
               SqlCommand cmd = new SqlCommand("InsertD_TL", _conn);
               cmd.CommandType = CommandType.StoredProcedure;
               SqlParameter sqlParam = cmd.Parameters.AddWithValue("@TempTable", tb);
               sqlParam.SqlDbType = SqlDbType.Structured;
               cmd.ExecuteNonQuery();
               _conn.Close();
          }
          public void InsertHD(DataTable tb)
          {
               _conn.Open();
               SqlCommand cmd = new SqlCommand("InsertHD", _conn);
               cmd.CommandType = CommandType.StoredProcedure;
               SqlParameter sqlParam = cmd.Parameters.AddWithValue("@TempTable", tb);
               sqlParam.SqlDbType = SqlDbType.Structured;
               cmd.ExecuteNonQuery();
               _conn.Close();
          }
          public DataTable GetViTri()
          {
               _conn.Open();
               SqlDataAdapter da = new SqlDataAdapter("select * from dbo.VITRILUUTRU ", _conn);
               DataTable vt = new DataTable();
               da.Fill(vt);
               _conn.Close();
               return vt;

          }

          public void UpdateVT( string trangthai , string ma)
          {
               _conn.Open();
               SqlCommand cmd = new SqlCommand();
               cmd.Connection = _conn;
               string queryString = @"UPDATE dbo.VITRILUUTRU SET TrangThai = @trangthai WHERE MaViTri = @ma";
               cmd.CommandText = queryString;
               cmd.Parameters.AddWithValue("@trangthai", trangthai);
               cmd.Parameters.AddWithValue("@ma", ma);
               cmd.ExecuteNonQuery();
               _conn.Close();
          }
          public void InsertDTL( string ma , string ten , string gc , int slk ,string kg , int st , string nn )
          {
               _conn.Open();
               SqlCommand cmd = new SqlCommand();
               cmd.Connection = _conn;
               string queryString = @"INSERT INTO dbo.DAUTAILIEU VALUES ( @ma, @ten , @gc , @slk , @kg , @st, @nn )";
               cmd.CommandText = queryString;
               cmd.Parameters.AddWithValue("@ma", ma);
               cmd.Parameters.AddWithValue("@ten", ten); 
               cmd.Parameters.AddWithValue("@gc", gc);
               cmd.Parameters.AddWithValue("@slk", slk);
               cmd.Parameters.AddWithValue("@kg", kg);
               cmd.Parameters.AddWithValue("@st", st);
               cmd.Parameters.AddWithValue("@nn", nn);
               cmd.ExecuteNonQuery();
               _conn.Close();
          }
          public void InsertTL(string ma, string tennv, int tt, string nxn )
          {
               _conn.Open();
               SqlCommand cmd = new SqlCommand();
               cmd.Connection = _conn;
               string queryString = @"INSERT INTO dbo.THANHLYTAILIEU VALUES ( @ma, @tennv , @tt , @nxn)";
               cmd.CommandText = queryString;
               cmd.Parameters.AddWithValue("@ma", ma);
               cmd.Parameters.AddWithValue("@tennv", tennv);
               cmd.Parameters.AddWithValue("@tt", tt);
               cmd.Parameters.AddWithValue("@nxn", nxn);
               cmd.ExecuteNonQuery();
               _conn.Close();
          }

     }
}
