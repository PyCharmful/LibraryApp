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
        public FormAddStuff()
        {
            InitializeComponent();
        }

        private void buttonCancelAddStuff_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
