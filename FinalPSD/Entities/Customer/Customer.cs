using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Customer
{
    public partial class Customer
    {
        public Guid CustomerId { get; set; }
        public string CustomerName { get; set; }
        public Address CustomerAddress { get; set; }
        public PhoneNumber PhoneNumber { get; set; }
        public Email Email { get; set; }

    }
}