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
    public partial class Client_Info : Form
    {
        public Client_Info()
        {
            InitializeComponent();

            Clegform.DropDownStyle = ComboBoxStyle.DropDownList;
            Clegform.SelectedIndex = 1;

            Ccur.DropDownStyle = ComboBoxStyle.DropDownList;
            Ccur.SelectedIndex = 0;

            Ccountr.DropDownStyle = ComboBoxStyle.DropDownList;
            Ccountr.SelectedIndex = 100;
        }

        MySqlConnection conn = Param.GetDBConnection();

        private void Client_Info_Load(object sender, EventArgs e)
        {
       
        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clegform_Load(object sender, EventArgs e)
        {
            
        }

        private void Clegform_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Clegform.Text == "Entity")
            {
                Lab_Cname.Visible = false;
                Cname.Visible = false;
                Lab_Csurname.Visible = false;
                Csurname.Visible = false;
                Lab_Cpatr.Visible = false;
                Cpatr.Visible = false;

                Lab_CCompname.Visible = true;
                CCompname.Visible = true;
            }
            else
            {
                Lab_Cname.Visible = true;
                Cname.Visible = true;
                Lab_Csurname.Visible = true;
                Csurname.Visible = true;
                Lab_Cpatr.Visible = true;
                Cpatr.Visible = true;

                Lab_CCompname.Visible = false;
                CCompname.Visible = false;
            }
        }

        private void But_CIcreate_Click(object sender, EventArgs e)
        {

/*---------------------------Генерируется номер заявки------------------------------------------------------*
 *  Год + Юр/Физ(0/1) + Страна(0-193) + валюта(0-2) + 3 последних цифры ИНН + 3 послед. цифры кпп           *
 *                              Пример: 2019 1 100 0 398 351                                                *
 *----------------------------------------------------------------------------------------------------------*/                              
           
            string a1 = DateTime.Now.Year.ToString();
            string a = Cinn.Text.Remove(0, 9);
            string b = Ckpp.Text.Remove(0, 6);
            int c = Clegform.SelectedIndex;
            int d = Ccountr.SelectedIndex;
            int f = Ccur.SelectedIndex;
            string abc = a1 + c + d + f + a + b;
            Cclinum.Text = abc;
/*-------------------------Конец Генератора------------------------------------------------------------------*/

            
         m:   if (ID_check(abc)) // проверка ключа
            {
                
                if (Cinn.Text.Length >= 12 &&
                    Ckpp.Text.Length >= 9 &&
                    Caccnum.Text.Length >= 20)
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(@" Insert Into clients
                    (Id, name, sname, patr, company, inn, kpp, accountnum, country, region, street, adr1, postcod,
                     fax, email, tel, lform, curren, accounamoun)Values
                    ('"
                    + abc + "','"
                    + Cname.Text + "','"
                    + Csurname.Text + "','"
                    + Cpatr.Text + "','"
                    + CCompname.Text + "','"
                    + Cinn.Text + "','"
                    + Ckpp.Text + "','"
                    + Caccnum.Text + "','"
                    + Ccountr.Text + "','"
                    + Creg.Text + "','"
                    + Cstreet.Text + "','"
                    + Cadrs2.Text + "','"
                    + Cpcod.Text + "','"
                    + Cfax.Text + "','"
                    + Cemail.Text + "','"
                    + Ctel.Text + "','"
                    + Clegform.Text + "','"
                    + Ccur.Text + "','"
                    + "0" + 
                    "')", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    this.Close();
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
                abc += 1; // если вводится повторный номер клиента то добавляем к неомеру 1 (не +1)
                goto m;  
            };
        }


        public bool ID_check(string z) // Проверка Номера клиента
        {
            bool x;

            conn.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter("Select Id From Clients Where Id='" + z + "'", conn); // номер ID из базы клиентов
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1) // Если количество строк равно 1 то переходим в блок ошибка
                x = false;
            else                    // Иначе передаем переменной х значение истина
                x = true;

            conn.Close();
            return x;
        }
        private void Cclinum_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cinn_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!Char.IsDigit(num))
            {
                e.Handled = true;
            }
        }

        private void Ckpp_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!Char.IsDigit(num))
            {
                e.Handled = true;
            }
        }

        private void Caccnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!Char.IsDigit(num))
            {
                e.Handled = true;
            }
        }

       

        private void Ccountr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Ccountr.SelectedIndex == 100)
            {
                Ctel.Mask = "+7(000)000-00-00";
                Cfax.Mask = "+7(000)000-00-00";
            }
            else
            {
                Ctel.Mask = "+000(00)000-00-00";
                Cfax.Mask = "+000(00)000-00-00";
            }
        }

        private void Ctel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }

        private void Ctel_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!Char.IsDigit(num))
            {
                e.Handled = true;
            }
        }

        private void Cfax_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!Char.IsDigit(num))
            {
                e.Handled = true;
            }
        }
    }

}
