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

            //customer.FirstName = "Luke";
            //customer.MiddleName = "Tom";
            //customer.LastName = "Davies";
            //customer.Address = "38 Grand Park Avenue";
            //customer.PhoneNumber = 882564;
            //customer.Email = "luke@gmail.com";
            //customer.DateCreated = DateTime.Now.ToShortDateString();

            //create.Create(customer);

            //create.PrintCustomers();



            //create.Delete("Bob", "Taylor");
            //create.PrintCustomers();


            customer.Customer_Id = 3;
            customer.FirstName = "Anna";
            customer.MiddleName = "Lynsey";
            customer.LastName = "Thompson";
            customer.Address = "12 Oak Lane";
            customer.PhoneNumber = 2229945;
            customer.Email = "anna@gmail.com";
            customer.DateCreated = DateTime.Now.ToShortDateString();

            create.Edit(customer);

            create.PrintCustomers();

        }
    }
}
