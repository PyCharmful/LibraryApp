namespace LibraryWinFormsApp
{
    partial class FormAddOperation
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
            labelOperationDate = new Label();
            textBoxOperationCustomerID = new TextBox();
            labelOperationCustomerID = new Label();
            textBoxOperationStuffID = new TextBox();
            labelOperationStuffID = new Label();
            textBoxOperationBookID = new TextBox();
            labelOperationBookID = new Label();
            dateTimePickerOperationDate = new DateTimePicker();
            labelOperationName = new Label();
            labelOperationID = new Label();
            textBoxOperationID = new TextBox();
            buttonConfirmAddOperation = new Button();
            buttonCancelAddOperation = new Button();
            comboBoxOperationName = new ComboBox();
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
            groupBoxAddOperation.Controls.Add(labelOperationID);
            groupBoxAddOperation.Controls.Add(textBoxOperationID);
            groupBoxAddOperation.Font = new Font("Segoe UI", 14F);
            groupBoxAddOperation.Location = new Point(12, 12);
            groupBoxAddOperation.Name = "groupBoxAddOperation";
            groupBoxAddOperation.Size = new Size(466, 284);
            groupBoxAddOperation.TabIndex = 33;
            groupBoxAddOperation.TabStop = false;
            groupBoxAddOperation.Text = "Внесение данных";
            // 
            // labelOperationDate
            // 
            labelOperationDate.AutoSize = true;
            labelOperationDate.Font = new Font("Segoe UI", 11F);
            labelOperationDate.Location = new Point(36, 223);
            labelOperationDate.Name = "labelOperationDate";
            labelOperationDate.Size = new Size(115, 20);
            labelOperationDate.TabIndex = 35;
            labelOperationDate.Text = "Дата операции";
            // 
            // textBoxOperationCustomerID
            // 
            textBoxOperationCustomerID.Font = new Font("Segoe UI", 10F);
            textBoxOperationCustomerID.Location = new Point(206, 182);
            textBoxOperationCustomerID.Name = "textBoxOperationCustomerID";
            textBoxOperationCustomerID.Size = new Size(236, 25);
            textBoxOperationCustomerID.TabIndex = 34;
            // 
            // labelOperationCustomerID
            // 
            labelOperationCustomerID.AutoSize = true;
            labelOperationCustomerID.Font = new Font("Segoe UI", 11F);
            labelOperationCustomerID.Location = new Point(36, 183);
            labelOperationCustomerID.Name = "labelOperationCustomerID";
            labelOperationCustomerID.Size = new Size(83, 20);
            labelOperationCustomerID.TabIndex = 33;
            labelOperationCustomerID.Text = "ID клиента";
            // 
            // textBoxOperationStuffID
            // 
            textBoxOperationStuffID.Font = new Font("Segoe UI", 10F);
            textBoxOperationStuffID.Location = new Point(206, 151);
            textBoxOperationStuffID.Name = "textBoxOperationStuffID";
            textBoxOperationStuffID.Size = new Size(236, 25);
            textBoxOperationStuffID.TabIndex = 32;
            // 
            // labelOperationStuffID
            // 
            labelOperationStuffID.AutoSize = true;
            labelOperationStuffID.Font = new Font("Segoe UI", 11F);
            labelOperationStuffID.Location = new Point(36, 152);
            labelOperationStuffID.Name = "labelOperationStuffID";
            labelOperationStuffID.Size = new Size(107, 20);
            labelOperationStuffID.TabIndex = 31;
            labelOperationStuffID.Text = "ID сотрудника";
            // 
            // textBoxOperationBookID
            // 
            textBoxOperationBookID.Font = new Font("Segoe UI", 10F);
            textBoxOperationBookID.Location = new Point(206, 120);
            textBoxOperationBookID.Name = "textBoxOperationBookID";
            textBoxOperationBookID.Size = new Size(236, 25);
            textBoxOperationBookID.TabIndex = 30;
            // 
            // labelOperationBookID
            // 
            labelOperationBookID.AutoSize = true;
            labelOperationBookID.Font = new Font("Segoe UI", 11F);
            labelOperationBookID.Location = new Point(36, 121);
            labelOperationBookID.Name = "labelOperationBookID";
            labelOperationBookID.Size = new Size(68, 20);
            labelOperationBookID.TabIndex = 29;
            labelOperationBookID.Text = "ID книги";
            // 
            // dateTimePickerOperationDate
            // 
            dateTimePickerOperationDate.Location = new Point(206, 213);
            dateTimePickerOperationDate.Name = "dateTimePickerOperationDate";
            dateTimePickerOperationDate.Size = new Size(236, 32);
            dateTimePickerOperationDate.TabIndex = 27;
            // 
            // labelOperationName
            // 
            labelOperationName.AutoSize = true;
            labelOperationName.Font = new Font("Segoe UI", 11F);
            labelOperationName.Location = new Point(36, 88);
            labelOperationName.Name = "labelOperationName";
            labelOperationName.Size = new Size(80, 20);
            labelOperationName.TabIndex = 26;
            labelOperationName.Text = "Операция";
            // 
            // labelOperationID
            // 
            labelOperationID.AutoSize = true;
            labelOperationID.Font = new Font("Segoe UI", 11F);
            labelOperationID.Location = new Point(36, 51);
            labelOperationID.Name = "labelOperationID";
            labelOperationID.Size = new Size(98, 20);
            labelOperationID.TabIndex = 25;
            labelOperationID.Text = "ID операции";
            // 
            // textBoxOperationID
            // 
            textBoxOperationID.Font = new Font("Segoe UI", 10F);
            textBoxOperationID.Location = new Point(206, 50);
            textBoxOperationID.Name = "textBoxOperationID";
            textBoxOperationID.Size = new Size(236, 25);
            textBoxOperationID.TabIndex = 24;
            // 
            // buttonConfirmAddOperation
            // 
            buttonConfirmAddOperation.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonConfirmAddOperation.Font = new Font("Segoe UI", 12F);
            buttonConfirmAddOperation.Location = new Point(403, 302);
            buttonConfirmAddOperation.Name = "buttonConfirmAddOperation";
            buttonConfirmAddOperation.Size = new Size(101, 34);
            buttonConfirmAddOperation.TabIndex = 34;
            buttonConfirmAddOperation.Text = "Добавить";
            buttonConfirmAddOperation.UseVisualStyleBackColor = true;
            // 
            // buttonCancelAddOperation
            // 
            buttonCancelAddOperation.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancelAddOperation.Font = new Font("Segoe UI", 12F);
            buttonCancelAddOperation.Location = new Point(296, 302);
            buttonCancelAddOperation.Name = "buttonCancelAddOperation";
            buttonCancelAddOperation.Size = new Size(101, 34);
            buttonCancelAddOperation.TabIndex = 35;
            buttonCancelAddOperation.Text = "Отмена";
            buttonCancelAddOperation.UseVisualStyleBackColor = true;
            buttonCancelAddOperation.Click += buttonCancelAddOperation_Click;
            // 
            // comboBoxOperationName
            // 
            comboBoxOperationName.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOperationName.FormattingEnabled = true;
            comboBoxOperationName.Items.AddRange(new object[] { "Выдача", "Возврат" });
            comboBoxOperationName.Location = new Point(206, 81);
            comboBoxOperationName.Name = "comboBoxOperationName";
            comboBoxOperationName.Size = new Size(236, 33);
            comboBoxOperationName.TabIndex = 36;
            // 
            // FormAddOperation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 348);
            Controls.Add(buttonCancelAddOperation);
            Controls.Add(buttonConfirmAddOperation);
            Controls.Add(groupBoxAddOperation);
            MinimumSize = new Size(532, 387);
            Name = "FormAddOperation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление операции";
            Load += AddOperationForm_Load;
            groupBoxAddOperation.ResumeLayout(false);
            groupBoxAddOperation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxAddOperation;
        private Label labelOperationDate;
        private TextBox textBoxOperationCustomerID;
        private Label labelOperationCustomerID;
        private TextBox textBoxOperationStuffID;
        private Label labelOperationStuffID;
        private TextBox textBoxOperationBookID;
        private Label labelOperationBookID;
        private DateTimePicker dateTimePickerOperationDate;
        private Label labelOperationName;
        private Label labelOperationID;
        private TextBox textBoxOperationID;
        private Button buttonConfirmAddOperation;
        private Button buttonCancelAddOperation;
        private ComboBox comboBoxOperationName;
    }
}