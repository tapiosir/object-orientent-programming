using System;
using System.Collections.Generic;
using System.Text;

namespace TicketPrice
{
    class Customer
    {
        public int age;
        public bool isMtk;
        public bool isStudent;
        public bool isArmy;
        private static int ticketPrice = 16;
        private double ticketPriceAge = ticketPrice * 0.5;
        private double ticketPriceMtk = ticketPrice * 0.85;
        private double ticketPriceMili = ticketPrice * 0.5;
        private double ticketPriceStud = ticketPrice * 0.55;
        private double ticketPriceMtkStud = ticketPrice * 0.40;

        public Customer(int age, bool isMtk, bool isStudent, bool isArmy)
        {
            this.age = age;
            this.isMtk = isMtk;
            this.isStudent = isStudent;
            this.isArmy = isArmy;
        }
        
        public Customer()
        {
            age = 0;
            isMtk = false;
            isStudent = false;
            isArmy = false;
        }

        public void CalculatePrice()
        {
            if (age <= 7)
            {
                Console.WriteLine("lippu on ilmainen");
            }
            else if (age >= 65)
            {
                Console.WriteLine($"lippu maksaa: {ticketPriceAge:C} ");
            }
            else if (age <= 15)
            {
                Console.WriteLine($"lippu maksaa: {ticketPriceAge:C}");
            }
            else
            {
                if (isMtk = true && isStudent == true)
                {
                    Console.WriteLine($"lippu maksaa: {ticketPriceMtkStud:C}");
                }
                else if (isMtk == true)
                {
                    Console.WriteLine($"lippu maksaa: {ticketPriceMtk:C}");
                }
                else if (isArmy == true)
                {
                    Console.WriteLine($"lippu maksaa: {ticketPriceMili:C}");
                }
                else
                    Console.WriteLine($"lippu maksaa: {ticketPrice:C} ");
            }
        }

    }
}
