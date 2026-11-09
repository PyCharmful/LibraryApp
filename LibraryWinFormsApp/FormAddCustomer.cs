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
    public partial class FormAddCustomer : Form
    {
        private LibraryContext _context;
        public FormAddCustomer(LibraryContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void buttonCancelAddCustomer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void buttonConfirmAddCustomer_Click(object sender, EventArgs e)
        {
            var customer = new Customer
            {
                SecondName = textBoxCustomerSecondName.Text,
                FirstName = textBoxCustomerFirstName.Text,
                ThirdName = textBoxCustomerThirdName.Text,
                BirthDate = textBoxCustomerBirthDate.Text,
                Address = textBoxCustomerAddress.Text,
                PhoneNumber = textBoxCustomerPhoneNumber.Text,
                Email = textBoxCustomerEmail.Text
            };
            _context.Customers.Add(customer);
            _context.SaveChanges();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        ~FormAddCustomer()
        {
            _context.Dispose();
        }
    }
}
