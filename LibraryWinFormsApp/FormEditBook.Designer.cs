namespace LibraryWinFormsApp
{
    partial class FormEditBook
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
            groupBoxEditBook = new GroupBox();
            labelBookInvNumber = new Label();
            textBoxBookInvNumber = new TextBox();
            labelBookName = new Label();
            textBoxBookGenre = new TextBox();
            textBoxBookName = new TextBox();
            labelBookGenre = new Label();
            labelBookAuthor = new Label();
            textBoxBookPublicationYear = new TextBox();
            textBoxBookAuthor = new TextBox();
            labelBookPublicationYear = new Label();
            labelBookPublisher = new Label();
            textBoxBookPublisher = new TextBox();
            buttonCancelEditBook = new Button();
            buttonConfirmEditBook = new Button();
            groupBoxEditBook.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxEditBook
            // 
            groupBoxEditBook.Controls.Add(labelBookInvNumber);
            groupBoxEditBook.Controls.Add(textBoxBookInvNumber);
            groupBoxEditBook.Controls.Add(labelBookName);
            groupBoxEditBook.Controls.Add(textBoxBookGenre);
            groupBoxEditBook.Controls.Add(textBoxBookName);
            groupBoxEditBook.Controls.Add(labelBookGenre);
            groupBoxEditBook.Controls.Add(labelBookAuthor);
            groupBoxEditBook.Controls.Add(textBoxBookPublicationYear);
            groupBoxEditBook.Controls.Add(textBoxBookAuthor);
            groupBoxEditBook.Controls.Add(labelBookPublicationYear);
            groupBoxEditBook.Controls.Add(labelBookPublisher);
            groupBoxEditBook.Controls.Add(textBoxBookPublisher);
            groupBoxEditBook.Font = new Font("Segoe UI", 14F);
            groupBoxEditBook.Location = new Point(12, 12);
            groupBoxEditBook.Name = "groupBoxEditBook";
            groupBoxEditBook.Size = new Size(430, 242);
            groupBoxEditBook.TabIndex = 31;
            groupBoxEditBook.TabStop = false;
            groupBoxEditBook.Text = "Изменение данных";
            // 
            // labelBookInvNumber
            // 
            labelBookInvNumber.AutoSize = true;
            labelBookInvNumber.Font = new Font("Segoe UI", 11F);
            labelBookInvNumber.Location = new Point(23, 39);
            labelBookInvNumber.Name = "labelBookInvNumber";
            labelBookInvNumber.Size = new Size(90, 20);
            labelBookInvNumber.TabIndex = 16;
            labelBookInvNumber.Text = "Инв. номер";
            // 
            // textBoxBookInvNumber
            // 
            textBoxBookInvNumber.Font = new Font("Segoe UI", 10F);
            textBoxBookInvNumber.Location = new Point(176, 42);
            textBoxBookInvNumber.Name = "textBoxBookInvNumber";
            textBoxBookInvNumber.Size = new Size(236, 25);
            textBoxBookInvNumber.TabIndex = 17;
            // 
            // labelBookName
            // 
            labelBookName.AutoSize = true;
            labelBookName.Font = new Font("Segoe UI", 11F);
            labelBookName.Location = new Point(23, 74);
            labelBookName.Name = "labelBookName";
            labelBookName.Size = new Size(90, 20);
            labelBookName.TabIndex = 18;
            labelBookName.Text = "Назв. книги";
            // 
            // textBoxBookGenre
            // 
            textBoxBookGenre.Font = new Font("Segoe UI", 10F);
            textBoxBookGenre.Location = new Point(176, 197);
            textBoxBookGenre.Name = "textBoxBookGenre";
            textBoxBookGenre.Size = new Size(236, 25);
            textBoxBookGenre.TabIndex = 27;
            // 
            // textBoxBookName
            // 
            textBoxBookName.Font = new Font("Segoe UI", 10F);
            textBoxBookName.Location = new Point(176, 73);
            textBoxBookName.Name = "textBoxBookName";
            textBoxBookName.Size = new Size(236, 25);
            textBoxBookName.TabIndex = 19;
            // 
            // labelBookGenre
            // 
            labelBookGenre.AutoSize = true;
            labelBookGenre.Font = new Font("Segoe UI", 11F);
            labelBookGenre.Location = new Point(23, 198);
            labelBookGenre.Name = "labelBookGenre";
            labelBookGenre.Size = new Size(48, 20);
            labelBookGenre.TabIndex = 26;
            labelBookGenre.Text = "Жанр";
            // 
            // labelBookAuthor
            // 
            labelBookAuthor.AutoSize = true;
            labelBookAuthor.Font = new Font("Segoe UI", 11F);
            labelBookAuthor.Location = new Point(23, 105);
            labelBookAuthor.Name = "labelBookAuthor";
            labelBookAuthor.Size = new Size(51, 20);
            labelBookAuthor.TabIndex = 20;
            labelBookAuthor.Text = "Автор";
            // 
            // textBoxBookPublicationYear
            // 
            textBoxBookPublicationYear.Font = new Font("Segoe UI", 10F);
            textBoxBookPublicationYear.Location = new Point(176, 166);
            textBoxBookPublicationYear.Name = "textBoxBookPublicationYear";
            textBoxBookPublicationYear.Size = new Size(236, 25);
            textBoxBookPublicationYear.TabIndex = 25;
            // 
            // textBoxBookAuthor
            // 
            textBoxBookAuthor.Font = new Font("Segoe UI", 10F);
            textBoxBookAuthor.Location = new Point(176, 104);
            textBoxBookAuthor.Name = "textBoxBookAuthor";
            textBoxBookAuthor.Size = new Size(236, 25);
            textBoxBookAuthor.TabIndex = 21;
            // 
            // labelBookPublicationYear
            // 
            labelBookPublicationYear.AutoSize = true;
            labelBookPublicationYear.Font = new Font("Segoe UI", 11F);
            labelBookPublicationYear.Location = new Point(23, 167);
            labelBookPublicationYear.Name = "labelBookPublicationYear";
            labelBookPublicationYear.Size = new Size(121, 20);
            labelBookPublicationYear.TabIndex = 24;
            labelBookPublicationYear.Text = "Год публикации";
            // 
            // labelBookPublisher
            // 
            labelBookPublisher.AutoSize = true;
            labelBookPublisher.Font = new Font("Segoe UI", 11F);
            labelBookPublisher.Location = new Point(23, 136);
            labelBookPublisher.Name = "labelBookPublisher";
            labelBookPublisher.Size = new Size(73, 20);
            labelBookPublisher.TabIndex = 22;
            labelBookPublisher.Text = "Издатель";
            // 
            // textBoxBookPublisher
            // 
            textBoxBookPublisher.Font = new Font("Segoe UI", 10F);
            textBoxBookPublisher.Location = new Point(176, 135);
            textBoxBookPublisher.Name = "textBoxBookPublisher";
            textBoxBookPublisher.Size = new Size(236, 25);
            textBoxBookPublisher.TabIndex = 23;
            // 
            // buttonCancelEditBook
            // 
            buttonCancelEditBook.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancelEditBook.Font = new Font("Segoe UI", 12F);
            buttonCancelEditBook.Location = new Point(238, 272);
            buttonCancelEditBook.Name = "buttonCancelEditBook";
            buttonCancelEditBook.Size = new Size(101, 34);
            buttonCancelEditBook.TabIndex = 32;
            buttonCancelEditBook.Text = "Отмена";
            buttonCancelEditBook.UseVisualStyleBackColor = true;
            buttonCancelEditBook.Click += buttonCancelEditBook_Click;
            // 
            // buttonConfirmEditBook
            // 
            buttonConfirmEditBook.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonConfirmEditBook.Font = new Font("Segoe UI", 12F);
            buttonConfirmEditBook.Location = new Point(345, 272);
            buttonConfirmEditBook.Name = "buttonConfirmEditBook";
            buttonConfirmEditBook.Size = new Size(101, 34);
            buttonConfirmEditBook.TabIndex = 33;
            buttonConfirmEditBook.Text = "Сохранить";
            buttonConfirmEditBook.UseVisualStyleBackColor = true;
            buttonConfirmEditBook.Click += buttonConfirmEditBook_Click;
            // 
            // FormEditBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 318);
            Controls.Add(buttonConfirmEditBook);
            Controls.Add(buttonCancelEditBook);
            Controls.Add(groupBoxEditBook);
            MaximumSize = new Size(474, 357);
            Name = "FormEditBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Редактирование книги";
            Load += FormEditBook_Load;
            groupBoxEditBook.ResumeLayout(false);
            groupBoxEditBook.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxEditBook;
        private Label labelBookInvNumber;
        private TextBox textBoxBookInvNumber;
        private Label labelBookName;
        private TextBox textBoxBookGenre;
        private TextBox textBoxBookName;
        private Label labelBookGenre;
        private Label labelBookAuthor;
        private TextBox textBoxBookPublicationYear;
        private TextBox textBoxBookAuthor;
        private Label labelBookPublicationYear;
        private Label labelBookPublisher;
        private TextBox textBoxBookPublisher;
        private Button buttonCancelEditBook;
        private Button buttonConfirmEditBook;
    }
}