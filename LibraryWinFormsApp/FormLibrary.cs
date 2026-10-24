using LibraryWinFormsApp.Data;

namespace LibraryWinFormsApp
{
    public partial class FormLibrary : Form
    {
        private List<Book> _books;
        public FormLibrary()
        {
            InitializeComponent();

        }
        // Практическая работа №2
        // Закомментировано до выяснения надобности
        /*public void BookAddCrud()
        {
            using (var context = new LibraryContext())
            {
                var book = new Book
                {
                    InvNumber = 205,
                    BookName = "Ты",
                    BookAuthor = "К. Кэпнес",
                    BookPublisher = "Эксмо",
                    PublicationYear = "2019",
                    Genre = "Триллер"
                };
                context.Books.Add(book);
                context.SaveChanges();
            }
        }
        public void BookRemoveCrud()
        {
            using (var context = new LibraryContext())
            {
                var books = context.Books.ToList();

                foreach (var s in books)
                {
                    Console.WriteLine(s.BookName);
                }
            }
        }
        public void BookUpdateCrud()
        {
            using (var context = new LibraryContext())
            {
                var book = context.Books.FirstOrDefault();

                if (book != null)
                {
                    book.InvNumber = 6;
                    context.SaveChanges();
                }
            }
        }
        public void BookDeleteCrud()
        {
            using (var context = new LibraryContext())
            {
                var book = context.Books.FirstOrDefault();

                if (book != null)
                {
                    context.Books.Remove(book);
                    context.SaveChanges();

                }

            }
        }*/

        private void labelBookName_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        private void tabPageBooks_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            AddBookForm addBook = new AddBookForm();
            addBook.Owner = this;
            addBook.ShowDialog();
        }

        private void buttonAddStuff_Click(object sender, EventArgs e)
        {
            AddStuffForm addStuff = new AddStuffForm();
            addStuff.Owner = this;
            addStuff.ShowDialog();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonStuffFind_Click(object sender, EventArgs e)
        {

        }
        // Практическая работа №3
        private void FormLibrary_Load(object sender, EventArgs e)
        {
            InitializeTestData();
            dataGridBooks.DataSource = _books; // Таблица с книгами
        }
        private void InitializeTestData()
        {
            _books = new List<Book>
            {
                new Book
                {
                    Id = 1,
                    InvNumber = 205,
                    BookName = "Ты",
                    BookAuthor = "К. Кэпнес",
                    BookPublisher = "Эксмо",
                    PublicationYear = "2019",
                    Genre = "Триллер"
                },
                new Book
                {
                    Id = 2,
                    InvNumber = 126,
                    BookName = "Преступление и наказание",
                    BookAuthor = "Ф. М. Досоевский",
                    BookPublisher = "АСТ",
                    PublicationYear = "2015",
                    Genre = "Роман"
                }

            };
        }
        // END OF Практическая работа №3
        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomer = new AddCustomerForm();
            addCustomer.Owner = this;
            addCustomer.ShowDialog();
        }

        private void buttonAddOperation_Click(object sender, EventArgs e)
        {
            AddOperationForm addOperation = new AddOperationForm();
            addOperation.Owner = this;
            addOperation.ShowDialog();
        }

        private void buttonDeleteCustomer_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteOperation_Click(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.Owner = this;
            formAbout.ShowDialog();
        }
    }
}
