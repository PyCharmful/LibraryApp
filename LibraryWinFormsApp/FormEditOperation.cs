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
        private readonly Book _book;
        public int invNum;
        public FormEditOperation(LibraryContext context, int operationId)
        {
            InitializeComponent();
            _context = context;
            _operation = _context.BookExchange.FirstOrDefault(x => x.Id == operationId);
            // Для вывода в форму вместо ID книги его инвентарного номера
            _book = _context.Books.FirstOrDefault(x => x.Id == _operation.BookId);
        }

        private void FormEditOperation_Load(object sender, EventArgs e)
        {
            comboBoxOperationName.SelectedItem = _operation.OperationName.ToString();
            textBoxOperationBookInvNumber.Text = _book.InvNumber.ToString();
            textBoxOperationStuffID.Text = _operation.StuffId.ToString();
            textBoxOperationCustomerID.Text = _operation.CustomerId.ToString();
            dateTimePickerOperationDate.Value = _operation.DateOperation.ToDateTime(TimeOnly.MinValue);
        }

        private void buttonCancelEditOperation_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private int? ToIntOrNull(string s)
        {
            if (int.TryParse(s, out int result))
            {
                return result;
            }
            return null;
        }
        private void buttonConfirmEditOperation_Click(object sender, EventArgs e)
        {
            var newBookId = _context.Books.FirstOrDefault(x => x.InvNumber == ToIntOrNull(textBoxOperationBookInvNumber.Text))?.Id ?? 0;
            var customerIDExist = _context.Customers.FirstOrDefault(x => x.Id == ToIntOrNull(textBoxOperationCustomerID.Text))?.Id;
            var stuffIDExist = _context.Stuff.FirstOrDefault(x => x.Id == ToIntOrNull(textBoxOperationStuffID.Text))?.Id;
            List<string> errors = new List<string>();
            if (newBookId == 0)
            {
                errors.Add("Введите существующий инвентарный номер.");
            }
            if (customerIDExist == null)
            {
                errors.Add("Введите существующий ID клиента.");
            }
            if (stuffIDExist == null)
            {
                errors.Add("Введите существующий ID сотрудника.");
            }
            string message = null;
            message = string.Join("\n", errors);
            if (message.Length > 2)
            {
                MessageBox.Show(message);
                return;
            }
            _operation.OperationName = comboBoxOperationName.SelectedItem.ToString();
            _operation.BookId = newBookId;
            _operation.StuffId = int.Parse(textBoxOperationStuffID.Text);
            _operation.CustomerId = int.Parse(textBoxOperationCustomerID.Text);
            _operation.DateOperation = DateOnly.FromDateTime(dateTimePickerOperationDate.Value);
            _context.BookExchange.Update(_operation);
            _context.SaveChanges();
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
