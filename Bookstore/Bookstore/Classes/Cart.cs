using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore
{
    public class Cart
    {

        List<Book> Items = new List<Book>();


        public void addBook(Book book)
        {
            Items.Add(book);
        }

        public void removeBook(int index)
        {
            Items.RemoveAt(index);
        }

        public void clearCart()
        {
            Items.Clear();
        }


        public List<Book> getCartItems()
        {
            return Items;
        }
        
        

    }
}
