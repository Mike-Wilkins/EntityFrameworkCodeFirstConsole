using EntityFrameworkCodeFirstConsole.CustomerLogic;
using EntityFrameworkCodeFirstConsole.Models;
using System;

namespace EntityFrameworkCodeFirstConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            var create = new Customers();
            create.PrintCustomers();
            Console.ReadLine();
            Console.Clear();

            customer.FirstName = "Jake";
            customer.MiddleName = "Harry";
            customer.LastName = "Anderson";
            customer.Address = "67 Belvour Drive";
            customer.PhoneNumber = 882564;
            customer.Email = "jake@gmail.com";
            customer.DateCreated = DateTime.Now.ToShortDateString();

            create.Create(customer);

            create.PrintCustomers();



            //create.Delete("Bob", "Taylor");
            //create.PrintCustomers();


            //customer.FirstName = "Anna";
            //customer.MiddleName = "Lynsey";
            //customer.LastName = "Thompson";
            //customer.Address = "6 Oak Lane";
            //customer.PhoneNumber = 2229945;
            //customer.Email = "anna@gmail.com";
            //customer.DateCreated = DateTime.Now.ToShortDateString();

            //create.Edit(customer);

            //create.PrintCustomers();

        }
    }
}
