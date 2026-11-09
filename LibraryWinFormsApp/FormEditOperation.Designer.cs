namespace LibraryWinFormsApp
{
    partial class FormEditOperation
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
            groupBoxAddOperation = new GroupBox();
            comboBoxOperationName = new ComboBox();
            labelOperationDate = new Label();
            textBoxOperationCustomerID = new TextBox();
            labelOperationCustomerID = new Label();
            textBoxOperationStuffID = new TextBox();
            labelOperationStuffID = new Label();
            textBoxOperationBookID = new TextBox();
            labelOperationBookID = new Label();
            dateTimePickerOperationDate = new DateTimePicker();
            labelOperationName = new Label();
            buttonCancelEditOperation = new Button();
            buttonConfirmEditOperation = new Button();
            groupBoxAddOperation.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxAddOperation
            // 
            groupBoxAddOperation.Controls.Add(comboBoxOperationName);
            groupBoxAddOperation.Controls.Add(labelOperationDate);
            groupBoxAddOperation.Controls.Add(textBoxOperationCustomerID);
            groupBoxAddOperation.Controls.Add(labelOperationCustomerID);
            groupBoxAddOperation.Controls.Add(textBoxOperationStuffID);
            groupBoxAddOperation.Controls.Add(labelOperationStuffID);
            groupBoxAddOperation.Controls.Add(textBoxOperationBookID);
            groupBoxAddOperation.Controls.Add(labelOperationBookID);
            groupBoxAddOperation.Controls.Add(dateTimePickerOperationDate);
            groupBoxAddOperation.Controls.Add(labelOperationName);
            groupBoxAddOperation.Font = new Font("Segoe UI", 14F);
            groupBoxAddOperation.Location = new Point(12, 12);
            groupBoxAddOperation.Name = "groupBoxAddOperation";
            groupBoxAddOperation.Size = new Size(466, 205);
            groupBoxAddOperation.TabIndex = 34;
            groupBoxAddOperation.TabStop = false;
            groupBoxAddOperation.Text = "изменение данных";
            // 
            // comboBoxOperationName
            // 
            comboBoxOperationName.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOperationName.FormattingEnabled = true;
            comboBoxOperationName.Items.AddRange(new object[] { "Выдача", "Возврат" });
            comboBoxOperationName.Location = new Point(206, 21);
            comboBoxOperationName.Name = "comboBoxOperationName";
            comboBoxOperationName.Size = new Size(236, 33);
            comboBoxOperationName.TabIndex = 36;
            // 
            // labelOperationDate
            // 
            labelOperationDate.AutoSize = true;
            labelOperationDate.Font = new Font("Segoe UI", 11F);
            labelOperationDate.Location = new Point(36, 163);
            labelOperationDate.Name = "labelOperationDate";
            labelOperationDate.Size = new Size(115, 20);
            labelOperationDate.TabIndex = 35;
            labelOperationDate.Text = "Дата операции";
            // 
            // textBoxOperationCustomerID
            // 
            textBoxOperationCustomerID.Font = new Font("Segoe UI", 10F);
            textBoxOperationCustomerID.Location = new Point(206, 122);
            textBoxOperationCustomerID.Name = "textBoxOperationCustomerID";
            textBoxOperationCustomerID.Size = new Size(236, 25);
            textBoxOperationCustomerID.TabIndex = 34;
            // 
            // labelOperationCustomerID
            // 
            labelOperationCustomerID.AutoSize = true;
            labelOperationCustomerID.Font = new Font("Segoe UI", 11F);
            labelOperationCustomerID.Location = new Point(36, 123);
            labelOperationCustomerID.Name = "labelOperationCustomerID";
            labelOperationCustomerID.Size = new Size(83, 20);
            labelOperationCustomerID.TabIndex = 33;
            labelOperationCustomerID.Text = "ID клиента";
            // 
            // textBoxOperationStuffID
            // 
            textBoxOperationStuffID.Font = new Font("Segoe UI", 10F);
            textBoxOperationStuffID.Location = new Point(206, 91);
            textBoxOperationStuffID.Name = "textBoxOperationStuffID";
            textBoxOperationStuffID.Size = new Size(236, 25);
            textBoxOperationStuffID.TabIndex = 32;
            // 
            // labelOperationStuffID
            // 
            labelOperationStuffID.AutoSize = true;
            labelOperationStuffID.Font = new Font("Segoe UI", 11F);
            labelOperationStuffID.Location = new Point(36, 92);
            labelOperationStuffID.Name = "labelOperationStuffID";
            labelOperationStuffID.Size = new Size(107, 20);
            labelOperationStuffID.TabIndex = 31;
            labelOperationStuffID.Text = "ID сотрудника";
            // 
            // textBoxOperationBookID
            // 
            textBoxOperationBookID.Font = new Font("Segoe UI", 10F);
            textBoxOperationBookID.Location = new Point(206, 60);
            textBoxOperationBookID.Name = "textBoxOperationBookID";
            textBoxOperationBookID.Size = new Size(236, 25);
            textBoxOperationBookID.TabIndex = 30;
            // 
            // labelOperationBookID
            // 
            labelOperationBookID.AutoSize = true;
            labelOperationBookID.Font = new Font("Segoe UI", 11F);
            labelOperationBookID.Location = new Point(36, 61);
            labelOperationBookID.Name = "labelOperationBookID";
            labelOperationBookID.Size = new Size(68, 20);
            labelOperationBookID.TabIndex = 29;
            labelOperationBookID.Text = "ID книги";
            // 
            // dateTimePickerOperationDate
            // 
            dateTimePickerOperationDate.Location = new Point(206, 153);
            dateTimePickerOperationDate.Name = "dateTimePickerOperationDate";
            dateTimePickerOperationDate.Size = new Size(236, 32);
            dateTimePickerOperationDate.TabIndex = 27;
            // 
            // labelOperationName
            // 
            labelOperationName.AutoSize = true;
            labelOperationName.Font = new Font("Segoe UI", 11F);
            labelOperationName.Location = new Point(36, 28);
            labelOperationName.Name = "labelOperationName";
            labelOperationName.Size = new Size(80, 20);
            labelOperationName.TabIndex = 26;
            labelOperationName.Text = "Операция";
            // 
            // buttonCancelEditOperation
            // 
            buttonCancelEditOperation.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancelEditOperation.Font = new Font("Segoe UI", 12F);
            buttonCancelEditOperation.Location = new Point(269, 225);
            buttonCancelEditOperation.Name = "buttonCancelEditOperation";
            buttonCancelEditOperation.Size = new Size(101, 34);
            buttonCancelEditOperation.TabIndex = 35;
            buttonCancelEditOperation.Text = "Отмена";
            buttonCancelEditOperation.UseVisualStyleBackColor = true;
            buttonCancelEditOperation.Click += buttonCancelEditOperation_Click;
            // 
            // buttonConfirmEditOperation
            // 
            buttonConfirmEditOperation.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonConfirmEditOperation.Font = new Font("Segoe UI", 12F);
            buttonConfirmEditOperation.Location = new Point(376, 225);
            buttonConfirmEditOperation.Name = "buttonConfirmEditOperation";
            buttonConfirmEditOperation.Size = new Size(101, 34);
            buttonConfirmEditOperation.TabIndex = 36;
            buttonConfirmEditOperation.Text = "Сохранить";
            buttonConfirmEditOperation.UseVisualStyleBackColor = true;
            buttonConfirmEditOperation.Click += buttonConfirmEditOperation_Click;
            // 
            // FormEditOperation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 271);
            Controls.Add(buttonConfirmEditOperation);
            Controls.Add(buttonCancelEditOperation);
            Controls.Add(groupBoxAddOperation);
            MaximumSize = new Size(505, 310);
            MinimumSize = new Size(505, 310);
            Name = "FormEditOperation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Изменение операции";
            Load += FormEditOperation_Load;
            groupBoxAddOperation.ResumeLayout(false);
            groupBoxAddOperation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxAddOperation;
        private ComboBox comboBoxOperationName;
        private Label labelOperationDate;
        private TextBox textBoxOperationCustomerID;
        private Label labelOperationCustomerID;
        private TextBox textBoxOperationStuffID;
        private Label labelOperationStuffID;
        private TextBox textBoxOperationBookID;
        private Label labelOperationBookID;
        private DateTimePicker dateTimePickerOperationDate;
        private Label labelOperationName;
        private Button buttonCancelEditOperation;
        private Button buttonConfirmEditOperation;
    }
}