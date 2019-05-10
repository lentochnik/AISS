using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace AIS
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }
        MySqlConnection conn = Param.GetDBConnection();
        string name, sname, patr;
        private void Serchname (string a, string b, string c)
        {

            conn.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter("Select * From clients Where name= '" + a + "," + "' sname='" + b + ","+ "'patr='" + c + "' ", conn);
            DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {

                a = dt.Rows[0][0].ToString();
                b = dt.Rows[0][2].ToString();
                c = dt.Rows[0][3].ToString();
               if (b.Length != 0 || a.Length !=0 && c.Length != 0)
               {
                    name = a;
                    sname = b;
                    patr = c;
               }

            }
        conn.Close();
        }

        private void But_searc_Click(object sender, EventArgs e)
        {

        }
    }
}
