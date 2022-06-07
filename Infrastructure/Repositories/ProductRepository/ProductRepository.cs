using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.ProductRepository
{
    internal class ProductRepository
    {
        public void Add(Guid ProductID, Supplier supplier, Storage storage, string ProductName, string ProductCategory, int ProductPrice, DateTime productExpire, string productDescription)
        {
            (INSERT INTO VALUES(ProductID, supplier, storage, ProductName, ProductCategory, ProductPrice, productExpire, productDescription));
        }
        public void GetAll()
        {
            (SELECT * FROM Product);
        }
        public void Get(Guid ProductID)
        {
            (SELECT * FROM Product WHERE Productid LIKE(ProductID));
        }
        public void Update(Guid ProductID, Supplier supplier, Storage storage, string ProductName, string ProductCategory, int ProductPrice, DateTime productExpire, string productDescription)
        {
            UPDATE Product
          SET
            supplier = Supplier,
            storage = storage,
            productName = ProductName,
            productPrice = ProductPrice,
            productExpire = productExpire,
            productDescription = productDescription
          WHERE
            productID LIKE(ProductID)
        }
        public void Delete(Guid ProductID)
        {
            (DELETE FROM Product WHERE ProductID LIKE(ProductID))
        }
    }
}
