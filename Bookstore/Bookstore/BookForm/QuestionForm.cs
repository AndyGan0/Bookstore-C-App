using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore.BookForm
{
    public partial class QuestionForm : Form
    {
        String sender; // This variable has the username of LoggedUser
        String Author;
        Book book;
        public QuestionForm(String username, String Author, Book book)
        {
            InitializeComponent();
            AuthorLabel.Text += "   " + Author;
            BookLabel.Text += "   " + book.Title;
            this.sender = username;
            this.book = book;
            this.Author = Author;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            Classes.Message NewMessage = new Classes.Message(this.sender , Author, richTextBox1.Text, "question" , book.ID );
            Database.sendMessage(NewMessage);
            MessageBox.Show("Η ερώτηση σας στάλθηκε με επιτυχία!");
            this.Close();
        }
    }
}
