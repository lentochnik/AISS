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

            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Select * From stor", conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);



            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dataGridView1.Rows.Add();
                for (int j = 0; j < dt.Columns.Count - 1; j++)
                {

                    dataGridView1.Rows[i].Cells[j].Value = dt.Rows[i][j].ToString();
                }


            }



            conn.Close();

        }







        private void Stor_Load(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                textBox3.Text = row.Cells[2].Value.ToString();
                textBox4.Text = row.Cells[3].Value.ToString();
                textBox5.Text = row.Cells[4].Value.ToString();
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

    }
}
