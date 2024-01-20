namespace Пошив_и_ремонт_одежды
{
    partial class Добавление_заказа
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Добавление_заказа));
            this.clientComboBox = new System.Windows.Forms.ComboBox();
            this.пользователиДляЗаказовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пошив_и_ремонт_одеждыDataSet = new Пошив_и_ремонт_одежды.пошив_и_ремонт_одеждыDataSet();
            this.clientLabel = new System.Windows.Forms.Label();
            this.workKindLabel = new System.Windows.Forms.Label();
            this.workKindComboBox = new System.Windows.Forms.ComboBox();
            this.видРаботBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dressTypeLabel = new System.Windows.Forms.Label();
            this.dressTypeComboBox = new System.Windows.Forms.ComboBox();
            this.типОдеждыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addOrderButton = new System.Windows.Forms.Button();
            this.пользователи_для_заказовTableAdapter = new Пошив_и_ремонт_одежды.пошив_и_ремонт_одеждыDataSetTableAdapters.Пользователи_для_заказовTableAdapter();
            this.вид_работTableAdapter = new Пошив_и_ремонт_одежды.пошив_и_ремонт_одеждыDataSetTableAdapters.Вид_работTableAdapter();
            this.тип_одеждыTableAdapter = new Пошив_и_ремонт_одежды.пошив_и_ремонт_одеждыDataSetTableAdapters.Тип_одеждыTableAdapter();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиДляЗаказовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пошив_и_ремонт_одеждыDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.видРаботBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типОдеждыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // clientComboBox
            // 
            this.clientComboBox.DataSource = this.пользователиДляЗаказовBindingSource;
            this.clientComboBox.DisplayMember = "ФИО";
            this.clientComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientComboBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientComboBox.FormattingEnabled = true;
            this.clientComboBox.Location = new System.Drawing.Point(204, 45);
            this.clientComboBox.Name = "clientComboBox";
            this.clientComboBox.Size = new System.Drawing.Size(206, 27);
            this.clientComboBox.TabIndex = 0;
            this.clientComboBox.ValueMember = "Идентификатор";
            // 
            // пользователиДляЗаказовBindingSource
            // 
            this.пользователиДляЗаказовBindingSource.DataMember = "Пользователи для заказов";
            this.пользователиДляЗаказовBindingSource.DataSource = this.пошив_и_ремонт_одеждыDataSet;
            // 
            // пошив_и_ремонт_одеждыDataSet
            // 
            this.пошив_и_ремонт_одеждыDataSet.DataSetName = "пошив_и_ремонт_одеждыDataSet";
            this.пошив_и_ремонт_одеждыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientLabel.Location = new System.Drawing.Point(100, 45);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(80, 23);
            this.clientLabel.TabIndex = 1;
            this.clientLabel.Text = "Клиент";
            // 
            // workKindLabel
            // 
            this.workKindLabel.AutoSize = true;
            this.workKindLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workKindLabel.Location = new System.Drawing.Point(54, 99);
            this.workKindLabel.Name = "workKindLabel";
            this.workKindLabel.Size = new System.Drawing.Size(126, 23);
            this.workKindLabel.TabIndex = 3;
            this.workKindLabel.Text = "Вид работы";
            // 
            // workKindComboBox
            // 
            this.workKindComboBox.DataSource = this.видРаботBindingSource;
            this.workKindComboBox.DisplayMember = "Наименование";
            this.workKindComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workKindComboBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workKindComboBox.FormattingEnabled = true;
            this.workKindComboBox.Location = new System.Drawing.Point(205, 99);
            this.workKindComboBox.Name = "workKindComboBox";
            this.workKindComboBox.Size = new System.Drawing.Size(206, 27);
            this.workKindComboBox.TabIndex = 2;
            this.workKindComboBox.ValueMember = "Идентификатор";
            this.workKindComboBox.SelectedValueChanged += new System.EventHandler(this.orderPriceComboBox_SelectedValueChanged);
            // 
            // видРаботBindingSource
            // 
            this.видРаботBindingSource.DataMember = "Вид работ";
            this.видРаботBindingSource.DataSource = this.пошив_и_ремонт_одеждыDataSet;
            // 
            // dressTypeLabel
            // 
            this.dressTypeLabel.AutoSize = true;
            this.dressTypeLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dressTypeLabel.Location = new System.Drawing.Point(48, 153);
            this.dressTypeLabel.Name = "dressTypeLabel";
            this.dressTypeLabel.Size = new System.Drawing.Size(132, 23);
            this.dressTypeLabel.TabIndex = 5;
            this.dressTypeLabel.Text = "Тип одежды";
            // 
            // dressTypeComboBox
            // 
            this.dressTypeComboBox.DataSource = this.типОдеждыBindingSource;
            this.dressTypeComboBox.DisplayMember = "Наименование";
            this.dressTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dressTypeComboBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dressTypeComboBox.FormattingEnabled = true;
            this.dressTypeComboBox.Location = new System.Drawing.Point(204, 153);
            this.dressTypeComboBox.Name = "dressTypeComboBox";
            this.dressTypeComboBox.Size = new System.Drawing.Size(206, 27);
            this.dressTypeComboBox.TabIndex = 4;
            this.dressTypeComboBox.ValueMember = "Идентификатор";
            this.dressTypeComboBox.SelectedValueChanged += new System.EventHandler(this.orderPriceComboBox_SelectedValueChanged);
            // 
            // типОдеждыBindingSource
            // 
            this.типОдеждыBindingSource.DataMember = "Тип одежды";
            this.типОдеждыBindingSource.DataSource = this.пошив_и_ремонт_одеждыDataSet;
            // 
            // addOrderButton
            // 
            this.addOrderButton.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addOrderButton.Location = new System.Drawing.Point(145, 291);
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.Size = new System.Drawing.Size(180, 52);
            this.addOrderButton.TabIndex = 6;
            this.addOrderButton.Text = "Добавить заказ";
            this.addOrderButton.UseVisualStyleBackColor = true;
            this.addOrderButton.Click += new System.EventHandler(this.addOrderButton_Click);
            // 
            // пользователи_для_заказовTableAdapter
            // 
            this.пользователи_для_заказовTableAdapter.ClearBeforeFill = true;
            // 
            // вид_работTableAdapter
            // 
            this.вид_работTableAdapter.ClearBeforeFill = true;
            // 
            // тип_одеждыTableAdapter
            // 
            this.тип_одеждыTableAdapter.ClearBeforeFill = true;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.priceLabel.Location = new System.Drawing.Point(121, 211);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(59, 23);
            this.priceLabel.TabIndex = 8;
            this.priceLabel.Text = "Цена";
            // 
            // priceNumericUpDown
            // 
            this.priceNumericUpDown.DecimalPlaces = 2;
            this.priceNumericUpDown.Location = new System.Drawing.Point(205, 217);
            this.priceNumericUpDown.Maximum = new decimal(new int[] {
            -159383553,
            46653770,
            5421,
            0});
            this.priceNumericUpDown.Name = "priceNumericUpDown";
            this.priceNumericUpDown.Size = new System.Drawing.Size(205, 20);
            this.priceNumericUpDown.TabIndex = 9;
            // 
            // Добавление_заказа
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 367);
            this.Controls.Add(this.priceNumericUpDown);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.addOrderButton);
            this.Controls.Add(this.dressTypeLabel);
            this.Controls.Add(this.dressTypeComboBox);
            this.Controls.Add(this.workKindLabel);
            this.Controls.Add(this.workKindComboBox);
            this.Controls.Add(this.clientLabel);
            this.Controls.Add(this.clientComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Добавление_заказа";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление заказа";
            this.Load += new System.EventHandler(this.Добавление_заказа_Load);
            ((System.ComponentModel.ISupportInitialize)(this.пользователиДляЗаказовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пошив_и_ремонт_одеждыDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.видРаботBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типОдеждыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox clientComboBox;
        private пошив_и_ремонт_одеждыDataSet пошив_и_ремонт_одеждыDataSet;
        private System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.Label workKindLabel;
        private System.Windows.Forms.ComboBox workKindComboBox;
        private System.Windows.Forms.Label dressTypeLabel;
        private System.Windows.Forms.ComboBox dressTypeComboBox;
        private System.Windows.Forms.Button addOrderButton;
        private System.Windows.Forms.BindingSource пользователиДляЗаказовBindingSource;
        private пошив_и_ремонт_одеждыDataSetTableAdapters.Пользователи_для_заказовTableAdapter пользователи_для_заказовTableAdapter;
        private System.Windows.Forms.BindingSource видРаботBindingSource;
        private пошив_и_ремонт_одеждыDataSetTableAdapters.Вид_работTableAdapter вид_работTableAdapter;
        private System.Windows.Forms.BindingSource типОдеждыBindingSource;
        private пошив_и_ремонт_одеждыDataSetTableAdapters.Тип_одеждыTableAdapter тип_одеждыTableAdapter;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.NumericUpDown priceNumericUpDown;
    }
}