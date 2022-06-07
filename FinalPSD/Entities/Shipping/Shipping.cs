using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Shipping
{
    public partial class Shipping
    {
        public Shipping()
        {

        }

        public Guid ShippingId { get; set; }
        public string ShipperName { get; set; }
        public Address Destination { get; set; }
        public string ShippingType { get; set; }
    }
}

