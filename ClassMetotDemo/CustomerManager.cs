using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        private List<Customer> customers = new List<Customer>();
        public void Add(Customer customer)
        {
            customers.Add(customer);
        }
        public void Add(Customer[] customersList)
        {
            foreach (Customer customer in customersList)
            {
                customers.Add(customer);
            }
            
        }

        public void List()
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Customer name: " + customer.Name + " Customer surname: " + customer.LastName
                                   +" \n Phone number: " + customer.PhoneNumber + " Email: " + customer.Email);
            }
            Console.WriteLine("\nCustomers listed!\n");
        }

        public void Delete(Customer customer)
        {
            int index = customers.FindIndex(cust => cust == customer);
            Console.WriteLine("Customer name: " + customers[index].Name + " Customer surname: " + customers[index].LastName
                                  + " \n Phone number: " + customers[index].PhoneNumber + " Email: " + customers[index].Email);
            customers.RemoveAt(index);
            Console.WriteLine("\nCustomers Deleted... !\n");
        }
    }
}
