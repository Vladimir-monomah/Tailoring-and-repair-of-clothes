using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static Пошив_и_ремонт_одежды.пошив_и_ремонт_одеждыDataSet;

namespace Пошив_и_ремонт_одежды
{
    public partial class Вход_в_программу_Клиент : Form
    {
        private const int UpdateMessagePeriod = 1000;

        private readonly string ordersFilter;

        private readonly string userMessagesFilter;
        private readonly string userOutputMessagesFilter;

        private string textBoxOrdersFilter;
        private string readyOrNotReadyOrdersFilter;
        private string userDeletedMessagesFilter;

        private int currentUserId;

        private int inputMessagesTimerId;
        private int outputMessagesTimerId;
        private int deletedMessagesTimerId;

        private Dictionary<DataGridView, int> currentDataGridViewRowPosition = new Dictionary<DataGridView, int>();
        private bool dataUpdating = false;

        public Вход_в_программу_Клиент(int userId)
        {
            this.currentUserId = userId;
            this.ordersFilter = $"([Номер клиента] = {userId})";

            // Сообщения
            this.userMessagesFilter = $"([Получатель] = {userId}) AND ([Удалено получателем] = FALSE)";
            this.userOutputMessagesFilter = $"([Отправитель] = {userId}) AND ([Удалено отправителем] = FALSE)";
            this.userDeletedMessagesFilter = $"([Отправитель] = {userId}) OR ([Получатель] = {userId})";

            InitializeComponent();
        }

        private void Вход_в_программу_Клиент_Load(object sender, EventArgs e)
        {
            this.заказыДляКлиентаBindingSource.Filter = this.textBoxOrdersFilter = this.ordersFilter;
            this.заказы_для_клиентаTableAdapter.Fill(this.пошив_и_ремонт_одеждыDataSet.Заказы_для_клиента);

            this.цены_работ_для_клиентаTableAdapter.Fill(this.пошив_и_ремонт_одеждыDataSet.Цены_работ_для_клиента);

            this.сообщенияBindingSource.Filter = this.userMessagesFilter;
            this.сообщенияTableAdapter.Fill(this.пошив_и_ремонт_одеждыDataSet.Сообщения);

            // Полученные сообщения
            this.inputMessagesTimerId = EmailService.StartCheckingNewMessages(
                new EmailService.UpdateTimerParameters
                {
                    ChangingTextControl = this.EmailTabPage,
                    BaseControlText = this.EmailTabPage.Text,
                    CountingPredicate = (entity) => !(entity as СообщенияRow).Прочитано_получателем,
                    Interval = UpdateMessagePeriod,
                    UpdatedTable = this.пошив_и_ремонт_одеждыDataSet.Сообщения,
                    UpdatingTableAdapter = this.сообщенияTableAdapter.Adapter,
                    CountingDataBindingSource = this.сообщенияBindingSource
                });

            // Отправленные сообщения
            this.исходящиеСообщенияBindingSource.Filter = this.userOutputMessagesFilter;
            this.outputMessagesTimerId = EmailService.StartCheckingNewMessages(
                new EmailService.UpdateTimerParameters
                {
                    ChangingTextControl = this.outputMessagesTabPage,
                    BaseControlText = this.outputMessagesTabPage.Text,
                    CountingPredicate = (entity) => !(entity as СообщенияRow).Прочитано_получателем,
                    Interval = UpdateMessagePeriod,
                    UpdatedTable = this.пошив_и_ремонт_одеждыDataSet.Сообщения,
                    UpdatingTableAdapter = this.сообщенияTableAdapter.Adapter,
                    CountingDataBindingSource = this.исходящиеСообщенияBindingSource
                });

            // Удалённые сообщения
            this.удаленныеСообщенияBindingSource.Filter = this.userDeletedMessagesFilter;
            this.сообщенияДляКлиентовУдаленныеTableAdapter.Fill(
                this.пошив_и_ремонт_одеждыDataSet.Сообщения_для_клиентов_удаленные);
            this.deletedMessagesTimerId = EmailService.StartCheckingNewMessages(
                new EmailService.UpdateTimerParameters
                {
                    CountingPredicate = (entity) => false,
                    Interval = UpdateMessagePeriod,
                    UpdatedTable = this.пошив_и_ремонт_одеждыDataSet.Сообщения_для_клиентов_удаленные,
                    UpdatingTableAdapter = this.сообщенияДляКлиентовУдаленныеTableAdapter.Adapter,
                    CountingDataBindingSource = this.удаленныеСообщенияBindingSource
                });
        }

