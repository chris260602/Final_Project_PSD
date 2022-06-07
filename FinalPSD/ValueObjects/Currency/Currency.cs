using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObjects.Currency
{
    public class Currency
    {
        public Currency(string value)
        {
            this.value = value;
        }
        private string value { get; set; }
    }
}
