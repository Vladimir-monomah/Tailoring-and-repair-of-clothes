using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Пошив_и_ремонт_одежды.пошив_и_ремонт_одеждыDataSetTableAdapters;
using static Пошив_и_ремонт_одежды.пошив_и_ремонт_одеждыDataSet;

namespace Пошив_и_ремонт_одежды
{
    public partial class Вход_в_программу : Form
    {
        private const int UpdateMessagePeriod = 1000;

        const string FilterNonAdministrators = "([Является администратором] = FALSE)";
        const string FilterNonDeletedMessagesByReciver = "([Удалено получателем] = FALSE)";
        const string FilterSendedMessages = "([Удалено отправителем] = FALSE)";
        private string textBoxOrdersFilter;
        private string readyOrNotReadyOrdersFilter;

        private int inputMessagesTimerId;
        private int outputMessagesTimerId;
        private int deletedMessagesTimerId;

        private Dictionary<DataGridView, int> currentDataGridViewRowPosition = new Dictionary<DataGridView, int>();
        private bool dataUpdating = false;

        public Вход_в_программу()
        {
            InitializeComponent();
        }

        private void Вход_в_программу_Load(object sender, EventArgs e)
        {
            this.тип_одеждыTableAdapter.Fill(this.пошив_и_ремонт_одеждыDataSet.Тип_одежды);
            this.вид_работTableAdapter.Fill(this.пошив_и_ремонт_одеждыDataSet.Вид_работ);
            this.заказы_с_клиентамиTableAdapter.Fill(this.пошив_и_ремонт_одеждыDataSet.Заказы_с_клиентами);

            this.пользователиBindingSource.Filter = FilterNonAdministrators;
            this.пользователиTableAdapter.Fill(this.пошив_и_ремонт_одеждыDataSet.Пользователи);

            // Отправленные сообщения
            this.сообщения_для_администраторов_отправленныеTableAdapter.Fill(
                this.пошив_и_ремонт_одеждыDataSet.Сообщения_для_администраторов_отправленные);
            this.сообщенияДляАдминистраторовОтправленныеBindingSource.Filter = FilterSendedMessages;
            this.outputMessagesTimerId = EmailService.StartCheckingNewMessages(
                new EmailService.UpdateTimerParameters
                {
                    ChangingTextControl = this.outcommingMessagesTabPanel,
                    BaseControlText = this.outcommingMessagesTabPanel.Text,
                    CountingPredicate = (entity) =>
                        !(entity as Сообщения_для_администраторов_отправленныеRow).Прочитано_получателем,
                    Interval = UpdateMessagePeriod,
                    UpdatedTable = this.пошив_и_ремонт_одеждыDataSet.Сообщения_для_администраторов_отправленные,
                    UpdatingTableAdapter = this.сообщения_для_администраторов_отправленныеTableAdapter.Adapter,
                    CountingDataBindingSource = this.сообщенияДляАдминистраторовОтправленныеBindingSource
                });

            // Полученные сообщения
            this.сообщения_для_администраторовTableAdapter.Fill(
                this.пошив_и_ремонт_одеждыDataSet.Сообщения_для_администраторов);
            this.сообщенияДляАдминистраторовBindingSource.Filter = FilterNonDeletedMessagesByReciver;
            this.inputMessagesTimerId = EmailService.StartCheckingNewMessages(
                new EmailService.UpdateTimerParameters
                {
                    ChangingTextControl = this.incomingMessagesTabPanel,
                    BaseControlText = this.incomingMessagesTabPanel.Text,
                    CountingPredicate = (entity) =>
                        !(entity as Сообщения_для_администраторовRow).Прочитано_получателем,
                    Interval = UpdateMessagePeriod,
                    UpdatedTable = this.пошив_и_ремонт_одеждыDataSet.Сообщения_для_администраторов,
                    UpdatingTableAdapter = this.сообщения_для_администраторовTableAdapter.Adapter,
                    CountingDataBindingSource = this.сообщенияДляАдминистраторовBindingSource
                });

            // Удаленные сообщения
            this.сообщения_для_администраторов_удаленныеTableAdapter.Fill(
                this.пошив_и_ремонт_одеждыDataSet.Сообщения_для_администраторов_удаленные);
            this.deletedMessagesTimerId = EmailService.StartCheckingNewMessages(
                new EmailService.UpdateTimerParameters
                {
                    CountingPredicate = (entity) => false,
                    Interval = UpdateMessagePeriod,
                    UpdatedTable = this.пошив_и_ремонт_одеждыDataSet.Сообщения_для_администраторов_удаленные,
                    UpdatingTableAdapter = this.сообщения_для_администраторов_удаленныеTableAdapter.Adapter,
                    CountingDataBindingSource = this.сообщенияДляАдминистраторовУдаленныеBindingSource
                });
        }

        /// <summary>
        /// Фильтрация пользователей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clientFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            var findFields = new[] { "[номер телефона]", "Фамилия", "Имя", "Отчество" };
            var filterString = EntityManager.GetFilterStringByFields(findFields, this.clientFilterTextBox.Text).Trim();

