using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObjects.Price
{
    public class Price
    {
        public Price(Currency currency, int amount)
        {
            this.currency = currency;
            this.amount = amount;
        }
        private Currency currency { get; set; }
        private int amount { get; set; }
    }
}
