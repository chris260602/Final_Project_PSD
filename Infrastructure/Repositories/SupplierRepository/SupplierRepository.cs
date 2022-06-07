using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.SupplierRepository
{
    internal class SupplierRepository
    {
        public void Add(Guid SupplierID, string SupplierName, Address address)
        {
            (INSERT INTO VALUES(SupplierID, SupplierName, address));
        }
        public void GetAll()
        {
            (SELECT * FROM Supplier);
        }
        public void Get(Guid SupplierID)
        {
            (SELECT * FROM Supplier WHERE supplierID LIKE(SupplierID));
        }
        public void Update(Guid SupplierID, string SupplierName, Address address)
        {
            (UPDATE Supplier
           SET
            supplierName = SupplierName;
            supplierAddress = address;
            WHERE
              supplierID = SupplierID)
        }
        public void Delete(Guid SupplierID)
        {
            (DELETE FROM Supplier WHERE SupplierID LIKE(SupplierID))
        }
    }
}
