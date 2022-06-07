using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Customer
{
    public partial class Customer
    {
        public Customer(string CustomerName, Address CustomerAddress, PhoneNumber PhoneNumber, Email Email)
        {
            this.update(CustomerName, CustomerAddress, PhoneNumber, Email);
          }

        public void update(string CustomerName, Address CustomerAddress, PhoneNumber PhoneNumber, Email Email)
        {
            this.CustomerId = new Guid();
            this.CustomerName = CustomerName;
            this.CustomerAddress = CustomerAddress;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
        }

        public Customer createCustomerFactory(string CustomerName, Address CustomerAddress, PhoneNumber PhoneNumber, Email Email)
        {
            return new Customer(CustomerName, CustomerAddress, PhoneNumber, Email);
        }
    }
}