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
    public partial class ACman : Form
    {
        MySqlConnection conn = Param.GetDBConnection();

        public ACman()
        {
            InitializeComponent();
            LoadData_Grid();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
/*
 * ------------------Заполнение Таблицы Grid---------------------------------
 */
        private void LoadData_Grid()  // Таблица из базы данных
        {
            conn.Open();

            string query = "Select * From Users Order By Uname";   //Выделить имена пользователей из таблицы Пользователи

            MySqlCommand command = new MySqlCommand(query, conn);

            MySqlDataReader GV_Table = command.ExecuteReader();

            List<string[]> data = new List<string[]>();  // заполнить таблицу в 3 колонки

            while (GV_Table.Read())
            {
                data.Add(new string[3]);

                data[data.Count - 1][0] = GV_Table[0].ToString();
                data[data.Count - 1][1] = GV_Table[1].ToString();
                data[data.Count - 1][2] = GV_Table[2].ToString();

            }

            GV_Table.Close();

            conn.Close();

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
                            textBox1.Text = dataGridView1.Rows[i].Cells[j].Value.ToString();
                            break;
                        }
            }
        }

        private void Search_tacm_TextChanged(object sender, EventArgs e)
        {

        }

        private void ACman_Load(object sender, EventArgs e)
        {
/*
 * ------------------Заполнить ComboBox из таблицы названиями Ролей--------------
 */
            comboBox1.Items.Clear();
            conn.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT Role FROM users", conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            DataTable dt = ds.Tables[0].DefaultView.ToTable(true, "Role");
            comboBox1.DataSource = dt;
            comboBox1.ValueMember = "Role";
            conn.Close();
/*
 * -----------------------------Конец Поля------------------------------------
 */
        }
/*
-----------------------Проверка Имени Пользователя----------------------------
*/
        public bool Login_check(string z) // Проверка логина
        {
            bool x;

            conn.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter("Select Uname From Users Where Uname='" + z + "'", conn); // Выбираем из базы Имя пользователся
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1) // Если количество строк равно 1 то переходим в блок ошибка
                x = false;
            else                    // Иначе передаем переменной х значение истина
                x = true;

            conn.Close();
            return x;
        }
/*
 * ----------------------Проверка Пароля---------------------------------------
 */
      public bool  Pass_check(string z)   
        {
            bool x;
            if (textBox2.Text != textBox1.Text && textBox2.Text.Length  >= 6)  // Если Пароль не совпадает с Логином и Длина пароля больше 6 символов то Истина
                x = true;
            else
                x = false;                                                      // Иначе переходим в блок ошибки
            return x;
        }
/*
 * --------------------Событие Нажатие Кнопки Create Account------------------
 */

        private void button1_Click(object sender, EventArgs e)
        {



            if (Login_check(textBox1.Text) && Pass_check(textBox2.Text) && comboBox1 != null)  // Если Имя пользователя Истино И НЕ равно null И Пароль Истина ТО
                {

                conn.Open();
                MySqlCommand cmd = new MySqlCommand(@" Insert Into users
                    (Uname, Pass, Role)Values ('" +textBox1.Text+ "','" +textBox2.Text+"','"+comboBox1.Text+"')", conn); // Содаем пользователя Имя + Пароль + Роль
                cmd.ExecuteNonQuery();
                conn.Close();
                
                MessageBox.Show
                (
                  "Ready",
                  "Ready",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information,
                  MessageBoxDefaultButton.Button1,
                  MessageBoxOptions.DefaultDesktopOnly
                  );
                }
            else
            {
               MessageBox.Show
               (
                "Invalid username or password",
                "Error",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error,
                 MessageBoxDefaultButton.Button1,
                 MessageBoxOptions.DefaultDesktopOnly
                );
            }



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Delete From Users Where Uname='" + textBox1.Text + "'", conn); // Удаляем пользователя
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show
                (
                  "Ready",
                  "Ready",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information,
                  MessageBoxDefaultButton.Button1,
                  MessageBoxOptions.DefaultDesktopOnly
                  );
        }
    }
}
