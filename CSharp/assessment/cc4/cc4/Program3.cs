using System;
using System.Collections.Generic;
using System.Linq;

public class Employee
{
    public int EmpId { get; set; }
    public string EmpName { get; set; }
    public string EmpCity { get; set; }
    public decimal EmpSalary { get; set; }
}

public class Program3
{
    public static void Main(string[] args)
    {
        // Create a list of employees and populate some data
        List<Employee> employees = new List<Employee>
        {
            new Employee { EmpId = 1, EmpName = "Mahesh", EmpCity = "Bangalore", EmpSalary = 50000 },
            new Employee { EmpId = 2, EmpName = "Ramesh", EmpCity = "Mumbai", EmpSalary = 48000 },
            new Employee { EmpId = 3, EmpName = "Suresh", EmpCity = "Bangalore", EmpSalary = 55000 },
            new Employee { EmpId = 4, EmpName = "Ravi", EmpCity = "Chennai", EmpSalary = 42000 },
            new Employee { EmpId = 5, EmpName = "Abhishek", EmpCity = "Bangalore", EmpSalary = 46000 }
        };

        Console.WriteLine("All employees:");
        DisplayEmployees(employees);

        Console.WriteLine("\nEmployees with salary greater than 45000:");
        DisplayEmployees(employees.Where(e => e.EmpSalary > 45000).ToList());

        Console.WriteLine("\nEmployees belonging to Bangalore:");
        DisplayEmployees(employees.Where(e => e.EmpCity.Equals("Bangalore", StringComparison.OrdinalIgnoreCase)).ToList());

        Console.WriteLine("\nEmployees sorted by name in ascending order:");
        DisplayEmployees(employees.OrderBy(e => e.EmpName).ToList());
        Console.Read();
    }

    // Method to display employees
    private static void DisplayEmployees(List<Employee> employees)
    {
        foreach (var emp in employees)
        {
            Console.WriteLine($"EmpId: {emp.EmpId}, EmpName: {emp.EmpName}, EmpCity: {emp.EmpCity}, EmpSalary: {emp.EmpSalary}");
        }
    }
}
