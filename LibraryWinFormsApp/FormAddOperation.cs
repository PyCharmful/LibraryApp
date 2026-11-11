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
        private int? ToIntOrNull(string s)
        {
            if (int.TryParse(s, out int result))
            {
                return result;
            }
            return null;
        }
        private void buttonConfirmAddOperation_Click(object sender, EventArgs e)
        {
            if (comboBoxOperationName.SelectedItem == null || textBoxOperationBookID.Text == "" || textBoxOperationStuffID.Text == ""
                || textBoxOperationCustomerID.Text == "")
            {
                MessageBox.Show("Введите все данные");
                return;
            }
            var bookId = _context.Books.FirstOrDefault(x => x.InvNumber == ToIntOrNull(textBoxOperationBookID.Text))?.Id;
            var stuffId = _context.Stuff.FirstOrDefault(x => x.Id == ToIntOrNull(textBoxOperationStuffID.Text))?.Id;
            var customerId = _context.Customers.FirstOrDefault(x => x.Id == ToIntOrNull(textBoxOperationCustomerID.Text))?.Id;
            List<string> errors = new List<string>();
            if (bookId == null)
            {
                errors.Add("Введите существующий инвентарный номер.");
            }
            if (stuffId == null)
            {
                errors.Add("Введите существующий ID сотрудника.");
            }
            if (customerId == null)
            {
                errors.Add("Введите существующий ID клиента.");
            }
            string message = null;
            message = string.Join("\n", errors);
            
            if (message.Length > 2)
            {
               
                MessageBox.Show(message);
                return;
            }
            var operation = new BookExchange
            {
                OperationName = comboBoxOperationName.SelectedItem.ToString(),
                BookId = bookId.Value,
                StuffId = stuffId.Value,
                CustomerId = customerId.Value,
                DateOperation = DateOnly.FromDateTime(dateTimePickerOperationDate.Value)
            };
            _context.BookExchange.Add(operation);
            _context.SaveChanges();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        ~FormAddOperation()
        {
            _context.Dispose();
        }
    }
}
