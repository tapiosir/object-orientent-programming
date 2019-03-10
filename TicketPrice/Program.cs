using System;

namespace TicketPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Customer newCustomer = new Customer(AskAge(), AskMtk(), AskStudent(), AskArmy());
            newCustomer.CalculatePrice();
        }

        

        public static int AskAge()
        {
            Console.WriteLine("Anna ikäsi");
            string userInput = Console.ReadLine();
            int age;
            int.TryParse(userInput, out age);
            return age;
        }
        public static bool AskMtk()
        {
            Console.WriteLine("Oletko Mtk:n jäsen? k/e");
            string userInput = Console.ReadLine();
            if (userInput == "k")
            {
                return true;
            }
            else if (userInput == "e")
            {
                return false;
            }
            else
                return false;
        }
        public static bool AskStudent()
        {
            Console.WriteLine("Oletko opiskelija? k/e");
            string userInput = Console.ReadLine();
            if (userInput == "k")
            {
                return true;
            }
            else if (userInput == "e")
            {
                return false;
            }
            else
                return false;
        }
        public static bool AskArmy()
        {
            Console.WriteLine("Oletko varusmiespalveluksessa K/e");
            string userInput = Console.ReadLine();
            if (userInput == "k")
            {
                return true;
            }
            else if (userInput == "e")
            {
                return false;
            }
            else
                return false;
        }
    }

}
