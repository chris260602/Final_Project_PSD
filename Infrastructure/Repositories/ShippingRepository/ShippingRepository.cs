using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.ShippingRepository
{
    internal class ShippingRepository
    {
        public void Add(Guid ShippingID, string ShipperName, Address Destination, string ShippingType)
        {
            (INSERT INTO VALUES(ShippingID, ShipperName, Destination, ShippingType));
        }
        public void GetAll()
        {
            (SELECT * FROM Shipping);
        }
        public void Get(Guid ShippingID)
        {
            (SELECT * FROM Shipping WHERE Shippingid LIKE(ShippingID));
        }
        public void Update(Guid ShippingID, string ShipperName, Address Destination, string ShippingType)
        {
            (UPDATE Shipping
            SET
            shipperName = ShipperName,
            destination = Destination,
            shippingType = ShippingType
          WHERE
            shippingID LIKE(ShippingID))
        }
        public void Delete(Guid ShippingID)
        {
            (DELETE FROM Shipping WHERE ShippingID LIKE(ShippingID))
        }
    }
}
