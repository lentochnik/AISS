using MySql.Data.MySqlClient;

namespace AIS
{
    class Param
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = Properties.Settings.Default.host;
            int port = Properties.Settings.Default.port;
            string database = Properties.Settings.Default.db;
            string username = Properties.Settings.Default.name;
            string password = Properties.Settings.Default.pass;

            return Msqlc.GetDBConnection(host, port, database, username, password);
        }
    }
}