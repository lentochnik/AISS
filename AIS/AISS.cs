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
            StLab.Text = role; 
            rl = role;

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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // выход
        }

        private void StLab_Click(object sender, EventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void accountManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ACman aCman = new ACman();
            aCman.MdiParent = this;
            aCman.Show();
            
        }

        private void toolStripStatusLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
