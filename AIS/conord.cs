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
        private double am;
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
                    am = Convert.ToDouble(dt.Rows[0][18].ToString());
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

       private bool sercpay(string a, string b)
        {
            conn.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter("Select idNum From pap Where idNum = '" + b + "' and idclient = '" + a + "' ", conn);
            DataTable dt1 = new System.Data.DataTable();
            sda.Fill(dt1);
            if (dt1.Rows.Count == 1)
            {
                MessageBox.Show(
                    "payment order is already use",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly
                    );
                conn.Close();
                return false;
            }
            else
            {
                conn.Close();
                return true;
            }
            
        }

        public object Converts(object value)
        {
            return value.ToString().Replace(",", ".");
        }
        string z;

        private bool prsv(string a)
        {

            conn.Open();
            MySqlCommand cmd1 = new MySqlCommand("Select * From pap Where idNum=" + a, conn);
            MySqlDataReader dr1 = cmd1.ExecuteReader();
            DataTable dt1 = new DataTable();
            dt1.Load(dr1);
            if (dt1.Rows.Count > 0)
            {

                
                if (dt1.Rows[0][12] != DBNull.Value)
                {
                   z = dt1.Rows[0][12].ToString(); 
                }
                else
                {
                    z = "0";
                }

                if (z.Length != 0)
                {
                    if (z == "")
                    {
                        return true;
                    }
                    conn.Close();
                    return false;
                }



                else
                {
                    conn.Close();
                    return false;
                }
            }
            else
            {
                conn.Close();
                return true;
            }
        }

        private void But_unit_Click(object sender, EventArgs e)
        {
            if (prsv(Paynum.Text))
            {
                if (sercpay(Cid.Text, Paynum.Text))
                {
                    if (Cid.Text.Length != 0 &&
                          Paynum.Text.Length != 0)
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand("Update pap Set idclient ='" + Cid.Text + "'Where idNum='" + Paynum.Text + "'", conn);
                        cmd.ExecuteNonQuery();

                        conn.Close();
                        am = am + Convert.ToDouble(ammount.Text);
                        conn.Open();
                        MySqlCommand cmd1 = new MySqlCommand("Update clients Set accounamoun ='" + Converts(am.ToString()) + "'Where Id= +'" + Cid.Text + "'", conn);
                        cmd1.ExecuteNonQuery();
                        conn.Close();
                        this.Close();

                    }
                    But_unit.Enabled = false;
                }
            }
            else
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("Select * From clients Where Id='" + z +"'", conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                if (dt.Rows.Count > 0)
                {
                    string n = dt.Rows[0][1].ToString() + " " + dt.Rows[0][2].ToString() + " " + dt.Rows[0][3].ToString(); // ФИО
                    string c = dt.Rows[0][4].ToString();
                    string d = dt.Rows[0][0].ToString();
                    dt.Clear();
                    conn.Close();
                    MessageBox.Show(
                                        "payment order is already use for \n client: " + n + " " + c + "\n client id: " + d ,
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error,
                                        MessageBoxDefaultButton.Button1,
                                        MessageBoxOptions.DefaultDesktopOnly);
                    But_unit.Enabled = false;
                   
                }
            
            }
        }

        private void Clnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!Char.IsDigit(num))
            {
                e.Handled = true;
            }
        }

        private void Ordnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!Char.IsDigit(num))
            {
                e.Handled = true;
            }
        }
    }
}