            this.пользователиBindingSource.Filter = FilterNonAdministrators;
            if (!string.IsNullOrEmpty(filterString))
            {
                this.пользователиBindingSource.Filter += $" AND ({filterString})";
            }
        }

        /// <summary>
        /// Добавление пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            (new ДобавлениеКлиента()).ShowDialog();
            this.пользователиTableAdapter.Fill(this.пошив_и_ремонт_одеждыDataSet.Пользователи);
        }

        /// <summary>
        /// Фильтрует заказы по строке поиска, учитывая фильтрацию по готовности
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void orderFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            var findFields = new[] { "ФИО", "[вид работы]", "[тип одежды]" };
            this.textBoxOrdersFilter =
                EntityManager.GetFilterStringByFields(findFields, this.orderFilterTextBox.Text).Trim();

            this.заказыСКлиентамиBindingSource.Filter = EntityManager.UnionFilter(
                this.textBoxOrdersFilter,
                this.readyOrNotReadyOrdersFilter);
        }

        /// <summary>
        /// Добавление заказов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addOrderButton_Click(object sender, EventArgs e)
        {
            (new Добавление_заказа()).ShowDialog();
            this.заказы_с_клиентамиTableAdapter.Fill(this.пошив_и_ремонт_одеждыDataSet.Заказы_с_клиентами);
        }

        /// <summary>
        /// Обновляет информацию в бд об отредактированном заказе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewReadyOrders_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var changedRow = (Заказы_с_клиентамиRow)((DataRowView)((DataGridView)sender).CurrentRow.DataBoundItem).Row;
            var orderTable = EntityManager.FilterOrders($"Идентификатор = {changedRow.Номер_заказа}");

            orderTable[0].заказ_готов = changedRow.Заказ_готов;
            orderTable[0].Цена = changedRow.Цена;
            // TODO Сделать возможность редактирования вида работы и типа одежды
            // orderTable[0].Вид_работы = changedRow.Вид_работы;
            // orderTable[0].тип_одежды = changedRow.тип_одежды;
            EntityManager.UpdateOrders();
        }

        /// <summary>
        /// Обновляет информацию в бд об отредактированном клиенте
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewClient_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var changedRow = (ПользователиRow)((DataRowView)((DataGridView)sender).CurrentRow.DataBoundItem).Row;
            var userTable = EntityManager.FilterUsers($"Идентификатор = {changedRow.Идентификатор}");

            userTable[0].Идентификатор = changedRow.Идентификатор;
            userTable[0].Фамилия = changedRow.Фамилия;
            userTable[0].Имя = changedRow.Имя;
            userTable[0].Отчество = changedRow.Отчество;
            userTable[0].номер_телефона = changedRow.номер_телефона;
            userTable[0]._E_mail = changedRow._E_mail;

            EntityManager.UpdateUsers();

            this.заказы_с_клиентамиTableAdapter.Fill(this.пошив_и_ремонт_одеждыDataSet.Заказы_с_клиентами);
        }

        /// <summary>
        /// Переключает фильтрацию заказов по полю "Заказ готов": true, false, all
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void readyOrdersFilterCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            switch (this.readyOrdersFilterCheckBox.CheckState)
            {
                case CheckState.Checked:
                    this.readyOrNotReadyOrdersFilter = "[Заказ готов] = TRUE";
                    this.readyOrdersFilterCheckBox.Text = "Отображаются готовые заказы";
                    break;

                case CheckState.Indeterminate:
                    this.readyOrNotReadyOrdersFilter = string.Empty;
                    this.readyOrdersFilterCheckBox.Text = "Отображаются все заказы";
                    break;

                case CheckState.Unchecked:
                    this.readyOrNotReadyOrdersFilter = "[Заказ готов] = FALSE";
                    this.readyOrdersFilterCheckBox.Text = "Отображаются неготовые заказы";
                    break;
            }

            this.заказыСКлиентамиBindingSource.Filter = EntityManager.UnionFilter(
                this.textBoxOrdersFilter,
                this.readyOrNotReadyOrdersFilter);
        }

        /// <summary>
        /// Останавливает все запущенные таймеры
        /// </summary>
        private void StopUpdateTimers()
        {
            EmailService.StopCheckingNewMessages(this.inputMessagesTimerId);
            EmailService.StopCheckingNewMessages(this.outputMessagesTimerId);
            EmailService.StopCheckingNewMessages(this.deletedMessagesTimerId);
        }

        /// <summary>
        /// Отправляет сообщение выбранному пользователю
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sendEmailButton_Click(object sender, EventArgs e)
        {
            if (this.userAdresseesComboBox.SelectedItem == null)
            {
                throw new Exception("Необходимо выбрать пользователя!");
            }

            if (string.IsNullOrEmpty(this.emailMessageTextBox.Text))
            {
                throw new Exception("Необходимо ввести текст сообщения!");
            }

            EmailService.SendEmail(
                null,
                (int)this.userAdresseesComboBox.SelectedValue,
                this.emailSubjectTextBox.Text,
                this.emailMessageTextBox.Text);
        }

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex == 2)
            {
                // Реагируем только на вкладку почты
                try
                {
                    this.пользователи_для_заказовTableAdapter.Fill(this.пошив_и_ремонт_одеждыDataSet.Пользователи_для_заказов);
                }
                catch
                {
                    // Если не загрузится, ничего страшного, надо будет перезайти на вкладку
                }
            }
        }

        /// <summary>
        /// Запоминает текущее положение курсора для каждого грида,
        /// чтобы при обновлении выделенная строка не сбрасывалась
        /// </summary>
        private void SetCurrentRowPosition(DataGridView mailDataGridView, int rowIndex)
        {
            if (mailDataGridView == null)
            {
                return;
            }

            if (this.dataUpdating)
            {
                return;
            }

            this.currentDataGridViewRowPosition[mailDataGridView] = rowIndex;
        }

        /// <summary>
        /// Запоминает позицию выделенной мышью строки, чтобы восстановить при перезагрузке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void messagesDataGridView_CellClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.SetCurrentRowPosition(sender as DataGridView, e.RowIndex);
        }

        /// <summary>
        /// Устанавливает курсор на сохранённую позицию после перезагрузки всех элементов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void messagesDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var mailDataGridView = sender as DataGridView;
            if (mailDataGridView == null)
            {
                return;
            }

            if (this.currentDataGridViewRowPosition.TryGetValue(mailDataGridView, out var currentRowIndex))
            {
                currentRowIndex = Math.Min(currentRowIndex, mailDataGridView.RowCount - 1);
                if (currentRowIndex > -1)
                {
                    this.dataUpdating = true;
                    mailDataGridView.CurrentCell = mailDataGridView[0, currentRowIndex];
                    this.dataUpdating = false;
                }
            }
        }

        /// <summary>
        /// Запоминает позицию выделенной стрелками строки, чтобы восстановить при перезагрузке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void messagesDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            var direction = e.KeyCode == Keys.Down
                ? 1
                : e.KeyCode == Keys.Up
                    ? -1
                    : 0;

            var mailDataGridView = sender as DataGridView;
            if (mailDataGridView?.CurrentCell == null)
            {
                return;
            }

            this.SetCurrentRowPosition(mailDataGridView, mailDataGridView.CurrentCell.RowIndex + direction);
        }

        /// <summary>
        /// Показывает окно с полным текстом сообщения, помечая его прочитанным, если оно во входящих
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void messagesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var mailDataGridView = sender as DataGridView;
            if (mailDataGridView?.CurrentCell == null)
            {
                return;
            }
            
            var message = ((DataRowView)mailDataGridView.CurrentRow.DataBoundItem).Row;
            var subjectMessage = message.GetType().GetProperty("Тема")?.GetValue(message) as string;
            var textMessage = message.GetType().GetProperty("Текст_сообщения")?.GetValue(message) as string;

            if(sender == this.inputMessagesDataGridView)
            {
                // Укажем письмо прочитанным
                var messageCode = message.GetType().GetProperty("Код")?.GetValue(message) as int?
                    ?? message.GetType().GetProperty("Идентификатор_сообщения")?.GetValue(message) as int?;
                if (messageCode.HasValue)
                {
                    EmailService.MarkEmailRed(messageCode.Value);
                }
            }

            (new EmailMessageForm(subjectMessage, textMessage)).ShowDialog();
        }

        /// <summary>
        /// Показывает вопрос об удалении файла
        /// </summary>
        /// <returns>
        /// True - пользователь нажал "Да"
        /// False - пользователь нажал "Нет"
        /// </returns>
        private bool ShowQuestionOnDeleteMessage()
        {
            var pressedButton = MessageBox.Show(
                "Вы действительно хотите удалить сообщение?",
                "Предупреждение",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Stop);
            return pressedButton == DialogResult.OK;
        }

        /// <summary>
        /// Удаляет выделенное сообщение на вкладке "Входящие"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteMessageButton_Click(object sender, EventArgs e)
        {
            if (this.ShowQuestionOnDeleteMessage())
            {
                var удаляемоеСообщение = (Сообщения_для_администраторовRow)
                    ((DataRowView)this.inputMessagesDataGridView.CurrentRow.DataBoundItem).Row;
                EmailService.DeleteEmail(удаляемоеСообщение.Идентификатор_сообщения, удаленоПолучателем: true);
            }
        }

        /// <summary>
        /// Удаляет выделенное сообщение на вкладке "Отправленные"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteOutMessageButton_Click(object sender, EventArgs e)
        {
            if (this.ShowQuestionOnDeleteMessage())
            {
                var удаляемоеСообщение = (Сообщения_для_администраторов_отправленныеRow)
                    ((DataRowView)this.outMessagesDataGridView.CurrentRow.DataBoundItem).Row;
                EmailService.DeleteEmail(удаляемоеСообщение.Идентификатор_сообщения, удаленоОтправителем: true);
            }
        }
    }
}