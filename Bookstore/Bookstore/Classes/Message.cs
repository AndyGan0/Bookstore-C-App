using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Classes
{
    public class Message
    {
        int questionID;
        String sender;
        String author;
        String text;
        String type; // question or answer 
        int book_id; // this message is part of a conversation to a specific question to a specific question done by a customer towards the author


        public Message(String sender, String Author, String text, String type, int bookID)
        {
            this.sender = sender;
            this.author = Author;
            this.text = text;
            this.type = type;
            this.book_id = bookID;
        }

        public int QuestionID { get => questionID; set => questionID = value; }
        public string Sender { get => sender; set => sender = value; }
        public string Author { get => author; set => author = value; }
        public string Text { get => text; set => text = value; }
        public string Type { get => type; set => type = value; }
        public int Book_id { get => book_id; set => book_id = value; }

        





    }


}
