using System;

namespace BookClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Book testBook = new Book("kirja1", "kiva kirjailia","01",14);
            Book testBook1 = new Book("kirja2", "kiva kirjailia", "01", 15);

            Console.WriteLine(testBook.GetInfo());
            Console.WriteLine(testBook1.GetInfo());

            Console.WriteLine(testBook.ComparePrice(testBook1));
        }
    }
}
