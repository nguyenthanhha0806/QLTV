using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLTV
{
    public class DBConnect
    {
        protected SqlConnection _conn = new SqlConnection("Data Source=LAPTOP-J8587HLD;Initial Catalog=QLTV;User=sa;Password=123456");
    }
}
