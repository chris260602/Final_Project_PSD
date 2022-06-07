using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObjects.PaymentType
{
    public class PaymentType
    {
        public PaymentType(string type)
        {
            this.type = type;
        }
        private string type { get; set; }
    }

}
