using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Employee
{
    public partial class Employee
    {
        public Employee(Guid employeeID, string employeeName, Address employeeAddress, DateTime employeeDOB, string employeeGender, PhoneNumber employeePhoneNumber, Email employeeEmail)
        {
            this.update(employeeName, employeeAddress, employeeDOB, employeeGender, employeePhoneNumber, employeeEmail);
        }

        public void update(string EmployeeName, Address EmployeeAddress, DateTime EmployeeDOB, string EmployeeGender, PhoneNumber EmployeePhoneNumber, Email EmployeeEmail)
        {
            this.EmployeeID = new Guid();
            this.EmployeeName = EmployeeName;
            this.EmployeeAddress = EmployeeAddress;
            this.EmployeeDOB = EmployeeDOB;
            this.EmployeeGender = EmployeeGender;
            this.EmployeePhoneNumber = EmployeePhoneNumber;
            this.EmployeeEmail = EmployeeEmail;
        }

        public Employee createCustomerFactory(string EmployeeName, Address EmployeeAddress, DateTime EmployeeDOB, string EmployeeGender, PhoneNumber EmployeePhoneNumber, Email EmployeeEmail)
        {
            return new Employee(new Guid(), EmployeeName, EmployeeAddress, EmployeeDOB, EmployeeGender, EmployeePhoneNumber, EmployeeEmail);
        }

        public void ScanProduct()
        {
            //...
        }
        public void ManagePayment()
        {
            //...
        }
    }
}