using LibraryWinFormsApp.Data;

namespace LibraryWinFormsApp
{
    public partial class FormLibrary : Form
    {
        public FormLibrary()
        {
            InitializeComponent();
            
        }
        public void BookAddCrud()
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
        }

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

        }

        private void buttonAddStuff_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonStuffFind_Click(object sender, EventArgs e)
        {

        }

        private void FormLibrary_Load(object sender, EventArgs e)
        {

        }
    }
}
