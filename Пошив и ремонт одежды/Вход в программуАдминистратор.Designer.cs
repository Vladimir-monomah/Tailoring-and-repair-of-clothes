namespace Пошив_и_ремонт_одежды
{
    partial class Вход_в_программу
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            this.StopUpdateTimers();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Вход_в_программу));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Klient = new System.Windows.Forms.TabPage();
            this.clientFilterTextBox = new System.Windows.Forms.TextBox();
            this.addClientButton = new System.Windows.Forms.Button();
            this.labelSortingCustomers = new System.Windows.Forms.Label();
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерТелефонаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пользователиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пошив_и_ремонт_одеждыDataSet = new Пошив_и_ремонт_одежды.пошив_и_ремонт_одеждыDataSet();
            this.Orders = new System.Windows.Forms.TabPage();
            this.readyOrdersFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.orderFilterTextBox = new System.Windows.Forms.TextBox();
            this.addOrderButton = new System.Windows.Forms.Button();
            this.orderSearchLabel = new System.Windows.Forms.Label();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workKindDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.заказыСКлиентамиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Email = new System.Windows.Forms.TabPage();
            this.deletedMessagesTabControl = new System.Windows.Forms.TabControl();
            this.WriteLetter = new System.Windows.Forms.TabPage();
            this.userAdresseesComboBox = new System.Windows.Forms.ComboBox();
            this.пользователиДляЗаказовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sendEmailButton = new System.Windows.Forms.Button();
            this.emailMessageTextBox = new System.Windows.Forms.TextBox();
            this.labelSubject = new System.Windows.Forms.Label();
            this.labelWhom = new System.Windows.Forms.Label();
            this.emailSubjectTextBox = new System.Windows.Forms.TextBox();
            this.incomingMessagesTabPanel = new System.Windows.Forms.TabPage();
            this.deleteMessageButton = new System.Windows.Forms.Button();
            this.inputMessagesDataGridView = new System.Windows.Forms.DataGridView();
            this.фИОDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.темаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.текстСообщенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сообщенияДляАдминистраторовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.outcommingMessagesTabPanel = new System.Windows.Forms.TabPage();
            this.deleteOutMessageButton = new System.Windows.Forms.Button();
            this.outMessagesDataGridView = new System.Windows.Forms.DataGridView();
            this.фИОDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.темаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.текстСообщенияDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сообщенияДляАдминистраторовОтправленныеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Basket = new System.Windows.Forms.TabPage();
            this.deletedMessagesDataGridView = new System.Windows.Forms.DataGridView();
            this.фИОПолучателяDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИООтправителяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.темаDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.текстСообщенияDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сообщенияДляАдминистраторовУдаленныеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ФИО = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Тема = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОПолучателяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видРаботBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.типОдеждыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.готовыеЗаказыСКлиентамиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пользователиTableAdapter = new Пошив_и_ремонт_одежды.пошив_и_ремонт_одеждыDataSetTableAdapters.ПользователиTableAdapter();
            this.заказы_с_клиентамиTableAdapter = new Пошив_и_ремонт_одежды.пошив_и_ремонт_одеждыDataSetTableAdapters.Заказы_с_клиентамиTableAdapter();
            this.вид_работTableAdapter = new Пошив_и_ремонт_одежды.пошив_и_ремонт_одеждыDataSetTableAdapters.Вид_работTableAdapter();
            this.тип_одеждыTableAdapter = new Пошив_и_ремонт_одежды.пошив_и_ремонт_одеждыDataSetTableAdapters.Тип_одеждыTableAdapter();
            this.сообщения_для_администраторовTableAdapter = new Пошив_и_ремонт_одежды.пошив_и_ремонт_одеждыDataSetTableAdapters.Сообщения_для_администраторовTableAdapter();
            this.сообщения_для_администраторов_отправленныеTableAdapter = new Пошив_и_ремонт_одежды.пошив_и_ремонт_одеждыDataSetTableAdapters.Сообщения_для_администраторов_отправленныеTableAdapter();
            this.пользователи_для_заказовTableAdapter = new Пошив_и_ремонт_одежды.пошив_и_ремонт_одеждыDataSetTableAdapters.Пользователи_для_заказовTableAdapter();
            this.сообщения_для_администраторов_удаленныеTableAdapter = new Пошив_и_ремонт_одежды.пошив_и_ремонт_одеждыDataSetTableAdapters.Сообщения_для_администраторов_удаленныеTableAdapter();
            this.tabControl.SuspendLayout();
            this.Klient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пошив_и_ремонт_одеждыDataSet)).BeginInit();
            this.Orders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыСКлиентамиBindingSource)).BeginInit();
            this.Email.SuspendLayout();
            this.deletedMessagesTabControl.SuspendLayout();
            this.WriteLetter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиДляЗаказовBindingSource)).BeginInit();
            this.incomingMessagesTabPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputMessagesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сообщенияДляАдминистраторовBindingSource)).BeginInit();
            this.outcommingMessagesTabPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outMessagesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сообщенияДляАдминистраторовОтправленныеBindingSource)).BeginInit();
            this.Basket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deletedMessagesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сообщенияДляАдминистраторовУдаленныеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.видРаботBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типОдеждыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.готовыеЗаказыСКлиентамиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Klient);
            this.tabControl.Controls.Add(this.Orders);
            this.tabControl.Controls.Add(this.Email);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(879, 799);
            this.tabControl.TabIndex = 0;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // Klient
            // 
            this.Klient.Controls.Add(this.clientFilterTextBox);
            this.Klient.Controls.Add(this.addClientButton);
            this.Klient.Controls.Add(this.labelSortingCustomers);
            this.Klient.Controls.Add(this.dataGridViewClient);
            this.Klient.Location = new System.Drawing.Point(4, 25);
            this.Klient.Margin = new System.Windows.Forms.Padding(4);
            this.Klient.Name = "Klient";
            this.Klient.Padding = new System.Windows.Forms.Padding(4);
            this.Klient.Size = new System.Drawing.Size(871, 770);
            this.Klient.TabIndex = 0;
            this.Klient.Text = "Клиент";
            this.Klient.UseVisualStyleBackColor = true;
            // 
            // clientFilterTextBox
            // 
            this.clientFilterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientFilterTextBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientFilterTextBox.Location = new System.Drawing.Point(0, 23);
            this.clientFilterTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.clientFilterTextBox.Multiline = true;
            this.clientFilterTextBox.Name = "clientFilterTextBox";
            this.clientFilterTextBox.Size = new System.Drawing.Size(863, 46);
            this.clientFilterTextBox.TabIndex = 1;
            this.clientFilterTextBox.TextChanged += new System.EventHandler(this.clientFilterTextBox_TextChanged);
            // 
            // addClientButton
            // 
            this.addClientButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addClientButton.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addClientButton.Location = new System.Drawing.Point(59, 78);
            this.addClientButton.Margin = new System.Windows.Forms.Padding(4);
            this.addClientButton.Name = "addClientButton";
            this.addClientButton.Size = new System.Drawing.Size(756, 48);
            this.addClientButton.TabIndex = 4;
            this.addClientButton.Text = "Добавить нового клиента";
            this.addClientButton.UseVisualStyleBackColor = true;
            this.addClientButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelSortingCustomers
            // 
            this.labelSortingCustomers.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSortingCustomers.Location = new System.Drawing.Point(4, 4);
            this.labelSortingCustomers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSortingCustomers.Name = "labelSortingCustomers";
            this.labelSortingCustomers.Size = new System.Drawing.Size(179, 28);
            this.labelSortingCustomers.TabIndex = 3;
            this.labelSortingCustomers.Text = "Поиск клиентов";
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.AllowUserToAddRows = false;
            this.dataGridViewClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewClient.AutoGenerateColumns = false;
            this.dataGridViewClient.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.номерТелефонаDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridViewClient.DataSource = this.пользователиBindingSource;
            this.dataGridViewClient.Location = new System.Drawing.Point(4, 133);
            this.dataGridViewClient.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.Size = new System.Drawing.Size(860, 630);
            this.dataGridViewClient.TabIndex = 0;
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            // 
            // номерТелефонаDataGridViewTextBoxColumn
            // 
            this.номерТелефонаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.номерТелефонаDataGridViewTextBoxColumn.DataPropertyName = "номер телефона";
            this.номерТелефонаDataGridViewTextBoxColumn.HeaderText = "номер телефона";
            this.номерТелефонаDataGridViewTextBoxColumn.Name = "номерТелефонаDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "E-mail";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // пользователиBindingSource
            // 
            this.пользователиBindingSource.DataMember = "Пользователи";
            this.пользователиBindingSource.DataSource = this.пошив_и_ремонт_одеждыDataSet;
            // 
            // пошив_и_ремонт_одеждыDataSet
            // 
            this.пошив_и_ремонт_одеждыDataSet.DataSetName = "пошив_и_ремонт_одеждыDataSet";
            this.пошив_и_ремонт_одеждыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Orders
            // 
            this.Orders.Controls.Add(this.readyOrdersFilterCheckBox);
            this.Orders.Controls.Add(this.orderFilterTextBox);
            this.Orders.Controls.Add(this.addOrderButton);
            this.Orders.Controls.Add(this.orderSearchLabel);
            this.Orders.Controls.Add(this.dataGridViewOrder);
            this.Orders.Location = new System.Drawing.Point(4, 25);
            this.Orders.Margin = new System.Windows.Forms.Padding(4);
            this.Orders.Name = "Orders";
            this.Orders.Padding = new System.Windows.Forms.Padding(4);
            this.Orders.Size = new System.Drawing.Size(871, 770);
            this.Orders.TabIndex = 1;
            this.Orders.Text = "Заказы";
            this.Orders.UseVisualStyleBackColor = true;
            // 
            // readyOrdersFilterCheckBox
            // 
            this.readyOrdersFilterCheckBox.AutoSize = true;
            this.readyOrdersFilterCheckBox.Checked = true;
            this.readyOrdersFilterCheckBox.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.readyOrdersFilterCheckBox.Location = new System.Drawing.Point(11, 68);
            this.readyOrdersFilterCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.readyOrdersFilterCheckBox.Name = "readyOrdersFilterCheckBox";
            this.readyOrdersFilterCheckBox.Size = new System.Drawing.Size(206, 21);
            this.readyOrdersFilterCheckBox.TabIndex = 7;
            this.readyOrdersFilterCheckBox.Text = "Отображаются все заказы";
            this.readyOrdersFilterCheckBox.ThreeState = true;
            this.readyOrdersFilterCheckBox.UseVisualStyleBackColor = true;
            this.readyOrdersFilterCheckBox.CheckStateChanged += new System.EventHandler(this.readyOrdersFilterCheckBox_CheckStateChanged);
            // 
            // orderFilterTextBox
            // 
            this.orderFilterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderFilterTextBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderFilterTextBox.Location = new System.Drawing.Point(7, 23);
            this.orderFilterTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.orderFilterTextBox.Name = "orderFilterTextBox";
            this.orderFilterTextBox.Size = new System.Drawing.Size(856, 36);
            this.orderFilterTextBox.TabIndex = 4;
            this.orderFilterTextBox.TextChanged += new System.EventHandler(this.orderFilterTextBox_TextChanged);
            // 
            // addOrderButton
            // 
            this.addOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addOrderButton.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addOrderButton.Location = new System.Drawing.Point(56, 96);
            this.addOrderButton.Margin = new System.Windows.Forms.Padding(4);
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.Size = new System.Drawing.Size(756, 42);
            this.addOrderButton.TabIndex = 6;
            this.addOrderButton.Text = "Добавить новый заказ";
            this.addOrderButton.UseVisualStyleBackColor = true;
            this.addOrderButton.Click += new System.EventHandler(this.addOrderButton_Click);
            // 
            // orderSearchLabel
            // 
            this.orderSearchLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderSearchLabel.Location = new System.Drawing.Point(11, 4);
            this.orderSearchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderSearchLabel.Name = "orderSearchLabel";
            this.orderSearchLabel.Size = new System.Drawing.Size(172, 28);
            this.orderSearchLabel.TabIndex = 5;
            this.orderSearchLabel.Text = "Поиск заказов";
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.AllowUserToAddRows = false;
            this.dataGridViewOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOrder.AutoGenerateColumns = false;
            this.dataGridViewOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фИОDataGridViewTextBoxColumn,
            this.workKindDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.ценаDataGridViewTextBoxColumn,
            this.dataGridViewCheckBoxColumn1});
            this.dataGridViewOrder.DataSource = this.заказыСКлиентамиBindingSource;
            this.dataGridViewOrder.Location = new System.Drawing.Point(4, 145);
            this.dataGridViewOrder.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.Size = new System.Drawing.Size(860, 618);
            this.dataGridViewOrder.TabIndex = 0;
            this.dataGridViewOrder.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReadyOrders_CellEndEdit);
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.FillWeight = 200F;
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // workKindDataGridViewTextBoxColumn
            // 
            this.workKindDataGridViewTextBoxColumn.DataPropertyName = "Вид работы";
            this.workKindDataGridViewTextBoxColumn.HeaderText = "Вид работы";
            this.workKindDataGridViewTextBoxColumn.Name = "workKindDataGridViewTextBoxColumn";
            this.workKindDataGridViewTextBoxColumn.ReadOnly = true;
            this.workKindDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Тип одежды";
            this.dataGridViewTextBoxColumn2.HeaderText = "Тип одежды";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Заказ готов";
            this.dataGridViewCheckBoxColumn1.FillWeight = 90F;
            this.dataGridViewCheckBoxColumn1.HeaderText = "Заказ готов";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // заказыСКлиентамиBindingSource
            // 
            this.заказыСКлиентамиBindingSource.DataMember = "Заказы с клиентами";
            this.заказыСКлиентамиBindingSource.DataSource = this.пошив_и_ремонт_одеждыDataSet;
            // 
            // Email
            // 
            this.Email.Controls.Add(this.deletedMessagesTabControl);
            this.Email.Location = new System.Drawing.Point(4, 25);
            this.Email.Margin = new System.Windows.Forms.Padding(4);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(871, 770);
            this.Email.TabIndex = 2;
            this.Email.Text = "Почта";
            this.Email.UseVisualStyleBackColor = true;
            // 
            // deletedMessagesTabControl
            // 
            this.deletedMessagesTabControl.Controls.Add(this.WriteLetter);
            this.deletedMessagesTabControl.Controls.Add(this.incomingMessagesTabPanel);
            this.deletedMessagesTabControl.Controls.Add(this.outcommingMessagesTabPanel);
            this.deletedMessagesTabControl.Controls.Add(this.Basket);
            this.deletedMessagesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deletedMessagesTabControl.Location = new System.Drawing.Point(0, 0);
            this.deletedMessagesTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.deletedMessagesTabControl.Name = "deletedMessagesTabControl";
            this.deletedMessagesTabControl.SelectedIndex = 0;
            this.deletedMessagesTabControl.Size = new System.Drawing.Size(871, 770);
            this.deletedMessagesTabControl.TabIndex = 0;
            // 
            // WriteLetter
            // 
            this.WriteLetter.Controls.Add(this.userAdresseesComboBox);
            this.WriteLetter.Controls.Add(this.sendEmailButton);
            this.WriteLetter.Controls.Add(this.emailMessageTextBox);
            this.WriteLetter.Controls.Add(this.labelSubject);
            this.WriteLetter.Controls.Add(this.labelWhom);
            this.WriteLetter.Controls.Add(this.emailSubjectTextBox);
            this.WriteLetter.Location = new System.Drawing.Point(4, 25);
            this.WriteLetter.Margin = new System.Windows.Forms.Padding(4);
            this.WriteLetter.Name = "WriteLetter";
            this.WriteLetter.Size = new System.Drawing.Size(863, 741);
            this.WriteLetter.TabIndex = 4;
            this.WriteLetter.Text = "Написать письмо";
            this.WriteLetter.UseVisualStyleBackColor = true;
            // 
            // userAdresseesComboBox
            // 
            this.userAdresseesComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userAdresseesComboBox.DataSource = this.пользователиДляЗаказовBindingSource;
            this.userAdresseesComboBox.DisplayMember = "ФИО";
            this.userAdresseesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userAdresseesComboBox.FormattingEnabled = true;
            this.userAdresseesComboBox.Location = new System.Drawing.Point(9, 20);
            this.userAdresseesComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.userAdresseesComboBox.Name = "userAdresseesComboBox";
            this.userAdresseesComboBox.Size = new System.Drawing.Size(844, 24);
            this.userAdresseesComboBox.TabIndex = 4;
            this.userAdresseesComboBox.ValueMember = "Идентификатор";
            // 
            // пользователиДляЗаказовBindingSource
            // 
            this.пользователиДляЗаказовBindingSource.DataMember = "Пользователи для заказов";
            this.пользователиДляЗаказовBindingSource.DataSource = this.пошив_и_ремонт_одеждыDataSet;
            // 
            // sendEmailButton
            // 
            this.sendEmailButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendEmailButton.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendEmailButton.Location = new System.Drawing.Point(347, 675);
            this.sendEmailButton.Margin = new System.Windows.Forms.Padding(4);
            this.sendEmailButton.Name = "sendEmailButton";
            this.sendEmailButton.Size = new System.Drawing.Size(191, 43);
            this.sendEmailButton.TabIndex = 3;
            this.sendEmailButton.Text = "Отправить";
            this.sendEmailButton.UseVisualStyleBackColor = true;
            this.sendEmailButton.Click += new System.EventHandler(this.sendEmailButton_Click);
            // 
            // emailMessageTextBox
            // 
            this.emailMessageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailMessageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailMessageTextBox.Location = new System.Drawing.Point(4, 113);
            this.emailMessageTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailMessageTextBox.Multiline = true;
            this.emailMessageTextBox.Name = "emailMessageTextBox";
            this.emailMessageTextBox.Size = new System.Drawing.Size(850, 554);
            this.emailMessageTextBox.TabIndex = 2;
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSubject.Location = new System.Drawing.Point(5, 53);
            this.labelSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(49, 17);
            this.labelSubject.TabIndex = 1;
            this.labelSubject.Text = "Тема:";
            // 
            // labelWhom
            // 
            this.labelWhom.AutoSize = true;
            this.labelWhom.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWhom.Location = new System.Drawing.Point(5, 0);
            this.labelWhom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWhom.Name = "labelWhom";
            this.labelWhom.Size = new System.Drawing.Size(51, 17);
            this.labelWhom.TabIndex = 1;
            this.labelWhom.Text = "Кому:";
            // 
            // emailSubjectTextBox
            // 
            this.emailSubjectTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailSubjectTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailSubjectTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailSubjectTextBox.Location = new System.Drawing.Point(5, 73);
            this.emailSubjectTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailSubjectTextBox.Multiline = true;
            this.emailSubjectTextBox.Name = "emailSubjectTextBox";
            this.emailSubjectTextBox.Size = new System.Drawing.Size(850, 33);
            this.emailSubjectTextBox.TabIndex = 0;
            // 
            // incomingMessagesTabPanel
            // 
            this.incomingMessagesTabPanel.Controls.Add(this.deleteMessageButton);
            this.incomingMessagesTabPanel.Controls.Add(this.inputMessagesDataGridView);
            this.incomingMessagesTabPanel.Location = new System.Drawing.Point(4, 25);
            this.incomingMessagesTabPanel.Margin = new System.Windows.Forms.Padding(4);
            this.incomingMessagesTabPanel.Name = "incomingMessagesTabPanel";
            this.incomingMessagesTabPanel.Padding = new System.Windows.Forms.Padding(4);
            this.incomingMessagesTabPanel.Size = new System.Drawing.Size(863, 741);
            this.incomingMessagesTabPanel.TabIndex = 0;
            this.incomingMessagesTabPanel.Text = "Входящие";
            this.incomingMessagesTabPanel.UseVisualStyleBackColor = true;
            // 
            // deleteMessageButton
            // 
            this.deleteMessageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteMessageButton.Location = new System.Drawing.Point(679, 50);
            this.deleteMessageButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteMessageButton.Name = "deleteMessageButton";
            this.deleteMessageButton.Size = new System.Drawing.Size(176, 28);
            this.deleteMessageButton.TabIndex = 1;
            this.deleteMessageButton.Text = "Удалить сообщение";
            this.deleteMessageButton.UseVisualStyleBackColor = true;
            this.deleteMessageButton.Click += new System.EventHandler(this.deleteMessageButton_Click);
            // 
            // inputMessagesDataGridView
            // 
            this.inputMessagesDataGridView.AllowUserToAddRows = false;
            this.inputMessagesDataGridView.AllowUserToDeleteRows = false;
            this.inputMessagesDataGridView.AllowUserToOrderColumns = true;
            this.inputMessagesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputMessagesDataGridView.AutoGenerateColumns = false;
            this.inputMessagesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inputMessagesDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.inputMessagesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inputMessagesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фИОDataGridViewTextBoxColumn1,
            this.темаDataGridViewTextBoxColumn,
            this.текстСообщенияDataGridViewTextBoxColumn});
            this.inputMessagesDataGridView.DataSource = this.сообщенияДляАдминистраторовBindingSource;
            this.inputMessagesDataGridView.Location = new System.Drawing.Point(5, 86);
            this.inputMessagesDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.inputMessagesDataGridView.Name = "inputMessagesDataGridView";
            this.inputMessagesDataGridView.ReadOnly = true;
            this.inputMessagesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inputMessagesDataGridView.Size = new System.Drawing.Size(850, 643);
            this.inputMessagesDataGridView.TabIndex = 0;
            this.inputMessagesDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.messagesDataGridView_CellDoubleClick);
            this.inputMessagesDataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.messagesDataGridView_CellClick);
            this.inputMessagesDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.messagesDataGridView_DataBindingComplete);
            this.inputMessagesDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.messagesDataGridView_KeyDown);
            // 
            // фИОDataGridViewTextBoxColumn1
            // 
            this.фИОDataGridViewTextBoxColumn1.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn1.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn1.Name = "фИОDataGridViewTextBoxColumn1";
            this.фИОDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // темаDataGridViewTextBoxColumn
            // 
            this.темаDataGridViewTextBoxColumn.DataPropertyName = "Тема";
            this.темаDataGridViewTextBoxColumn.HeaderText = "Тема";
            this.темаDataGridViewTextBoxColumn.Name = "темаDataGridViewTextBoxColumn";
            this.темаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // текстСообщенияDataGridViewTextBoxColumn
            // 
            this.текстСообщенияDataGridViewTextBoxColumn.DataPropertyName = "Текст сообщения";
            this.текстСообщенияDataGridViewTextBoxColumn.HeaderText = "Текст сообщения";
            this.текстСообщенияDataGridViewTextBoxColumn.Name = "текстСообщенияDataGridViewTextBoxColumn";
            this.текстСообщенияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // сообщенияДляАдминистраторовBindingSource
            // 
            this.сообщенияДляАдминистраторовBindingSource.DataMember = "Сообщения для администраторов";
            this.сообщенияДляАдминистраторовBindingSource.DataSource = this.пошив_и_ремонт_одеждыDataSet;
            // 
            // outcommingMessagesTabPanel
            // 
            this.outcommingMessagesTabPanel.Controls.Add(this.deleteOutMessageButton);
            this.outcommingMessagesTabPanel.Controls.Add(this.outMessagesDataGridView);
            this.outcommingMessagesTabPanel.Location = new System.Drawing.Point(4, 25);
            this.outcommingMessagesTabPanel.Margin = new System.Windows.Forms.Padding(4);
            this.outcommingMessagesTabPanel.Name = "outcommingMessagesTabPanel";
            this.outcommingMessagesTabPanel.Size = new System.Drawing.Size(863, 741);
            this.outcommingMessagesTabPanel.TabIndex = 2;
            this.outcommingMessagesTabPanel.Text = "Отправленные";
            this.outcommingMessagesTabPanel.UseVisualStyleBackColor = true;
            // 
            // deleteOutMessageButton
            // 
            this.deleteOutMessageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteOutMessageButton.Location = new System.Drawing.Point(679, 50);
            this.deleteOutMessageButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteOutMessageButton.Name = "deleteOutMessageButton";
            this.deleteOutMessageButton.Size = new System.Drawing.Size(176, 28);
            this.deleteOutMessageButton.TabIndex = 2;
            this.deleteOutMessageButton.Text = "Удалить сообщение";
            this.deleteOutMessageButton.UseVisualStyleBackColor = true;
            this.deleteOutMessageButton.Click += new System.EventHandler(this.deleteOutMessageButton_Click);
            // 
            // outMessagesDataGridView
            // 
            this.outMessagesDataGridView.AllowUserToAddRows = false;
            this.outMessagesDataGridView.AllowUserToDeleteRows = false;
            this.outMessagesDataGridView.AllowUserToOrderColumns = true;
            this.outMessagesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outMessagesDataGridView.AutoGenerateColumns = false;
            this.outMessagesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.outMessagesDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.outMessagesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outMessagesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фИОDataGridViewTextBoxColumn2,
            this.темаDataGridViewTextBoxColumn1,
            this.текстСообщенияDataGridViewTextBoxColumn1});
            this.outMessagesDataGridView.DataSource = this.сообщенияДляАдминистраторовОтправленныеBindingSource;
            this.outMessagesDataGridView.Location = new System.Drawing.Point(5, 86);
            this.outMessagesDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.outMessagesDataGridView.Name = "outMessagesDataGridView";
            this.outMessagesDataGridView.ReadOnly = true;
            this.outMessagesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.outMessagesDataGridView.Size = new System.Drawing.Size(850, 643);
            this.outMessagesDataGridView.TabIndex = 0;
            this.outMessagesDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.messagesDataGridView_CellDoubleClick);
            this.outMessagesDataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.messagesDataGridView_CellClick);
            this.outMessagesDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.messagesDataGridView_DataBindingComplete);
            this.outMessagesDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.messagesDataGridView_KeyDown);
            // 
            // фИОDataGridViewTextBoxColumn2
            // 
            this.фИОDataGridViewTextBoxColumn2.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn2.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn2.Name = "фИОDataGridViewTextBoxColumn2";
            this.фИОDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // темаDataGridViewTextBoxColumn1
            // 
            this.темаDataGridViewTextBoxColumn1.DataPropertyName = "Тема";
            this.темаDataGridViewTextBoxColumn1.HeaderText = "Тема";
            this.темаDataGridViewTextBoxColumn1.Name = "темаDataGridViewTextBoxColumn1";
            this.темаDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // текстСообщенияDataGridViewTextBoxColumn1
            // 
            this.текстСообщенияDataGridViewTextBoxColumn1.DataPropertyName = "Текст сообщения";
            this.текстСообщенияDataGridViewTextBoxColumn1.HeaderText = "Текст сообщения";
            this.текстСообщенияDataGridViewTextBoxColumn1.Name = "текстСообщенияDataGridViewTextBoxColumn1";
            this.текстСообщенияDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // сообщенияДляАдминистраторовОтправленныеBindingSource
            // 
            this.сообщенияДляАдминистраторовОтправленныеBindingSource.DataMember = "Сообщения для администраторов отправленные";
            this.сообщенияДляАдминистраторовОтправленныеBindingSource.DataSource = this.пошив_и_ремонт_одеждыDataSet;
            // 
            // Basket
            // 
            this.Basket.Controls.Add(this.deletedMessagesDataGridView);
            this.Basket.Location = new System.Drawing.Point(4, 25);
            this.Basket.Margin = new System.Windows.Forms.Padding(4);
            this.Basket.Name = "Basket";
            this.Basket.Size = new System.Drawing.Size(863, 741);
            this.Basket.TabIndex = 3;
            this.Basket.Text = "Корзина";
            this.Basket.UseVisualStyleBackColor = true;
            // 
            // deletedMessagesDataGridView
            // 
            this.deletedMessagesDataGridView.AllowUserToAddRows = false;
            this.deletedMessagesDataGridView.AllowUserToDeleteRows = false;
            this.deletedMessagesDataGridView.AllowUserToOrderColumns = true;
            this.deletedMessagesDataGridView.AutoGenerateColumns = false;
            this.deletedMessagesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.deletedMessagesDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.deletedMessagesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deletedMessagesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фИОПолучателяDataGridViewTextBoxColumn1,
            this.фИООтправителяDataGridViewTextBoxColumn,
            this.темаDataGridViewTextBoxColumn2,
            this.текстСообщенияDataGridViewTextBoxColumn2});
            this.deletedMessagesDataGridView.DataSource = this.сообщенияДляАдминистраторовУдаленныеBindingSource;
            this.deletedMessagesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deletedMessagesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.deletedMessagesDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.deletedMessagesDataGridView.Name = "deletedMessagesDataGridView";
            this.deletedMessagesDataGridView.ReadOnly = true;
            this.deletedMessagesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.deletedMessagesDataGridView.Size = new System.Drawing.Size(863, 741);
            this.deletedMessagesDataGridView.TabIndex = 0;
            this.deletedMessagesDataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.messagesDataGridView_CellClick);
            this.deletedMessagesDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.messagesDataGridView_DataBindingComplete);
            this.deletedMessagesDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.messagesDataGridView_KeyDown);
            // 
            // фИОПолучателяDataGridViewTextBoxColumn1
            // 
            this.фИОПолучателяDataGridViewTextBoxColumn1.DataPropertyName = "ФИО получателя";
            this.фИОПолучателяDataGridViewTextBoxColumn1.HeaderText = "ФИО получателя";
            this.фИОПолучателяDataGridViewTextBoxColumn1.Name = "фИОПолучателяDataGridViewTextBoxColumn1";
            this.фИОПолучателяDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // фИООтправителяDataGridViewTextBoxColumn
            // 
            this.фИООтправителяDataGridViewTextBoxColumn.DataPropertyName = "ФИО отправителя";
            this.фИООтправителяDataGridViewTextBoxColumn.HeaderText = "ФИО отправителя";
            this.фИООтправителяDataGridViewTextBoxColumn.Name = "фИООтправителяDataGridViewTextBoxColumn";
            this.фИООтправителяDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // темаDataGridViewTextBoxColumn2
            // 
            this.темаDataGridViewTextBoxColumn2.DataPropertyName = "Тема";
            this.темаDataGridViewTextBoxColumn2.HeaderText = "Тема";
            this.темаDataGridViewTextBoxColumn2.Name = "темаDataGridViewTextBoxColumn2";
            this.темаDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // текстСообщенияDataGridViewTextBoxColumn2
            // 
            this.текстСообщенияDataGridViewTextBoxColumn2.DataPropertyName = "Текст сообщения";
            this.текстСообщенияDataGridViewTextBoxColumn2.HeaderText = "Текст сообщения";
            this.текстСообщенияDataGridViewTextBoxColumn2.Name = "текстСообщенияDataGridViewTextBoxColumn2";
            this.текстСообщенияDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // сообщенияДляАдминистраторовУдаленныеBindingSource
            // 
            this.сообщенияДляАдминистраторовУдаленныеBindingSource.DataMember = "Сообщения для администраторов удаленные";
            this.сообщенияДляАдминистраторовУдаленныеBindingSource.DataSource = this.пошив_и_ремонт_одеждыDataSet;
            // 
            // ФИО
            // 
            this.ФИО.DataPropertyName = "ФИО";
            this.ФИО.HeaderText = "ФИО";
            this.ФИО.Name = "ФИО";
            this.ФИО.ReadOnly = true;
            // 
            // Тема
            // 
            this.Тема.DataPropertyName = "Тема";
            this.Тема.HeaderText = "Тема";
            this.Тема.Name = "Тема";
            this.Тема.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumn1.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Тема";
            this.dataGridViewTextBoxColumn3.HeaderText = "Тема";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // фИОПолучателяDataGridViewTextBoxColumn
            // 
            this.фИОПолучателяDataGridViewTextBoxColumn.DataPropertyName = "ФИО получателя";
            this.фИОПолучателяDataGridViewTextBoxColumn.HeaderText = "ФИО получателя";
            this.фИОПолучателяDataGridViewTextBoxColumn.Name = "фИОПолучателяDataGridViewTextBoxColumn";
            this.фИОПолучателяDataGridViewTextBoxColumn.Width = 197;
            // 
            // видРаботBindingSource
            // 
            this.видРаботBindingSource.DataMember = "Вид работ";
            this.видРаботBindingSource.DataSource = this.пошив_и_ремонт_одеждыDataSet;
            // 
            // типОдеждыBindingSource
            // 
            this.типОдеждыBindingSource.DataMember = "Тип одежды";
            this.типОдеждыBindingSource.DataSource = this.пошив_и_ремонт_одеждыDataSet;
            // 
            // готовыеЗаказыСКлиентамиBindingSource
            // 
            this.готовыеЗаказыСКлиентамиBindingSource.DataMember = "Заказы с клиентами";
            this.готовыеЗаказыСКлиентамиBindingSource.DataSource = this.пошив_и_ремонт_одеждыDataSet;
            // 
            // пользователиTableAdapter
            // 
            this.пользователиTableAdapter.ClearBeforeFill = true;
            // 
            // заказы_с_клиентамиTableAdapter
            // 
            this.заказы_с_клиентамиTableAdapter.ClearBeforeFill = true;
            // 
            // вид_работTableAdapter
            // 
            this.вид_работTableAdapter.ClearBeforeFill = true;
            // 
            // тип_одеждыTableAdapter
            // 
            this.тип_одеждыTableAdapter.ClearBeforeFill = true;
            // 
            // сообщения_для_администраторовTableAdapter
            // 
            this.сообщения_для_администраторовTableAdapter.ClearBeforeFill = true;
            // 
            // сообщения_для_администраторов_отправленныеTableAdapter
            // 
            this.сообщения_для_администраторов_отправленныеTableAdapter.ClearBeforeFill = true;
            // 
            // пользователи_для_заказовTableAdapter
            // 
            this.пользователи_для_заказовTableAdapter.ClearBeforeFill = true;
            // 
            // сообщения_для_администраторов_удаленныеTableAdapter
            // 
            this.сообщения_для_администраторов_удаленныеTableAdapter.ClearBeforeFill = true;
            // 
            // Вход_в_программу
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 799);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Вход_в_программу";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход в программу";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Вход_в_программу_Load);
            this.tabControl.ResumeLayout(false);
            this.Klient.ResumeLayout(false);
            this.Klient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пошив_и_ремонт_одеждыDataSet)).EndInit();
            this.Orders.ResumeLayout(false);
            this.Orders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыСКлиентамиBindingSource)).EndInit();
            this.Email.ResumeLayout(false);
            this.deletedMessagesTabControl.ResumeLayout(false);
            this.WriteLetter.ResumeLayout(false);
            this.WriteLetter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиДляЗаказовBindingSource)).EndInit();
            this.incomingMessagesTabPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inputMessagesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сообщенияДляАдминистраторовBindingSource)).EndInit();
            this.outcommingMessagesTabPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.outMessagesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сообщенияДляАдминистраторовОтправленныеBindingSource)).EndInit();
            this.Basket.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deletedMessagesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сообщенияДляАдминистраторовУдаленныеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.видРаботBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типОдеждыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.готовыеЗаказыСКлиентамиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Klient;
        private System.Windows.Forms.DataGridView dataGridViewClient;
        private System.Windows.Forms.TabPage Orders;
        private пошив_и_ремонт_одеждыDataSet пошив_и_ремонт_одеждыDataSet;
        private System.Windows.Forms.BindingSource пользователиBindingSource;
        private System.Windows.Forms.TextBox clientFilterTextBox;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.Label labelSortingCustomers;
        private System.Windows.Forms.Button addClientButton;
        private System.Windows.Forms.Button addOrderButton;
        private System.Windows.Forms.TextBox orderFilterTextBox;
        private System.Windows.Forms.Label orderSearchLabel;
        private пошив_и_ремонт_одеждыDataSetTableAdapters.ПользователиTableAdapter пользователиTableAdapter;
        private System.Windows.Forms.BindingSource заказыСКлиентамиBindingSource;
        private пошив_и_ремонт_одеждыDataSetTableAdapters.Заказы_с_клиентамиTableAdapter заказы_с_клиентамиTableAdapter;
        private System.Windows.Forms.BindingSource готовыеЗаказыСКлиентамиBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерТелефонаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn видРаботыDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn типОдеждыDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn заказГотовDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn видРаботыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типОдеждыDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource видРаботBindingSource;
        private пошив_и_ремонт_одеждыDataSetTableAdapters.Вид_работTableAdapter вид_работTableAdapter;
        private System.Windows.Forms.BindingSource типОдеждыBindingSource;
        private пошив_и_ремонт_одеждыDataSetTableAdapters.Тип_одеждыTableAdapter тип_одеждыTableAdapter;
        private System.Windows.Forms.CheckBox readyOrdersFilterCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workKindDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.TabPage Email;
        private System.Windows.Forms.TabControl deletedMessagesTabControl;
        private System.Windows.Forms.TabPage WriteLetter;
        private System.Windows.Forms.Button sendEmailButton;
        private System.Windows.Forms.TextBox emailMessageTextBox;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Label labelWhom;
        private System.Windows.Forms.TextBox emailSubjectTextBox;
        private System.Windows.Forms.TabPage incomingMessagesTabPanel;
        private System.Windows.Forms.TabPage outcommingMessagesTabPanel;
        private System.Windows.Forms.TabPage Basket;
        private System.Windows.Forms.DataGridView inputMessagesDataGridView;
        private System.Windows.Forms.BindingSource сообщенияДляАдминистраторовBindingSource;
        private System.Windows.Forms.BindingSource сообщенияДляАдминистраторовОтправленныеBindingSource;
        private пошив_и_ремонт_одеждыDataSetTableAdapters.Сообщения_для_администраторовTableAdapter сообщения_для_администраторовTableAdapter;
        private пошив_и_ремонт_одеждыDataSetTableAdapters.Сообщения_для_администраторов_отправленныеTableAdapter сообщения_для_администраторов_отправленныеTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn получательDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource пользователиДляЗаказовBindingSource;
        private пошив_и_ремонт_одеждыDataSetTableAdapters.Пользователи_для_заказовTableAdapter пользователи_для_заказовTableAdapter;
        private System.Windows.Forms.ComboBox userAdresseesComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn темаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn текстСообщенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button deleteMessageButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ФИО;
        private System.Windows.Forms.DataGridViewTextBoxColumn Тема;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView outMessagesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn темаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn текстСообщенияDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button deleteOutMessageButton;
        private System.Windows.Forms.BindingSource сообщенияДляАдминистраторовУдаленныеBindingSource;
        private пошив_и_ремонт_одеждыDataSetTableAdapters.Сообщения_для_администраторов_удаленныеTableAdapter сообщения_для_администраторов_удаленныеTableAdapter;
        private System.Windows.Forms.DataGridView deletedMessagesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОПолучателяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОПолучателяDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИООтправителяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn темаDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn текстСообщенияDataGridViewTextBoxColumn2;
    }
}