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
    public partial class Stor : Form
    {
        MySqlConnection conn = Param.GetDBConnection();

        public Stor()
        {
            InitializeComponent();
            dataGridView1.ColumnHeadersVisible = false;
            update_data();

        }


        public void update_data()
        {
        try { 

            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Select * From stor", conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.Refresh();

            for (int i = 0; i < dt.Rows.Count; i++)
            { if (dataGridView1.Rows.Count < dt.Rows.Count)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    




        private void Stor_Load(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try { 
            if (dataGridView1.Rows.Count != 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {

                    textBox1.Text = row.Cells[0].Value.ToString();
                    textBox2.Text = row.Cells[1].Value.ToString();
                    textBox3.Text = row.Cells[2].Value.ToString();
                    textBox4.Text = row.Cells[3].Value.ToString();
                    comboBox1.Text = row.Cells[4].Value.ToString();
                    
                }
            }
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Select * From stor Where idStor=" + textBox1.Text, conn);
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
                 catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
}

        private void button4_Click(object sender, EventArgs e)
        {
            add_product ap = new add_product();
            ap.MdiParent = this.MdiParent;
            ap.Show();
        
        }

        public object Convert(object value)
        {
            return value.ToString().Replace(",", ".");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Update stor Set product='" + textBox2.Text + "', quantity='" + textBox3.Text + "', price='" +Convert(textBox4.Text) +
                "', nds='" + Convert(comboBox1.Text) + "' Where idStor='" + int.Parse(textBox1.Text) + "'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            update_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == ',') && (textBox4.Text.IndexOf(",") == -1) && (textBox4.Text.Length != 0))) if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try { 
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Delete From stor Where idStor = '" + int.Parse(textBox1.Text) + "'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
