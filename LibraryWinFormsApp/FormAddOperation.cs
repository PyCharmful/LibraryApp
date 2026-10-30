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
        public FormAddOperation()
        {
            InitializeComponent();
        }

        private void buttonCancelAddOperation_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddOperationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
