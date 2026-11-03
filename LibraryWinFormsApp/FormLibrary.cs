using LibraryWinFormsApp.Data;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace LibraryWinFormsApp
{
    public partial class FormLibrary : Form
    {
        private List<Book> _books;
        private LibraryContext _context;
        // Практическая работа №4
        public FormLibrary()
        {
            InitializeComponent();
            _context = new LibraryContext();
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
            //FormAddBook addBook = new FormAddBook(_context);
            //addBook.Owner = this;
            //addBook.ShowDialog();
            var form = new FormAddBook(_context); 
            if (form.ShowDialog() == DialogResult.OK) 
            { 
                LoadBooks(); 
            }
        }

        private void buttonAddStuff_Click(object sender, EventArgs e)
        {
            FormAddStuff addStuff = new FormAddStuff();
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
            LoadBooks();
            LoadStuff();
            LoadCustomers();
            LoadBookExchange();
        }
        private void LoadBooks()
        {
            bookBindingSource.DataSource = _context.Books.ToList();
        }
        private void LoadCustomers()
        {
            customerBindingSource.DataSource = _context.Customers.ToList();
        }
        private void LoadStuff()
        {
            stuffBindingSource.DataSource = _context.Stuff.ToList();
        }
        private void LoadBookExchange()
        {
            bookExchangeBindingSource.DataSource = _context.BookExchange.ToList();
        }
        //private void InitializeTestData()
        //{
        //    _books = new List<Book>
        //    {
        //        new Book
        //        {
        //            Id = 1,
        //            InvNumber = 205,
        //            BookName = "Ты",
        //            BookAuthor = "К. Кэпнес",
        //            BookPublisher = "Эксмо",
        //            PublicationYear = "2019",
        //            Genre = "Триллер"
        //        },
        //        new Book
        //        {
        //            Id = 2,
        //            InvNumber = 126,
        //            BookName = "Преступление и наказание",
        //            BookAuthor = "Ф. М. Досоевский",
        //            BookPublisher = "АСТ",
        //            PublicationYear = "2015",
        //            Genre = "Роман"
        //        }

        //    };
        //}
        // END OF Практическая работа №3
        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            FormAddCustomer addCustomer = new FormAddCustomer();
            addCustomer.Owner = this;
            addCustomer.ShowDialog();
        }

        private void buttonAddOperation_Click(object sender, EventArgs e)
        {
            FormAddOperation addOperation = new FormAddOperation();
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

        private void buttonBookFind_Click(object sender, EventArgs e)
        {
            var grid = this.dataGridBooks;
            grid.ClearSelection();
            grid.CurrentCell = null;
            string idQuerry = textBoxBookID.Text;
            string invQuerry = textBoxBookInvNumber.Text;
            if (grid != null)
            {
                if (idQuerry == "")
                {
                    if (invQuerry != "")
                    {
                        InvNumberFound(grid);
                    }
                }
                else if (invQuerry == "")
                {
                    if (idQuerry != "")
                    {
                        BookIdFound(grid);
                    }
                }
            }
        }
        // Поиск по ID
        private void BookIdFound(DataGridView grid)
        {
            bool idFound = false;
            for (int i = 0; i < grid.RowCount; i++)
            {
                grid.Rows[i].Selected = false;

                for (int j = 0; j < 1; j++)
                {
                    if (grid.Rows[i].Cells[j].Value != null)
                    {
                        if (grid.Rows[i].Cells[j].Value.ToString().Contains(textBoxBookID.Text))
                        {
                            grid.Rows[i].Selected = true;
                            idFound = true;
                            break;
                        }
                    }
                }
            }
            if (!idFound)
            {
                MessageBox.Show("Ничего не найдено");
            }
        }
        // Поиск по инвентарному номеру
        private void InvNumberFound(DataGridView grid)
        {
            bool invFound = false;
            for (int i = 0; i < grid.RowCount; i++)
            {
                grid.Rows[i].Selected = false;
                for (int j = 1; j < 2; j++)
                {
                    if (grid.Rows[i].Cells[j].Value != null)
                    {
                        if (grid.Rows[i].Cells[j].Value.ToString().Contains(textBoxBookInvNumber.Text))
                        {
                            grid.Rows[i].Selected = true;
                            invFound = true;
                            break;
                        }
                    }
                }
            }
            if (!invFound)
            {
                MessageBox.Show("Ничего не найдено");
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormLibrary_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context.Dispose();
        }
    }
}
