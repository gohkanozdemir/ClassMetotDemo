using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer(1, "Gokhan", "Ozdemir", "email1@gmail.com","00905311112233");
            Customer customer2 = new Customer(2, "Ahmet", "Arif", "email2@gmail.com", "00905311112244");
            Customer customer3 = new Customer(3, "Esra", "Guzel", "email3@gmail.com", "00905311112255");
            Customer customer4 = new Customer(4, "Salih", "Can", "email4@gmail.com", "00905311112266");
            Customer customer5 = new Customer(5, "Sehnaz", "Kapi", "email5@gmail.com", "00905311112277");
            Customer customer6 = new Customer(6, "Sakine", "Kale", "email6@gmail.com", "00905311112288");

            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4, customer5, customer6 };
            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customers);
            customerManager.List();

            customerManager.Delete(customer6);

            customerManager.List();

        }
    }
}
