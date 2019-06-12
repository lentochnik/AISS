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
                    textBox8.Text = dt1.Rows[0][12].ToString() + "\r\n" + dt1.Rows[0][10].ToString() + ", " + dt1.Rows[0][11].ToString() + ",\r\n" + dt1.Rows[0][9].ToString() + ",\r\n" + dt1.Rows[0][8].ToString();
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
            if (Canum.Text.Length > 0)
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("Select * From pap Where idclient= '" + Canum.Text + "'", conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Columns.Count - 2; i++)
                    {
                        dataGridView3.Columns.Add(dt.Columns[i].Caption, dt.Columns[i].Caption);
                    }
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (dataGridView3.Rows.Count < dt.Rows.Count)
                        {
                            dataGridView3.Rows.Add();
                        }
                        for (int j = 0; j < dt.Columns.Count - 2; j++)
                        {

                            dataGridView3.Rows[i].Cells[j].Value = dt.Rows[i][j].ToString();
                        }
                    }

                    conn.Close();

                }

            }

            if (Canum.Text.Length > 0)
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("Select * From orders Where idclient= '" + Canum.Text + "'", conn);
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

                   

                }
                conn.Close();
            }

            if (Canum.Text.Length > 0)
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("Select * From invoce Where idclient= '" + Canum.Text + "'", conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Columns.Count - 1; i++)
                    {
                        dataGridView2.Columns.Add(dt.Columns[i].Caption, dt.Columns[i].Caption);
                    }
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (dataGridView2.Rows.Count < dt.Rows.Count)
                        {
                            dataGridView2.Rows.Add();
                        }
                        for (int j = 0; j < dt.Columns.Count - 1; j++)
                        {

                            dataGridView2.Rows[i].Cells[j].Value = dt.Rows[i][j].ToString();
                        }
                    }

                    

                }
                conn.Close();

            }

        }


        private void Sresult_Load(object sender, EventArgs e)
        {

        }

        private void adorder_Click(object sender, EventArgs e)
        {
            if (Canum.Text != null)
            {
                order or = new order(Canum.Text);
                or.MdiParent = this.MdiParent;
                or.Show();
            }
            else
            {
                order or = new order();
                or.MdiParent = this.MdiParent;
                or.Show();
            }
        }

        private void invocecre_Click(object sender, EventArgs e)
        {
            if (Canum.Text != null)
            {
                Invoce invoce = new Invoce(Canum.Text);
                invoce.MdiParent = this.MdiParent;
                invoce.Show();
            }

        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            adpap pap = new adpap();
            pap.MdiParent = this.MdiParent;
            pap.Show();
        }

        private void Canum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(Canum.Text);
        }
    }
}