        private void orderFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            var findFields = new[] { "[Вид работы]", "[Тип одежды]" };
            var filterString =
                EntityManager.GetFilterStringByFields(findFields, this.orderFilterTextBox.Text).Trim();

            this.textBoxOrdersFilter = this.ordersFilter;
            if (!string.IsNullOrEmpty(filterString))
            {
                this.textBoxOrdersFilter += $" AND ({filterString})";
            }

            this.заказыДляКлиентаBindingSource.Filter = EntityManager.UnionFilter(
                this.textBoxOrdersFilter,
                this.readyOrNotReadyOrdersFilter);
        }

        private void priceListFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            var findFields = new[] { "[Вид работы]", "[Тип одежды]" };
            var filterString =
                EntityManager.GetFilterStringByFields(findFields, this.priceListFilterTextBox.Text).Trim();

            this.ценыРаботДляКлиентаBindingSource.Filter = filterString;
        }

        private void clientOrdersFilterCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            switch (this.clientOrdersFilterCheckBox.CheckState)
            {
                case CheckState.Checked:
                    this.readyOrNotReadyOrdersFilter = "[Заказ готов] = TRUE";
                    this.clientOrdersFilterCheckBox.Text = "Отображаются готовые заказы";
                    break;

                case CheckState.Indeterminate:
                    this.readyOrNotReadyOrdersFilter = string.Empty;
                    this.clientOrdersFilterCheckBox.Text = "Отображаются все заказы";
                    break;

                case CheckState.Unchecked:
                    this.readyOrNotReadyOrdersFilter = "[Заказ готов] = FALSE";
                    this.clientOrdersFilterCheckBox.Text = "Отображаются неготовые заказы";
                    break;
            }

            this.заказыДляКлиентаBindingSource.Filter = EntityManager.UnionFilter(
                this.textBoxOrdersFilter,
                this.readyOrNotReadyOrdersFilter);
        }

        private void updateOrdersButton_Click(object sender, EventArgs e)
        {
            this.заказы_для_клиентаTableAdapter.Fill(this.пошив_и_ремонт_одеждыDataSet.Заказы_для_клиента);
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

        private void emailSendButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(this.emailMessageTextBox.Text))
            {
                throw new Exception("Необходимо ввести текст сообщения!");
            }

            EmailService.SendEmail(
                this.currentUserId,
                null,
                this.emailSubjectTextBox.Text,
                this.emailMessageTextBox.Text);
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
        /// Удаляет выделенное сообщение на вкладке "Входящие"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteMessageButton_Click(object sender, EventArgs e)
        {
            var pressedButton = MessageBox.Show(
                "Вы действительно хотите удалить сообщение?",
                "Предупреждение",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Stop);
            if (pressedButton != DialogResult.OK)
            {
                return;
            }

            var удаляемоеСообщение = (Сообщения_для_администраторовRow)
                ((DataRowView)this.inputMessagesDataGridView.CurrentRow.DataBoundItem).Row;
            EmailService.DeleteEmail(удаляемоеСообщение.Идентификатор_сообщения, удаленоПолучателем: true);
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

            if (sender == this.inputMessagesDataGridView)
            {
                // Укажем письмо прочитанным
                var messageCode = message.GetType().GetProperty("Код")?.GetValue(message) as int?;
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
        private void inputMessageDeleteButton_Click(object sender, EventArgs e)
        {
            if (this.ShowQuestionOnDeleteMessage())
            {
                var удаляемоеСообщение = (СообщенияRow)
                    ((DataRowView)this.inputMessagesDataGridView.CurrentRow.DataBoundItem).Row;
                EmailService.DeleteEmail(удаляемоеСообщение.Код, удаленоПолучателем: true);
            }
        }

        /// <summary>
        /// Удаляет выделенное сообщение на вкладке "Отправленные"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void outputMessageDeleteButton_Click(object sender, EventArgs e)
        {
            if (this.ShowQuestionOnDeleteMessage())
            {

                var удаляемоеСообщение = (СообщенияRow)
                    ((DataRowView)this.outputMessagesDataGridView.CurrentRow.DataBoundItem).Row;
                EmailService.DeleteEmail(удаляемоеСообщение.Код, удаленоОтправителем: true);
            }
        }
    }
}