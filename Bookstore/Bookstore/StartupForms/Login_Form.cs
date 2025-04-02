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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if (textBox_email.Text.Length < 3)
            {
                MessageBox.Show("Λάθος email!");
                return;
            }
            if (textBox_password.Text.Length < 3)
            {
                MessageBox.Show("Λάθος κωδικός!");
                return;
            }

            String email = textBox_email.Text;
            String password = textBox_password.Text;

            User currentUser = Database.loginUser(email, password);
            if (currentUser == null)
            {
                MessageBox.Show("Λάθος Email ή Κωδικός!");
            }
            else
            {
                this.FormClosed -= Login_Form_FormClosed;
                MessageBox.Show("logged in!");
                this.Close();
                MainMenuForm main_menu_form = new MainMenuForm(currentUser);
                main_menu_form.Show();
            }



        }

        private void textBox_email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Tab))
            {
                textBox_password.Focus();

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void textBox_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Tab))
            {
                login_button.Focus();

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void Login_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
