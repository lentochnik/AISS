using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIS
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            textBox1.Text = Properties.Settings.Default.host;
            textBox2.Text = Properties.Settings.Default.port.ToString();
            textBox3.Text = Properties.Settings.Default.db;
            textBox4.Text = Properties.Settings.Default.name;
            textBox5.Text = Properties.Settings.Default.pass;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "localhost";
            textBox2.Text = "3306";
            textBox3.Text = "AIS";
            textBox4.Text = "root";
            textBox5.Text = "rh38H38dj23*I34jk";
            Properties.Settings.Default.host = textBox1.Text;
            Properties.Settings.Default.port = Int32.Parse(textBox2.Text);
            Properties.Settings.Default.db = textBox3.Text;
            Properties.Settings.Default.name = textBox4.Text;
            Properties.Settings.Default.pass = textBox5.Text;
            Properties.Settings.Default.Save();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.host = textBox1.Text;
            Properties.Settings.Default.port = Int32.Parse(textBox2.Text);
            Properties.Settings.Default.db = textBox3.Text;
            Properties.Settings.Default.name = textBox4.Text;
            Properties.Settings.Default.pass = textBox5.Text;
            Properties.Settings.Default.Save();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }
    }
}
