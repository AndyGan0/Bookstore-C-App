using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore.Messages
{
    public partial class User_Author_contactForm : Form
    {
        User LoggedUser;
        Dictionary<int, List<Classes.Message>> messages = new Dictionary<int, List<Classes.Message>>();
        List<Panel> DynamicPanels = new List<Panel>();
        int CurrentQuestionID;


        public User_Author_contactForm(User loggedUser)
        {
            InitializeComponent();
            LoggedUser = loggedUser;
            refresh();
        }


        public void refresh()
        {

            clearAllConversations();

             messages = RetrieveMessages.retrieveUserMessages(LoggedUser.Username);
            Boolean firstclick = true;

            foreach (int questionID in messages.Keys)
            {                
                int BookID = messages[questionID][0].Book_id;
                String BookTitle = Database.getBookByID(BookID).Title;

                String PersonBehindConversation = messages[questionID][0].Sender;                
                if (PersonBehindConversation == LoggedUser.Username)
                {
                    //logged user is the person who made the question
                    PersonBehindConversation = messages[questionID][0].Author;
                }


                Panel TempPanel = new Panel();
                TempPanel.Name = questionID.ToString();
                TempPanel.Size = new Size(380, 90);
                TempPanel.BorderStyle = BorderStyle.FixedSingle;
                TempPanel.Cursor = Cursors.Hand;
                TempPanel.Click += click_on_question;
                flowLayoutPanel1.Controls.Add(TempPanel);
                
                Label TempLabel = new Label();
                TempLabel.Name = questionID.ToString();
                TempPanel.Controls.Add(TempLabel);
                TempLabel.Text = PersonBehindConversation;
                TempLabel.Click += click_on_question;
                TempLabel.Location = new Point(25, 15);
                TempLabel.AutoSize = true;
                TempLabel.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

                Label TempLabel2 = new Label();
                TempLabel2.Name = questionID.ToString();
                TempPanel.Controls.Add(TempLabel2);
                TempLabel2.Text = "Ερώτηση για: " + BookTitle;
                TempLabel2.Click += click_on_question;
                TempLabel2.Location = new Point(25, 50);
                TempLabel2.AutoSize = false;
                TempLabel2.Size = new Size(335,30);
                TempLabel2.Font = new Font("Microsoft Sans Serif", 10);

                DynamicPanels.Add(TempPanel);

                if (firstclick)
                {
                    firstclick = false;
                    click_on_question(TempPanel, EventArgs.Empty);
                }

            }

        }


        private void replyButton_Click(object sender, EventArgs e)
        {
            String replyMessage = richTextBox1.Text;
            if (replyMessage == "") { return; }

            Classes.Message temp_message = new Classes.Message(messages[CurrentQuestionID][0].Sender, messages[CurrentQuestionID][0].Author, replyMessage, "answer", messages[CurrentQuestionID][0].Book_id );
            temp_message.QuestionID = CurrentQuestionID;

            Database.sendMessage( temp_message );

            messages[CurrentQuestionID].Add(temp_message);


            AnswerPanel.Show();
            flowLayoutPanel2.Size = new Size(850, 720);
            richTextBox1.Hide();
            replyButton.Hide();

            Classes.Message Answer = null;
            if (messages[CurrentQuestionID][0].Type == "question")
            {
                Answer = messages[CurrentQuestionID][1];
            }
            else
            {
                Answer = messages[CurrentQuestionID][0];
            }


            AuthorUsername.Text = Answer.Author;
            AnswerLabel.Text = Answer.Text;

        }


        private void click_on_question(object sender, EventArgs e)
        {
            if (sender is Panel) { CurrentQuestionID = Int32.Parse(((Panel)sender).Name); }
            else { CurrentQuestionID = Int32.Parse(((Label)sender).Name); }

            
            Classes.Message Question = null;
            Classes.Message Answer = null;
            if (messages[CurrentQuestionID].Count == 1)
            {
                // there is only a question message without answer
                AnswerPanel.Hide();
                flowLayoutPanel2.Size = new Size(850, 640);
                richTextBox1.Show();
                replyButton.Show();

                Question = messages[CurrentQuestionID][0];
            }
            else
            {

                AnswerPanel.Show();
                flowLayoutPanel2.Size = new Size(850, 720);
                richTextBox1.Hide();
                replyButton.Hide();


                if (messages[CurrentQuestionID][0].Type == "question")
                {
                    Question = messages[CurrentQuestionID][0];
                    Answer = messages[CurrentQuestionID][1];
                }
                else
                {
                    Question = messages[CurrentQuestionID][1];
                    Answer = messages[CurrentQuestionID][0];
                }
            }

            
            UsernameLabel.Text = Question.Sender;
            BookLabel.Text = "Ερώτηση σχετικά με το βιβλίο: " + Database.getBookByID(Question.Book_id).Title;
            QuestionLabel.Text = Question.Text;

            if (!(Answer is null))
            {
                AuthorUsername.Text = Question.Author;
                AnswerLabel.Text = Answer.Text;
            }

            resize_UI(this, EventArgs.Empty);

        }


        private void clearAllConversations()
        {
            foreach (Panel p in DynamicPanels)
            {
                foreach (Control c in p.Controls)
                {
                    c.Dispose();
                }
                p.Dispose();
            }

            DynamicPanels.Clear();
            messages.Clear();
        }

        private void User_Author_contactForm_Load(object sender, EventArgs e)
        {

        }

        private void resize_UI(object sender, EventArgs e)
        {
            //  manage UI

            //  calculate size for flowpanel2
            int width;
            int height;

            if (replyButton.Visible)
            {
                width = replyButton.Location.X + replyButton.Size.Width - flowLayoutPanel2.Location.X;
                height = richTextBox1.Location.Y - 35 - flowLayoutPanel2.Location.Y;
            }
            else
            {
                width = replyButton.Location.X + replyButton.Size.Width - flowLayoutPanel2.Location.X;
                height = replyButton.Location.Y + replyButton.Size.Height - flowLayoutPanel2.Location.Y;
            }            

            flowLayoutPanel2.Size = new Size(width, height);
        }
    }
}
