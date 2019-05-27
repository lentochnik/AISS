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
using System.Globalization;
using System.IO;
using System.Drawing.Imaging;

namespace AIS
{
    public partial class add_product : Form
    {
        public add_product()
        {
            InitializeComponent();
        }
        MySqlConnection conn = Param.GetDBConnection();

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string imname;

        private void button1_Click(object sender, EventArgs e)
        {

            MySqlCommand cmd;
            FileStream fs;
            BinaryReader br;

            try
            {
                string FileName = imname;
                byte[] ImageData;
                fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fs);
                ImageData = br.ReadBytes((int)fs.Length);
                br.Close();
                fs.Close();
                string CmdString = "Insert Into stor (product, quantity, price, nds, foto)Values(@prod, @quantity, @price, @nds, @foto)";
                cmd = new MySqlCommand(CmdString, conn);
                cmd.Parameters.Add("@prod", MySqlDbType.VarChar, 255);
                cmd.Parameters.Add("@quantity", MySqlDbType.Int32, 11);
                cmd.Parameters.Add("@price", MySqlDbType.Decimal, 12);
                cmd.Parameters.Add("@nds", MySqlDbType.Int32, 11);
                cmd.Parameters.Add("@foto", MySqlDbType.Blob);
                cmd.Parameters["@prod"].Value = textBox1.Text;
                cmd.Parameters["@quantity"].Value = textBox2.Text;
                cmd.Parameters["@price"].Value = Convert(textBox3.Text);
                cmd.Parameters["@nds"].Value = comboBox1.Text;
                cmd.Parameters["@foto"].Value = ImageData;
                conn.Open();
                int RowsAffected = cmd.ExecuteNonQuery();
                Stor st = new Stor();
                st.update_data();

                if (RowsAffected > 0)
                {

                    conn.Close();
                    this.Close();
                    
                }
                

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

            private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
        imname = opf.FileName;
        pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        public object Convert(object value)
        {
            return value.ToString().Replace(",", ".");
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == ',') && (textBox3.Text.IndexOf(",") == -1) && (textBox3.Text.Length != 0))) if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!Char.IsDigit(num))
            {
                e.Handled = true;
            }
        }
    }
}
