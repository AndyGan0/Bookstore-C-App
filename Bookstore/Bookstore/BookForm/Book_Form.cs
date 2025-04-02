using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bookstore.BookForm;

namespace Bookstore
{
    public partial class Book_Form : Form
    {

        User LoggedUser;
        Book CurrentBook;
        List<Panel> DynamicCritiquePanels;

        public Book_Form(User LoggedUser)
        {
            InitializeComponent();
            CurrentBook = new Book();
            this.LoggedUser = LoggedUser;
            DynamicCritiquePanels = new List<Panel>();

        }

        public void loadBook(int Book_id)
        {
            

            CurrentBook = Database.getBookByID(Book_id);

            Title_label.Text = CurrentBook.Title;
            Description_label.Text = CurrentBook.Description;
            Book_cover.ImageLocation = "Dynamic_resources/Covers/" + CurrentBook.ID + ".jpg";
            ID_label.Text = CurrentBook.ID.ToString();
            Author_label.Text = CurrentBook.Author;
            Publisher_label.Text = CurrentBook.Publisher;
            pages_label.Text = CurrentBook.Page_number.ToString();
            Language_label.Text = CurrentBook.Language;
            Dimensions_label.Text = CurrentBook.Dimensions;
            Category_label.Text = CurrentBook.Category;

            if (CurrentBook.Old_price == 0)
            {
                Old_Price_label.Hide();
                Price_label.Show();
                Price_label.ForeColor = Color.Black;
            }
            else
            {
                Old_Price_label.Show();
                Price_label.Show();
                Price_label.ForeColor = Color.Red;
            }

            Old_Price_label.Text = CurrentBook.Old_price + " €";
            Price_label.Text = CurrentBook.Price + " €";


            if (LoggedUser.GetType() == typeof(Classes.Author))
            {
                List<int> WrittenBooks = Database.booksWrittenByUser(LoggedUser.Username);
                if (! (LoggedUser.GetType() == typeof(Classes.Author)) ) { WrittenBooks.Clear(); }

                if (WrittenBooks.Contains(CurrentBook.ID))
                {
                    add_basket_button.Hide();
                    question_button.Hide();
                    Stats_button.Show();
                }
                else
                {
                    add_basket_button.Show();
                    question_button.Show();
                    Stats_button.Hide();
                }
            }



            // load critique section
            clearCritiques();

            List<Classes.Critique> critiques = Database.retrieveCritiquesForBook(CurrentBook.ID);

            //  calculating score
            int sum = 0;
            int count = 0;

            foreach (Classes.Critique c in critiques)
            {
                sum += c.Stars;
                count++;
            }

            if (count == 0)
            {
                Score.Text = "SCORE: -";
            }
            else
            {
                double score = (double)sum / count;

                Score.Text = "SCORE: " + String.Format("{0:0.#}", score) + "/5";
            }
            



            // Checking if user boight the book and loading their critique section

            List<int> BooksOwnedByUser = Database.getBooksOwnedByUser(LoggedUser.Username);
            if (!BooksOwnedByUser.Contains(CurrentBook.ID))
            {
                // User hasnt bought the book. Dont show post critique section
                MyCritique_Section.Hide();
            }
            else
            {
                // User has bought the book. Show post critique section
                MyCritique_Section.Show();


                // find if user has critiqued
                Classes.Critique usersCritique = null;
                foreach (Classes.Critique c in critiques)
                {
                    if (c.Username.Equals(LoggedUser.Username))
                    {
                        usersCritique = c;
                        break;
                    }
                }

                
                if (usersCritique == null)
                {
                    // if User Hasnt critiqued then show the post comment section
                    CritiqueLabel.Hide();
                    richTextBox1.Show();
                    richTextBox1.Text = "Αξιολογίστε το προϊόν";
                    Comment_buttom.Show();
                    pictureBox1.Enabled = true;
                    pictureBox2.Enabled = true;
                    pictureBox3.Enabled = true;
                    pictureBox4.Enabled = true;
                    pictureBox5.Enabled = true;
                }
                else
                {
                    // if User Has critiqued then hide the post comment section and replace it with their critique
                    CritiqueLabel.Show();
                    richTextBox1.Hide();
                    Comment_buttom.Hide();
                    pictureBox1.Enabled = false;
                    pictureBox2.Enabled = false;
                    pictureBox3.Enabled = false;
                    pictureBox4.Enabled = false;
                    pictureBox5.Enabled = false;

                    // retrieve user's critique
                    CritiqueLabel.Text = usersCritique.Text;
                    switch (usersCritique.Stars)
                    {
                        case 1:
                            pictureBox2.Image = Properties.Resources.empty_star;
                            pictureBox3.Image = Properties.Resources.empty_star;
                            pictureBox4.Image = Properties.Resources.empty_star;
                            pictureBox5.Image = Properties.Resources.empty_star;
                            break;
                        case 2:
                            pictureBox2.Image = Properties.Resources.gold_star;
                            pictureBox3.Image = Properties.Resources.empty_star;
                            pictureBox4.Image = Properties.Resources.empty_star;
                            pictureBox5.Image = Properties.Resources.empty_star;
                            break;
                        case 3:
                            pictureBox2.Image = Properties.Resources.gold_star;
                            pictureBox3.Image = Properties.Resources.gold_star;
                            pictureBox4.Image = Properties.Resources.empty_star;
                            pictureBox5.Image = Properties.Resources.empty_star;
                            break;
                        case 4:
                            pictureBox2.Image = Properties.Resources.gold_star;
                            pictureBox3.Image = Properties.Resources.gold_star;
                            pictureBox4.Image = Properties.Resources.gold_star;
                            pictureBox5.Image = Properties.Resources.empty_star;
                            break;
                        case 5:
                            pictureBox2.Image = Properties.Resources.gold_star;
                            pictureBox3.Image = Properties.Resources.gold_star;
                            pictureBox4.Image = Properties.Resources.gold_star;
                            pictureBox5.Image = Properties.Resources.gold_star;
                            break;
                    }

                    // removing user's critique from the list with the other critiques
                    critiques.Remove(usersCritique);

                }
            }

            // Loading the other critiques
            if (critiques.Count() == 0)
            {
                NoCommentPanel.Show();
            }
            else
            {
                NoCommentPanel.Hide();
            }

            foreach (Classes.Critique c in critiques)
            {

                Panel TempPanel = new Panel();
                flowLayoutPanel2.Controls.Add(TempPanel);
                TempPanel.MaximumSize = new Size(1200, 0);
                TempPanel.MinimumSize = new Size(1200, 0);
                TempPanel.AutoSize = true;
                TempPanel.BorderStyle = BorderStyle.None;


                Label Seperator = new Label();
                TempPanel.Controls.Add(Seperator);
                Seperator.Text = "";
                Seperator.BorderStyle = BorderStyle.FixedSingle;
                Seperator.AutoSize = false;
                Seperator.Size = new Size(1194, 2);
                Seperator.Location = new Point(0, 25);
                Seperator.Font = new Font("Arial", 16, FontStyle.Italic);


                Label TempLabel = new Label();
                TempPanel.Controls.Add(TempLabel);
                TempLabel.Text = c.Username;
                TempLabel.AutoSize = true;
                TempLabel.Location = new Point(100, 50);
                TempLabel.Font = new Font("Candara Light", 16, FontStyle.Italic);



                PictureBox Star1PictureBox = new PictureBox();
                TempPanel.Controls.Add(Star1PictureBox);
                Star1PictureBox.Size = new Size(40, 30);                
                Star1PictureBox.Location = new Point(100, 91);
                Star1PictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                PictureBox Star2PictureBox = new PictureBox();
                TempPanel.Controls.Add(Star2PictureBox);
                Star2PictureBox.Size = new Size(40, 30);
                Star2PictureBox.Location = new Point(150, 91);
                Star2PictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                PictureBox Star3PictureBox = new PictureBox();
                TempPanel.Controls.Add(Star3PictureBox);
                Star3PictureBox.Size = new Size(40, 30);
                Star3PictureBox.Location = new Point(200, 91);
                Star3PictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                PictureBox Star4PictureBox = new PictureBox();
                TempPanel.Controls.Add(Star4PictureBox);
                Star4PictureBox.Size = new Size(40, 30);
                Star4PictureBox.Location = new Point(250, 91);
                Star4PictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                PictureBox Star5PictureBox = new PictureBox();
                TempPanel.Controls.Add(Star5PictureBox);
                Star5PictureBox.Size = new Size(40, 30);
                Star5PictureBox.Location = new Point(300, 91);
                Star5PictureBox.SizeMode = PictureBoxSizeMode.Zoom;



                Label TempLabel2 = new Label();
                TempPanel.Controls.Add(TempLabel2);
                TempLabel2.Text = c.Text;
                TempLabel2.AutoSize = true;
                TempLabel2.Location = new Point(100, 150);
                TempLabel2.Font = new Font("Microsoft Sans Serif", 12);


                // Adding the stars in PictureBoxes
                Star1PictureBox.Image = Properties.Resources.gold_star;
                switch (c.Stars)
                {
                    case 1:
                        Star2PictureBox.Image = Properties.Resources.empty_star;
                        Star3PictureBox.Image = Properties.Resources.empty_star;
                        Star4PictureBox.Image = Properties.Resources.empty_star;
                        Star5PictureBox.Image = Properties.Resources.empty_star;
                        break;
                    case 2:
                        Star2PictureBox.Image = Properties.Resources.gold_star;
                        Star3PictureBox.Image = Properties.Resources.empty_star;
                        Star4PictureBox.Image = Properties.Resources.empty_star;
                        Star5PictureBox.Image = Properties.Resources.empty_star;
                        break;
                    case 3:
                        Star2PictureBox.Image = Properties.Resources.gold_star;
                        Star3PictureBox.Image = Properties.Resources.gold_star;
                        Star4PictureBox.Image = Properties.Resources.empty_star;
                        Star5PictureBox.Image = Properties.Resources.empty_star;
                        break;
                    case 4:
                        Star2PictureBox.Image = Properties.Resources.gold_star;
                        Star3PictureBox.Image = Properties.Resources.gold_star;
                        Star4PictureBox.Image = Properties.Resources.gold_star;
                        Star5PictureBox.Image = Properties.Resources.empty_star;
                        break;
                    case 5:
                        Star2PictureBox.Image = Properties.Resources.gold_star;
                        Star3PictureBox.Image = Properties.Resources.gold_star;
                        Star4PictureBox.Image = Properties.Resources.gold_star;
                        Star5PictureBox.Image = Properties.Resources.gold_star;
                        break;
                }


                DynamicCritiquePanels.Add(TempPanel);
            }



        }


