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
    public partial class FormEditCustomer : Form
    {
        private readonly LibraryContext _context;
        private readonly Customer _customer;
        public FormEditCustomer(LibraryContext context, int customerId)
        {
            InitializeComponent();
            _context = context;
            _customer = _context.Customers.FirstOrDefault(x => x.Id == customerId);
        }

        private void buttonCancelEditCustomer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirmEditCustomer_Click(object sender, EventArgs e)
        {
            _customer.SecondName = textBoxCustomerSecondName.Text;
            _customer.FirstName = textBoxCustomerFirstName.Text;
            _customer.ThirdName = textBoxCustomerThirdName.Text;
            try
            {
                _customer.BirthDate = Convert.ToDateTime(textBoxCustomerBirthDate.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Введите корректную дату рождения");
                return;
            }
            _customer.Address = textBoxCustomerAddress.Text;
            _customer.PhoneNumber = textBoxCustomerPhoneNumber.Text;
            _customer.Email = textBoxCustomerEmail.Text;
            _context.Customers.Update(_customer);
            _context.SaveChanges();
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FormEditCustomer_Load(object sender, EventArgs e)
        {
            textBoxCustomerSecondName.Text = _customer.SecondName;
            textBoxCustomerFirstName.Text = _customer.FirstName;
            textBoxCustomerThirdName.Text = _customer.ThirdName;
            textBoxCustomerBirthDate.Text = _customer.BirthDate.ToShortDateString();
            textBoxCustomerAddress.Text = _customer.Address;
            textBoxCustomerPhoneNumber.Text = _customer.PhoneNumber;
            textBoxCustomerEmail.Text = _customer.Email;
        }
    }
}
