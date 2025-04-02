using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore
{
    public partial class Start_up_Form : Form
    {
        public Start_up_Form()
        {
            InitializeComponent();
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            Register_Form register_form = new Register_Form();
            register_form.Show();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form login_form = new Login_Form();
            login_form.Show();
        }
    }
}