        private void clearCritiques()
        {
            foreach (Panel p in DynamicCritiquePanels)
            {
                foreach (Control c in p.Controls)
                {
                    c.Dispose();
                }
                p.Dispose();
            }

            DynamicCritiquePanels.Clear();
        }























        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.empty_star;
            pictureBox3.Image = Properties.Resources.empty_star;
            pictureBox4.Image = Properties.Resources.empty_star;
            pictureBox5.Image = Properties.Resources.empty_star;
            pictureBox2.Tag = "empty_star";
            pictureBox3.Tag = "empty_star";
            pictureBox4.Tag = "empty_star";
            pictureBox5.Tag = "empty_star";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.gold_star;
            pictureBox3.Image = Properties.Resources.empty_star;
            pictureBox4.Image = Properties.Resources.empty_star;
            pictureBox5.Image = Properties.Resources.empty_star;
            pictureBox2.Tag = "gold_star";
            pictureBox3.Tag = "empty_star";
            pictureBox4.Tag = "empty_star";
            pictureBox5.Tag = "empty_star";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.gold_star;
            pictureBox3.Image = Properties.Resources.gold_star;
            pictureBox4.Image = Properties.Resources.empty_star;
            pictureBox5.Image = Properties.Resources.empty_star;
            pictureBox2.Tag = "gold_star";
            pictureBox3.Tag = "gold_star";
            pictureBox4.Tag = "empty_star";
            pictureBox5.Tag = "empty_star";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.gold_star;
            pictureBox3.Image = Properties.Resources.gold_star;
            pictureBox4.Image = Properties.Resources.gold_star;
            pictureBox5.Image = Properties.Resources.empty_star;
            pictureBox2.Tag = "gold_star";
            pictureBox3.Tag = "gold_star";
            pictureBox4.Tag = "gold_star";
            pictureBox5.Tag = "empty_star";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.gold_star;
            pictureBox3.Image = Properties.Resources.gold_star;
            pictureBox4.Image = Properties.Resources.gold_star;
            pictureBox5.Image = Properties.Resources.gold_star;
            pictureBox2.Tag = "gold_star";
            pictureBox3.Tag = "gold_star";
            pictureBox4.Tag = "gold_star";
            pictureBox5.Tag = "gold_star";
        }

        
        private void richTextBox1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void richTextBox1_Leave(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                richTextBox1.Text = "Αξιολογίστε το προϊόν";
            }
        }

        private void add_to_basket_button_Click(object sender, EventArgs e)
        {
            LoggedUser.cart.addBook(Database.getBookByID(CurrentBook.ID));
        }

        private void question_button_Click(object sender, EventArgs e)
        {
            QuestionForm QuestionForm = new QuestionForm(LoggedUser.Username, CurrentBook.Author, CurrentBook);
            QuestionForm.ShowDialog();
        }

        private void Comment_buttom_Click(object sender, EventArgs e)
        {

            if (richTextBox1.Text == "" || richTextBox1.Text == "Αξιολογίστε το προϊόν")
            {
                return;
            }

            int Stars = 0;
            if (pictureBox5.Tag.ToString() == "gold_star")
            {
                Stars = 5;
            }
            else if (pictureBox4.Tag.ToString() == "gold_star")
            {
                Stars = 4;
            }
            else if (pictureBox3.Tag.ToString() == "gold_star")
            {
                Stars = 3;
            }
            else if (pictureBox2.Tag.ToString() == "gold_star")
            {
                Stars = 2;
            }
            else 
            {
                Stars = 1;
            }

            Classes.Critique temp_critique = new Classes.Critique(CurrentBook.ID, LoggedUser.Username, Stars, richTextBox1.Text);

            Database.postCritique(temp_critique);


            CritiqueLabel.Text = richTextBox1.Text;
            CritiqueLabel.Show();
            richTextBox1.Hide();
            Comment_buttom.Hide();            
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;



        }

        private void Statistics_button_Click(object sender, EventArgs e)
        {
            Statistics_form StaticsticsForm = new Statistics_form(CurrentBook.ID);
            StaticsticsForm.ShowDialog();
        }

        private void Book_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
