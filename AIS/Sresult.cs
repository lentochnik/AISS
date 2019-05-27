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
    public partial class Sresult : Form
    {

        MySqlConnection conn = Param.GetDBConnection();

        public Sresult(string name, string sname, string patr, string company)
        {
            InitializeComponent();
            string n = name;
            string s = sname;
            string p = patr;
            string co = company;
            if (n.Length != 0 && s.Length != 0 && p.Length != 0)

            {
                conn.Open();

                MySqlCommand cmd1 = new MySqlCommand("Select * From clients Where name= '" + n + "' and sname='" + s + "' and patr= '" + p + "'", conn);
                MySqlDataReader dr1 = cmd1.ExecuteReader();
                DataTable dt1 = new DataTable();
                dt1.Load(dr1);
                if (dt1.Rows.Count > 0)
                {
                    Canum.Text = dt1.Rows[0][0].ToString();
                    textBox1.Text = dt1.Rows[0][1].ToString();
                    textBox2.Text = dt1.Rows[0][2].ToString();
                    textBox3.Text = dt1.Rows[0][3].ToString();
                    textBox4.Text = dt1.Rows[0][4].ToString();
                    textBox5.Text = dt1.Rows[0][5].ToString();
                    textBox6.Text = dt1.Rows[0][6].ToString();
                    textBox7.Text = dt1.Rows[0][7].ToString();
                    textBox8.Text = dt1.Rows[0][12].ToString() + "\r\n" + dt1.Rows[0][9].ToString() + ",\r\n" + dt1.Rows[0][10].ToString() + ", " + dt1.Rows[0][11].ToString() + ",\r\n" + dt1.Rows[0][8].ToString();
                    label13.Text = dt1.Rows[0][18].ToString();
                    label14.Text = dt1.Rows[0][17].ToString();
                }

                conn.Close();
            }

            if (co != null)
            {
                conn.Open();

                MySqlCommand cmd1 = new MySqlCommand("Select * From clients Where company= '" + co + "'", conn);
                MySqlDataReader dr1 = cmd1.ExecuteReader();
                DataTable dt1 = new DataTable();
                dt1.Load(dr1);
                if (dt1.Rows.Count > 0)
                {
                    Canum.Text = dt1.Rows[0][0].ToString();
                    textBox1.Text = dt1.Rows[0][1].ToString();
                    textBox2.Text = dt1.Rows[0][2].ToString();
                    textBox3.Text = dt1.Rows[0][3].ToString();
                    textBox4.Text = dt1.Rows[0][4].ToString();
                    textBox5.Text = dt1.Rows[0][5].ToString();
                    textBox6.Text = dt1.Rows[0][6].ToString();
                    textBox7.Text = dt1.Rows[0][7].ToString();
                    textBox8.Text = dt1.Rows[0][12].ToString() + "\r\n" + dt1.Rows[0][9].ToString() + ",\r\n" + dt1.Rows[0][10].ToString() + ", " + dt1.Rows[0][11].ToString() + ",\r\n" + dt1.Rows[0][8].ToString();
                    label13.Text = dt1.Rows[0][18].ToString();
                    label14.Text = dt1.Rows[0][17].ToString();

                }
            }
        }

        private void Sresult_Load(object sender, EventArgs e)
        {

        }
    }
}
