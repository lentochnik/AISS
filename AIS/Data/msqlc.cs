using MySql.Data.MySqlClient;

namespace AIS
{
    class Msqlc
    {
       public static string sconn = @"Data Source=NIXE-PC\SQLEXPRESS;Initial Catalog=AIS; Integrated Security=True; Connect Timeout=30; Encrypt=False; TrustServerCertificate=False; ApplicationIntent=ReadWrite; MultiSubnetFailover=False";

        public static MySqlConnection
               GetDBConnection(string host, int port, string database, string username, string password)
        {
            // Connection String.
            string connString = "Server=" + host + ";Database=" + database
                + ";port=" + port + ";User Id=" + username + ";password=" + password;

            MySqlConnection conn = new MySqlConnection(connString);
            return conn;
        }
    }
}