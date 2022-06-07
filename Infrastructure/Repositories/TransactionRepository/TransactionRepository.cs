using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.TransactionRepository
{
    internal class TransactionRepository
    {
        public void Add(Guid TransactionID, Customer customer, Product product, Employee employee, Shipping shipping, DateTime TransactionDate, Payment payment)
        {
            (INSERT INTO VALUES(TransactionID, customer, product, employee, shipping, TransactionDate, payment));
        }
        public void GetAll()
        {
            (SELECT * FROM Transaction);
        }
        public void Get(Guid TransactionID)
        {
            (SELECT * FROM Transaction WHERE transactionID LIKE(TransactionID));
        }
        public void Update(Guid TransactionID, Customer customer, Product product, Employee employee, Shipping shipping, DateTime TransactionDate, Payment payment)
        {
            (UPDATE Transaction
            SET
            customer = customer;
            product = product;
            product = employee;
            shipping = shipping;
            transactionDate = TransactionDate;
            payment = payment;
            WHERE
                transactionID = TransactionID)
        }
        public void Delete(Guid TransactionID)
        {
            (DELETE FROM Transaction WHERE TransactionID like(TransactionID))
        }
    }
}

