using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObjects.Payment
{
    public class Payment
    {
        public Payment(int totalPrice, PaymentType paymentType)
        {
            this.totalPrice = totalPrice;
            this.paymentType = paymentType;
        }
        private int totalPrice { get; set; }
        private PaymentType paymentType { get; set; }
    }
}
