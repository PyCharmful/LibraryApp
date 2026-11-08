using LibraryWinFormsApp.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryWinFormsApp
{
    public partial class FormEditBook : Form
    {
        private readonly LibraryContext _context;
        private readonly Book _book;
        public FormEditBook(LibraryContext context, int bookId)
        {
            InitializeComponent();
            _context = context;
            _book = _context.Books.FirstOrDefault(x => x.Id == bookId);
        }

        private void buttonCancelEditBook_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEditBook_Load(object sender, EventArgs e)
        {
            textBoxBookInvNumber.Text = _book.InvNumber.ToString();
            textBoxBookName.Text = _book.BookName;
            textBoxBookAuthor.Text = _book.BookAuthor;
            textBoxBookPublisher.Text = _book.BookPublisher;
            textBoxBookPublicationYear.Text = _book.PublicationYear;
            textBoxBookGenre.Text = _book.Genre;
        }

        private void buttonConfirmEditBook_Click(object sender, EventArgs e)
        {
            _book.InvNumber = int.Parse(textBoxBookInvNumber.Text);
            _book.BookName = textBoxBookName.Text;
            _book.BookAuthor = textBoxBookAuthor.Text;
            _book.BookPublisher = textBoxBookPublisher.Text;
            _book.PublicationYear = textBoxBookPublicationYear.Text;
            _book.Genre = textBoxBookGenre.Text;
            _context.Books.Update(_book);
            _context.SaveChanges();
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
