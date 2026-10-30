namespace LibraryWinFormsApp
{
    partial class FormAddCustomer
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
            groupBoxAddCustomer = new GroupBox();
            buttonConfirmAddCustomer = new Button();
            buttonCancelAddCustomer = new Button();
            textBoxCustomerID = new TextBox();
            textBoxCustomerSecondName = new TextBox();
            textBoxCustomerFirstName = new TextBox();
            textBoxCustomerThirdName = new TextBox();
            textBoxCustomerBirthDate = new TextBox();
            textBoxCustomerAddress = new TextBox();
            textBoxCustomerPhoneNumber = new TextBox();
            textBoxCustomerEmail = new TextBox();
            labelCustomerEmail = new Label();
            labelCustomerPhoneNumber = new Label();
            labelCustomerAddress = new Label();
            labelCustomerBirthDate = new Label();
            labelCustomerThirdName = new Label();
            labelCustomerFirstName = new Label();
            labelCustomerSecondName = new Label();
            labelCustomerID = new Label();
            groupBoxAddCustomer.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxAddCustomer
            // 
            groupBoxAddCustomer.Controls.Add(textBoxCustomerEmail);
            groupBoxAddCustomer.Controls.Add(labelCustomerEmail);
            groupBoxAddCustomer.Controls.Add(textBoxCustomerPhoneNumber);
            groupBoxAddCustomer.Controls.Add(labelCustomerPhoneNumber);
            groupBoxAddCustomer.Controls.Add(textBoxCustomerAddress);
            groupBoxAddCustomer.Controls.Add(labelCustomerAddress);
            groupBoxAddCustomer.Controls.Add(textBoxCustomerBirthDate);
            groupBoxAddCustomer.Controls.Add(labelCustomerBirthDate);
            groupBoxAddCustomer.Controls.Add(textBoxCustomerThirdName);
            groupBoxAddCustomer.Controls.Add(labelCustomerThirdName);
            groupBoxAddCustomer.Controls.Add(textBoxCustomerFirstName);
            groupBoxAddCustomer.Controls.Add(labelCustomerFirstName);
            groupBoxAddCustomer.Controls.Add(textBoxCustomerSecondName);
            groupBoxAddCustomer.Controls.Add(labelCustomerSecondName);
            groupBoxAddCustomer.Controls.Add(labelCustomerID);
            groupBoxAddCustomer.Controls.Add(textBoxCustomerID);
            groupBoxAddCustomer.Font = new Font("Segoe UI", 14F);
            groupBoxAddCustomer.Location = new Point(12, 12);
            groupBoxAddCustomer.Name = "groupBoxAddCustomer";
            groupBoxAddCustomer.Size = new Size(481, 309);
            groupBoxAddCustomer.TabIndex = 32;
            groupBoxAddCustomer.TabStop = false;
            groupBoxAddCustomer.Text = "Внесение данных";
            // 
            // buttonConfirmAddCustomer
            // 
            buttonConfirmAddCustomer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonConfirmAddCustomer.Font = new Font("Segoe UI", 12F);
            buttonConfirmAddCustomer.Location = new Point(396, 343);
            buttonConfirmAddCustomer.Name = "buttonConfirmAddCustomer";
            buttonConfirmAddCustomer.Size = new Size(101, 34);
            buttonConfirmAddCustomer.TabIndex = 33;
            buttonConfirmAddCustomer.Text = "Добавить";
            buttonConfirmAddCustomer.UseVisualStyleBackColor = true;
            // 
            // buttonCancelAddCustomer
            // 
            buttonCancelAddCustomer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancelAddCustomer.Font = new Font("Segoe UI", 12F);
            buttonCancelAddCustomer.Location = new Point(289, 343);
            buttonCancelAddCustomer.Name = "buttonCancelAddCustomer";
            buttonCancelAddCustomer.Size = new Size(101, 34);
            buttonCancelAddCustomer.TabIndex = 34;
            buttonCancelAddCustomer.Text = "Отмена";
            buttonCancelAddCustomer.UseVisualStyleBackColor = true;
            buttonCancelAddCustomer.Click += buttonCancelAddCustomer_Click;
            // 
            // textBoxCustomerID
            // 
            textBoxCustomerID.Font = new Font("Segoe UI", 10F);
            textBoxCustomerID.Location = new Point(216, 42);
            textBoxCustomerID.Name = "textBoxCustomerID";
            textBoxCustomerID.Size = new Size(236, 25);
            textBoxCustomerID.TabIndex = 17;
            // 
            // textBoxCustomerSecondName
            // 
            textBoxCustomerSecondName.Font = new Font("Segoe UI", 10F);
            textBoxCustomerSecondName.Location = new Point(216, 73);
            textBoxCustomerSecondName.Name = "textBoxCustomerSecondName";
            textBoxCustomerSecondName.Size = new Size(236, 25);
            textBoxCustomerSecondName.TabIndex = 20;
            // 
            // textBoxCustomerFirstName
            // 
            textBoxCustomerFirstName.Font = new Font("Segoe UI", 10F);
            textBoxCustomerFirstName.Location = new Point(216, 104);
            textBoxCustomerFirstName.Name = "textBoxCustomerFirstName";
            textBoxCustomerFirstName.Size = new Size(236, 25);
            textBoxCustomerFirstName.TabIndex = 22;
            // 
            // textBoxCustomerThirdName
            // 
            textBoxCustomerThirdName.Font = new Font("Segoe UI", 10F);
            textBoxCustomerThirdName.Location = new Point(216, 135);
            textBoxCustomerThirdName.Name = "textBoxCustomerThirdName";
            textBoxCustomerThirdName.Size = new Size(236, 25);
            textBoxCustomerThirdName.TabIndex = 24;
            // 
            // textBoxCustomerBirthDate
            // 
            textBoxCustomerBirthDate.Font = new Font("Segoe UI", 10F);
            textBoxCustomerBirthDate.Location = new Point(216, 166);
            textBoxCustomerBirthDate.Name = "textBoxCustomerBirthDate";
            textBoxCustomerBirthDate.Size = new Size(236, 25);
            textBoxCustomerBirthDate.TabIndex = 26;
            // 
            // textBoxCustomerAddress
            // 
            textBoxCustomerAddress.Font = new Font("Segoe UI", 10F);
            textBoxCustomerAddress.Location = new Point(216, 197);
            textBoxCustomerAddress.Name = "textBoxCustomerAddress";
            textBoxCustomerAddress.Size = new Size(236, 25);
            textBoxCustomerAddress.TabIndex = 28;
            // 
            // textBoxCustomerPhoneNumber
            // 
            textBoxCustomerPhoneNumber.Font = new Font("Segoe UI", 10F);
            textBoxCustomerPhoneNumber.Location = new Point(216, 228);
            textBoxCustomerPhoneNumber.Name = "textBoxCustomerPhoneNumber";
            textBoxCustomerPhoneNumber.Size = new Size(236, 25);
            textBoxCustomerPhoneNumber.TabIndex = 30;
            // 
            // textBoxCustomerEmail
            // 
            textBoxCustomerEmail.Font = new Font("Segoe UI", 10F);
            textBoxCustomerEmail.Location = new Point(216, 259);
            textBoxCustomerEmail.Name = "textBoxCustomerEmail";
            textBoxCustomerEmail.Size = new Size(236, 25);
            textBoxCustomerEmail.TabIndex = 32;
            // 
            // labelCustomerEmail
            // 
            labelCustomerEmail.AutoSize = true;
            labelCustomerEmail.Font = new Font("Segoe UI", 11F);
            labelCustomerEmail.Location = new Point(27, 260);
            labelCustomerEmail.Name = "labelCustomerEmail";
            labelCustomerEmail.Size = new Size(143, 20);
            labelCustomerEmail.TabIndex = 31;
            labelCustomerEmail.Text = "Электронная почта";
            // 
            // labelCustomerPhoneNumber
            // 
            labelCustomerPhoneNumber.AutoSize = true;
            labelCustomerPhoneNumber.Font = new Font("Segoe UI", 11F);
            labelCustomerPhoneNumber.Location = new Point(27, 229);
            labelCustomerPhoneNumber.Name = "labelCustomerPhoneNumber";
            labelCustomerPhoneNumber.Size = new Size(148, 20);
            labelCustomerPhoneNumber.TabIndex = 29;
            labelCustomerPhoneNumber.Text = "Телефонный номер";
            // 
            // labelCustomerAddress
            // 
            labelCustomerAddress.AutoSize = true;
            labelCustomerAddress.Font = new Font("Segoe UI", 11F);
            labelCustomerAddress.Location = new Point(27, 198);
            labelCustomerAddress.Name = "labelCustomerAddress";
            labelCustomerAddress.Size = new Size(51, 20);
            labelCustomerAddress.TabIndex = 27;
            labelCustomerAddress.Text = "Адрес";
            // 
            // labelCustomerBirthDate
            // 
            labelCustomerBirthDate.AutoSize = true;
            labelCustomerBirthDate.Font = new Font("Segoe UI", 11F);
            labelCustomerBirthDate.Location = new Point(27, 167);
            labelCustomerBirthDate.Name = "labelCustomerBirthDate";
            labelCustomerBirthDate.Size = new Size(116, 20);
            labelCustomerBirthDate.TabIndex = 25;
            labelCustomerBirthDate.Text = "Дата рождения";
            // 
            // labelCustomerThirdName
            // 
            labelCustomerThirdName.AutoSize = true;
            labelCustomerThirdName.Font = new Font("Segoe UI", 11F);
            labelCustomerThirdName.Location = new Point(27, 136);
            labelCustomerThirdName.Name = "labelCustomerThirdName";
            labelCustomerThirdName.Size = new Size(72, 20);
            labelCustomerThirdName.TabIndex = 23;
            labelCustomerThirdName.Text = "Отчество";
            // 
            // labelCustomerFirstName
            // 
            labelCustomerFirstName.AutoSize = true;
            labelCustomerFirstName.Font = new Font("Segoe UI", 11F);
            labelCustomerFirstName.Location = new Point(27, 105);
            labelCustomerFirstName.Name = "labelCustomerFirstName";
            labelCustomerFirstName.Size = new Size(39, 20);
            labelCustomerFirstName.TabIndex = 21;
            labelCustomerFirstName.Text = "Имя";
            // 
            // labelCustomerSecondName
            // 
            labelCustomerSecondName.AutoSize = true;
            labelCustomerSecondName.Font = new Font("Segoe UI", 11F);
            labelCustomerSecondName.Location = new Point(27, 74);
            labelCustomerSecondName.Name = "labelCustomerSecondName";
            labelCustomerSecondName.Size = new Size(73, 20);
            labelCustomerSecondName.TabIndex = 19;
            labelCustomerSecondName.Text = "Фамилия";
            // 
            // labelCustomerID
            // 
            labelCustomerID.AutoSize = true;
            labelCustomerID.Font = new Font("Segoe UI", 11F);
            labelCustomerID.Location = new Point(27, 43);
            labelCustomerID.Name = "labelCustomerID";
            labelCustomerID.Size = new Size(83, 20);
            labelCustomerID.TabIndex = 18;
            labelCustomerID.Text = "ID клиента";
            // 
            // FormAddCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 389);
            Controls.Add(buttonCancelAddCustomer);
            Controls.Add(buttonConfirmAddCustomer);
            Controls.Add(groupBoxAddCustomer);
            MinimumSize = new Size(525, 428);
            Name = "FormAddCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление клиента";
            groupBoxAddCustomer.ResumeLayout(false);
            groupBoxAddCustomer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxAddCustomer;
        private Button buttonConfirmAddCustomer;
        private Button buttonCancelAddCustomer;
        private TextBox textBoxCustomerEmail;
        private Label labelCustomerEmail;
        private TextBox textBoxCustomerPhoneNumber;
        private Label labelCustomerPhoneNumber;
        private TextBox textBoxCustomerAddress;
        private Label labelCustomerAddress;
        private TextBox textBoxCustomerBirthDate;
        private Label labelCustomerBirthDate;
        private TextBox textBoxCustomerThirdName;
        private Label labelCustomerThirdName;
        private TextBox textBoxCustomerFirstName;
        private Label labelCustomerFirstName;
        private TextBox textBoxCustomerSecondName;
        private Label labelCustomerSecondName;
        private Label labelCustomerID;
        private TextBox textBoxCustomerID;
    }
}