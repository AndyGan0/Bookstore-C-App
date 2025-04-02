using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Classes
{
    class Critique
    {

        int critiqueID;
        int bookID;
        String username;
        int stars;
        String text;

        public Critique(int BookID, String Username, int Stars, String CritiqueMessage)
        {
            this.bookID = BookID;
            this.username = Username;
            this.stars = Stars;
            this.text = CritiqueMessage;
        }

        public int CritiqueID { get => critiqueID; set => critiqueID = value; }
        public int BookID { get => bookID; set => bookID = value; }
        public string Username { get => username; set => username = value; }
        public int Stars { get => stars; set => stars = value; }
        public string Text { get => text; set => text = value; }

        





    }
}
