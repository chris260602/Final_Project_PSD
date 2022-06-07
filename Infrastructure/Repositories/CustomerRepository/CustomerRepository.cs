using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.CustomerRepository
{
    internal class CustomerRepository
    {
        public void Add(Guid CustomerID, string CustomerName, Address CustomerAddress, PhoneNumber PhoneNumber, Email Email)
        {
            (INSERT INTO VALUES(CustomerID, CustomerName, CustomerAddress, PhoneNumber, Email));
        }

        public void GetAll()
        {
            (SELECT * FROM Customer);
        }

        public void Get(Guid CustomerID)
        {
            (SELECT * FROM Customer WHERE customerID LIKE(CustomerID));
        }

        public void Update(Guid CustomerID, string CustomerName, Address CustomerAddress, PhoneNumber PhoneNumber, Email Email)
        {
            (UPDATE Customer
            SET
            customerName = CustomerName,
            customerAddress = CustomerAddress,
            phoneNumber = PhoneNumber,
            email = Email
          WHERE
              customerID = CustomerID)
        }

        public void Delete(Guid CustomerID)
        {
            (DELETE FROM Customer WHERE customerID LIKE(CustomerID))
        }
    }
}
