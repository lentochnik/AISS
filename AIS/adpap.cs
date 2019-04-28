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
using System.Text.RegularExpressions;

namespace AIS
{
    public partial class adpap : Form
    {
        MySqlConnection conn = Param.GetDBConnection();
        public adpap()
        {
            InitializeComponent();
        }

        Regex reg = new Regex(@"\d");
        


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void payer_save_Click(object sender, EventArgs e)
        {
            if (pay_check(pay_number.Text))
            {
                if (payer_inn.Text.Length >= 12 &&
                    payer_kpp.Text.Length >= 9 &&
                    payer_number.Text.Length >= 20 &&
                    payer_bic_bank.Text.Length >= 9 &&
                    payer_bank_accnumber.Text.Length >= 20)
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(@" Insert Into pap
                    (idNum, paydata, inn, kpp, payer, paymnum, bank, bic, bpaymnum, summ, mess, img)Values
                    ('"
                    + pay_number.Text + "','"
                    + dateTimePicker1.Text + "','"
                    + payer_inn.Text + "','"
                    + payer_kpp.Text + "','"
                    + payer_name.Text + "','"
                    + payer_number.Text + "','"
                    + payer_bank.Text + "','"
                    + payer_bic_bank.Text + "','"
                    + payer_bank_accnumber.Text + "','"
                    + payer_ammount.Text + "','"
                    + textBox8.Text + "','"
                    + pictureBox1.Image +
                    "')", conn); 
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show
                            (
                             "Please check form",
                             "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error,
                              MessageBoxDefaultButton.Button1,
                              MessageBoxOptions.DefaultDesktopOnly
                             );
                }
            }
            else 
            {
                MessageBox.Show
                             (
                              "Pay numder already used",
                              "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error,
                               MessageBoxDefaultButton.Button1,
                               MessageBoxOptions.DefaultDesktopOnly
                              );
            }
        }

        public bool pay_check(string z) // Проверка логина
        {
            bool x;

            conn.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter("Select idNum From pap Where idNum='" + z + "'", conn); // Выбираем из базы Имя пользователся
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1) // Если количество строк равно 1 то переходим в блок ошибка
                x = false;
            else                    // Иначе передаем переменной х значение истина
                x = true;

            conn.Close();
            return x;
        }

        private void payer_inn_TextChanged(object sender, EventArgs e)
        {

        }

        private void payer_inn_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!Char.IsDigit(num))
            {
                e.Handled = true;
            }
        }

        private void payer_kpp_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!Char.IsDigit(num))
            {
                e.Handled = true;
            }
        }

        private void payer_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!Char.IsDigit(num))
            {
                e.Handled = true;
            }
        }

        private void payer_bic_bank_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!Char.IsDigit(num))
            {
                e.Handled = true;
            }
        }

        private void payer_bank_accnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!Char.IsDigit(num))
            {
                e.Handled = true;
            }
        }

        private void payer_ammount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!Char.IsDigit(num))
            {
                e.Handled = true;
            }
        }

        private void payer_addscan_Click(object sender, EventArgs e)
        {
            Bitmap image; //Bitmap для открываемого изображения

            OpenFileDialog open_dialog = new OpenFileDialog(); //создание диалогового окна для выбора файла
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"; //формат загружаемого файла
            if (open_dialog.ShowDialog() == DialogResult.OK) //если в окне была нажата кнопка "ОК"
            {
                try
                {
                    image = new Bitmap(open_dialog.FileName);
                    this.pictureBox1.Size = pictureBox1.Size;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Image = image;
                    pictureBox1.Invalidate();
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Error, can not open this file!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void adpap_Load(object sender, EventArgs e)
        {

        }
    }
}
