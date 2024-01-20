namespace Пошив_и_ремонт_одежды
{
    partial class Вход_в_программу_Клиент
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Вход_в_программу_Клиент));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PriceList = new System.Windows.Forms.TabPage();
            this.priceListFilterTextBox = new System.Windows.Forms.TextBox();
            this.priceListDataGridView = new System.Windows.Forms.DataGridView();
            this.OrdersTab = new System.Windows.Forms.TabPage();
            this.updateOrdersButton = new System.Windows.Forms.Button();
            this.clientOrdersFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.orderFilterTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewReadyOrders = new System.Windows.Forms.DataGridView();
            this.tabPageEmail = new System.Windows.Forms.TabPage();
            this.tabControlEmail = new System.Windows.Forms.TabControl();
            this.WriteLetter = new System.Windows.Forms.TabPage();
            this.emailSendButton = new System.Windows.Forms.Button();
            this.emailMessageTextBox = new System.Windows.Forms.TextBox();
            this.emailSubjectTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EmailTabPage = new System.Windows.Forms.TabPage();
            this.inputMessagesDataGridView = new System.Windows.Forms.DataGridView();
            this.Код = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outputMessagesTabPage = new System.Windows.Forms.TabPage();
            this.outputMessagesDataGridView = new System.Windows.Forms.DataGridView();
            this.Basket = new System.Windows.Forms.TabPage();
            this.deletedMessagesDataGridView = new System.Windows.Forms.DataGridView();
            this.ToWriteMessage = new System.Windows.Forms.TabPage();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.buttonFile = new System.Windows.Forms.Button();
            this.textBoxWhom = new System.Windows.Forms.TextBox();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.labelWhom = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.Bascket = new System.Windows.Forms.TabPage();
            this.Sent = new System.Windows.Forms.TabPage();
            this.Outgoing = new System.Windows.Forms.TabPage();
            this.Incoming = new System.Windows.Forms.TabPage();
            this.заказГотовDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ценаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типОдеждыDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видРаботыDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типОдеждыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видРаботыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.идентификаторDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видРаботыDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типОдеждыDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценыРаботДляКлиентаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пошив_и_ремонт_одеждыDataSet = new Пошив_и_ремонт_одежды.пошив_и_ремонт_одеждыDataSet();
            this.видРаботыDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типОдеждыDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заказГотовDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.заказыДляКлиентаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.темаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.текстСообщенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сообщенияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.темаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.текстСообщенияDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.исходящиеСообщенияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.типСообщенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.темаDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.текстСообщенияDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.удаленныеСообщенияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказы_с_клиентамиTableAdapter = new Пошив_и_ремонт_одежды.пошив_и_ремонт_одеждыDataSetTableAdapters.Заказы_с_клиентамиTableAdapter();
            this.цены_работ_для_клиентаTableAdapter = new Пошив_и_ремонт_одежды.пошив_и_ремонт_одеждыDataSetTableAdapters.Цены_работ_для_клиентаTableAdapter();
            this.заказы_для_клиентаTableAdapter = new Пошив_и_ремонт_одежды.пошив_и_ремонт_одеждыDataSetTableAdapters.Заказы_для_клиентаTableAdapter();
            this.сообщенияTableAdapter = new Пошив_и_ремонт_одежды.пошив_и_ремонт_одеждыDataSetTableAdapters.СообщенияTableAdapter();
            this.сообщенияДляКлиентовУдаленныеTableAdapter = new Пошив_и_ремонт_одежды.пошив_и_ремонт_одеждыDataSetTableAdapters.Сообщения_для_клиентов_удаленныеTableAdapter();
            this.inputMessageDeleteButton = new System.Windows.Forms.Button();
            this.outputMessageDeleteButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.PriceList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceListDataGridView)).BeginInit();
            this.OrdersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReadyOrders)).BeginInit();
            this.tabPageEmail.SuspendLayout();
            this.tabControlEmail.SuspendLayout();
            this.WriteLetter.SuspendLayout();
            this.EmailTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputMessagesDataGridView)).BeginInit();
            this.outputMessagesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputMessagesDataGridView)).BeginInit();
            this.Basket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deletedMessagesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ценыРаботДляКлиентаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пошив_и_ремонт_одеждыDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыДляКлиентаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сообщенияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.исходящиеСообщенияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.удаленныеСообщенияBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PriceList);
            this.tabControl1.Controls.Add(this.OrdersTab);
            this.tabControl1.Controls.Add(this.tabPageEmail);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(632, 638);
            this.tabControl1.TabIndex = 0;
            // 
            // PriceList
            // 
            this.PriceList.AutoScroll = true;
            this.PriceList.Controls.Add(this.priceListFilterTextBox);
            this.PriceList.Controls.Add(this.priceListDataGridView);
            this.PriceList.Location = new System.Drawing.Point(4, 22);
            this.PriceList.Name = "PriceList";
            this.PriceList.Padding = new System.Windows.Forms.Padding(3);
            this.PriceList.Size = new System.Drawing.Size(624, 612);
            this.PriceList.TabIndex = 0;
            this.PriceList.Text = "Прайс-лист";
            this.PriceList.UseVisualStyleBackColor = true;
            // 
            // priceListFilterTextBox
            // 
            this.priceListFilterTextBox.Location = new System.Drawing.Point(6, 6);
            this.priceListFilterTextBox.Multiline = true;
            this.priceListFilterTextBox.Name = "priceListFilterTextBox";
            this.priceListFilterTextBox.Size = new System.Drawing.Size(604, 36);
            this.priceListFilterTextBox.TabIndex = 3;
            this.priceListFilterTextBox.TextChanged += new System.EventHandler(this.priceListFilterTextBox_TextChanged);
            // 
            // priceListDataGridView
            // 
            this.priceListDataGridView.AllowUserToAddRows = false;
            this.priceListDataGridView.AllowUserToDeleteRows = false;
            this.priceListDataGridView.AllowUserToOrderColumns = true;
            this.priceListDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceListDataGridView.AutoGenerateColumns = false;
            this.priceListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.priceListDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.priceListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.priceListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.идентификаторDataGridViewTextBoxColumn,
            this.видРаботыDataGridViewTextBoxColumn2,
            this.типОдеждыDataGridViewTextBoxColumn2,
            this.ценаDataGridViewTextBoxColumn2});
            this.priceListDataGridView.DataSource = this.ценыРаботДляКлиентаBindingSource;
            this.priceListDataGridView.Location = new System.Drawing.Point(3, 48);
            this.priceListDataGridView.Name = "priceListDataGridView";
            this.priceListDataGridView.ReadOnly = true;
            this.priceListDataGridView.Size = new System.Drawing.Size(610, 514);
            this.priceListDataGridView.TabIndex = 0;
            // 
            // OrdersTab
            // 
            this.OrdersTab.Controls.Add(this.updateOrdersButton);
            this.OrdersTab.Controls.Add(this.clientOrdersFilterCheckBox);
            this.OrdersTab.Controls.Add(this.orderFilterTextBox);
            this.OrdersTab.Controls.Add(this.dataGridViewReadyOrders);
            this.OrdersTab.Location = new System.Drawing.Point(4, 22);
            this.OrdersTab.Name = "OrdersTab";
            this.OrdersTab.Size = new System.Drawing.Size(624, 612);
            this.OrdersTab.TabIndex = 3;
            this.OrdersTab.Text = "Заказы";
            this.OrdersTab.UseVisualStyleBackColor = true;
            // 
            // updateOrdersButton
            // 
            this.updateOrdersButton.Location = new System.Drawing.Point(533, 48);
            this.updateOrdersButton.Name = "updateOrdersButton";
            this.updateOrdersButton.Size = new System.Drawing.Size(75, 23);
            this.updateOrdersButton.TabIndex = 9;
            this.updateOrdersButton.Text = "Обновить";
            this.updateOrdersButton.UseVisualStyleBackColor = true;
            this.updateOrdersButton.Click += new System.EventHandler(this.updateOrdersButton_Click);
            // 
            // clientOrdersFilterCheckBox
            // 
            this.clientOrdersFilterCheckBox.AutoSize = true;
            this.clientOrdersFilterCheckBox.Checked = true;
            this.clientOrdersFilterCheckBox.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.clientOrdersFilterCheckBox.Location = new System.Drawing.Point(8, 54);
            this.clientOrdersFilterCheckBox.Name = "clientOrdersFilterCheckBox";
            this.clientOrdersFilterCheckBox.Size = new System.Drawing.Size(164, 17);
            this.clientOrdersFilterCheckBox.TabIndex = 8;
            this.clientOrdersFilterCheckBox.Text = "Отображаются все заказы";
            this.clientOrdersFilterCheckBox.ThreeState = true;
            this.clientOrdersFilterCheckBox.UseVisualStyleBackColor = true;
            this.clientOrdersFilterCheckBox.CheckStateChanged += new System.EventHandler(this.clientOrdersFilterCheckBox_CheckStateChanged);
            // 
            // orderFilterTextBox
            // 
            this.orderFilterTextBox.Location = new System.Drawing.Point(8, 3);
            this.orderFilterTextBox.Multiline = true;
            this.orderFilterTextBox.Name = "orderFilterTextBox";
            this.orderFilterTextBox.Size = new System.Drawing.Size(600, 45);
            this.orderFilterTextBox.TabIndex = 2;
            this.orderFilterTextBox.TextChanged += new System.EventHandler(this.orderFilterTextBox_TextChanged);
            // 
            // dataGridViewReadyOrders
            // 
            this.dataGridViewReadyOrders.AllowUserToAddRows = false;
            this.dataGridViewReadyOrders.AllowUserToDeleteRows = false;
            this.dataGridViewReadyOrders.AllowUserToOrderColumns = true;
            this.dataGridViewReadyOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewReadyOrders.AutoGenerateColumns = false;
            this.dataGridViewReadyOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReadyOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewReadyOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReadyOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.видРаботыDataGridViewTextBoxColumn3,
            this.типОдеждыDataGridViewTextBoxColumn3,
            this.ценаDataGridViewTextBoxColumn3,
            this.заказГотовDataGridViewCheckBoxColumn1});
            this.dataGridViewReadyOrders.DataSource = this.заказыДляКлиентаBindingSource;
            this.dataGridViewReadyOrders.Location = new System.Drawing.Point(3, 77);
            this.dataGridViewReadyOrders.Name = "dataGridViewReadyOrders";
            this.dataGridViewReadyOrders.ReadOnly = true;
            this.dataGridViewReadyOrders.Size = new System.Drawing.Size(610, 484);
            this.dataGridViewReadyOrders.TabIndex = 1;
            // 
            // tabPageEmail
            // 
            this.tabPageEmail.Controls.Add(this.tabControlEmail);
            this.tabPageEmail.Location = new System.Drawing.Point(4, 22);
            this.tabPageEmail.Name = "tabPageEmail";
            this.tabPageEmail.Size = new System.Drawing.Size(624, 612);
            this.tabPageEmail.TabIndex = 4;
            this.tabPageEmail.Text = "Почта";
            this.tabPageEmail.UseVisualStyleBackColor = true;
            // 
            // tabControlEmail
            // 
            this.tabControlEmail.Controls.Add(this.WriteLetter);
            this.tabControlEmail.Controls.Add(this.EmailTabPage);
            this.tabControlEmail.Controls.Add(this.outputMessagesTabPage);
            this.tabControlEmail.Controls.Add(this.Basket);
            this.tabControlEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlEmail.Location = new System.Drawing.Point(0, 0);
            this.tabControlEmail.Name = "tabControlEmail";
            this.tabControlEmail.SelectedIndex = 0;
            this.tabControlEmail.Size = new System.Drawing.Size(624, 612);
            this.tabControlEmail.TabIndex = 1;
            // 
            // WriteLetter
            // 
            this.WriteLetter.Controls.Add(this.emailSendButton);
            this.WriteLetter.Controls.Add(this.emailMessageTextBox);
            this.WriteLetter.Controls.Add(this.emailSubjectTextBox);
            this.WriteLetter.Controls.Add(this.label2);
            this.WriteLetter.Location = new System.Drawing.Point(4, 22);
            this.WriteLetter.Name = "WriteLetter";
            this.WriteLetter.Size = new System.Drawing.Size(616, 586);
            this.WriteLetter.TabIndex = 4;
            this.WriteLetter.Text = "Написать письмо";
            this.WriteLetter.UseVisualStyleBackColor = true;
            // 
            // emailSendButton
            // 
            this.emailSendButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailSendButton.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailSendButton.Location = new System.Drawing.Point(238, 547);
            this.emailSendButton.Name = "emailSendButton";
            this.emailSendButton.Size = new System.Drawing.Size(141, 35);
            this.emailSendButton.TabIndex = 3;
            this.emailSendButton.Text = "Отправить";
            this.emailSendButton.UseVisualStyleBackColor = true;
            this.emailSendButton.Click += new System.EventHandler(this.emailSendButton_Click);
            // 
            // emailMessageTextBox
            // 
            this.emailMessageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailMessageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailMessageTextBox.Location = new System.Drawing.Point(4, 56);
            this.emailMessageTextBox.Multiline = true;
            this.emailMessageTextBox.Name = "emailMessageTextBox";
            this.emailMessageTextBox.Size = new System.Drawing.Size(608, 485);
            this.emailMessageTextBox.TabIndex = 2;
            // 
            // emailSubjectTextBox
            // 
            this.emailSubjectTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailSubjectTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailSubjectTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailSubjectTextBox.Location = new System.Drawing.Point(4, 23);
            this.emailSubjectTextBox.Multiline = true;
            this.emailSubjectTextBox.Name = "emailSubjectTextBox";
            this.emailSubjectTextBox.Size = new System.Drawing.Size(608, 27);
            this.emailSubjectTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(5, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тема:";
            // 
            // EmailTabPage
            // 
            this.EmailTabPage.Controls.Add(this.inputMessageDeleteButton);
            this.EmailTabPage.Controls.Add(this.inputMessagesDataGridView);
            this.EmailTabPage.Location = new System.Drawing.Point(4, 22);
            this.EmailTabPage.Name = "EmailTabPage";
            this.EmailTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EmailTabPage.Size = new System.Drawing.Size(616, 586);
            this.EmailTabPage.TabIndex = 0;
            this.EmailTabPage.Text = "Входящие";
            this.EmailTabPage.UseVisualStyleBackColor = true;
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
            this.темаDataGridViewTextBoxColumn,
            this.Код,
            this.текстСообщенияDataGridViewTextBoxColumn});
            this.inputMessagesDataGridView.DataSource = this.сообщенияBindingSource;
            this.inputMessagesDataGridView.Location = new System.Drawing.Point(3, 52);
            this.inputMessagesDataGridView.Name = "inputMessagesDataGridView";
            this.inputMessagesDataGridView.ReadOnly = true;
            this.inputMessagesDataGridView.Size = new System.Drawing.Size(610, 530);
            this.inputMessagesDataGridView.TabIndex = 0;
            this.inputMessagesDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.messagesDataGridView_CellDoubleClick);
            this.inputMessagesDataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.messagesDataGridView_CellClick);
            this.inputMessagesDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.messagesDataGridView_DataBindingComplete);
            this.inputMessagesDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.messagesDataGridView_KeyDown);
            // 
            // Код
            // 
            this.Код.DataPropertyName = "Код";
            this.Код.HeaderText = "Код";
            this.Код.Name = "Код";
            this.Код.ReadOnly = true;
            this.Код.Visible = false;
            // 
            // outputMessagesTabPage
            // 
            this.outputMessagesTabPage.Controls.Add(this.outputMessageDeleteButton);
            this.outputMessagesTabPage.Controls.Add(this.outputMessagesDataGridView);
            this.outputMessagesTabPage.Location = new System.Drawing.Point(4, 22);
            this.outputMessagesTabPage.Name = "outputMessagesTabPage";
            this.outputMessagesTabPage.Size = new System.Drawing.Size(616, 586);
            this.outputMessagesTabPage.TabIndex = 2;
            this.outputMessagesTabPage.Text = "Отправленные";
            this.outputMessagesTabPage.UseVisualStyleBackColor = true;
            // 
            // outputMessagesDataGridView
            // 
            this.outputMessagesDataGridView.AllowUserToAddRows = false;
            this.outputMessagesDataGridView.AllowUserToDeleteRows = false;
            this.outputMessagesDataGridView.AllowUserToOrderColumns = true;
            this.outputMessagesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputMessagesDataGridView.AutoGenerateColumns = false;
            this.outputMessagesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.outputMessagesDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.outputMessagesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outputMessagesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.темаDataGridViewTextBoxColumn1,
            this.текстСообщенияDataGridViewTextBoxColumn1});
            this.outputMessagesDataGridView.DataSource = this.исходящиеСообщенияBindingSource;
            this.outputMessagesDataGridView.Location = new System.Drawing.Point(3, 52);
            this.outputMessagesDataGridView.Name = "outputMessagesDataGridView";
            this.outputMessagesDataGridView.ReadOnly = true;
            this.outputMessagesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.outputMessagesDataGridView.Size = new System.Drawing.Size(610, 530);
            this.outputMessagesDataGridView.TabIndex = 0;
            this.outputMessagesDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.messagesDataGridView_CellDoubleClick);
            this.outputMessagesDataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.messagesDataGridView_CellClick);
            this.outputMessagesDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.messagesDataGridView_DataBindingComplete);
            this.outputMessagesDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.messagesDataGridView_KeyDown);
            // 
            // Basket
            // 
            this.Basket.Controls.Add(this.deletedMessagesDataGridView);
            this.Basket.Location = new System.Drawing.Point(4, 22);
            this.Basket.Name = "Basket";
            this.Basket.Size = new System.Drawing.Size(616, 586);
            this.Basket.TabIndex = 3;
            this.Basket.Text = "Корзина";
            this.Basket.UseVisualStyleBackColor = true;
            // 
            // deletedMessagesDataGridView
            // 
            this.deletedMessagesDataGridView.AllowUserToAddRows = false;
            this.deletedMessagesDataGridView.AllowUserToDeleteRows = false;
            this.deletedMessagesDataGridView.AutoGenerateColumns = false;
            this.deletedMessagesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.deletedMessagesDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.deletedMessagesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deletedMessagesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.типСообщенияDataGridViewTextBoxColumn,
            this.темаDataGridViewTextBoxColumn2,
            this.текстСообщенияDataGridViewTextBoxColumn2});
            this.deletedMessagesDataGridView.DataSource = this.удаленныеСообщенияBindingSource;
            this.deletedMessagesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deletedMessagesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.deletedMessagesDataGridView.Name = "deletedMessagesDataGridView";
            this.deletedMessagesDataGridView.ReadOnly = true;
            this.deletedMessagesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.deletedMessagesDataGridView.Size = new System.Drawing.Size(616, 586);
            this.deletedMessagesDataGridView.TabIndex = 1;
            this.deletedMessagesDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.messagesDataGridView_CellDoubleClick);
            this.deletedMessagesDataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.messagesDataGridView_CellClick);
            this.deletedMessagesDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.messagesDataGridView_DataBindingComplete);
            this.deletedMessagesDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.messagesDataGridView_KeyDown);
            // 
            // ToWriteMessage
            // 
            this.ToWriteMessage.Location = new System.Drawing.Point(4, 22);
            this.ToWriteMessage.Name = "ToWriteMessage";
            this.ToWriteMessage.Padding = new System.Windows.Forms.Padding(3);
            this.ToWriteMessage.Size = new System.Drawing.Size(602, 511);
            this.ToWriteMessage.TabIndex = 4;
            this.ToWriteMessage.Text = "Написать сообщение";
            this.ToWriteMessage.UseVisualStyleBackColor = true;
            // 
            // textBoxFile
            // 
            this.textBoxFile.Location = new System.Drawing.Point(6, 7);
            this.textBoxFile.Multiline = true;
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(443, 51);
            this.textBoxFile.TabIndex = 6;
            // 
            // buttonFile
            // 
            this.buttonFile.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFile.Location = new System.Drawing.Point(455, 6);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(130, 51);
            this.buttonFile.TabIndex = 7;
            this.buttonFile.Text = "Прикрепить файл";
            this.buttonFile.UseVisualStyleBackColor = true;
            // 
            // textBoxWhom
            // 
            this.textBoxWhom.Location = new System.Drawing.Point(6, 87);
            this.textBoxWhom.Multiline = true;
            this.textBoxWhom.Name = "textBoxWhom";
            this.textBoxWhom.Size = new System.Drawing.Size(579, 34);
            this.textBoxWhom.TabIndex = 9;
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(6, 150);
            this.textBoxSubject.Multiline = true;
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(579, 34);
            this.textBoxSubject.TabIndex = 8;
            // 
            // labelWhom
            // 
            this.labelWhom.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWhom.Location = new System.Drawing.Point(9, 61);
            this.labelWhom.Name = "labelWhom";
            this.labelWhom.Size = new System.Drawing.Size(94, 23);
            this.labelWhom.TabIndex = 11;
            // 
            // labelSubject
            // 
            this.labelSubject.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSubject.Location = new System.Drawing.Point(6, 124);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(97, 23);
            this.labelSubject.TabIndex = 10;
            // 
            // textBoxText
            // 
            this.textBoxText.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxText.Location = new System.Drawing.Point(6, 208);
            this.textBoxText.Multiline = true;
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(590, 300);
            this.textBoxText.TabIndex = 12;
            // 
            // Bascket
            // 
            this.Bascket.Location = new System.Drawing.Point(4, 22);
            this.Bascket.Name = "Bascket";
            this.Bascket.Size = new System.Drawing.Size(602, 511);
            this.Bascket.TabIndex = 3;
            this.Bascket.Text = "Корзина";
            this.Bascket.UseVisualStyleBackColor = true;
            // 
            // Sent
            // 
            this.Sent.Location = new System.Drawing.Point(4, 22);
            this.Sent.Name = "Sent";
            this.Sent.Padding = new System.Windows.Forms.Padding(3);
            this.Sent.Size = new System.Drawing.Size(602, 511);
            this.Sent.TabIndex = 2;
            this.Sent.Text = "Отправленные";
            this.Sent.UseVisualStyleBackColor = true;
            // 
            // Outgoing
            // 
            this.Outgoing.Location = new System.Drawing.Point(4, 22);
            this.Outgoing.Name = "Outgoing";
            this.Outgoing.Padding = new System.Windows.Forms.Padding(3);
            this.Outgoing.Size = new System.Drawing.Size(602, 511);
            this.Outgoing.TabIndex = 1;
            this.Outgoing.Text = "Исходящие";
            this.Outgoing.UseVisualStyleBackColor = true;
            // 
            // Incoming
            // 
            this.Incoming.Location = new System.Drawing.Point(4, 22);
            this.Incoming.Name = "Incoming";
            this.Incoming.Padding = new System.Windows.Forms.Padding(3);
            this.Incoming.Size = new System.Drawing.Size(602, 511);
            this.Incoming.TabIndex = 0;
            this.Incoming.Text = "Входящие";
            this.Incoming.UseVisualStyleBackColor = true;
            // 
            // заказГотовDataGridViewCheckBoxColumn
            // 
            this.заказГотовDataGridViewCheckBoxColumn.DataPropertyName = "Заказ готов";
            this.заказГотовDataGridViewCheckBoxColumn.HeaderText = "Заказ готов";
            this.заказГотовDataGridViewCheckBoxColumn.Name = "заказГотовDataGridViewCheckBoxColumn";
            this.заказГотовDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // ценаDataGridViewTextBoxColumn1
            // 
            this.ценаDataGridViewTextBoxColumn1.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn1.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn1.Name = "ценаDataGridViewTextBoxColumn1";
            this.ценаDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // типОдеждыDataGridViewTextBoxColumn1
            // 
            this.типОдеждыDataGridViewTextBoxColumn1.DataPropertyName = "Тип одежды";
            this.типОдеждыDataGridViewTextBoxColumn1.HeaderText = "Тип одежды";
            this.типОдеждыDataGridViewTextBoxColumn1.Name = "типОдеждыDataGridViewTextBoxColumn1";
            this.типОдеждыDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // видРаботыDataGridViewTextBoxColumn1
            // 
            this.видРаботыDataGridViewTextBoxColumn1.DataPropertyName = "Вид работы";
            this.видРаботыDataGridViewTextBoxColumn1.HeaderText = "Вид работы";
            this.видРаботыDataGridViewTextBoxColumn1.Name = "видРаботыDataGridViewTextBoxColumn1";
            this.видРаботыDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            this.ценаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // типОдеждыDataGridViewTextBoxColumn
            // 
            this.типОдеждыDataGridViewTextBoxColumn.DataPropertyName = "Тип одежды";
            this.типОдеждыDataGridViewTextBoxColumn.HeaderText = "Тип одежды";
            this.типОдеждыDataGridViewTextBoxColumn.Name = "типОдеждыDataGridViewTextBoxColumn";
            this.типОдеждыDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // видРаботыDataGridViewTextBoxColumn
            // 
            this.видРаботыDataGridViewTextBoxColumn.DataPropertyName = "Вид работы";
            this.видРаботыDataGridViewTextBoxColumn.HeaderText = "Вид работы";
            this.видРаботыDataGridViewTextBoxColumn.Name = "видРаботыDataGridViewTextBoxColumn";
            this.видРаботыDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // идентификаторDataGridViewTextBoxColumn
            // 
            this.идентификаторDataGridViewTextBoxColumn.DataPropertyName = "Идентификатор";
            this.идентификаторDataGridViewTextBoxColumn.HeaderText = "Идентификатор";
            this.идентификаторDataGridViewTextBoxColumn.Name = "идентификаторDataGridViewTextBoxColumn";
            this.идентификаторDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // видРаботыDataGridViewTextBoxColumn2
            // 
            this.видРаботыDataGridViewTextBoxColumn2.DataPropertyName = "Вид работы";
            this.видРаботыDataGridViewTextBoxColumn2.HeaderText = "Вид работы";
            this.видРаботыDataGridViewTextBoxColumn2.Name = "видРаботыDataGridViewTextBoxColumn2";
            this.видРаботыDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // типОдеждыDataGridViewTextBoxColumn2
            // 
            this.типОдеждыDataGridViewTextBoxColumn2.DataPropertyName = "Тип одежды";
            this.типОдеждыDataGridViewTextBoxColumn2.HeaderText = "Тип одежды";
            this.типОдеждыDataGridViewTextBoxColumn2.Name = "типОдеждыDataGridViewTextBoxColumn2";
            this.типОдеждыDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // ценаDataGridViewTextBoxColumn2
            // 
            this.ценаDataGridViewTextBoxColumn2.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn2.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn2.Name = "ценаDataGridViewTextBoxColumn2";
            this.ценаDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // ценыРаботДляКлиентаBindingSource
            // 
            this.ценыРаботДляКлиентаBindingSource.DataMember = "Цены работ для клиента";
            this.ценыРаботДляКлиентаBindingSource.DataSource = this.пошив_и_ремонт_одеждыDataSet;
            // 
            // пошив_и_ремонт_одеждыDataSet
            // 
            this.пошив_и_ремонт_одеждыDataSet.DataSetName = "пошив_и_ремонт_одеждыDataSet";
            this.пошив_и_ремонт_одеждыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // видРаботыDataGridViewTextBoxColumn3
            // 
            this.видРаботыDataGridViewTextBoxColumn3.DataPropertyName = "Вид работы";
            this.видРаботыDataGridViewTextBoxColumn3.HeaderText = "Вид работы";
            this.видРаботыDataGridViewTextBoxColumn3.Name = "видРаботыDataGridViewTextBoxColumn3";
            this.видРаботыDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // типОдеждыDataGridViewTextBoxColumn3
            // 
            this.типОдеждыDataGridViewTextBoxColumn3.DataPropertyName = "Тип одежды";
            this.типОдеждыDataGridViewTextBoxColumn3.HeaderText = "Тип одежды";
            this.типОдеждыDataGridViewTextBoxColumn3.Name = "типОдеждыDataGridViewTextBoxColumn3";
            this.типОдеждыDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // ценаDataGridViewTextBoxColumn3
            // 
            this.ценаDataGridViewTextBoxColumn3.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn3.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn3.Name = "ценаDataGridViewTextBoxColumn3";
            this.ценаDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // заказГотовDataGridViewCheckBoxColumn1
            // 
            this.заказГотовDataGridViewCheckBoxColumn1.DataPropertyName = "Заказ готов";
            this.заказГотовDataGridViewCheckBoxColumn1.HeaderText = "Заказ готов";
            this.заказГотовDataGridViewCheckBoxColumn1.Name = "заказГотовDataGridViewCheckBoxColumn1";
            this.заказГотовDataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // заказыДляКлиентаBindingSource
            // 
            this.заказыДляКлиентаBindingSource.DataMember = "Заказы для клиента";
            this.заказыДляКлиентаBindingSource.DataSource = this.пошив_и_ремонт_одеждыDataSet;
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
            // сообщенияBindingSource
            // 
            this.сообщенияBindingSource.DataMember = "Сообщения";
            this.сообщенияBindingSource.DataSource = this.пошив_и_ремонт_одеждыDataSet;
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
            // исходящиеСообщенияBindingSource
            // 
            this.исходящиеСообщенияBindingSource.DataMember = "Сообщения";
            this.исходящиеСообщенияBindingSource.DataSource = this.пошив_и_ремонт_одеждыDataSet;
            // 
            // типСообщенияDataGridViewTextBoxColumn
            // 
            this.типСообщенияDataGridViewTextBoxColumn.DataPropertyName = "Тип сообщения";
            this.типСообщенияDataGridViewTextBoxColumn.HeaderText = "Тип сообщения";
            this.типСообщенияDataGridViewTextBoxColumn.Name = "типСообщенияDataGridViewTextBoxColumn";
            this.типСообщенияDataGridViewTextBoxColumn.ReadOnly = true;
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
            // удаленныеСообщенияBindingSource
            // 
            this.удаленныеСообщенияBindingSource.DataMember = "Сообщения для клиентов удаленные";
            this.удаленныеСообщенияBindingSource.DataSource = this.пошив_и_ремонт_одеждыDataSet;
            // 
            // заказы_с_клиентамиTableAdapter
            // 
            this.заказы_с_клиентамиTableAdapter.ClearBeforeFill = true;
            // 
            // цены_работ_для_клиентаTableAdapter
            // 
            this.цены_работ_для_клиентаTableAdapter.ClearBeforeFill = true;
            // 
            // заказы_для_клиентаTableAdapter
            // 
            this.заказы_для_клиентаTableAdapter.ClearBeforeFill = true;
            // 
            // сообщенияTableAdapter
            // 
            this.сообщенияTableAdapter.ClearBeforeFill = true;
            // 
            // сообщенияДляКлиентовУдаленныеTableAdapter
            // 
            this.сообщенияДляКлиентовУдаленныеTableAdapter.ClearBeforeFill = true;
            // 
            // inputMessageDeleteButton
            // 
            this.inputMessageDeleteButton.Location = new System.Drawing.Point(473, 23);
            this.inputMessageDeleteButton.Name = "inputMessageDeleteButton";
            this.inputMessageDeleteButton.Size = new System.Drawing.Size(140, 23);
            this.inputMessageDeleteButton.TabIndex = 1;
            this.inputMessageDeleteButton.Text = "Удалить сообщение";
            this.inputMessageDeleteButton.UseVisualStyleBackColor = true;
            this.inputMessageDeleteButton.Click += new System.EventHandler(this.inputMessageDeleteButton_Click);
            // 
            // outputMessageDeleteButton
            // 
            this.outputMessageDeleteButton.Location = new System.Drawing.Point(472, 23);
            this.outputMessageDeleteButton.Name = "outputMessageDeleteButton";
            this.outputMessageDeleteButton.Size = new System.Drawing.Size(140, 23);
            this.outputMessageDeleteButton.TabIndex = 1;
            this.outputMessageDeleteButton.Text = "Удалить сообщение";
            this.outputMessageDeleteButton.UseVisualStyleBackColor = true;
            this.outputMessageDeleteButton.Click += new System.EventHandler(this.outputMessageDeleteButton_Click);
            // 
            // Вход_в_программу_Клиент
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 638);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Вход_в_программу_Клиент";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход в программу Клиент";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Вход_в_программу_Клиент_Load);
            this.tabControl1.ResumeLayout(false);
            this.PriceList.ResumeLayout(false);
            this.PriceList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceListDataGridView)).EndInit();
            this.OrdersTab.ResumeLayout(false);
            this.OrdersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReadyOrders)).EndInit();
            this.tabPageEmail.ResumeLayout(false);
            this.tabControlEmail.ResumeLayout(false);
            this.WriteLetter.ResumeLayout(false);
            this.WriteLetter.PerformLayout();
            this.EmailTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inputMessagesDataGridView)).EndInit();
            this.outputMessagesTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.outputMessagesDataGridView)).EndInit();
            this.Basket.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deletedMessagesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ценыРаботДляКлиентаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пошив_и_ремонт_одеждыDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыДляКлиентаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сообщенияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.исходящиеСообщенияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.удаленныеСообщенияBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private пошив_и_ремонт_одеждыDataSet пошив_и_ремонт_одеждыDataSet;
        private System.Windows.Forms.BindingSource ценыРаботДляКлиентаBindingSource;
        private пошив_и_ремонт_одеждыDataSetTableAdapters.Цены_работ_для_клиентаTableAdapter цены_работ_для_клиентаTableAdapter;
        private пошив_и_ремонт_одеждыDataSetTableAdapters.Заказы_с_клиентамиTableAdapter заказы_с_клиентамиTableAdapter;
        private System.Windows.Forms.BindingSource заказыДляКлиентаBindingSource;
        private пошив_и_ремонт_одеждыDataSetTableAdapters.Заказы_для_клиентаTableAdapter заказы_для_клиентаTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PriceList;
        private System.Windows.Forms.TextBox priceListFilterTextBox;
        private System.Windows.Forms.DataGridView priceListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn идентификаторDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn видРаботыDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn типОдеждыDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn2;
        private System.Windows.Forms.TabPage OrdersTab;
        private System.Windows.Forms.Button updateOrdersButton;
        private System.Windows.Forms.CheckBox clientOrdersFilterCheckBox;
        private System.Windows.Forms.TextBox orderFilterTextBox;
        private System.Windows.Forms.DataGridView dataGridViewReadyOrders;
        private System.Windows.Forms.TabPage ToWriteMessage;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.TextBox textBoxWhom;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.Label labelWhom;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.TabPage Bascket;
        private System.Windows.Forms.TabPage Sent;
        private System.Windows.Forms.TabPage Outgoing;
        private System.Windows.Forms.TabPage Incoming;
        private System.Windows.Forms.DataGridViewCheckBoxColumn заказГотовDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn типОдеждыDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn видРаботыDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типОдеждыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn видРаботыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn видРаботыDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn типОдеждыDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn заказГотовDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.TabPage tabPageEmail;
        private System.Windows.Forms.BindingSource сообщенияBindingSource;
        private System.Windows.Forms.BindingSource исходящиеСообщенияBindingSource;
        private System.Windows.Forms.BindingSource удаленныеСообщенияBindingSource;
        private пошив_и_ремонт_одеждыDataSetTableAdapters.СообщенияTableAdapter сообщенияTableAdapter;
        private пошив_и_ремонт_одеждыDataSetTableAdapters.Сообщения_для_клиентов_удаленныеTableAdapter сообщенияДляКлиентовУдаленныеTableAdapter;
        private System.Windows.Forms.TabControl tabControlEmail;
        private System.Windows.Forms.TabPage WriteLetter;
        private System.Windows.Forms.Button emailSendButton;
        private System.Windows.Forms.TextBox emailMessageTextBox;
        private System.Windows.Forms.TextBox emailSubjectTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage EmailTabPage;
        private System.Windows.Forms.DataGridView inputMessagesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn темаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Код;
        private System.Windows.Forms.DataGridViewTextBoxColumn текстСообщенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage outputMessagesTabPage;
        private System.Windows.Forms.TabPage Basket;
        private System.Windows.Forms.DataGridView outputMessagesDataGridView;
        private System.Windows.Forms.DataGridView deletedMessagesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn темаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn текстСообщенияDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn типСообщенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn темаDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn текстСообщенияDataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button inputMessageDeleteButton;
        private System.Windows.Forms.Button outputMessageDeleteButton;
    }
}