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
    public partial class FormRegistrationWindow : Form
    {
        public FormRegistrationWindow()
        {
            InitializeComponent();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            Регистрация открыть = new Регистрация();
            открыть.ShowDialog();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите закрыть программу?", "Закрытие программы", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void buttonEntry_Click(object sender, EventArgs e)
        {
            var loginCondition = $"логин = '{textBoxLogin.Text}' AND пароль = '{textBoxPassword.Text}' ";
            var user = EntityManager.FilterUsers(loginCondition).FirstOrDefault();
            if (user != null)
            {
                MessageBox.Show($"Привет, {user.Имя}!");
                if (user.Является_администратором)
                {
                    Вход_в_программу формаАдминистратора = new Вход_в_программу();
                    формаАдминистратора.Show();
                }
                else
                {
                    Вход_в_программу_Клиент формаКлиента = new Вход_в_программу_Клиент(user.Идентификатор);
                    формаКлиента.Show();
                }
            }
            else
            {
                MessageBox.Show("Пользователь не найден");
            }
        }



        private void textBoxLogin_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxPassword.Text == "")
                {
                    textBoxPassword.Focus();
                }
                else
                {
                    buttonEntry.PerformClick();
                }
            }

        }
    }
}
