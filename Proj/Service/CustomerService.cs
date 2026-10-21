
using System;
using System.Collections.Generic;
using Proj_.Models;

namespace Proj_.Service
{
    public class CustomerService
    {
        private List<Customer> Customers = new List<Customer>();

        public void AddCustomer(Customer customer)
        {
            foreach (Customer c in Customers)
            {
                if (c.CustomerId == customer.CustomerId)
                {
                    Console.WriteLine("Customer ID already exists");
                    return;
                }
            }

            Customers.Add(customer);
            Console.WriteLine("Customer added successfully");
        }

        public void ViewCustomer()
        {
            if (Customers.Count == 0)
            {
                Console.WriteLine("No customers found. Add a customer first.");
                return;
            }

            foreach (Customer c in Customers)
            {
                Console.WriteLine("Customer ID: " + c.CustomerId);
                Console.WriteLine("Full Name: " + c.FullName);
            }
        }

        public void SearchCustomer(int customer)
        {
            foreach (Customer c in Customers)
            {
                if (c.CustomerId == customer)
                {
                    Console.WriteLine("Customer ID: " + c.CustomerId);
                    Console.WriteLine("Customer Name: " + c.FullName);
                    Console.WriteLine("Phone Number: " + c.PhoneNumber);
                    Console.WriteLine("Address: " + c.Address);
                    return;
                }
            }

            Console.WriteLine("Customer not found.");
        }
    }
}
