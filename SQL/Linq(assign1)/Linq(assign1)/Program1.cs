using System;
using System.Linq;
using YourNamespace.Models; // Replace with your actual namespace

class Program1
{
    static void Main()
    {
        using (var context = new YourDbContext())
        {
            var employees = context.Employees
                                   .Where(e => e.JoinDate < new DateTime(2015, 1, 1))
                                   .ToList();

            foreach (var employee in employees)
            {
                Console.WriteLine($"Employee ID: {employee.EmployeeID}, Name: {employee.Name}, Join Date: {employee.JoinDate}");
            }
        }
    }
}
