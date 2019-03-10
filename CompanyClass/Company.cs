using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyClass
{
    class Company
    {
        public string title;
        public string address;
        public string phone;
        public double outcome;
        public double expense;
        private readonly string skippy = "-----------------------------------------------";

        public Company(string title, string address, string phone, double outcome, double expense)
        {
            this.title = title;
            this.address = address;
            this.phone = phone;
            this.outcome = outcome;
            this.expense = expense;
        }

        public Company()
        {
            title = "title";
            address = "address";
            phone = "000000000";
            outcome = 0;
            expense = 0;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Company title: {title}");
            Console.WriteLine($"Address: {address}");
            Console.WriteLine($"Phone: {phone}");
            Console.WriteLine($"Outcome: {outcome}");
            Console.WriteLine($"Expense: {expense}");
            Console.WriteLine(ProfitCalc(outcome, expense));
            Console.WriteLine(skippy);
        }

        public string ProfitCalc(double outcome, double expense)
        {
            double profit = 100 * (outcome - expense) / expense;
            Console.WriteLine($"{title} profit % is {profit:0.00}%");
            if (profit > 300)
            {
                return "Company is doing fine";
            }
            else if (profit < 100)
            {
                return "Company is doing badly.";
            }
            else if (profit < 300 && profit > 200)
            {
                return "company is doing average";
            }
            else
            {
                return "company is doing below average";
            }

        }

        public Company(Company copiedCompany)
        {
           title = copiedCompany.title;
           address = copiedCompany.address;
           phone = copiedCompany.phone;
           outcome = copiedCompany.outcome;
           expense = copiedCompany.expense;
        }
    }
}
