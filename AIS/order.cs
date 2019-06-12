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
    public partial class order : Form
    {
        MySqlConnection conn = Param.GetDBConnection();
        double  am;
        string val;
        public order(string a)
        {
            InitializeComponent();
            textBox1.Text = a;
            if (a != null)
            {
                conn.Open();
                MySqlCommand cmd1 = new MySqlCommand("Select * From clients Where Id= '" + a + "'", conn);
                MySqlDataReader dr1 = cmd1.ExecuteReader();
                DataTable dt1 = new DataTable();
                dt1.Load(dr1);
                if (dt1.Rows.Count > 0)
                {
                    textBox2.Text = dt1.Rows[0][1].ToString();
                    textBox3.Text = dt1.Rows[0][2].ToString();
                    textBox4.Text = dt1.Rows[0][3].ToString();
                    textBox5.Text = dt1.Rows[0][12].ToString() + "\r\n" + dt1.Rows[0][10].ToString() + ", " + dt1.Rows[0][11].ToString() + ",\r\n" + dt1.Rows[0][9].ToString() + ",\r\n" + dt1.Rows[0][8].ToString();
                    val = dt1.Rows[0][17].ToString();
                  string amm = dt1.Rows[0][18].ToString();
                    am = Convert.ToDouble(amm);
                    label1.Text = am.ToString() + " " + val;
                }

                conn.Close();
                data_ad();
            }
        }

        public order()
        {
            InitializeComponent();
        }

        private void order_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                MySqlCommand cmd1 = new MySqlCommand("Select * From clients Where Id= '" + textBox1.Text + "'", conn);
                MySqlDataReader dr1 = cmd1.ExecuteReader();
                DataTable dt1 = new DataTable();
                dt1.Load(dr1);
                if (dt1.Rows.Count > 0)
                {
                    textBox2.Text = dt1.Rows[0][1].ToString();
                    textBox3.Text = dt1.Rows[0][2].ToString();
                    textBox4.Text = dt1.Rows[0][3].ToString();
                    textBox5.Text = dt1.Rows[0][12].ToString() + "\r\n" + dt1.Rows[0][10].ToString() + ", " + dt1.Rows[0][11].ToString() + ",\r\n" + dt1.Rows[0][9].ToString() + ",\r\n" + dt1.Rows[0][8].ToString();
                    label1.Text = dt1.Rows[0][18].ToString() + "  " + dt1.Rows[0][17].ToString();
                }

                conn.Close();
                data_ad();
            }
        }

        private void data_ad()
        {

            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Select * From stor", conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Columns.Count - 1; i++)
                {
                    dataGridView1.Columns.Add(dt.Columns[i].Caption, dt.Columns[i].Caption);
                }
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dataGridView1.Rows.Count < dt.Rows.Count)
                    {
                        dataGridView1.Rows.Add();
                    }
                    for (int j = 0; j < dt.Columns.Count - 1; j++)
                    {

                        dataGridView1.Rows[i].Cells[j].Value = dt.Rows[i][j].ToString();
                    }

                }
                conn.Close();
            }
        }
        int sta;
        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {

                    textBox6.Text = row.Cells[0].Value.ToString();
                    textBox7.Text = row.Cells[1].Value.ToString();
                    textBox8.Text = row.Cells[2].Value.ToString();
                    textBox9.Text = row.Cells[3].Value.ToString();
                    textBox10.Text = row.Cells[4].Value.ToString();
                    sta = Convert.ToInt32(row.Cells[2].Value.ToString());
                }
            }
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Select * From stor Where idStor=" + textBox6.Text, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)

            {
                Bitmap bmp;
                using (var ms = new MemoryStream((byte[])dt.Rows[0][5]))
                {
                    bmp = new Bitmap(ms);
                }

                pictureBox1.Image = bmp;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox11.Text) < Convert.ToInt32(textBox8.Text))

            {
                double nd = Convert.ToDouble(textBox9.Text) * Convert.ToDouble(textBox11.Text);
                double a = Convert.ToDouble(textBox9.Text);
                double b = Convert.ToDouble(textBox10.Text);
                double c = (b * (a / 100));
                a = (a + c) * Convert.ToDouble(textBox11.Text);
                c = c * Convert.ToDouble(textBox11.Text);
                double ab = a;
                sumextr(ab);
                MySqlCommand cmd;
                string CmdString = "Insert Into orders (product, idProd, name, quantity, pice, sumnnds, nds, ndssumm, total, idclient, Invcr)Values(@product, @idProd, @name, @quantity, @pice, @sumnnds, @nds, @ndssumm, @total, @idclient, @Invcr)";
                cmd = new MySqlCommand(CmdString, conn);

                cmd.Parameters.Add("@product", MySqlDbType.VarChar, 255);
                cmd.Parameters.Add("@idProd", MySqlDbType.Int32, 11);
                cmd.Parameters.Add("@name", MySqlDbType.VarChar, 45);
                cmd.Parameters.Add("@quantity", MySqlDbType.Int32, 11);
                cmd.Parameters.Add("@pice", MySqlDbType.Decimal, 12);
                cmd.Parameters.Add("@sumnnds", MySqlDbType.Decimal, 12);
                cmd.Parameters.Add("@nds", MySqlDbType.Decimal, 12);
                cmd.Parameters.Add("@ndssumm", MySqlDbType.Decimal, 12);
                cmd.Parameters.Add("@total", MySqlDbType.Decimal, 12);
                cmd.Parameters.Add("@idclient", MySqlDbType.VarChar, 255);
                cmd.Parameters.Add("@Invcr", MySqlDbType.Int16, 2);

                cmd.Parameters["@product"].Value = textBox7.Text;
                cmd.Parameters["@idProd"].Value = textBox6.Text;
                cmd.Parameters["@name"].Value = textBox7.Text;
                cmd.Parameters["@quantity"].Value = textBox11.Text;
                
                cmd.Parameters["@pice"].Value = textBox9.Text;
                cmd.Parameters["@sumnnds"].Value = nd;
                cmd.Parameters["@nds"].Value = textBox10.Text;
                cmd.Parameters["@ndssumm"].Value = c;
                cmd.Parameters["@total"].Value = a;
                cmd.Parameters["@idclient"].Value = textBox1.Text;
                cmd.Parameters["@Invcr"].Value = 0;

                conn.Open();


                int RowsAffected = cmd.ExecuteNonQuery();


                if (RowsAffected > 0)
                {

                    conn.Close();

                }
            }
            else
            {
                MessageBox.Show
              (
                String.Format("There is not enough product in stock"),
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly
                );
            }
        }


        private void sumextr(double a)
        {
        if(am != 0)
            {
                if (am > a)
                {
                    if (sta >= Convert.ToInt32(textBox11.Text))
                        {
                        am -= a;
                        sta -= Convert.ToInt32(textBox11.Text);
                        dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value = sta;
                        dataGridView1.Refresh();
                        label1.Text = am.ToString() + " " + val;
                        textBox8.Text = sta.ToString();
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand("Update clients Set accounamoun='" + Convert1(am.ToString()) + "' Where Id ='" + textBox1.Text + "'", conn);
                        cmd.ExecuteNonQuery();
                        cmd = new MySqlCommand("Update stor Set quantity='" + sta + "' Where idStor='" + textBox6.Text + "'", conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        dataGridView1.Refresh();
                        MessageBox.Show
                           (
                             String.Format("Added to order"),
                             "Information",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Information,
                             MessageBoxDefaultButton.Button1,
                             MessageBoxOptions.DefaultDesktopOnly
                             );
                    }
                }
                else
                {
                    MessageBox.Show
             (
               String.Format("The customer's account is not sufficient amount"),
               "Error",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error,
               MessageBoxDefaultButton.Button1,
               MessageBoxOptions.DefaultDesktopOnly
               );
                }

            }
        else
            {
                MessageBox.Show
            (
              String.Format("The customer's account is not sufficient amount"),
              "Error",
              MessageBoxButtons.OK,
              MessageBoxIcon.Error,
              MessageBoxDefaultButton.Button1,
              MessageBoxOptions.DefaultDesktopOnly
              );
            }
        }

        public object Convert1(object value)
        {
            return value.ToString().Replace(",", ".");
        }
    }
}