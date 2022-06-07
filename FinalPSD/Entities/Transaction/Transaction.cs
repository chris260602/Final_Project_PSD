using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Transaction
{
    public partial class Transaction 
    {
        public Transaction()
        {
        }
        public Guid TransactionId { get; set; }
        public Customer customer { get; set; }
        public Product product { get; set; }
        public Employee employee { get; set; }
        public Shipping shipping { get; set; }
        public DateTime TransactionDate { get; set; }
        public Payment Payment { get; set; }
    }
    
}
