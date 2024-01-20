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
    public partial class Добавление_заказа : Form
    {
        public Добавление_заказа()
        {
            InitializeComponent();
        }

        private void Добавление_заказа_Load(object sender, EventArgs e)
        {
            this.тип_одеждыTableAdapter.Fill(this.пошив_и_ремонт_одеждыDataSet.Тип_одежды);
            this.вид_работTableAdapter.Fill(this.пошив_и_ремонт_одеждыDataSet.Вид_работ);
            this.пользователи_для_заказовTableAdapter.Fill(this.пошив_и_ремонт_одеждыDataSet.Пользователи_для_заказов);

            orderPriceComboBox_SelectedValueChanged(null, null);
        }

        /// <summary>
        /// Добавляет заказ в таблицу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addOrderButton_Click(object sender, EventArgs e)
        {
            var newOrder = EntityManager.OrderDataTable.NewЗаказыRow();
            
            newOrder.Номер_клиента = (int)this.clientComboBox.SelectedValue;
            newOrder.Вид_работы = (int)this.workKindComboBox.SelectedValue;
            newOrder.Тип_одежды = (int)this.dressTypeComboBox.SelectedValue;
            newOrder.Цена = this.priceNumericUpDown.Value;

            EntityManager.OrderDataTable.AddЗаказыRow(newOrder);
            EntityManager.UpdateOrders();

            MessageBox.Show("Заказ успешно добавлен");
            this.Close();
        }

        /// <summary>
        /// Загружает цену из таблицы "Цены работ", если выбранная пара значений "Тип одежды" и "Вид работы"
        /// найдена в соответствующих полях
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void orderPriceComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if(workKindComboBox.SelectedItem == null || dressTypeComboBox.SelectedItem == null)
            {
                return;
            }

            var filterCondition = $"[Вид работы] = {this.workKindComboBox.SelectedValue} AND [Тип одежды] = {this.dressTypeComboBox.SelectedValue}";
            var foundRowWorkPrices = EntityManager.FilterWorkPrices(filterCondition).FirstOrDefault();
            this.priceNumericUpDown.Value = foundRowWorkPrices?.Цена as decimal? ?? 0m;
        }
    }
}