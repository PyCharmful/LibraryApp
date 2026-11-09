using LibraryWinFormsApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryWinFormsApp
{
    public partial class FormEditOperation : Form
    {
        private readonly LibraryContext _context;
        private readonly BookExchange _operation;
        public FormEditOperation(LibraryContext context, int operationId)
        {
            InitializeComponent();
            _context = context;
            _operation = _context.BookExchange.FirstOrDefault(x => x.Id == operationId);
        }

        private void FormEditOperation_Load(object sender, EventArgs e)
        {
            comboBoxOperationName.SelectedValue = _operation.OperationName.ToString();
            textBoxOperationBookID.Text = _operation.BookId.ToString();
            textBoxOperationStuffID.Text = _operation.StuffId.ToString();
            textBoxOperationCustomerID.Text = _operation.CustomerId.ToString();
            dateTimePickerOperationDate.Value = _operation.DateOperation;
        }

        private void buttonCancelEditOperation_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirmEditOperation_Click(object sender, EventArgs e)
        {
            // Проблемы
            _operation.OperationName = comboBoxOperationName.SelectedValue.ToString();
            _operation.BookId = int.Parse(textBoxOperationBookID.Text);
            _operation.StuffId = int.Parse(textBoxOperationStuffID.Text);
            _operation.CustomerId = int.Parse(textBoxOperationCustomerID.Text);
            _operation.DateOperation = dateTimePickerOperationDate.Value;
            _context.BookExchange.Update(_operation);
            _context.SaveChanges();
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
