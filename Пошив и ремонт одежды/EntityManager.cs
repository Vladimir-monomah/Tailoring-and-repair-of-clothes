using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Пошив_и_ремонт_одежды.пошив_и_ремонт_одеждыDataSetTableAdapters;
using static Пошив_и_ремонт_одежды.пошив_и_ремонт_одеждыDataSet;
using System.Data.OleDb;
using System.Data;

namespace Пошив_и_ремонт_одежды
{
    public static class EntityManager
    {
        static пошив_и_ремонт_одеждыDataSet пошивИРемонтОдеждыDataSet = new пошив_и_ремонт_одеждыDataSet();

        private static ЗаказыTableAdapter заказыTableAdapter = new ЗаказыTableAdapter();
        private static ПользователиTableAdapter пользователиTableAdapter = new ПользователиTableAdapter();
        private static Цены_работTableAdapter ценыРаботTableAdapter = new Цены_работTableAdapter();
        private static СообщенияTableAdapter сообщенияTableAdapter = new СообщенияTableAdapter();

        static EntityManager()
        {
            // Костыль заменяет оригинальную команду обновления строк во избежание ошибки "Нарушение параллелизма"
            var заказыUpdateCommand = заказыTableAdapter.Adapter.UpdateCommand;
            заказыUpdateCommand.CommandText = "UPDATE `Заказы` SET `Номер клиента` = ?, `заказ готов` = ?, `Вид работы` = ?," +
                " `Тип одежды` = ?, `Цена` = ? WHERE (`Идентификатор` = ?)";
            var parameters = заказыUpdateCommand.Parameters;
            while (parameters.Count > 6)
            {
                заказыTableAdapter.Adapter.UpdateCommand.Parameters.RemoveAt(6);
            }
        }

        public static ПользователиDataTable UserDataTable
        {
            get
            {
                return пошивИРемонтОдеждыDataSet.Пользователи;
            }
        }

        public static ЗаказыDataTable OrderDataTable
        {
            get
            {
                return пошивИРемонтОдеждыDataSet.Заказы;
            }
        }

        public static Цены_работDataTable WorkPrices
        {
            get
            {
                return пошивИРемонтОдеждыDataSet.Цены_работ;
            }
        }

        public static СообщенияDataTable MessageDataTable
        {
            get
            {
                return пошивИРемонтОдеждыDataSet.Сообщения;
            }
        }

        public static void UpdateUsers()
        {
            пользователиTableAdapter.Adapter.Update(UserDataTable);
        }

        public static void UpdateOrders()
        {
            заказыTableAdapter.Adapter.Update(OrderDataTable);
            OrderDataTable.AcceptChanges();
        }

        public static void UpdateWorkPrices()
        {
            ценыРаботTableAdapter.Adapter.Update(WorkPrices);
        }

        internal static void UpdateMessages()
        {
            сообщенияTableAdapter.Adapter.Update(MessageDataTable);
        }

        /// <summary>
        /// Возвращает отфильтрованную таблицу заказов по условию <paramref name="condition"/>
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static ЗаказыDataTable FilterOrders(string condition = null)
        {
            var whereCondition = string.Empty;
            if (!string.IsNullOrEmpty(condition))
            {
                whereCondition = $"WHERE {condition}";
            }

            var filterOrderCommand = new OleDbCommand()
            {
                Connection = заказыTableAdapter.Connection,
                CommandText = "SELECT Идентификатор, [Номер клиента], [вид работы], [тип одежды], [заказ готов] " +
                $"FROM Заказы {whereCondition}",
                CommandType = global::System.Data.CommandType.Text
            };

            FillFilteredTable(заказыTableAdapter.Adapter, filterOrderCommand, OrderDataTable);

            return OrderDataTable;
        }

