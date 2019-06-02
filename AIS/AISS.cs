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
    public partial class AISS : Form
    {
        string rl;  // переменная нужная для проверки
        

        public AISS(string role)
        {
            InitializeComponent();
            rl = role;
            StLab.Text = role; 

            if (rl != "admin") // проверяем роль
            {
                adminToolStripMenuItem.Enabled = false;
                adminToolStripMenuItem.Visible = false;
                
            }
            else
            {
                adminToolStripMenuItem.Enabled = true;
                adminToolStripMenuItem.Visible = true;

            }

        }
        
       
        private void AISS_Load(object sender, EventArgs e)
        {

        }


        private void StLab_Click(object sender, EventArgs e)
        {

        }


        private void ToolStripStatusLabel_Click(object sender, EventArgs e)
        {

        }
        

        private void addPaymentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            adpap adpay = new adpap();
            adpay.MdiParent = this;
            adpay.Show();
        }

        private void accountManagementToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ACman aCman = new ACman();
            aCman.MdiParent = this;
            aCman.Show();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit(); // выход
        }

        private void AISS_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void clientAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Client_Info cinf = new Client_Info();
            cinf.MdiParent = this;
            cinf.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conord conr = new conord();
            conr.MdiParent = this;
            conr.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Invoce iv = new Invoce();
                iv.MdiParent = this;
                iv.Show();
        }

        private void strorageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stor st = new Stor();
            st.MdiParent = this;
            st.Show();
        }

        private void searchToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Search srt = new Search();
            srt.MdiParent = this;
            srt.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.MdiParent = this;
            settings.Show();
        }
    }
}
