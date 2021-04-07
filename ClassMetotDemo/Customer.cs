using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public Customer()
        {

        }

        public Customer(int id, string name, string lastName, string email, string phoneNumber)
        {
            this.Id = id;
            this.Name = name;
            this.LastName = lastName;
            this.Email = email;
            this.PhoneNumber = phoneNumber;

        }
    }
}
