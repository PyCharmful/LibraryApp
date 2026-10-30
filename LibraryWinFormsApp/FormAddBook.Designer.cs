namespace LibraryWinFormsApp
{
    partial class FormAddBook
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
            textBoxBookGenre = new TextBox();
            labelBookGenre = new Label();
            textBoxBookPublicationYear = new TextBox();
            labelBookPublicationYear = new Label();
            textBoxBookPublisher = new TextBox();
            labelBookPublisher = new Label();
            textBoxBookAuthor = new TextBox();
            labelBookAuthor = new Label();
            textBoxBookName = new TextBox();
            labelBookName = new Label();
            textBoxBookInvNumber = new TextBox();
            labelBookInvNumber = new Label();
            buttonConfirmAddBook = new Button();
            buttonCancelAddBook = new Button();
            groupBoxAddBook = new GroupBox();
            groupBoxAddBook.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxBookGenre
            // 
            textBoxBookGenre.Font = new Font("Segoe UI", 10F);
            textBoxBookGenre.Location = new Point(176, 197);
            textBoxBookGenre.Name = "textBoxBookGenre";
            textBoxBookGenre.Size = new Size(236, 25);
            textBoxBookGenre.TabIndex = 27;
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
            // textBoxBookPublicationYear
            // 
            textBoxBookPublicationYear.Font = new Font("Segoe UI", 10F);
            textBoxBookPublicationYear.Location = new Point(176, 166);
            textBoxBookPublicationYear.Name = "textBoxBookPublicationYear";
            textBoxBookPublicationYear.Size = new Size(236, 25);
            textBoxBookPublicationYear.TabIndex = 25;
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
            // textBoxBookPublisher
            // 
            textBoxBookPublisher.Font = new Font("Segoe UI", 10F);
            textBoxBookPublisher.Location = new Point(176, 135);
            textBoxBookPublisher.Name = "textBoxBookPublisher";
            textBoxBookPublisher.Size = new Size(236, 25);
            textBoxBookPublisher.TabIndex = 23;
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
            // textBoxBookAuthor
            // 
            textBoxBookAuthor.Font = new Font("Segoe UI", 10F);
            textBoxBookAuthor.Location = new Point(176, 104);
            textBoxBookAuthor.Name = "textBoxBookAuthor";
            textBoxBookAuthor.Size = new Size(236, 25);
            textBoxBookAuthor.TabIndex = 21;
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
            // textBoxBookName
            // 
            textBoxBookName.Font = new Font("Segoe UI", 10F);
            textBoxBookName.Location = new Point(176, 73);
            textBoxBookName.Name = "textBoxBookName";
            textBoxBookName.Size = new Size(236, 25);
            textBoxBookName.TabIndex = 19;
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
            // textBoxBookInvNumber
            // 
            textBoxBookInvNumber.Font = new Font("Segoe UI", 10F);
            textBoxBookInvNumber.Location = new Point(176, 42);
            textBoxBookInvNumber.Name = "textBoxBookInvNumber";
            textBoxBookInvNumber.Size = new Size(236, 25);
            textBoxBookInvNumber.TabIndex = 17;
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
            // buttonConfirmAddBook
            // 
            buttonConfirmAddBook.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonConfirmAddBook.Font = new Font("Segoe UI", 12F);
            buttonConfirmAddBook.Location = new Point(339, 271);
            buttonConfirmAddBook.Name = "buttonConfirmAddBook";
            buttonConfirmAddBook.Size = new Size(101, 34);
            buttonConfirmAddBook.TabIndex = 28;
            buttonConfirmAddBook.Text = "Добавить";
            buttonConfirmAddBook.UseVisualStyleBackColor = true;
            buttonConfirmAddBook.Click += buttonConfirmAddBook_Click;
            // 
            // buttonCancelAddBook
            // 
            buttonCancelAddBook.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancelAddBook.Font = new Font("Segoe UI", 12F);
            buttonCancelAddBook.Location = new Point(232, 271);
            buttonCancelAddBook.Name = "buttonCancelAddBook";
            buttonCancelAddBook.Size = new Size(101, 34);
            buttonCancelAddBook.TabIndex = 29;
            buttonCancelAddBook.Text = "Отмена";
            buttonCancelAddBook.UseVisualStyleBackColor = true;
            buttonCancelAddBook.Click += buttonCancelAddBook_Click;
            // 
            // groupBoxAddBook
            // 
            groupBoxAddBook.Controls.Add(labelBookInvNumber);
            groupBoxAddBook.Controls.Add(textBoxBookInvNumber);
            groupBoxAddBook.Controls.Add(labelBookName);
            groupBoxAddBook.Controls.Add(textBoxBookGenre);
            groupBoxAddBook.Controls.Add(textBoxBookName);
            groupBoxAddBook.Controls.Add(labelBookGenre);
            groupBoxAddBook.Controls.Add(labelBookAuthor);
            groupBoxAddBook.Controls.Add(textBoxBookPublicationYear);
            groupBoxAddBook.Controls.Add(textBoxBookAuthor);
            groupBoxAddBook.Controls.Add(labelBookPublicationYear);
            groupBoxAddBook.Controls.Add(labelBookPublisher);
            groupBoxAddBook.Controls.Add(textBoxBookPublisher);
            groupBoxAddBook.Font = new Font("Segoe UI", 14F);
            groupBoxAddBook.Location = new Point(12, 12);
            groupBoxAddBook.Name = "groupBoxAddBook";
            groupBoxAddBook.Size = new Size(430, 242);
            groupBoxAddBook.TabIndex = 30;
            groupBoxAddBook.TabStop = false;
            groupBoxAddBook.Text = "Внесение данных";
            // 
            // AddBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 318);
            Controls.Add(groupBoxAddBook);
            Controls.Add(buttonCancelAddBook);
            Controls.Add(buttonConfirmAddBook);
            MinimumSize = new Size(474, 357);
            Name = "AddBookForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление книги";
            Load += AddBookForm_Load;
            groupBoxAddBook.ResumeLayout(false);
            groupBoxAddBook.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxBookGenre;
        private Label labelBookGenre;
        private TextBox textBoxBookPublicationYear;
        private Label labelBookPublicationYear;
        private TextBox textBoxBookPublisher;
        private Label labelBookPublisher;
        private TextBox textBoxBookAuthor;
        private Label labelBookAuthor;
        private TextBox textBoxBookName;
        private Label labelBookName;
        private TextBox textBoxBookInvNumber;
        private Label labelBookInvNumber;
        private Button buttonConfirmAddBook;
        private Button buttonCancelAddBook;
        private GroupBox groupBoxAddBook;
    }
}