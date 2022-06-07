using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.EmployeeRepository
{
    internal class EmployeeRepository
    {
        public void Add(Guid EmployeeID, string EmployeeName, Address EmployeeAddress, DateTime EmployeeDOB, string EmployeeGender, PhoneNumber EmployeePhoneNumber, Email EmployeeEmail)
        {
            (INSERT INTO VALUES(EmployeeID, EmployeeName, EmployeeAddress, EmployeeDOB, EmployeeGender, EmployeePhoneNumber, EmployeeEmail));
        }
        public void GetAll()
        {
            (SELECT * FROM Employee);
        }
        public void Get(Guid EmployeeID)
        {
            (SELECT * FROM Employee WHERE Employeeid LIKE(EmployeeID));
        }
        public void Update(Guid employeeid, string EmployeeName, Address EmployeeAddress, DateTime EmployeeDOB, string EmployeeGender, PhoneNumber EmployeePhoneNumber, Email EmployeeEmail)
        {
            (UPDATE employee
            SET
           employeeName = EmployeeName,
           employeeAddress = EmployeeAddress,
           employeeDOB = EmployeeDOB,
           employeeGender = EmployeeGender,
           employeePhoneNumber = EmployeePhoneNumber,
           employeeEmail = EmployeeEmail
           WHERE employeeid = employeeid
          )
        }
        public void Delete(Guid EmployeeID)
        {
            (DELETE FROM Employee WHERE EmployeeID LIKE(EmployeeID))
        }
    }
}
