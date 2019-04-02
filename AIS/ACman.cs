using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AIS
{
    public partial class ACman : Form
    {
        public ACman()
        {
            InitializeComponent();
            LoadData_Grid();
        
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadData_Grid()  // Таблица из базы данных
        {
            string connectString = @"Data Source=NIXE-PC\SQLExpress;Initial Catalog=AIS;Integrated Security=True;" +
                "Integrated Security=true;";

            SqlConnection myConnection = new SqlConnection(connectString);

            myConnection.Open();

            string query = "SELECT * FROM Users ORDER BY Uname";

            SqlCommand command = new SqlCommand(query, myConnection);

            SqlDataReader GV_Table = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (GV_Table.Read())
            {
                data.Add(new string[3]);

                data[data.Count - 1][0] = GV_Table[0].ToString();
                data[data.Count - 1][1] = GV_Table[1].ToString();
                data[data.Count - 1][2] = GV_Table[2].ToString();

            }

            GV_Table.Close();

            myConnection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void Search_acm_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(Search_tacm.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void Search_tacm_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
