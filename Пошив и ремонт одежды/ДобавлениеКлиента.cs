using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Пошив_и_ремонт_одежды
{
    public partial class ДобавлениеКлиента : Form
    {
        public ДобавлениеКлиента()
        {
            InitializeComponent();
        }

        private void addClientButton_Click(object sender, EventArgs e)
        {
            if (!CheckTextBoxes())
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            var newUser = EntityManager.UserDataTable.NewПользователиRow();
            newUser.Фамилия = this.textBoxSurname.Text;
            newUser.Имя = this.textBoxName.Text;
            newUser.Отчество = this.textBoxPatronymic.Text;
            newUser.номер_телефона = this.textBoxTelefon.Text;
            newUser._E_mail = this.textBoxEmail.Text;
            EntityManager.UserDataTable.AddПользователиRow(newUser);
            EntityManager.UpdateUsers();

            MessageBox.Show("Клиент успешно добавлен");
            this.Close();
        }

        private bool CheckTextBoxes()
        {

            if (textBoxSurname.Text == "" || textBoxName.Text == "" ||
                textBoxPatronymic.Text == "" || textBoxTelefon.Text == ""
                || textBoxEmail.Text == "")

            {
                return false;
            }

            return true;

        }

        private void textBoxSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void textBoxTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (char.IsLetter(c))
            {
                e.Handled = true;
            }
        }
    }
}