        /// <summary>
        /// Возвращает отфильтрованную таблицу пользователей по условию <paramref name="condition"/>
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static ПользователиDataTable FilterUsers(string condition = null)
        {
            var whereCondition = string.Empty;
            if (!string.IsNullOrEmpty(condition))
            {
                whereCondition = $"WHERE {condition}";
            }

            var filterUserCommand = new OleDbCommand()
            {
                Connection = пользователиTableAdapter.Connection,
                CommandText = "SELECT Идентификатор, Фамилия, Имя, Отчество, [номер телефона], логин, пароль, " +
                $"[E-mail], [Является администратором] FROM Пользователи {whereCondition}",
                CommandType = global::System.Data.CommandType.Text
            };

            FillFilteredTable(пользователиTableAdapter.Adapter, filterUserCommand, UserDataTable);

            return UserDataTable;
        }

        /// <summary>
        /// Возвращает отфильтрованную таблицу цен работ по условию <paramref name="condition"/>
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static Цены_работDataTable FilterWorkPrices(string condition = null)
        {
            var whereCondition = string.Empty;
            if (!string.IsNullOrEmpty(condition))
            {
                whereCondition = $"WHERE {condition}";
            }

            var filterUserCommand = new OleDbCommand()
            {
                Connection = ценыРаботTableAdapter.Connection,
                CommandText = "SELECT Идентификатор, [Вид работы], [Тип одежды], Цена" +
                $" FROM [Цены работ] {whereCondition}",
                CommandType = CommandType.Text
            };

            FillFilteredTable(ценыРаботTableAdapter.Adapter, filterUserCommand, WorkPrices);

            return WorkPrices;
        }

        public static СообщенияDataTable FilterMessages(string condition = null)
        {

            var whereCondition = string.Empty;
            if (!string.IsNullOrEmpty(condition))
            {
                whereCondition = $"WHERE {condition}";
            }

            var filterUserCommand = new OleDbCommand()
            {
                Connection = сообщенияTableAdapter.Connection,
                CommandText = "SELECT Код, Отправитель, Получатель, Тема, [Текст сообщения]," +
                    " [Прочитано получателем], [Удалено отправителем], [Удалено получателем]" +
                    $" FROM [Сообщения] {whereCondition}",
                CommandType = CommandType.Text
            };

            FillFilteredTable(сообщенияTableAdapter.Adapter, filterUserCommand, MessageDataTable);

            return MessageDataTable;
        }

        /// <summary>
        /// Создает строку для фильтрации: всевозможные комбинации по сравнению предоставленных полей с текстом поиска
        /// </summary>
        /// <param name="fields"></param>
        /// <param name="searchText"></param>
        /// <returns></returns>
        public static string GetFilterStringByFields(string[] fields, string searchText)
        {
            var findValues = string.IsNullOrEmpty(searchText)
                ? new string[] { }
                : searchText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var filterStrings = new List<string>();
            foreach (var findingField in fields)
            {
                foreach (var findingValue in findValues)
                {
                    filterStrings.Add($"{findingField} LIKE '%{findingValue}%'");
                }
            }

            return string.Join(" OR ", filterStrings);
        }

        /// <summary>
        /// Объединяет условия фильтрации заданным логическим оператором
        /// </summary>
        /// <param name="leftPart"></param>
        /// <param name="rightPart"></param>
        /// <param name="operator"></param>
        /// <returns></returns>
        public static string UnionFilter(string leftPart, string rightPart, string @operator = "AND")
        {
            if (string.IsNullOrEmpty(leftPart))
            {
                return rightPart;
            }

            if (string.IsNullOrEmpty(rightPart))
            {
                return leftPart;
            }

            return $"({leftPart}) {@operator} ({rightPart})";
        }

        /// <summary>
        /// Заполняет таблицу по фильтрующей команде выбора строк
        /// </summary>
        /// <param name="adapter"></param>
        /// <param name="selectCommand"></param>
        /// <param name="table"></param>
        private static void FillFilteredTable(OleDbDataAdapter adapter, OleDbCommand selectCommand, DataTable table)
        {
            var oldSelectComand = adapter.SelectCommand;
            adapter.SelectCommand = selectCommand;

            table.Clear();

            adapter.Fill(table);
            adapter.SelectCommand = oldSelectComand;
        }
    }
}