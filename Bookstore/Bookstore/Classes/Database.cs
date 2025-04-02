using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookstore.Classes;

namespace Bookstore
{
    class Database
    {
        static String connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='Database/Database.mdb';";
        static OleDbConnection conn = new OleDbConnection(connectionString);


        static public void registerUser(User user)
        {
            conn.Open();

            OleDbCommand command = conn.CreateCommand();
            command.Connection = conn;

            command.CommandText = "INSERT INTO `Accounts` (`FirstName`, `Surname` ,`Username` ,`Email` ,`Password` ,`isAuthor`) VALUES(@FirstName, @Surname, @Username, @Email, @Password, @isAuhtor)";
            command.Parameters.AddWithValue("@FirstName", user.FirstName);
            command.Parameters.AddWithValue("@Surname", user.Surname);
            command.Parameters.AddWithValue("@Username", user.Username);
            command.Parameters.AddWithValue("@Email", user.Email);
            command.Parameters.AddWithValue("@Password", user.Password);
            command.Parameters.AddWithValue("@isAuhtor", user.GetType() == typeof(Classes.Author));
            

            command.ExecuteNonQuery();

            conn.Close();

        }


        

        static public User loginUser(String Email, String Password)
        {
            conn.Open();

            OleDbCommand command = conn.CreateCommand();
            command.Connection = conn;

            command.CommandText = "SELECT* FROM[Accounts] WHERE Email=@email AND Password=@pass";
            command.Parameters.AddWithValue("@email", Email);
            command.Parameters.AddWithValue("@pass", Password);

            OleDbDataReader reader = command.ExecuteReader();

            if (!reader.Read())
            {
                conn.Close();
                return null;
            }


            User currentUser;

            if (reader.GetBoolean(6))
            {
                //  if user is author
                currentUser = new Author(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
            }
            else
            {
                //  if user isnt author
                currentUser = new User(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
            }
            
            currentUser.createCart();

            if (reader.Read())
            {
                conn.Close();
                return null;
            }

            conn.Close();
            return currentUser;

        }



        static public Book getBookByID(int ID)
        {
            /*
             *  Finds the specific book with the ID and returns it
             */

            Book temp = new Book();

            conn.Open();

            OleDbCommand command = conn.CreateCommand();
            command.Connection = conn;

            command.CommandText = "SELECT* FROM[Books] WHERE ID=@id";
            command.Parameters.AddWithValue("@id", ID);

            OleDbDataReader reader = command.ExecuteReader();           


            if (!reader.Read())
            {
                return null;
            }

            Book BookFound = new Book();
            BookFound.ID = reader.GetInt32(0);
            BookFound.Title = reader.GetString(1);
            BookFound.Description = reader.GetString(2);
            BookFound.Author = reader.GetString(3);
            BookFound.Publisher = reader.GetString(4);
            BookFound.Language = reader.GetString(5);
            BookFound.Category = reader.GetString(6);
            BookFound.Page_number = reader.GetInt32(7);
            BookFound.Dimensions = reader.GetString(8);
            BookFound.Price = reader.GetDouble(9);

            if ( reader.IsDBNull(10))
            {
                BookFound.Old_price = 0;
            }
            else
            {
                BookFound.Old_price = reader.GetDouble(10);
            }



            conn.Close();
            return BookFound;
        }

        static public List<List<String>> searchBookByCategory(String SearchWord, String SearchCategory="Title", String BookCategory=null)
        {
            /*
             *  Performs a Search for books based on the search the user made
             */

            conn.Open();

            OleDbCommand command = conn.CreateCommand();
            command.Connection = conn;


            //command.CommandText = "SELECT * FROM Books WHERE Books.Title Like '%Vinci%';";
            command.CommandText = "SELECT * FROM Books WHERE " + SearchCategory + " Like @searchWord ";
            if (BookCategory != null) { command.CommandText = command.CommandText + "AND Category = '" + BookCategory + "' ;"; }
            command.Parameters.AddWithValue("@searchWord", "%" + SearchWord + "%");


            OleDbDataReader reader = command.ExecuteReader();

            List<List<String>> results = new List<List<string>>();

            while (reader.Read())
            {
                List<String> temp = new List<string>();

                temp.Add(reader.GetInt32(0).ToString()); // ID
                temp.Add(reader.GetString(1)); // title
                temp.Add(reader.GetString(3)); // Author
                temp.Add(reader.GetString(4)); // Publisher
                temp.Add(reader.GetDouble(9).ToString()); // Price

                results.Add(temp);
            }


            conn.Close();
            return results;
        }




        public static void userBoughtBook(String username, int BookID)
        {
            /*
             *  Called when a user buys a new book. This purchase will be saved in the database
             */

            conn.Open();

            OleDbCommand command = conn.CreateCommand();
            command.Connection = conn;

            command.CommandText = "INSERT INTO `UserBoughtBook` (`username`, `Book_ID`, `Purchase_date`) VALUES(@username, @Book_ID, Now() )";
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@Book_ID", BookID);

            command.ExecuteNonQuery();

            conn.Close();
        }


        public static List<int> getBooksOwnedByUser(String username)
        {
            /*
             *  Gets a user as parameter and returns all the books he has bought in the past
             */

            conn.Open();

            OleDbCommand command = conn.CreateCommand();
            command.Connection = conn;


            command.CommandText = "SELECT Book_ID FROM UserBoughtBook WHERE username=@username";            
            command.Parameters.AddWithValue("@username", username);


            OleDbDataReader reader = command.ExecuteReader();

            List<int> results = new List<int>();

            while (reader.Read())
            {
                results.Add(reader.GetInt32(0));
            }

            conn.Close();
            return results;
        }


        public static List<int> booksWrittenByUser(String username)
        {
            /*
             *  Gets a user as parameter and returns all the books he has written in the past
             *  Thats assuming the user is author
             */

            conn.Open();

            OleDbCommand command = conn.CreateCommand();
            command.Connection = conn;


            command.CommandText = "SELECT ID FROM Books WHERE Author=@username";
            command.Parameters.AddWithValue("@username", username);


            OleDbDataReader reader = command.ExecuteReader();

            List<int> results = new List<int>();

            while (reader.Read())
            {
                results.Add(reader.GetInt32(0));
            }

            conn.Close();
            return results;
        }






        public static void sendMessage(Message message)
        {
            /*
             *  This method is called when a user asks a question to an author or an author answers a question from a user. 
             */

            conn.Open();
            OleDbCommand command = conn.CreateCommand();
            command.Connection = conn;

            command.CommandText = "INSERT INTO `QuestionAndAnswers` (`Sender`, `Author`, `Message`, `Book_id`, `type`) VALUES(@sender, @Author, @message, @book_id, @type )";
            command.Parameters.AddWithValue("@sender", message.Sender);
            command.Parameters.AddWithValue("@Author", message.Author);
            command.Parameters.AddWithValue("@message", message.Text);
            command.Parameters.AddWithValue("@book_id", message.Book_id);
            command.Parameters.AddWithValue("@type", message.Type);

            command.ExecuteNonQuery();
            conn.Close();
        }


        public static List<Message> getUserConversations(String username)
        {
            List<Message> results = new List<Message>();

            conn.Open();
            OleDbCommand command = conn.CreateCommand();
            command.Connection = conn;

            command.CommandText = "SELECT * FROM QuestionAndAnswers WHERE Sender=@username Or Author=@username";
            command.Parameters.AddWithValue("@username", username);

            OleDbDataReader reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                int QuestionID = reader.GetInt32(0);
                String sender = reader.GetString(1); 
                String Author = reader.GetString(2);
                String message = reader.GetString(3);
                int bookID = reader.GetInt32(4);
                String type = reader.GetString(5);

                Message temp_message = new Message( sender, Author, message, type, bookID);
                temp_message.QuestionID = QuestionID;

                results.Add(temp_message);

            }

            conn.Close();
            return results;

        }
        
        

        public static void postCritique(Critique critique)
        {
            /*
             *  This method When a User Posts A Critique
             */

            conn.Open();
            OleDbCommand command = conn.CreateCommand();
            command.Connection = conn;

            command.CommandText = "INSERT INTO `BookCritique` (`BookID`, `Username`, `Stars`, `Text`) VALUES(@BookID, @Username, @Stars, @Text )";
            command.Parameters.AddWithValue("@BookID", critique.BookID);
            command.Parameters.AddWithValue("@Username", critique.Username);
            command.Parameters.AddWithValue("@Stars", critique.Stars);
            command.Parameters.AddWithValue("@Text", critique.Text);

            command.ExecuteNonQuery();
            conn.Close();
        }

        public static List<Critique> retrieveCritiquesForBook(int Book_id)
        {
            /*
             *  This method is used when we need to retrieved critiques for a specific book from the database
             */

            conn.Open();

            OleDbCommand command = conn.CreateCommand();
            command.Connection = conn;


            command.CommandText = "SELECT * FROM BookCritique WHERE BookID=@BookID";
            command.Parameters.AddWithValue("@BookID", Book_id);


            OleDbDataReader reader = command.ExecuteReader();

            List<Critique> results = new List<Critique>();

            while (reader.Read())
            {
                int CritiqueID = reader.GetInt32(0);
                int BookID = reader.GetInt32(1);
                String Username = reader.GetString(2);
                int Stars = reader.GetInt32(3);
                String message = reader.GetString(4);


                Critique temp = new Critique(BookID, Username, Stars, message);
                temp.CritiqueID = CritiqueID;
                results.Add(temp);
            }

            conn.Close();
            return results;
        }



        public static List<DateTime> returnDatesOfBookPurchases(int Book_id)
        {
            conn.Open();

            OleDbCommand command = conn.CreateCommand();
            command.Connection = conn;


            command.CommandText = "SELECT PurchaseID,Purchase_date FROM UserBoughtBook WHERE Book_ID=@BookID";
            command.Parameters.AddWithValue("@BookID", Book_id);


            OleDbDataReader reader = command.ExecuteReader();

            List<DateTime> results = new List<DateTime>();

            while (reader.Read())
            {
                results.Add(reader.GetDateTime(1).Date);
            }

            conn.Close();
            return results;
        }


        // SELECT @@IDENTITY 
        // selects last inserted value
    }
}
