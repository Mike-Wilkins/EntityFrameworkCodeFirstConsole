using ConsoleTables;
using EntityFrameworkCodeFirstConsole.Models;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace EntityFrameworkCodeFirstConsole.CustomerLogic
{
    class Customers
    {
        CustomerDbContext db = new CustomerDbContext();

        // Add new customer to database
        public void Create(Customer customer)
        {
            bool emailIsValid = ValidateEmail(customer.Email);
            var customerExists = db.Customers.Where(m => m.FirstName == customer.FirstName && m.LastName == customer.LastName).FirstOrDefault();

            if (emailIsValid == false)
            {
                Console.WriteLine("Customer email is invalid");
            }

            if (customerExists != null)
            {
                Console.WriteLine("Customer already exists");
            }

            if (emailIsValid == true && customerExists == null)
            {
                db.Customers.Add(customer);
                db.SaveChanges();
            }
        }

        // Update custumer details
        public void Edit(Customer customer)
        {
            var result = db.Customers.Where(m => m.FirstName == customer.FirstName && m.LastName == customer.LastName).FirstOrDefault();
            db.Customers.Remove(result);

            db.Customers.Add(customer);
            db.SaveChanges();
        }

        // Delete customer from database
        public void Delete(string firstname, string lastname)
        {
            var result = db.Customers.Where(m => m.FirstName == firstname && m.LastName == lastname).FirstOrDefault();

            if (result == null)
            {
                Console.WriteLine("Customer details not found");
            }
            else
            {
                db.Customers.Remove(result);
                db.SaveChanges();
            }
        }

        // Validate email address
        public bool ValidateEmail(string customerEmail)
        {
            return Regex.IsMatch(customerEmail, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }

        // Print customer list in console
        public void PrintCustomers()
        {
            var result = db.Customers.OrderBy(m => m.Id).ToList();
            var table = new ConsoleTable("Id", "Firstname", "Middlename", "Lastname", "PhoneNumber", "Address", "Email", "DateCreated");

            foreach (var item in result)
            {
                table.AddRow(item.Id, item.FirstName, item.MiddleName, item.LastName, item.PhoneNumber, item.Address, item.Email, item.DateCreated);
            }
            Console.WriteLine(table);
        }
    }
}
