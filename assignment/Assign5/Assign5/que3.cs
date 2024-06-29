using System;


class Employee
{
    public int EmpId { get; set; }
    public string EmpName { get; set; }
    public float Salary { get; set; }

  
    public Employee(int empId, string empName, float salary)
    {
        EmpId = empId;
        EmpName = empName;
        Salary = salary;
    }
}

class ParttimeEmployee : Employee
{
    public float Wages { get; set; }

    
    public ParttimeEmployee(int empId, string empName, float salary, float wages)
        : base(empId, empName, salary)
    {
        Wages = wages;
    }
}

class que3
{
    static void Main(string[] args)
    {
       
        ParttimeEmployee parttimeEmp = new ParttimeEmployee(200, "Abhishek", 4000.0f, 20.5f);

        
        Console.WriteLine($"Employee ID: {parttimeEmp.EmpId}");
        Console.WriteLine($"Employee Name: {parttimeEmp.EmpName}");
        Console.WriteLine($"Employee Salary: {parttimeEmp.Salary}");
        Console.WriteLine($"Employee Wages: {parttimeEmp.Wages}");

        Console.ReadKey();
    }
}
