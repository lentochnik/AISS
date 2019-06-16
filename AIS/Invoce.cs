using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using MySql.Data.MySqlClient;

namespace AIS
{
    public partial class Invoce : Form
    {
        int d = 1;
        MySqlConnection conn = Param.GetDBConnection();

        public Invoce(string a)
        {
            InitializeComponent();
            SetReadonlyControls(gb1.Controls);
            printDocument1.DefaultPageSettings.Landscape = true;
            dataGridView1.ColumnHeadersVisible = false;
           
            data_cret(a);
            orn(a);
            d -= 1;
            label59.Text = d.ToString();
            string s4 = DateTime.Now.ToString("dd MMMM yyyy");
            
                        double s = dataGridView1.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDouble(t.Cells[13].Value));
            label54.Text = "НДС  " + s.ToString() + " RUB";
            double s1 = dataGridView1.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDouble(t.Cells[14].Value));
            label55.Text = s1.ToString() + " RUB";
            double s2 = dataGridView1.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDouble(t.Cells[13].Value));
            label56.Text = "НДС  " + s2.ToString() + " RUB";
            double s3 = dataGridView1.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDouble(t.Cells[14].Value));
            label57.Text = s3.ToString() + " RUB";
            invdate.Text = s4;
            textBox12.Text = s4;
            textBox10.Text = s4;
        }

        private void orn(string a)
        {
            if (a != null)
            {
                conn.Open();
                MySqlCommand cmd1 = new MySqlCommand("Select * From cominfo Where id= 1", conn);
                MySqlDataReader dr1 = cmd1.ExecuteReader();
                DataTable dt1 = new DataTable();
                dt1.Load(dr1);
                if (dt1.Rows.Count > 0)
                {
                    orname.Text =
                      dt1.Rows[0][1].ToString() + " ИНН: "
                    + dt1.Rows[0][2].ToString() + "  КПП: "
                    + dt1.Rows[0][3].ToString() + " Адрес: "
                    + dt1.Rows[0][4].ToString() + ", "
                    + dt1.Rows[0][5].ToString() + ", "
                    + dt1.Rows[0][6].ToString() + "\r\n"
                    + dt1.Rows[0][7].ToString() + ",  Тел.: "
                    + dt1.Rows[0][8].ToString() + ", р/с: "
                    + dt1.Rows[0][9].ToString() + ", к/с: "
                    + dt1.Rows[0][11].ToString() + ", БИК: "
                    + dt1.Rows[0][10].ToString();
                    orgokpo.Text = dt1.Rows[0][12].ToString();
                    prokpo.Text = dt1.Rows[0][12].ToString();
                }

                conn.Close();
                prname.Text = orname.Text;
            }
            if (a != null)
            {
                conn.Open();
                MySqlCommand cmd1 = new MySqlCommand("Select * From clients Where id= " + a, conn);
                MySqlDataReader dr1 = cmd1.ExecuteReader();
                DataTable dt1 = new DataTable();
                dt1.Load(dr1);
                if (dt1.Rows.Count > 0)
                {
                    clname.Text = dt1.Rows[0][1].ToString() + dt1.Rows[0][2].ToString() + dt1.Rows[0][3].ToString() +
                      dt1.Rows[0][4].ToString() + " ИНН: "
                    + dt1.Rows[0][5].ToString() + "  КПП: "
                    + dt1.Rows[0][6].ToString() + "\r\n Адрес: "
                    + dt1.Rows[0][12].ToString() + ", "
                    + dt1.Rows[0][8].ToString() + ", "
                    + dt1.Rows[0][9].ToString() + ", "
                    + dt1.Rows[0][10].ToString() + ", "
                    + dt1.Rows[0][11].ToString() + ", Тел.: "
                    + dt1.Rows[0][15].ToString() + ", р/с: "
                    + dt1.Rows[0][7].ToString();
                }
                conn.Close();
                payname.Text = clname.Text;

            }
        }

        private void data_cret(string a)
        {

            if (a != null)
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("Select * From orders where idclient='" + a + "' and Invcr='0'", conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                if (dt.Rows.Count > 0)
                {
                    
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        
                        if (dataGridView1.Rows.Count < dt.Rows.Count)
                        {
                            dataGridView1.Rows.Add();
                            dataGridView1.Rows[i].Cells[0].Value = d;
                            d++;
                        }
                        for (int j = 1; j < dt.Columns.Count -2; j++)
                        {

                            dataGridView1.Rows[i].Cells[j].Value = dt.Rows[i][j].ToString();
                        }

                    }
                    conn.Close();
                }

            }
        }

        private void SetReadonlyControls(Control.ControlCollection controlCollection)
        {
            if (controlCollection == null)
            {
                return;
            }

            foreach (TextBoxBase c in controlCollection.OfType<TextBoxBase>())
            {
                c.ReadOnly = true;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox51_TextChanged(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]

        public static extern long BitBlt(IntPtr hdcDest,
            int nXDest, int nYDest, int nWidth, int nHeight,
            IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);

        private Bitmap memoryImage;

        private void CaptureScreen()
        {
            Graphics mygraphics = this.gb1.CreateGraphics();
            Size s = this.gb1.Size;
            memoryImage = new Bitmap(s.Width, s.Height,
                mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(
                memoryImage);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, this.gb1.ClientRectangle.Width,
                this.gb1.ClientRectangle.Height, dc1, 0, 0,
                13369376);
            mygraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            CaptureScreen();
            printDialog1.Document = printDocument1;
            DialogResult result = printDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
               printDocument1.Print();
            }
            
           
    }



        

        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {

            
             e.Graphics.DrawImage(memoryImage, 10, 10, 1146, 800);
            printPreviewDialog1.Document = printDocument1;
           
        }

        private void gb1_Enter(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label65_Click(object sender, EventArgs e)
        {

        }

        private void label58_Click(object sender, EventArgs e)
        {

        }

        private void label62_Click(object sender, EventArgs e)
        {

        }

        private void label63_Click(object sender, EventArgs e)
        {

        }

        private void label64_Click(object sender, EventArgs e)
        {

        }

        private void label52_Click(object sender, EventArgs e)
        {

        }

        private void label51_Click(object sender, EventArgs e)
        {

        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void label49_Click(object sender, EventArgs e)
        {

        }

        private void label48_Click(object sender, EventArgs e)
        {

        }

        private void label47_Click(object sender, EventArgs e)
        {

        }

        private void label46_Click(object sender, EventArgs e)
        {

        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label53_Click(object sender, EventArgs e)
        {

        }

        private void textBox46_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void textBox47_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox48_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox49_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox50_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox52_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox53_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox54_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox55_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox45_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox44_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox43_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox42_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox41_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox40_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox39_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void Invoce_Load(object sender, EventArgs e)
        {

        }

        private void label59_Click(object sender, EventArgs e)
        {

        }

        private void label57_Click(object sender, EventArgs e)
        {

        }
    }
}
