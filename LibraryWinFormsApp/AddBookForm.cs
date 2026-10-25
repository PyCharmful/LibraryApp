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
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
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
         //   FormLibrary main = this.Owner as FormLibrary;
         //   if (main != null)
         //   {
         //       DataRow rowBooks = main.booksDataSet.
          //  }
        }
    }
}
