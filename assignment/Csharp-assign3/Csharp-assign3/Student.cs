using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Csharp_assign3
{
     public class Student
    {
        private int rollNo;
        private string name;
        private string studentClass;
        private string semester;
        private string branch;
        private int[] marks = new int[5];
        public Student(int rollNo,string name,string StudentClass, string semester, string branch)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.studentClass = studentClass;
            this.semester = semester;
            this.branch = branch;
        }
        public void GetMarks()
            {
            for(int i=0;i<marks.Length; i++)
            {
                Console.Write($"Enter marks for subject{i + 1}:");
                marks[i]=int.Parse(Console.ReadLine());

            }
        }
        public void DisplayResult()
            {
            int total = 0;
            bool isFailed = false;
            for (int i = 0; i< marks.Length; i++){
                total += marks[i];
                if (marks[i] < 35) 
                {
                    isFailed = true;

                }


            }
            double average = total / 5.0;
            if (isFailed || average < 50)
            {
                Console.WriteLine("Result: Failed");
            }
            else
            {
                Console.WriteLine("Result: Passed");
            }
            Console.WriteLine($"AverageMarks :{average}");
        }
        public void DisplayData()
        {
            Console.WriteLine("Student Details:");
            Console.WriteLine($"Roll No:{rollNo}");
            Console.WriteLine($"Name:{name}");
            Console.WriteLine($"Class:{studentClass}");
            Console.WriteLine($"Semester:{semester}");
            Console.WriteLine($"Branch:{branch}");

            Console.Write("Marks:");
             for(int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine($"Subject{i + 1}:{marks[i]}");

            }
             
        }
        public void ShowData()
        {
            DisplayData();
            DisplayResult();
        } 
        
    
    
        public static void Main()
        {
            Student student = new Student(2," Abhishek", "5th", "1th", "Science");

            student.GetMarks();
            student.ShowData();
            Console.ReadLine();
        
        }
        
    
        
        
        
        



       
        
        

        }
    }

