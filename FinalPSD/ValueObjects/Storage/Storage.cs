using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObjects.Storage
{
    public class Storage
    {
        public Storage(int StorageCapacity)
        {
            this.StorageID = new Guid();
            this.StorageCapacity = StorageCapacity;
        }

        public Guid StorageID { get; set; }
        public int StorageCapacity { get; set; }

        public void StoreProduct()
        {
            //...
        }
    }
}
