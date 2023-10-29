using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class Db
    {
        public string strCon = @"Data Source=DESKTOP-1SGEUSL\KAY;Initial Catalog=ShopSp;Integrated Security=True";

        public SqlConnection sqlCon = null;
        public SqlCommand command = null;
        public SqlDataReader reader = null;
        public Db()
        {
            OpenConnection();
        }
        public void OpenConnection()
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == System.Data.ConnectionState.Closed)
                sqlCon.Open();
        }
    }
}
