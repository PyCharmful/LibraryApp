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
            LoadBooks();
            LoadStuff();
            LoadCustomers();
            LoadBookExchange();
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
            var form = new FormAddStuff(_context);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadStuff();
            }
        }

        private void buttonStuffFind_Click(object sender, EventArgs e)
        {
            var query = _context.Stuff.AsQueryable();
            if (!string.IsNullOrWhiteSpace(textBoxStuffSecondName.Text))
            {
                query = query.Where(x => x.SecondName == textBoxStuffSecondName.Text);
            }
            if (!string.IsNullOrWhiteSpace(textBoxStuffFirstName.Text))
            {
                query = query.Where(x => x.FirstName == textBoxStuffSecondName.Text);
            }
            if (!string.IsNullOrWhiteSpace(textBoxStuffThirdName.Text))
            {
                query = query.Where(x => x.ThirdName == textBoxStuffThirdName.Text);
            }
            // ???
            if (!string.IsNullOrWhiteSpace(textBoxStuffBirthDate.Text))
            {
                query = query.Where(x => x.BirthDate == Convert.ToDateTime(textBoxStuffBirthDate.Text));
            }
            if (!string.IsNullOrWhiteSpace(textBoxStuffJobRole.Text))
            {
                query = query.Where(x => x.JobRole == textBoxStuffJobRole.Text);
            }
            if (!string.IsNullOrWhiteSpace(textBoxStuffPhoneNumber.Text))
            {
                query = query.Where(x => x.PhoneNumber == textBoxStuffPhoneNumber.Text);
            }
            if (!string.IsNullOrWhiteSpace(textBoxStuffEmail.Text))
            {
                query = query.Where(x => x.Email == textBoxStuffEmail.Text);
            }
            var stuff = query.ToList();
            stuffBindingSource.DataSource = stuff;
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
        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            var form = new FormAddCustomer(_context);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadCustomers();
            }
        }

        private void buttonAddOperation_Click(object sender, EventArgs e)
        {
            var form = new FormAddOperation(_context);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadBookExchange();
            }
        }

        private void buttonDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (customerBindingSource.Current == null)
            {
                MessageBox.Show("Выберите запись для удаления.");
                return;
            }
            var result = MessageBox.Show(
                "Удалить выбранную запись",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;
            var stuff = (Customer)customerBindingSource.Current;
            _context.Customers.Remove(stuff);
            _context.SaveChanges();
            LoadCustomers();
        }

        private void buttonDeleteOperation_Click(object sender, EventArgs e)
        {
            if (bookExchangeBindingSource.Current == null)
            {
                MessageBox.Show("Выберите запись для удаления.");
                return;
            }
            var result = MessageBox.Show(
                "Удалить выбранную запись",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;
            var bookEx = (BookExchange)customerBindingSource.Current;
            _context.BookExchange.Remove(bookEx);
            _context.SaveChanges();
            LoadBookExchange();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.Owner = this;
            formAbout.ShowDialog();
        }
        // Поиск книги
        private void buttonBookFind_Click(object sender, EventArgs e)
        {
            var query = _context.Books.AsQueryable();
            if (!string.IsNullOrWhiteSpace(textBoxBookInvNumber.Text))
            {
                query = query.Where(x => x.InvNumber == Convert.ToInt32(textBoxBookInvNumber.Text));
            }
            if (!string.IsNullOrWhiteSpace(textBoxBookName.Text))
            {
                query = query.Where(x => x.BookName == textBoxBookName.Text);
            }
            if (!string.IsNullOrWhiteSpace(textBoxBookAuthor.Text))
            {
                query = query.Where(x => x.BookAuthor == textBoxBookAuthor.Text);
            }
            if (!string.IsNullOrWhiteSpace(textBoxBookPublisher.Text))
            {
                query = query.Where(x => x.BookPublisher == textBoxBookPublisher.Text);
            }
            if (!string.IsNullOrWhiteSpace(textBoxPublicationYear.Text))
            {
                query = query.Where(x => x.PublicationYear == textBoxPublicationYear.Text);
            }
            if (!string.IsNullOrWhiteSpace(textBoxGenre.Text))
            {
                query = query.Where(x => x.Genre == textBoxGenre.Text);
            }
            var book = query.ToList();
            bookBindingSource.DataSource = book;
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormLibrary_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context.Dispose();
        }

        private void buttonDeleteBook_Click(object sender, EventArgs e)
        {
            if (bookBindingSource.Current == null)
            {
                MessageBox.Show("Выберите запись для удаления.");
                return;
            }
            var result = MessageBox.Show(
                "Удалить выбранную запись",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;
            var book = (Book)bookBindingSource.Current;
            _context.Books.Remove(book);
            _context.SaveChanges();
            LoadBooks();
        }

        private void dataGridStuff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            var stuff = (Stuff)stuffBindingSource[e.RowIndex];
            var formAdd = new FormEditStuff(_context, stuff.Id);
            //if (dataGridStuff.Columns[e.RowIndex].Name == "ActionEditStuff")
            //{
            //    if (formAdd.ShowDialog() == DialogResult.OK)
            //    {
            //        LoadStuff();
            //    }
            //}
            if (dataGridStuff.Columns[e.ColumnIndex].Name == "ActionEditStuff")
            {
                formAdd.Owner = this;
                formAdd.ShowDialog();
                LoadStuff();
            }
        }

        private void dataGridCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            var customer = (Customer)customerBindingSource[e.RowIndex];
            var formAdd = new FormEditCustomer(_context, customer.Id);
            //if (dataGridCustomers.Columns[e.RowIndex].Name == "ActionEditCustomer")
            //{
            //    if (formAdd.ShowDialog() == DialogResult.OK)
            //    {
            //        LoadCustomers();
            //    }
            //}
            if (dataGridCustomers.Columns[e.ColumnIndex].Name == "ActionEditCustomer")
            {
                formAdd.Owner = this;
                formAdd.ShowDialog();
                LoadCustomers();
            }
        }

        private void dataGridBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            var book = (Book)bookBindingSource[e.RowIndex];
            var formAdd = new FormEditBook(_context, book.Id);
            //if (dataGridBooks.Columns[e.RowIndex].Name == "ActionEditBook")
            //{
            //    if (formAdd.ShowDialog() == DialogResult.OK)
            //    {
            //        LoadBooks();
            //    }
            //}
            if (dataGridBooks.Columns[e.ColumnIndex].Name == "ActionEditBook")
            {
                formAdd.Owner = this;
                formAdd.ShowDialog();
                LoadBooks();
            }
        }

        private void buttonDeleteStuff_Click(object sender, EventArgs e)
        {
            if (stuffBindingSource.Current == null)
            {
                MessageBox.Show("Выберите запись для удаления.");
                return;
            }
            var result = MessageBox.Show(
                "Удалить выбранную запись",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;
            var stuff = (Stuff)stuffBindingSource.Current;
            _context.Stuff.Remove(stuff);
            _context.SaveChanges();
            LoadStuff();
        }

        private void buttonCustomerFind_Click(object sender, EventArgs e)
        {
            var query = _context.Customers.AsQueryable();
            if (!string.IsNullOrWhiteSpace(textBoxCustomerSecondName.Text))
            {
                query = query.Where(x => x.SecondName == textBoxCustomerSecondName.Text);
            }
            if (!string.IsNullOrWhiteSpace(textBoxCustomerFirstName.Text))
            {
                query = query.Where(x => x.FirstName == textBoxCustomerFirstName.Text);
            }
            if (!string.IsNullOrWhiteSpace(textBoxCustomerThirdName.Text))
            {
                query = query.Where(x => x.ThirdName == textBoxCustomerThirdName.Text);
            }
            if (!string.IsNullOrWhiteSpace(textBoxCustomerBirthDate.Text))
            {
                query = query.Where(x => x.BirthDate == Convert.ToDateTime(textBoxCustomerBirthDate.Text));
            }
            if (!string.IsNullOrWhiteSpace(textBoxCustomerAddress.Text))
            {
                query = query.Where(x => x.Address == textBoxCustomerAddress.Text);
            }
            if (!string.IsNullOrWhiteSpace(textBoxCustomerPhoneNumber.Text))
            {
                query = query.Where(x => x.PhoneNumber == textBoxCustomerPhoneNumber.Text);
            }
            if (!string.IsNullOrWhiteSpace(textBoxCustomerEmail.Text))
            {
                query = query.Where(x => x.Email == textBoxCustomerEmail.Text);
            }
            var customer = query.ToList();
            customerBindingSource.DataSource = customer;
        }

        private void dataGridOperations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            var operation = (BookExchange)bookExchangeBindingSource[e.RowIndex];
            var formAdd = new FormEditOperation(_context, operation.Id);
            if (dataGridOperations.Columns[e.ColumnIndex].Name == "ActionEditOperation")
            {
                formAdd.Owner = this;
                formAdd.ShowDialog();
                LoadBookExchange();
            }
        }

        private void buttonOperationFind_Click(object sender, EventArgs e)
        {
            var query = _context.BookExchange.AsQueryable();
            if (comboBoxOperationName.SelectedValue is not null)
            {
                query = query.Where(x => x.OperationName == comboBoxOperationName.SelectedValue);
            }
            if (!string.IsNullOrWhiteSpace(textBoxOperationBookID.Text))
            {
                query = query.Where(x => x.BookId == Convert.ToInt32(textBoxOperationBookID.Text));
            }
            if (!string.IsNullOrWhiteSpace(textBoxOperationStuffID.Text))
            {
                query = query.Where(x => x.StuffId == Convert.ToInt32(textBoxOperationStuffID.Text));
            }
            if (!string.IsNullOrWhiteSpace(textBoxOperationCustomerID.Text))
            {
                query = query.Where(x => x.CustomerId == Convert.ToInt32(textBoxOperationCustomerID.Text));
            }
            // ???
            //if (dateTimePickerOperationDate_ValueChanged)
            //{
            //    query = query.Where(x => x.DateOperation == dateTimePickerOperationDate.Value);
            //}
            var operation = query.ToList();
            bookExchangeBindingSource.DataSource = operation;
        }
    }
}
