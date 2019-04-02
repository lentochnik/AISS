using System.Data.SqlClient;

namespace AIS
{
    class Msqlc
    {
       public static string sconn = @"Data Source=NIXE-PC\SQLEXPRESS;Initial Catalog=AIS; Integrated Security=True; Connect Timeout=30; Encrypt=False; TrustServerCertificate=False; ApplicationIntent=ReadWrite; MultiSubnetFailover=False";

        public static SqlConnection
               GetDBConnection(string datasource, string database, string username, string password)
        {
            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;

            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
    }
}