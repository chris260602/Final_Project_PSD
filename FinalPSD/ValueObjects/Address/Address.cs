using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObjects.Address
{
    public class Address
    {
        public Address(int streetNumber, string street, string city, string province, string country, string postCode)
        {
            this.streetNumber = streetNumber;
            this.street = street;
            this.city = city;
            this.province = province;
            this.country = country;
            this.postCode = postCode;
        }
        private int streetNumber { get; set; }
        private string street { get; set; }
        private string city { get; set; }
        private string province { get; set; }
        private string country { get; set; }
        private string postCode { get; set; }

        private void validateProvince(string province)
        {
            //...
        }
        private void validateCity(string city)
        {
            //...
        }
        private void validateCountry(string country)
        {
            //...
        }
        private void validatePostCode(string postCode)
        {
            //...
        }
    }
}
