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
            textBoxOperationBookInvNumber = new TextBox();
            labelOperationBookInvNumber = new Label();
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
            groupBoxAddOperation.Controls.Add(textBoxOperationBookInvNumber);
            groupBoxAddOperation.Controls.Add(labelOperationBookInvNumber);
            groupBoxAddOperation.Controls.Add(dateTimePickerOperationDate);
            groupBoxAddOperation.Controls.Add(labelOperationName);
            groupBoxAddOperation.Font = new Font("Segoe UI", 14F);
            groupBoxAddOperation.Location = new Point(12, 12);
            groupBoxAddOperation.Name = "groupBoxAddOperation";
            groupBoxAddOperation.Size = new Size(484, 205);
            groupBoxAddOperation.TabIndex = 34;
            groupBoxAddOperation.TabStop = false;
            groupBoxAddOperation.Text = "Изменение данных";
            // 
            // comboBoxOperationName
            // 
            comboBoxOperationName.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOperationName.FormattingEnabled = true;
            comboBoxOperationName.Items.AddRange(new object[] { "Выдача", "Возврат" });
            comboBoxOperationName.Location = new Point(233, 21);
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
            textBoxOperationCustomerID.Location = new Point(233, 122);
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
            textBoxOperationStuffID.Location = new Point(233, 91);
            textBoxOperationStuffID.Name = "textBoxOperationStuffID";
            textBoxOperationStuffID.Size = new Size(236, 25);
            textBoxOperationStuffID.TabIndex = 32;
            // 
            // labelOperationStuffID
            // 
            labelOperationStuffID.AutoSize = true;
            labelOperationStuffID.Font = new Font("Segoe UI", 11F);
            labelOperationStuffID.Location = new Point(36, 91);
            labelOperationStuffID.Name = "labelOperationStuffID";
            labelOperationStuffID.Size = new Size(107, 20);
            labelOperationStuffID.TabIndex = 31;
            labelOperationStuffID.Text = "ID сотрудника";
            // 
            // textBoxOperationBookInvNumber
            // 
            textBoxOperationBookInvNumber.Font = new Font("Segoe UI", 10F);
            textBoxOperationBookInvNumber.Location = new Point(233, 60);
            textBoxOperationBookInvNumber.Name = "textBoxOperationBookInvNumber";
            textBoxOperationBookInvNumber.Size = new Size(236, 25);
            textBoxOperationBookInvNumber.TabIndex = 30;
            // 
            // labelOperationBookInvNumber
            // 
            labelOperationBookInvNumber.AutoSize = true;
            labelOperationBookInvNumber.Font = new Font("Segoe UI", 11F);
            labelOperationBookInvNumber.Location = new Point(36, 61);
            labelOperationBookInvNumber.Name = "labelOperationBookInvNumber";
            labelOperationBookInvNumber.Size = new Size(191, 20);
            labelOperationBookInvNumber.TabIndex = 29;
            labelOperationBookInvNumber.Text = "Инвентарны номер книги";
            // 
            // dateTimePickerOperationDate
            // 
            dateTimePickerOperationDate.Location = new Point(233, 153);
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
            buttonCancelEditOperation.Location = new Point(289, 225);
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
            buttonConfirmEditOperation.Location = new Point(396, 225);
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
            ClientSize = new Size(509, 271);
            Controls.Add(buttonConfirmEditOperation);
            Controls.Add(buttonCancelEditOperation);
            Controls.Add(groupBoxAddOperation);
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
        private TextBox textBoxOperationBookInvNumber;
        private Label labelOperationBookInvNumber;
        private DateTimePicker dateTimePickerOperationDate;
        private Label labelOperationName;
        private Button buttonCancelEditOperation;
        private Button buttonConfirmEditOperation;
    }
}