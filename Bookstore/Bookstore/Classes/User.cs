using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore
{
    public class User
    {
        String firstName;
        String surname;
        String username;
        String email;
        String password;
        public Cart cart;   

        

        public User(String FirstName, String Surname, String Username, String Email, String Password)
        {
            this.FirstName = FirstName;
            this.Surname = Surname;
            this.Username = Username;
            this.Email = Email;
            this.Password = Password;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Username { get => username; set => username = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }



        public void createCart()
        {
            //  cart is created when user logs in
            cart = new Cart();
        }

    }
}
