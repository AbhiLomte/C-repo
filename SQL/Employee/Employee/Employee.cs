using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Employee
    {
        static void Main(string[] args)
        {
            int Empid;
            string Firstname;
            string Lastname;
            string Title;
            DateTime DOB;
            DateTime DOJ;
            string city;
         }
        public Employee(int employeeID, string firstName, string lastName, string title, DateTime dob, DateTime doj, string city)
        {
            EmployeeID = employeeID;
            FirstName = firstName;
            LastName = lastName;
            Title = title;
            DOB = dob;
            DOJ = doj;
            City = city;
        }
    }
}
