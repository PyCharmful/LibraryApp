using LibraryWinFormsApp.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryWinFormsApp
{
    public partial class FormAddBook : Form
    {
        private LibraryContext _context;
        public FormAddBook(LibraryContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void buttonCancelAddBook_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonConfirmAddBook_Click(object sender, EventArgs e)
        {
            var book = new Book
            {
                InvNumber = int.Parse(textBoxBookInvNumber.Text),
                BookName = textBoxBookName.Text,
                BookAuthor = textBoxBookAuthor.Text,
                BookPublisher = textBoxBookPublisher.Text,
                PublicationYear = textBoxBookPublicationYear.Text,
                Genre = textBoxBookGenre.Text
            };
            _context.Books.Add(book);
            _context.SaveChanges();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        ~FormAddBook()
        {
            _context.Dispose();
        }
    }
}
