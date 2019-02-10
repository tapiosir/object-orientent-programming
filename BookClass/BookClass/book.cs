using System;
using System.Collections.Generic;
using System.Text;

namespace BookClass
{
    class Book
    {
        public string title;
        public string author;
        public string bookId;
        public double price;
        private readonly string skippy = "----------------------------------------------------------";

        public Book(string title, string author, string bookId, double price)
        {
            this.title = title;
            this.author = author;
            this.bookId = bookId;
            this.price = price;
        }

        public string GetInfo()
        {
            return $" Name: {this.title}\n Author: {this.author}\n Price: {this.price}\n Book id: {this.bookId} \n {skippy}";

        }

        public string ComparePrice(Book book)
        {
            if (price > book.price)
            {
                return $" {title} is more expensive than {book.title}";
            }
            else if (price < book.price)
            {
                return $" {book.title} is more expensive than {title}";
            }
            else
            {
                return $" books costs same";
            }
        }
    }
}
