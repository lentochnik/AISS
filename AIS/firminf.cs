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
    public partial class firminf : Form
    {
        MySqlConnection conn = Param.GetDBConnection();

        public firminf()
        {
            InitializeComponent();

            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Select * From cominfo where id='1'", conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            textBox1.Text = dt.Rows[0][1].ToString();
            textBox2.Text = dt.Rows[0][2].ToString();
            textBox3.Text = dt.Rows[0][3].ToString();
            textBox4.Text = dt.Rows[0][4].ToString();
            textBox5.Text = dt.Rows[0][5].ToString();
            textBox6.Text = dt.Rows[0][6].ToString();
            textBox7.Text = dt.Rows[0][8].ToString();
            textBox8.Text = dt.Rows[0][9].ToString();
            textBox9.Text = dt.Rows[0][10].ToString();
            textBox10.Text = dt.Rows[0][7].ToString();
            conn.Close();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void firminf_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("Update cominfo" +
                    " Set name ='"     + textBox1.Text +
                    "', inn ='"        + textBox2.Text +
                    "', ind ='" + textBox3.Text +
                    "', country ='" + textBox4.Text +
                    "', city ='" + textBox5.Text +
                    "', adress ='" + textBox6.Text +
                    "', tel ='" + textBox10.Text +
                    "', acc ='" + textBox7.Text +
                    "', bic ='" + textBox8.Text +
                    "', bankcs ='" + textBox9.Text +
                    "' Where id = 1", conn);
                cmd.ExecuteNonQuery();
            }
         
   catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();

            this.Close();
        }
    }
}
