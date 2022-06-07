using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Employee
{
    public partial class Employee
    {
        public Employee()
        {

        }

        public Guid EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public Address EmployeeAddress { get; set; }
        public DateTime EmployeeDOB { get; set; }
        public string EmployeeGender { get; set; }
        public PhoneNumber EmployeePhoneNumber { get; set; }
        public Email EmployeeEmail { get; set; }


    }
}