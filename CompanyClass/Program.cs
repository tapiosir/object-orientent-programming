using System;

namespace CompanyClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company1 = new Company("company1", "street1", "111111111", 12345, 123);
            Company company2 = new Company("company1", "street2", "222222222", 4567575, 305000);
            Company company3 = new Company("company1", "street3", "333333333", 777770, 645645);
            Company company4 = new Company(company1);

            company1.PrintInfo();
            company2.PrintInfo();
            company3.PrintInfo();
            company4.PrintInfo();
        }
    }
}
