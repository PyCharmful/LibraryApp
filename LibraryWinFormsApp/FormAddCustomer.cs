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
            if (textBoxCustomerSecondName.Text == string.Empty || textBoxCustomerFirstName.Text == string.Empty || textBoxCustomerThirdName.Text == string.Empty ||
                textBoxCustomerBirthDate.Text == string.Empty || textBoxCustomerAddress.Text == string.Empty || textBoxCustomerPhoneNumber.Text == string.Empty ||
                textBoxCustomerEmail.Text == string.Empty)
            {
                MessageBox.Show("Введите все данные");
                return;
            }
            try
            {
                var customer = new Customer
                {
                    SecondName = textBoxCustomerSecondName.Text,
                    FirstName = textBoxCustomerFirstName.Text,
                    ThirdName = textBoxCustomerThirdName.Text,
                    BirthDate = Convert.ToDateTime(textBoxCustomerBirthDate.Text),
                    Address = textBoxCustomerAddress.Text,
                    PhoneNumber = textBoxCustomerPhoneNumber.Text,
                    Email = textBoxCustomerEmail.Text
                };
                _context.Customers.Add(customer);
                _context.SaveChanges();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType().ToString() + "\n" + "Некорректный ввод данных");
            }
            
        }
        ~FormAddCustomer()
        {
            _context.Dispose();
        }
    }
}
