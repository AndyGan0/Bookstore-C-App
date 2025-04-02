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
    public partial class MainMenuForm : Form
    {

        User LoggedUser;

        Search_Form Search_Form;
        Book_Form Book_Form;
        CartForm Cart_Form;
        Messages.User_Author_contactForm Messages_Form;


        public MainMenuForm(User logged_user)
        {
            InitializeComponent();

            LoggedUser = logged_user;

            label_name.Text = logged_user.Username;

            Search_Form = new Search_Form(this, logged_user);
            Search_Form.TopLevel = false;
            Search_Form.TopMost = true;
            Search_Form.FormBorderStyle = FormBorderStyle.None;
            Search_Form.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            panel1.Controls.Add(Search_Form);
            Search_Form.Show();

            Book_Form = new Book_Form(logged_user);
            Book_Form.TopLevel = false;
            Book_Form.TopMost = true;
            Book_Form.FormBorderStyle = FormBorderStyle.None;
            Book_Form.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            panel1.Controls.Add(Book_Form);
            Book_Form.Hide();

            Cart_Form = new CartForm(this,LoggedUser);
            Cart_Form.TopLevel = false;
            Cart_Form.TopMost = true;
            Cart_Form.FormBorderStyle = FormBorderStyle.None;
            Cart_Form.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            panel1.Controls.Add(Cart_Form);
            Cart_Form.Hide();

            Messages_Form = new Messages.User_Author_contactForm(LoggedUser);
            Messages_Form.TopLevel = false;
            Messages_Form.TopMost = true;
            Messages_Form.FormBorderStyle = FormBorderStyle.None;
            Messages_Form.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            panel1.Controls.Add(Messages_Form);
            Messages_Form.Hide();



        }


        


        public void showBook(int id)
        {
            Search_Form.Hide();
            Cart_Form.Hide();
            Book_Form.Show();
            Messages_Form.Hide();
            Book_Form.loadBook(id);
            Back_button_show();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            Book_Form.Hide();
            Messages_Form.Hide();
            Search_Form.Show();
            Back_button.Hide();

            pictureBox_user.Show();
            label_name.Show();
        }

        public void Back_button_show()
        {
            Back_button.Show();
            pictureBox_user.Hide();
            label_name.Hide();
        }

        private void CartButon_Click(object sender, EventArgs e)
        {
            Search_Form.Hide();
            Book_Form.Hide();
            Cart_Form.Show();
            Messages_Form.Hide();
            Cart_Form.refreshCart();
            Back_button_show();
        }

        private void messages_Button_Click(object sender, EventArgs e)
        {
            Search_Form.Hide();
            Book_Form.Hide();
            Cart_Form.Hide();
            Messages_Form.Show();
            Messages_Form.refresh();
            Back_button_show();
        }


        private void help_button_Click(object sender, EventArgs e)
        {
            if(LoggedUser.GetType() == typeof(Classes.Author))
            {
                Help.ShowHelp(this, "Manuals/Author_manual/Author_Manual.chm");
            }
            else
            {
                Help.ShowHelp(this, "Manuals/User_manual/User_manual.chm");
            }
            
        }

        private void MainMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
