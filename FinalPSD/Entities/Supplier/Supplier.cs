using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Supplier
{
    public partial class Supplier
    {
        public Supplier()
        {

        }
        public Guid SupplierId { get; set; }
        public string SupplierName { get; set; }
        public Address SupplierAddress { get; set; }
    }
}
