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
                companyInfoToolStripMenuItem.Enabled = false;
                companyInfoToolStripMenuItem.Visible = false;
            }
            else
            {
                adminToolStripMenuItem.Enabled = true;
                adminToolStripMenuItem.Visible = true;
                companyInfoToolStripMenuItem.Enabled = true;
                companyInfoToolStripMenuItem.Visible = true;

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
            toolStripStatusLabel.Visible = true;
            toolStripProgressBar1.Visible = true;
            toolStripProgressBar1.Value = 0;
            adpap adpay = new adpap();
            toolStripProgressBar1.Value = 50;
            adpay.MdiParent = this;
            toolStripProgressBar1.Value = 75;
            adpay.Show();
            toolStripProgressBar1.Value = 100;
            toolStripProgressBar1.Visible = false;
            toolStripStatusLabel.Visible = false;
        }

        private void accountManagementToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            toolStripStatusLabel.Visible = true;
            toolStripProgressBar1.Visible = true;
            toolStripProgressBar1.Value = 0;
            ACman aCman = new ACman();
            toolStripProgressBar1.Value = 50;
            aCman.MdiParent = this;
            toolStripProgressBar1.Value = 75;
            aCman.Show();
            toolStripProgressBar1.Value = 100;
            toolStripProgressBar1.Visible = false;
            toolStripStatusLabel.Visible = false;
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
            toolStripStatusLabel.Visible = true;
            toolStripProgressBar1.Visible = true;
            toolStripProgressBar1.Value = 0;
            Client_Info cinf = new Client_Info();
            toolStripProgressBar1.Value = 50;
            cinf.MdiParent = this;
            toolStripProgressBar1.Value = 75;
            cinf.Show();
            toolStripProgressBar1.Value = 100;
            toolStripProgressBar1.Visible = false;
            toolStripStatusLabel.Visible = false;
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel.Visible = true;
            toolStripProgressBar1.Visible = true;
            toolStripProgressBar1.Value = 0;
            conord conr = new conord();
            toolStripProgressBar1.Value = 50;
            conr.MdiParent = this;
            toolStripProgressBar1.Value = 75;
            conr.Show();
            toolStripProgressBar1.Value = 100;
            toolStripProgressBar1.Visible = false;
            toolStripStatusLabel.Visible = false;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
         
        }

        private void strorageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel.Visible = true;
            toolStripProgressBar1.Visible = true;
            toolStripProgressBar1.Value = 0;
            Stor st = new Stor();
            toolStripProgressBar1.Value = 50;
            st.MdiParent = this;
            toolStripProgressBar1.Value = 75;
            st.Show();
            toolStripProgressBar1.Value = 100;
            toolStripProgressBar1.Visible = false;
            toolStripStatusLabel.Visible = false;
        }

        private void searchToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            toolStripStatusLabel.Visible = true;
            toolStripProgressBar1.Visible = true;
            toolStripProgressBar1.Value = 0;
            Search srt = new Search();
            toolStripProgressBar1.Value = 50;
            srt.MdiParent = this;
            toolStripProgressBar1.Value = 75;
            srt.Show();
            toolStripProgressBar1.Value = 100;
            toolStripProgressBar1.Visible = false;
            toolStripStatusLabel.Visible = false;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel.Visible = true;
            toolStripProgressBar1.Visible = true;
            toolStripProgressBar1.Value = 0;
            Settings settings = new Settings();
            toolStripProgressBar1.Value = 50;
            settings.MdiParent = this;
            toolStripProgressBar1.Value = 75;
            settings.Show();
            toolStripProgressBar1.Value = 100;
            toolStripProgressBar1.Visible = false;
            toolStripStatusLabel.Visible = false;
        }

        private void companyInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel.Visible = true;
            toolStripProgressBar1.Visible = true;
            toolStripProgressBar1.Value = 0;
            firminf finf = new firminf();
            toolStripProgressBar1.Value = 50;
            finf.MdiParent = this;
            toolStripProgressBar1.Value = 75;
            finf.Show();
            toolStripProgressBar1.Value = 100;
            toolStripProgressBar1.Visible = false;
            toolStripStatusLabel.Visible = false;
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel.Visible = true;
            toolStripProgressBar1.Visible = true;
            toolStripProgressBar1.Value = 0;
            info inf = new info();
            toolStripProgressBar1.Value = 50;
            inf.MdiParent = this;
            toolStripProgressBar1.Value = 75;
            inf.Show();
            toolStripProgressBar1.Value = 100;
            toolStripProgressBar1.Visible = false;
            toolStripStatusLabel.Visible = false;
        }
    }
}
