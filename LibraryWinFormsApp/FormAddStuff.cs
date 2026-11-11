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
    public partial class FormAddStuff : Form
    {
        private LibraryContext _context;
        public FormAddStuff(LibraryContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void buttonCancelAddStuff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAddStuff_Load(object sender, EventArgs e)
        {

        }

        private void buttonConfirmAddStuff_Click(object sender, EventArgs e)
        {
            if (textBoxStuffSecondName.Text == string.Empty || textBoxStuffFirstName.Text == string.Empty || textBoxStuffThirdName.Text == string.Empty ||
                textBoxStuffBirthDate.Text == string.Empty || textBoxStuffJobRole.Text == string.Empty || textBoxStuffPhoneNumber.Text == string.Empty ||
                textBoxStuffEmail.Text == string.Empty)
            {
                MessageBox.Show("Введите все данные");
                return;
            }
            try 
            {
                var stuff = new Stuff
                {
                    SecondName = textBoxStuffSecondName.Text,
                    FirstName = textBoxStuffFirstName.Text,
                    ThirdName = textBoxStuffThirdName.Text,
                    BirthDate = DateOnly.FromDateTime(Convert.ToDateTime(textBoxStuffBirthDate.Text)),
                    JobRole = textBoxStuffJobRole.Text,
                    PhoneNumber = textBoxStuffPhoneNumber.Text,
                    Email = textBoxStuffEmail.Text
                };
                _context.Stuff.Add(stuff);
                _context.SaveChanges();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType().ToString() + "\n" + "Некорректный ввод данных");
            }
            
        }
        ~FormAddStuff()
        {
            _context.Dispose();
        }
    }
}
