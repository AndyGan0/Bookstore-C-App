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
    public partial class Register_Form : Form
    {
        public Register_Form()
        {
            InitializeComponent();
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            
            
            if (! textBox_password.Text.Equals(textBox_password_confirm.Text))
            {
                MessageBox.Show("Λάθος Κωδικός! Οι κωδικοί δεν ταιριάζουν μεταξύ τους!");
                return;
            }
            if(!radioButton_customer.Checked && !radioButton_Author.Checked)
            {
                MessageBox.Show("Επιλέξτε ρόλο πελάτης ή συγγραφέας!");
                return;
            }

            String FirstName = textBox_name.Text;
            String Surname = textBox_surname.Text;
            String username = textBox_username.Text;
            String Email = textBox_email.Text;
            String password = textBox_password.Text;

            if (FirstName.Length <3)
            {
                MessageBox.Show("Το όνομα είναι πολύ μικρό!");
                return;
            }
            if (Surname.Length < 3)
            {
                MessageBox.Show("Το επώνυμο είναι πολύ μικρό!");
                return;
            }
            if (username.Length < 3)
            {
                MessageBox.Show("Το username είναι πολύ μικρό!");
                return;
            }
            if (Email.Length < 3)
            {
                MessageBox.Show("Το Email είναι λάθος!");
                return;
            }
            if (password.Length < 3)
            {
                MessageBox.Show("Ο κωδικός είναι πολύ μικρός!");
                return;
            }

            User NewUser;

            if ( radioButton_Author.Checked )
            {
                NewUser = new Classes.Author(FirstName, Surname, username, Email, password);
            }
            else
            {
                NewUser = new User(FirstName, Surname, username, Email, password);
            }            


            Database.registerUser(NewUser);
            MessageBox.Show("Συγχαρητήρια! Η εγγραφή ολοκληρώθηκε με επιτυχία!");

            this.Close();
        }
    
    
    
    }
}
