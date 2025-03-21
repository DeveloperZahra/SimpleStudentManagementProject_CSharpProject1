﻿using System.Reflection.Metadata;
using System.Xml.Linq;

namespace SimpleStudentManagementProject_CSharpProject1
{
    internal class Program
    {
        static double[] marks = new double[10];
        static int[] Ages = new int[10];
        static string[] names = new string[10];
        static DateTime[] dates = new DateTime[10];
        static int StudentCounter = 0;
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\nChoose an Array Exercise:");
                Console.WriteLine("1. Add a new student record (Name, Age, Marks)");
                Console.WriteLine("2. View all students");
                Console.WriteLine("3. Find a student by name");
                Console.WriteLine("4. Calculate the class average");
                Console.WriteLine("5. Find the top-performing student ");
                Console.WriteLine("6. Sort students by marks (highest to lowest)");
                Console.WriteLine("7. Delete a student record (handle shifting logic)");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: AddaNewStudent(); break;
                    case 2: ViewStudents(); break;
                    case 3: FindaStudentByName(); break;
                    case 4: CalculateTheClassAverage(); break;
                    case 5: FindTheTopPerformingStudent(); break;
                    case 6: SortStudentsByMarks(); break;
                    case 7: DeleteaStudentRecord(); break;
                    case 0: return;
                    default: Console.WriteLine("Invalid choice! Try again."); break;
                }

                Console.ReadLine();
            }
        }

        // 1. Add a new student record (Name, Age, Marks)______
        static void AddaNewStudent()
        {
            Console.WriteLine("Enter student details:  \n");

            while (true)
            {
                Console.Write("Enter student's name: ");
                string name = Console.ReadLine();
                if (name.ToLower() == "done") break;

                names[StudentCounter] = name;

                Console.Write("Enter student's age: ");
                Ages[StudentCounter] = int.Parse(Console.ReadLine());

                Console.Write("Enter student's marks: ");
                marks[StudentCounter] = double.Parse(Console.ReadLine());

                Console.Write("Enter student's enrollment date (yyyy-mm-dd): ");
                dates[StudentCounter] = DateTime.Parse(Console.ReadLine());

               
                StudentCounter++;

                if (StudentCounter == 100) 
                {
                    Console.WriteLine("Maximum number of students reached.");
                    break;
                }
            }

            Console.WriteLine("\nStudent Information:");
            for (int i = 0; i < StudentCounter; i++)
            {
                Console.WriteLine($"Student {i + 1}:");
                Console.WriteLine($"Name: {names[i]}");
                Console.WriteLine($"Age: {Ages[i]}");
                Console.WriteLine($"Marks: {marks[i]}");
                Console.WriteLine($"Enrollment Date: {dates[i]:yyyy-MM-dd}");
                Console.WriteLine();
               
            }

            Console.WriteLine($"Total number of students: {StudentCounter}");
           
        }

        

        //2. View all students_______
        static void ViewStudents()
        {

        }

        //3. Find a student by name________
        static void FindaStudentByName()
        {

        }

        //4. Calculate the class average_____
        static void CalculateTheClassAverage()
        {

        }

        //5. Find the top-performing student___
        static void FindTheTopPerformingStudent()
        {

        }

        //6. Sort students by marks (highest to lowest)
        static void SortStudentsByMarks()
        {

        }

        //7. Delete a student record (handle shifting logic)____
        static void DeleteaStudentRecord()
        {

        }
    }
}
