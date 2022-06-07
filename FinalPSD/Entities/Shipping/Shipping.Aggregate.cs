using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Shipping
{
    public partial class Shipping
    {
        public Shipping(string ShipperName, Address Destination, string ShippingType)
        {
            this.update(ShipperName, Destination, ShippingType);
        }

        public void update(string ShipperName, Address Destination, string ShippingType)
        {
            this.ShippingId = new Guid();
            this.ShipperName = ShipperName;
            this.Destination = Destination;
            this.ShippingType = ShippingType;
        }
        public Shipping createShippingFactory(string ShipperName, Address Destination, string ShippingType)
        {
            return new Shipping(ShipperName, Destination, ShippingType);
        }
    }
}
