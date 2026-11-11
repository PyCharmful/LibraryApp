using LibraryWinFormsApp.Data;
using Microsoft.EntityFrameworkCore;
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
    public partial class FormEditStuff : Form
    {
        private readonly LibraryContext _context;
        private readonly Stuff _stuff;
        public FormEditStuff(LibraryContext context, int stuffId)
        {
            InitializeComponent();
            _context = context;
            _stuff = _context.Stuff.FirstOrDefault(x => x.Id == stuffId);
        }

        private void buttonCancelEditStuff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirmEditStuff_Click(object sender, EventArgs e)
        {
            _stuff.SecondName = textBoxStuffSecondName.Text;
            _stuff.FirstName = textBoxStuffFirstName.Text;
            _stuff.ThirdName = textBoxStuffThirdName.Text;
            _stuff.BirthDate = DateOnly.FromDateTime(Convert.ToDateTime(textBoxStuffBirthDate.Text));
            _stuff.JobRole = textBoxStuffJobRole.Text;
            _stuff.PhoneNumber = textBoxStuffPhoneNumber.Text;
            _stuff.Email = textBoxStuffEmail.Text;
            _context.Stuff.Update(_stuff);
            _context.SaveChanges();
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FormEditStuff_Load(object sender, EventArgs e)
        {
            textBoxStuffSecondName.Text = _stuff.SecondName;
            textBoxStuffFirstName.Text = _stuff.FirstName;
            textBoxStuffThirdName.Text = _stuff.ThirdName;
            textBoxStuffBirthDate.Text = _stuff.BirthDate.ToShortDateString();
            textBoxStuffJobRole.Text = _stuff.JobRole;
            textBoxStuffPhoneNumber.Text = _stuff.PhoneNumber;
            textBoxStuffEmail.Text = _stuff.Email;
        }
    }
}
