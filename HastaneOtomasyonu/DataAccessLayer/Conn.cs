using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class Conn
    {
        public static string constring = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Hospital;Integrated Security=True";//veritabı bağlantısı
        public static SqlConnection Con = new SqlConnection(constring);
    }
}
