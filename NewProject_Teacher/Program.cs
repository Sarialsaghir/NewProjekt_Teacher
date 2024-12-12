using System;
using System.Data;
using System.Runtime.InteropServices;

namespace NewProjekt_Teacher
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> students = new Dictionary<string, int>();
            string input;

            Console.WriteLine("Welcome to the Student Grade Manager!");

            while (true) 
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1.Add/Update a Student");
                Console.WriteLine("2. View All Students and Grades");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Choose an option:");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddOrUppdateStudent(students);
                        break;
                    case "2":
                        ViewStudents(students);
                        break;
                    case "3":
                        Console.WriteLine("Exiting the program.");
                        return;

                        default:

                        Console.WriteLine("Invalid option. Please try again.");
                        break;

                     

                }
            
            }
     
        }

        static void AddOrUppdateStudent(Dictionary<string, int> students)

        {
            Console.Write("Enter the student's name: ");
            string name = Console.ReadLine();

            int grade;
            while (true)
            {
                Console.Write($"Enter the grade for {name} (0-100): ");
                if(int.TryParse(Console.ReadLine(), out grade) && grade >= 0 && grade <= 100)
                        break;

                Console.WriteLine("Invalid grade. Please enter a number between 0 and 100.");

            }

            //Add or update the student's grade

            students[name] = grade;
            Console.WriteLine($"Successfully added/Update {name} ArrayWithOffset grade {grade}.");

        }

        static void ViewStudents(Dictionary<string, int> students) 
        { 
            if (students.Count == 0)
            {
                Console.WriteLine("No students to display.");
                return;
            }

            Console.WriteLine("\nStudents and Grades");
            foreach (var student in students) 
            {
                string status = student.Value >= 60 ? "passed" : "Failed";
                Console.WriteLine($"{student.Key} : {student.Value} ({status})");
            
            }
        
        }

    }


}

