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
        string name, sname, patr, company;

        private void Search_Load(object sender, EventArgs e)
        {

        }
        string strcmd;

        private void Serchname(string a, string b, string c, string d)
        {

            if (a.Length != 0 && b.Length != 0 && c.Length != 0 && d.Length == 0)
            {
                strcmd = "Select * From clients Where name='" + a +"' and sname='" + b + "' and patr='" + c + "'";
                conn.Open();
                MySqlDataAdapter sda = new MySqlDataAdapter(strcmd, conn);
                DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {

                    a = dt.Rows[0][1].ToString();
                    b = dt.Rows[0][2].ToString();
                    c = dt.Rows[0][3].ToString();
                    d = dt.Rows[0][4].ToString();
                    if (a.Length != 0 && b.Length != 0 && c.Length != 0)
                    {
                        name = a;
                        sname = b;
                        patr = c;
                        if (d.Length != 0)
                        {
                            company = d;
                        }
                        conn.Close();
                        serccomp(name, sname, patr, company);
                    }

                }
                conn.Close();
            }
            else if (d.Length != 0)
            {


                strcmd = "Select * From clients Where company='" + d + "'";
                conn.Open();
                MySqlDataAdapter sda = new MySqlDataAdapter(strcmd, conn);
                DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {

                    a = dt.Rows[0][1].ToString();
                    b = dt.Rows[0][2].ToString();
                    c = dt.Rows[0][3].ToString();
                    d = dt.Rows[0][4].ToString();
                        name = a;
                        sname = b;
                        patr = c;
                        company = d;
                        conn.Close();
                        serccomp(name, sname, patr, company);
                }
                conn.Close();

            }
        }

        //private void Serchname(string a, string b, string c, string d)
        //{

        //    conn.Open();
        //    MySqlDataAdapter sda = new MySqlDataAdapter("Select * From clients Where name= '" + a + "," + "' sname='" + b + "," + "'patr='" + c + "," + "'company='" + d + "' ", conn);
        //    DataTable dt = new System.Data.DataTable();
        //    sda.Fill(dt);
        //    if (dt.Rows.Count == 1)
        //    {

        //        a = dt.Rows[0][0].ToString();
        //        b = dt.Rows[0][2].ToString();
        //        c = dt.Rows[0][3].ToString();
        //        d = dt.Rows[0][4].ToString();
        //        if (b.Length != 0 || d.Length != 0 || a.Length != 0 && c.Length != 0)
        //        {
        //            name = a;
        //            sname = b;
        //            patr = c;
        //        }

        //    }
        //    conn.Close();
        //}

        private void serccomp(string name, string sname, string patr, string company)
        {

            Sresult sr = new Sresult(name, sname, patr, company);
            sr.Show();
            

        }

        private void But_searc_Click(object sender, EventArgs e)
        {
            if (ser_name.Text.Length != 0 && textBox1.Text.Length != 0 && textBox2.Text.Length !=0 || ser_cname.Text.Length != 0)
            {
                
                //    "Select * From clients Where name='" + a + "' and" + " sname='" + b + "', Or " + " patr='" + c + "', Or" + " company='" + d + "'"
                Serchname(ser_name.Text, textBox1.Text, textBox2.Text, ser_cname.Text);
            }
        }
    }
}
