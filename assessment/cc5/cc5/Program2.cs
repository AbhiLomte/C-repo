using System;

namespace CalculatorDelegates
{
    // Define delegate types for different calculator operations
    delegate int CalculatorOperation(int num1, int num2);

    class Program2
    {
        static void Main(string[] args)
        {
           
            CalculatorOperation add = Add;
            CalculatorOperation subtract = Subtract;
            CalculatorOperation multiply = Multiply;

          
            Console.Write("Enter the first integer: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second integer: ");
            int num2 = int.Parse(Console.ReadLine());

           
            int resultAdd = PerformOperation(num1, num2, add);
            Console.WriteLine($"Result of addition: {resultAdd}");

            
            int resultSubtract = PerformOperation(num1, num2, subtract);
            Console.WriteLine($"Result of subtraction: {resultSubtract}");

            
            int resultMultiply = PerformOperation(num1, num2, multiply);
            Console.WriteLine($"Result of multiplication: {resultMultiply}");

            Console.ReadLine();
        }

       
        static int PerformOperation(int num1, int num2, CalculatorOperation operation)
        {
            return operation(num1, num2);
        }

        
        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
