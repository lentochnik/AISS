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
using System.IO;

namespace AIS
{
    public partial class adpap : Form
    {
        MySqlConnection conn = Param.GetDBConnection();

        public adpap()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        string imname;

        private void payer_save_Click(object sender, EventArgs e)
        {

            MySqlCommand cmd;
            FileStream fs;
            BinaryReader br;
            if (pay_check(pay_number.Text))
            {


                if (payer_inn.Text.Length >= 12 &&
                  payer_kpp.Text.Length >= 9 &&
                  payer_number.Text.Length >= 20 &&
                  payer_bic_bank.Text.Length >= 9 &&
                  payer_bank_accnumber.Text.Length >= 20)
                {
                    try
                    {
                        string FileName = imname;
                        byte[] ImageData;
                        fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                        br = new BinaryReader(fs);
                        ImageData = br.ReadBytes((int)fs.Length);
                        br.Close();
                        fs.Close();
                        string CmdString = "Insert Into pap (idNum, paydata, inn, kpp, payer, paymnum, bank, bic, bpaymnum, summ, mess, img)Values(@idNum, @paydata, @inn, @kpp, @payer, @paymnum, @bank, @bic, @bpaymnum, @summ, @mess, @img)";
                        cmd = new MySqlCommand(CmdString, conn);
                        cmd.Parameters.Add("@idNum", MySqlDbType.Int32, 25);
                        cmd.Parameters.Add("@paydata", MySqlDbType.Date);
                        cmd.Parameters.Add("@inn", MySqlDbType.VarChar, 255);
                        cmd.Parameters.Add("@kpp", MySqlDbType.Int32, 9);
                        cmd.Parameters.Add("@payer", MySqlDbType.VarChar, 255);
                        cmd.Parameters.Add("@paymnum", MySqlDbType.VarChar, 255);
                        cmd.Parameters.Add("@bank", MySqlDbType.VarChar, 255);
                        cmd.Parameters.Add("@bic", MySqlDbType.Int32, 9);
                        cmd.Parameters.Add("@bpaymnum", MySqlDbType.VarChar, 255);
                        cmd.Parameters.Add("@summ", MySqlDbType.Decimal, 12);
                        cmd.Parameters.Add("@mess", MySqlDbType.VarChar, 255);
                        cmd.Parameters.Add("@img", MySqlDbType.Blob);
                        cmd.Parameters["@idNum"].Value = pay_number.Text;
                        cmd.Parameters["@paydata"].Value = dateTimePicker1.Value;
                        cmd.Parameters["@inn"].Value = payer_inn.Text;
                        cmd.Parameters["@kpp"].Value = payer_kpp.Text;
                        cmd.Parameters["@payer"].Value = payer_name.Text;
                        cmd.Parameters["@paymnum"].Value = payer_number.Text;
                        cmd.Parameters["@bank"].Value = payer_bank.Text;
                        cmd.Parameters["@bic"].Value = payer_bic_bank.Text;
                        cmd.Parameters["@bpaymnum"].Value = payer_bank_accnumber.Text;
                        cmd.Parameters["@summ"].Value = Convert(payer_ammount.Text);
                        cmd.Parameters["@mess"].Value = textBox8.Text;
                        cmd.Parameters["@img"].Value = ImageData;
                        conn.Open();

                        int RowsAffected = cmd.ExecuteNonQuery();

                        if (RowsAffected > 0)
                        {
                            conn.Close();
                            this.Close();

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    finally
                    {
                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }
                    }

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

        public object Convert(object value)
        {
            return value.ToString().Replace(",", ".");
        }

        private void payer_ammount_KeyPress(object sender, KeyPressEventArgs e)
            {
            if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == ',') && (payer_ammount.Text.IndexOf(",") == -1) && (payer_ammount.Text.Length != 0))) if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
        }

            private void payer_addscan_Click(object sender, EventArgs e)
            {

                OpenFileDialog opf = new OpenFileDialog();
                opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    imname = opf.FileName;
                    pictureBox1.Image = Image.FromFile(opf.FileName);
                }
            }

            private void adpap_Load(object sender, EventArgs e)
            {

            }
    }
}

