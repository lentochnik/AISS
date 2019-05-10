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
using System.IO;

namespace AIS
{
    public partial class conord : Form
    {
        public conord()
        {
            InitializeComponent();
            But_unit.Enabled = false;
        }

        MySqlConnection conn = Param.GetDBConnection();

        private void conord_Load(object sender, EventArgs e)
        {

        }

        private void But_Search_Click(object sender, EventArgs e)
        {
            Loadinfo();

        }

        private void Loadinfo()
        {

            if (Clnum.Text.Length > 0)
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("Select * From clients Where Id = " + Clnum.Text, conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                if (dt.Rows.Count > 0)
                {
                    Cid.Text = dt.Rows[0][0].ToString();
                    Cname.Text = dt.Rows[0][1].ToString() + " " + dt.Rows[0][2].ToString() + " " + dt.Rows[0][3].ToString(); // ФИО
                    Ccomp.Text = dt.Rows[0][4].ToString();  // Название компании
                    Cinn.Text = dt.Rows[0][5].ToString();
                    Ckpp.Text = dt.Rows[0][6].ToString();
                    Cacc.Text = dt.Rows[0][7].ToString();
                    Cadr.Text = dt.Rows[0][12].ToString() + "\r\n" + dt.Rows[0][9].ToString() + ",\r\n" + dt.Rows[0][10].ToString() + ", " + dt.Rows[0][11].ToString() + ",\r\n" + dt.Rows[0][8].ToString();
                    Cfax.Text = dt.Rows[0][13].ToString(); Cmail.Text = dt.Rows[0][14].ToString();
                    Ctel.Text = dt.Rows[0][15].ToString();
                    dt.Clear();

                }
                conn.Close();
              
            }

            if (Ordnum.Text.Length > 0)
            {
                conn.Open();
                MySqlCommand cmd1 = new MySqlCommand("Select * From pap Where idNum = " + Ordnum.Text, conn);
                MySqlDataReader dr1 = cmd1.ExecuteReader();
                DataTable dt1 = new DataTable();
                dt1.Load(dr1);
                if (dt1.Rows.Count > 0)
                {
                    Paynum.Text = dt1.Rows[0][0].ToString();
                    Oinn.Text = dt1.Rows[0][2].ToString();
                    Okpp.Text = dt1.Rows[0][3].ToString();
                    Oacc.Text = dt1.Rows[0][5].ToString();
                    Obic.Text = dt1.Rows[0][7].ToString();
                    Obank.Text = dt1.Rows[0][6].ToString();
                    Obacc.Text = dt1.Rows[0][8].ToString();
                    Omess.Text = dt1.Rows[0][10].ToString();
                    ammount.Text = dt1.Rows[0][9].ToString();
                    pictureBox1.Image = Image.FromStream(new MemoryStream((byte[])dt1.Rows[0][11]));

                }
                conn.Close();

              
               
            }

            if (Cid.Text.Length !=0 && Paynum.Text.Length !=0)
                {
                But_unit.Enabled = true;
                }

            

        }

        private void But_unit_Click(object sender, EventArgs e)
        {
                if (Cid.Text.Length != 0 &&
                    Paynum.Text.Length != 0)
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("Update pap Set idclient ='" +Cid.Text+ "'Where idNum='" +Paynum.Text +"'", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    this.Close();
                }
            But_unit.Enabled = false;
            
        }
    }
}
