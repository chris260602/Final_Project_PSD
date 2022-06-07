using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObjects.Email
{
    public class Email
    {
        public Email(string email)
        {
            this.email = email;
        }
        private string email { get; set; }
        private void validateEmail(string email)
        {
            //...
        }
    }
}
