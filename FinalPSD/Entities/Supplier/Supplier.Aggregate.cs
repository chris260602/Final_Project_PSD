using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Supplier
{
    public partial class Supplier
    {
        public Supplier(string SupplierName, Address address)
        {
            this.update(SupplierName, address);
        }

        public void update(string SupplierName, Address address)
        {
            this.SupplierId = new Guid();
            this.SupplierName = SupplierName;
            this.SupplierAddress = address;
        }
        public Supplier createSupplierFactory(string SupplierName, Address address)
        {
            return new Supplier(SupplierName, address);
        }
    }
}
