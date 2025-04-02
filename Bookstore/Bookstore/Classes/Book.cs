using System;
using System.Collections.Generic;

namespace Bookstore
{
    public class Book
    {
        int id;
        String title;
        String description;
        String author;
        String publisher;
        String language;
        String category;
        int page_number;
        String dimensions;
        Double price;
        Double old_price;

        public int ID { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public string Author { get => author; set => author = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public string Language { get => language; set => language = value; }
        public string Dimensions { get => dimensions; set => dimensions = value; }
        public string Category { get => category; set => category = value; }
        public int Page_number { get => page_number; set => page_number = value; }
        public double Price { get => price; set => price = value; }
        public double Old_price { get => old_price; set => old_price = value; }
       



    }
}
