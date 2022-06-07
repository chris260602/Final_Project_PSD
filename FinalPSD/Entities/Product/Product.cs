using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Product
{
    public partial class Product
    {
        public Product()
        {

        }

        public Guid ProductId { get; set; }
        public Guid SupplierId { get; set; }
        public Storage StorageID { get; set; }
        public string ProductName { get; set; }
        public string ProductCategory { get; set; }
        public int ProductPrice { get; set; }
        public DateTime productExpire { get; set; }
        public string productDescription { get; set; }
    }
}
