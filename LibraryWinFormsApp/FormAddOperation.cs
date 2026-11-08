using LibraryWinFormsApp.Data;
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
    public partial class FormAddOperation : Form
    {
        private LibraryContext _context;
        public FormAddOperation(LibraryContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void buttonCancelAddOperation_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddOperationForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonConfirmAddOperation_Click(object sender, EventArgs e)
        {
            var operation = new BookExchange
            {
                OperationName = (string)comboBoxOperationName.SelectedValue,
                BookId = int.Parse(textBoxOperationBookID.Text),
                StuffId = int.Parse(textBoxOperationStuffID.Text),
                CustomerId = int.Parse(textBoxOperationCustomerID.Text),
                DateOperation = dateTimePickerOperationDate.Value
            };
            _context.BookExchange.Add(operation);
            _context.SaveChanges();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
