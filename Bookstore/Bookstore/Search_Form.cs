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
    public partial class Search_Form : Form
    {

        MainMenuForm MainMenu;
        User LoggedUser;
        // THIS LIST IS USED TO DELETE OLD RESULTS IF NEW SEARCH IS DONE
        List<Panel> panel_results = new List<Panel>();

        public Search_Form(MainMenuForm Mainmenu, User loggedUser)
        {
            InitializeComponent();
            this.MainMenu = Mainmenu;
            LoggedUser = loggedUser;
        }


        


        void refreshResults()
        {

            String UserTypedWords = textBox1.Text;
            String SearchBy = "Title";
            if (radioButtonTitle.Checked)
            {
                SearchBy = "Title";
            }
            else if (radioButtonAuthor.Checked)
            {
                SearchBy = "Author";
            }
            else
            {
                SearchBy = "Publisher";
            }


            List<List<String>> results;
            if (comboBox1.SelectedIndex != -1 && comboBox1.SelectedIndex != 0)
            {
                results = Database.searchBookByCategory(UserTypedWords, SearchBy, comboBox1.SelectedItem.ToString());
            }
            else
            {
                results = Database.searchBookByCategory(UserTypedWords, SearchBy);
            }

            

            
            if (results.Count == 0)
            {
                no_results_label.Show();
                return;
            }

            no_results_label.Hide();
            foreach (List<String> result in results)
            {
                Panel TempPanel = new Panel();
                TempPanel.Name = result[0];
                TempPanel.Size = new Size(400,450);
                TempPanel.BorderStyle = BorderStyle.FixedSingle;
                flowLayoutPanel1.Controls.Add(TempPanel);

                PictureBox TempPicture = new PictureBox();
                TempPicture.Size = new Size(200, 250);
                TempPanel.Controls.Add(TempPicture);
                TempPicture.Location = new Point(100,30);
                TempPicture.SizeMode = PictureBoxSizeMode.Zoom;
                TempPicture.ImageLocation = "Dynamic_resources/Covers/" + result[0] + ".jpg";
                TempPicture.Name =  result[0];
                TempPicture.Click += showBook;
                TempPicture.Cursor = Cursors.Hand;

                Label TempLabel = new Label();
                TempPanel.Controls.Add(TempLabel);
                TempLabel.Text = result[1];
                TempLabel.AutoSize = false;
                TempLabel.TextAlign = ContentAlignment.MiddleCenter;
                TempLabel.Size = new Size(400, 65);
                TempLabel.Location = new Point(0,280);
                TempLabel.Font = new Font("Microsoft Sans Serif", 12);
                TempLabel.Name = result[0];
                TempLabel.Click += showBook;
                TempLabel.Cursor = Cursors.Hand;


                Label TempLabel2 = new Label();
                TempPanel.Controls.Add(TempLabel2);
                TempLabel2.Text = result[4] + "€";
                TempLabel2.AutoSize = false;
                TempLabel2.TextAlign = ContentAlignment.MiddleCenter;
                TempLabel2.Size = new Size(400, 35);
                TempLabel2.Location = new Point(0, 360);
                TempLabel2.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);


                Button TempButton = new Button();
                TempButton.Text = "ΑΓΟΡΑ";
                TempButton.Name = result[0];
                TempButton.Click += addBookInCart;
                TempButton.Cursor = Cursors.Hand;
                TempButton.BackColor = Color.White;
                TempButton.Size = new Size(390,45);
                TempButton.Location = new Point(3, 400);
                TempPanel.Controls.Add(TempButton);



                panel_results.Add(TempPanel);


            }

            //  remove buy button for books if the user is author and wrote author this book
            if (! (LoggedUser.GetType() == typeof(Classes.Author)) ) { return; }
            List<int> WrittenBooks = Database.booksWrittenByUser(LoggedUser.Username);

            foreach (Panel p in panel_results)
            {
                foreach (Control c in p.Controls)
                {
                    if (c is Button && WrittenBooks.Contains( Int32.Parse(c.Name) ) )
                    {
                        c.Dispose();
                    }                    
                }
            }
            


        }

        
        void clearResults()
        {

            foreach (Panel p in panel_results)
            {
                foreach (Control c in p.Controls)
                {
                    c.Dispose();
                }
                p.Dispose();
            }

            panel_results.Clear();

        }



        private void showBook(object sender, EventArgs e)
        {
            String ObjectName = "";

            if (sender is Label) ObjectName = ((Label)sender).Name;
            if (sender is PictureBox) ObjectName = ((PictureBox)sender).Name;

            MainMenu.showBook(Int32.Parse(ObjectName));
        }


        private void addBookInCart(object sender, EventArgs e)
        {
            String bookId = ((Button)sender).Name;
            LoggedUser.cart.addBook(Database.getBookByID(Int32.Parse(bookId)));
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            clearResults();
            refreshResults();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(panel1.Visible == true)
            {
                panel1.Hide();
            }
            else
            {
                panel1.Show();
            }
        }

    }
}
