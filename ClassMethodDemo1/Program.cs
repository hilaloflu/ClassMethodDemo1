using System;
using System.Collections.Generic;

namespace ClassMethodDemo1
{
    class Program
    {
        
            static void Main(string[] args)
            {
                Customer customer1 = new Customer();
                customer1.Id = 61;
                customer1.FirstName = "Hilal";
                customer1.LastName = "Oflu";
                customer1.Balance = 6120;

                Customer customer2 = new Customer();
                customer2.Id = 35;
                customer2.FirstName = "Ayşegül";
                customer2.LastName = "Bingül";
                customer2.Balance = 1500;

                Customer customer3 = new Customer();
                customer3.Id = 85;
                customer3.FirstName = "Beyza";
                customer3.LastName = "Bodur";
                customer3.Balance = 8100;

                List<Customer> customerList = new List<Customer> { customer1, customer2, customer3 };


                CustomerManager customerManager = new CustomerManager();
                customerManager.CustomerAdd(customer1);
                customerManager.CustomerDelete(customer2);
                customerManager.CustomerBalance(customer3);
                customerManager.List(customerList);

                Console.ReadLine();
            }
        
    }
}
