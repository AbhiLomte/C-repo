using System;

class Scholarship
{
    public double Merit(int marks, double fees)
    {
        double scholarshipAmount = 0.0;

        if (marks >= 70 && marks <= 80)
        {
            scholarshipAmount = 0.2 * fees; // 20% of fees
        }
        else if (marks > 80 && marks <= 90)
        {
            scholarshipAmount = 0.3 * fees; // 30% of fees
        }
        else if (marks > 90)
        {
            scholarshipAmount = 0.5 * fees; // 50% of fees
        }

        return scholarshipAmount;
    }
}

class que4
{
    static void Main()
    {
        Scholarship scholarship = new Scholarship();

        // Example usage:
        int studentMarks = 85;
        double tuitionFees = 10000.0;

        double amount = scholarship.Merit(studentMarks, tuitionFees);

        Console.WriteLine($"Scholarship amount for marks {studentMarks} is: {amount:C2}");
        Console.Read();
    }
}
