namespace LibraryWinFormsApp
{
    partial class FormEditCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditCustomer));
            groupBoxEditCustomer = new GroupBox();
            textBoxCustomerEmail = new TextBox();
            labelCustomerEmail = new Label();
            textBoxCustomerPhoneNumber = new TextBox();
            labelCustomerPhoneNumber = new Label();
            textBoxCustomerAddress = new TextBox();
            labelCustomerAddress = new Label();
            textBoxCustomerBirthDate = new TextBox();
            labelCustomerBirthDate = new Label();
            textBoxCustomerThirdName = new TextBox();
            labelCustomerThirdName = new Label();
            textBoxCustomerFirstName = new TextBox();
            labelCustomerFirstName = new Label();
            textBoxCustomerSecondName = new TextBox();
            labelCustomerSecondName = new Label();
            buttonCancelEditCustomer = new Button();
            buttonConfirmEditCustomer = new Button();
            groupBoxEditCustomer.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxEditCustomer
            // 
            groupBoxEditCustomer.Controls.Add(textBoxCustomerEmail);
            groupBoxEditCustomer.Controls.Add(labelCustomerEmail);
            groupBoxEditCustomer.Controls.Add(textBoxCustomerPhoneNumber);
            groupBoxEditCustomer.Controls.Add(labelCustomerPhoneNumber);
            groupBoxEditCustomer.Controls.Add(textBoxCustomerAddress);
            groupBoxEditCustomer.Controls.Add(labelCustomerAddress);
            groupBoxEditCustomer.Controls.Add(textBoxCustomerBirthDate);
            groupBoxEditCustomer.Controls.Add(labelCustomerBirthDate);
            groupBoxEditCustomer.Controls.Add(textBoxCustomerThirdName);
            groupBoxEditCustomer.Controls.Add(labelCustomerThirdName);
            groupBoxEditCustomer.Controls.Add(textBoxCustomerFirstName);
            groupBoxEditCustomer.Controls.Add(labelCustomerFirstName);
            groupBoxEditCustomer.Controls.Add(textBoxCustomerSecondName);
            groupBoxEditCustomer.Controls.Add(labelCustomerSecondName);
            resources.ApplyResources(groupBoxEditCustomer, "groupBoxEditCustomer");
            groupBoxEditCustomer.Name = "groupBoxEditCustomer";
            groupBoxEditCustomer.TabStop = false;
            // 
            // textBoxCustomerEmail
            // 
            resources.ApplyResources(textBoxCustomerEmail, "textBoxCustomerEmail");
            textBoxCustomerEmail.Name = "textBoxCustomerEmail";
            // 
            // labelCustomerEmail
            // 
            resources.ApplyResources(labelCustomerEmail, "labelCustomerEmail");
            labelCustomerEmail.Name = "labelCustomerEmail";
            // 
            // textBoxCustomerPhoneNumber
            // 
            resources.ApplyResources(textBoxCustomerPhoneNumber, "textBoxCustomerPhoneNumber");
            textBoxCustomerPhoneNumber.Name = "textBoxCustomerPhoneNumber";
            // 
            // labelCustomerPhoneNumber
            // 
            resources.ApplyResources(labelCustomerPhoneNumber, "labelCustomerPhoneNumber");
            labelCustomerPhoneNumber.Name = "labelCustomerPhoneNumber";
            // 
            // textBoxCustomerAddress
            // 
            resources.ApplyResources(textBoxCustomerAddress, "textBoxCustomerAddress");
            textBoxCustomerAddress.Name = "textBoxCustomerAddress";
            // 
            // labelCustomerAddress
            // 
            resources.ApplyResources(labelCustomerAddress, "labelCustomerAddress");
            labelCustomerAddress.Name = "labelCustomerAddress";
            // 
            // textBoxCustomerBirthDate
            // 
            resources.ApplyResources(textBoxCustomerBirthDate, "textBoxCustomerBirthDate");
            textBoxCustomerBirthDate.Name = "textBoxCustomerBirthDate";
            // 
            // labelCustomerBirthDate
            // 
            resources.ApplyResources(labelCustomerBirthDate, "labelCustomerBirthDate");
            labelCustomerBirthDate.Name = "labelCustomerBirthDate";
            // 
            // textBoxCustomerThirdName
            // 
            resources.ApplyResources(textBoxCustomerThirdName, "textBoxCustomerThirdName");
            textBoxCustomerThirdName.Name = "textBoxCustomerThirdName";
            // 
            // labelCustomerThirdName
            // 
            resources.ApplyResources(labelCustomerThirdName, "labelCustomerThirdName");
            labelCustomerThirdName.Name = "labelCustomerThirdName";
            // 
            // textBoxCustomerFirstName
            // 
            resources.ApplyResources(textBoxCustomerFirstName, "textBoxCustomerFirstName");
            textBoxCustomerFirstName.Name = "textBoxCustomerFirstName";
            // 
            // labelCustomerFirstName
            // 
            resources.ApplyResources(labelCustomerFirstName, "labelCustomerFirstName");
            labelCustomerFirstName.Name = "labelCustomerFirstName";
            // 
            // textBoxCustomerSecondName
            // 
            resources.ApplyResources(textBoxCustomerSecondName, "textBoxCustomerSecondName");
            textBoxCustomerSecondName.Name = "textBoxCustomerSecondName";
            // 
            // labelCustomerSecondName
            // 
            resources.ApplyResources(labelCustomerSecondName, "labelCustomerSecondName");
            labelCustomerSecondName.Name = "labelCustomerSecondName";
            // 
            // buttonCancelEditCustomer
            // 
            resources.ApplyResources(buttonCancelEditCustomer, "buttonCancelEditCustomer");
            buttonCancelEditCustomer.Name = "buttonCancelEditCustomer";
            buttonCancelEditCustomer.UseVisualStyleBackColor = true;
            buttonCancelEditCustomer.Click += buttonCancelEditCustomer_Click;
            // 
            // buttonConfirmEditCustomer
            // 
            resources.ApplyResources(buttonConfirmEditCustomer, "buttonConfirmEditCustomer");
            buttonConfirmEditCustomer.Name = "buttonConfirmEditCustomer";
            buttonConfirmEditCustomer.UseVisualStyleBackColor = true;
            buttonConfirmEditCustomer.Click += buttonConfirmEditCustomer_Click;
            // 
            // FormEditCustomer
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonConfirmEditCustomer);
            Controls.Add(buttonCancelEditCustomer);
            Controls.Add(groupBoxEditCustomer);
            Name = "FormEditCustomer";
            Load += FormEditCustomer_Load;
            groupBoxEditCustomer.ResumeLayout(false);
            groupBoxEditCustomer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxEditCustomer;
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
        private Button buttonCancelEditCustomer;
        private Button buttonConfirmEditCustomer;
    }
}