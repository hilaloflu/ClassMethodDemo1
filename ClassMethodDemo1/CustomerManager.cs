using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo1
{
    class CustomerManager
    {
        public void CustomerAdd(Customer customer)
        {

            Console.WriteLine("Customer " + customer.FirstName + " " + customer.LastName + " WELCOME!");
        }

        public void CustomerDelete(Customer customer)
        {
            Console.WriteLine("Customer " + customer.FirstName + " " + customer.LastName + " removed from the system.");

        }
        public void CustomerBalance(Customer customer)
        {
            Console.WriteLine("Customer " + customer.FirstName + " " + customer.LastName + "'s balance has been reorganized.");
        }
        public void List(List<Customer> customers)
        {
            Console.WriteLine("Customers :");
            foreach (var customer in customers)
            {
                Console.WriteLine("Id : " + customer.Id + " First Name : " + customer.FirstName + " Last Name : " + customer.LastName + " Balance : " + customer.Balance);
            }
        }
    }
}
