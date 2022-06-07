using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Transaction
{
    public partial class Transaction
    {
        public Transaction(Customer customer, Product product, Employee employee, Shipping shipping, DateTime TransactionDate, Payment payment)
        {
            this.Update(customer, product, employee, shipping, TransactionDate, payment);
        }

        public void Update(Customer customer, Product product, Employee employee, Shipping shipping, DateTime TransactionDate, Payment payment)
        {
            this.TransactionId = new Guid();
            this.customer = customer;
            this.product = product;
            this.product = employee;
            this.shipping = shipping;
            this.TransactionDate = TransactionDate;
            this.Payment = payment;
        }
        public Transaction createTransaction(Customer customer, Product product, Employee employee, Shipping shipping, DateTime TransactionDate, Payment payment)
        {
            return new Transaction(customer, product, employee, shipping, TransactionDate, payment);
        }
    }
}
