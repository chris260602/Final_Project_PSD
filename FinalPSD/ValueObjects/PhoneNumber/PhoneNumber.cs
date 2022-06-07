using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObjects.PhoneNumber
{
    public class PhoneNumber
    {
        public PhoneNumber(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }
        private string phoneNumber { get; set; }
        private void validatePhoneNumber(string phoneNumber)
        {
            //...
        }
    }
}
