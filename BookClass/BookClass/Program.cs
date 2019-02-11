using System;

namespace BookClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Book testBook = new Book("kirja1", "Jolkien Tolkien","00001",14);
            Book testBook1 = new Book("kirja2", "Stephen King", "00002", 15);

            Console.WriteLine(testBook.GetInfo());
            Console.WriteLine(testBook1.GetInfo());

            Console.WriteLine(testBook.ComparePrice(testBook1));
        }
    }
}
