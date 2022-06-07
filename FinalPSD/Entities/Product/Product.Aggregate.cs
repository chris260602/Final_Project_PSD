using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Product
{
    public partial class Product
    {
        public Product(Guid ProductId, Guid SupplierId, Storage StorageID, string ProductName, string ProductCategory, int ProductPrice, DateTime productExpire, string productDescription)
        {
            this.update(ProductId, SupplierId, StorageID, ProductName, ProductCategory, ProductPrice, productExpire, productDescription);
        }

        public void update(Guid ProductId, Guid SupplierId, Storage StorageID, string ProductName, string ProductCategory, int ProductPrice, DateTime productExpire, string productDescription)
        {
            this.ProductId = new Guid();
            this.SupplierId = SupplierId;
            this.StorageID = StorageID;
            this.ProductName = ProductName;
            this.ProductCategory = ProductCategory;
            this.ProductPrice = ProductPrice;
            this.productExpire = productExpire;
            this.productDescription = productDescription;
        }

        public Product createProduct(Guid SupplierId, Storage StorageID, string ProductName, string ProductCategory, int ProductPrice, DateTime productExpire, string productDescription)
        {
            return new Product(new Guid(), SupplierId, StorageID, ProductName, ProductCategory, ProductPrice, productExpire, productDescription);
        }

        public void AddProduct()
        {
            //...  
        }
        public void DeleteProduct()
        {
            //...  
        }
        public void UpdateProduct()
        {
            //...  
        }
    }
}
