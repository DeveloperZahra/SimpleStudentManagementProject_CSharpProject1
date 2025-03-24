using Microsoft.VisualBasic;
using System;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;

namespace SimpleStudentManagementProject_CSharpProject1
{
    internal class Student
    {
        // Create the array and add the required variables...
        static double[] Mark = new double[5];
        static int[] Age = new int[5];
        static string[] Name = new string[5];
        static DateTime[] Date = new DateTime[5];
        static int StudentCounter = 0;
        static void Main(string[] args)
        {
            while (true) //addition the  function types  of the project...
            {
                Console.Clear();
                Console.WriteLine("\nChoose an Array Exercise:");
                Console.WriteLine("1. Add a new student record");
                Console.WriteLine("2. View all students");
                Console.WriteLine("3. Find a student by name");
                Console.WriteLine("4. Calculate the class average");
                Console.WriteLine("5. Find the top-performing student ");
                Console.WriteLine("6. Sort students by marks (highest to lowest)");
                Console.WriteLine("7. Delete a student record (handle shifting logic)");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");
                try
                {

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
                }
                catch (Exception ex)

                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }


                Console.ReadLine();
            }
        }

        // 1. Add a new student record (Name, Age, Marks)______
        static void AddaNewStudent()
        {
            try
            {
                char choice;
                do
                {
                    if (StudentCounter < Name.Length)
                    {
                        Console.Clear();
                        Console.WriteLine("Enter student details:  \n");

                        //add student name...
                        Console.Write("Enter student's name: ");
                        Name[StudentCounter] = Console.ReadLine();

                        // add student age...
                        Console.Write("Enter student's age: ");
                        Age[StudentCounter] = int.Parse(Console.ReadLine());
                        while (Age[StudentCounter] > 21)
                        {
                            Console.WriteLine("Sorry, I can't add any student over the age of 21!\n" + "Please add another age of student:");
                            Age[StudentCounter] = int.Parse(Console.ReadLine());
                        }
                        // add student marks....
                        Console.Write("Enter student's marks: ");
                        Mark[StudentCounter] = double.Parse(Console.ReadLine());
                        while (Mark[StudentCounter] < 0 || Mark[StudentCounter] > 100)
                        {
                            Console.WriteLine("Sorry student mark should be (0-100) !\n " +
                                              "Please enter anther mark of student :");
                            Mark[StudentCounter] = double.Parse(Console.ReadLine());
                        }

                        // add date of today....
                        Console.Write("Enter student's enrollment date (yyyy-mm-dd): ");
                        Date[StudentCounter] = DateTime.Parse(Console.ReadLine());


                        StudentCounter++;
                        Console.WriteLine("Do you want to add anther student? Yes / No ");
                        choice = Console.ReadKey().KeyChar;
                    }

                    else
                    {
                        Console.WriteLine("Sorry, there is no vacancy to add another student.!");
                        Console.WriteLine();
                        choice = 'n';
                    }


                } while (choice == 'y' || choice == 'Y');

            }
            catch (Exception e)

            {
                Console.WriteLine($"Invalid to add another student!" + e.Message);

            }

        }

            //2. View all students_______
            static void ViewStudents()

            {
                try
            { 

                 if (StudentCounter == 0)
            {
                Console.WriteLine("No students available.");
                return;
            }
            for (int i = 0; i < StudentCounter; i++)
            {
                Console.WriteLine($"Student {i + 1}:");
                Console.WriteLine($"Name: {Name[i]}");
                Console.WriteLine($"Mark: {Mark[i]}");
                Console.WriteLine($"Age: {Age[i]}");
                Console.WriteLine($"Date of Enrollment: {Date[i]:yyyy-MM-dd HH:mm:ss}\n");
            }
            }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }

            }


            //3. Find a student by name________
            static void FindaStudentByName()
            {
                try
                {

                    char choice;
                    //Create a loop to repeat the process of searching for the student's name until it is found according to the user's requirements
                    do
                    {
                        Console.Write("\nEnter a student name to search: ");
                        string searchName = Console.ReadLine().ToLower();// store the name to search...
                        bool found = false;
                        // use a student counter to repeat according to the number of students coming out...
                        for (int i = 0; i < StudentCounter; i++)
                        {
                            if (Name[i].ToLower() == searchName)
                            {
                                Console.WriteLine($"Student found: {Name[i]} - Score: {Name[i]}");
                                found = true;
                                break;
                            }
                        }

                        if (!found)
                        {
                            Console.WriteLine("Student not found! Please Try again.");
                        }

                        Console.WriteLine("Do you want to search for anther student? y / n");
                        choice = Console.ReadKey().KeyChar;

                    } while (choice == 'y' || choice == 'Y');
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input format. Please enter the correct name.");
                }

                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }

            }


            //4. Calculate the class average_____
            static void CalculateTheClassAverage()
            {
                try
                {

                    double sum = 0;
                    double Average;
                    for (int i = 0; i < StudentCounter; i++)//Use the student counter to repeat based on the number of students coming out...
                    {
                        sum = sum + Mark[i];
                    }
                    Average = sum / StudentCounter;
                    double rounded_average = Math.Round(Average, 2);
                    Console.WriteLine($"The student average is: {rounded_average}");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"An error occurred: {e.Message}");
                }

            }

            //5. Find the top-performing student___
            static void FindTheTopPerformingStudent()
            {
                try
                {
                    double largest_Mark = 0;
                    int index = 0;
                    for (int i = 0; i < StudentCounter; i++)
                    {   // to find the largest mark in array...
                        if (Mark[i] > largest_Mark)
                        {
                            largest_Mark = Mark[i];
                            // to store the index of the largest mark
                            index = Array.IndexOf(Mark, Mark[i]);

                        }
                    }
                    // Display the top-performing student
                    Console.WriteLine($"The top pPerforming Student is: {Name[index]} with Mark: {largest_Mark}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            //6. Sort students by marks (highest to lowest)____
            static void SortStudentsByMarks()
            {
                try
                {
                    // Sorting the students by marks..
                    for (int i = 0; i < StudentCounter; i++)
                    {
                        for (int j = i + 1; j < StudentCounter; j++) // compare 1st element with 2nd element
                        {
                            // Declaring Variables...
                            double tempMark = Mark[i];
                            string tempName = Name[i];
                            int tempAge = Age[i];
                            DateTime tempDate = Date[i];

                            // Swapping the elements...
                            if (Mark[i] < Mark[j])
                            {
                                Mark[i] = Mark[j];
                                Mark[j] = tempMark;

                                Name[i] = Name[j];
                                Name[j] = tempName;

                                Age[i] = Age[j];
                                Age[j] = tempAge;

                                Date[i] = Date[j];
                                Date[j] = tempDate;
                            }
                        }
                    }

                    Console.WriteLine("*------  Students Sorted by Marks  ------*");

                    // Printing the sorted students
                    for (int i = 0; i < StudentCounter; i++)
                    {
                        Console.WriteLine($"{i}: Name of Student: {Name[i]} , Student Age: {Age[i]} , Student Mark: {Mark[i]} , Student Enrollment Date: {Date[i]} \n");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            //7. Delete a student record (handle shifting logic)____
            static void DeleteaStudentRecord()
            {
                try
                {
                    char choice;

                    do
                    {
                        int IndexName = 0;
                        Console.WriteLine("Enter the name of student tou want to delete it: ");
                        string DeleteName = Console.ReadLine().ToLower();//store name to delete....
                        for (int i = 0; i < StudentCounter; i++)//loop to know if delete_name is exit in the recored or not... 
                        {
                            if (Name[i].ToLower() == DeleteName)
                            {
                                IndexName = i;
                                for (int j = IndexName + 1; j < StudentCounter - 1; j++)
                                {
                                    Name[j] = Name[j - 1];
                                    Mark[j] = Mark[j - 1];
                                    Age[j] = Age[j - 1];
                                    Date[j] = Date[j - 1];
                                }
                                StudentCounter--;

                                Console.WriteLine("Student record deleted successfully.");
                            }
                            else
                            {
                                Console.WriteLine("Student not found.");
                            }
                        }
                        //loop to remove delete_name from the recored and shift all elements to the left after delete_name ... 
                        for (int i = 0; i < StudentCounter; i++)
                        {
                            Console.WriteLine($"Name: {Name[i]}");
                            Console.WriteLine($"Mark: {Mark[i]}");
                            Console.WriteLine($"Age: {Age[i]}");
                            Console.WriteLine($"Date of Enrollment: {Date[i]:yyyy-MM-dd HH:mm:ss}\n");
                        }

                        Console.WriteLine("Do you want to delete anther student? y / n");
                        choice = Console.ReadKey().KeyChar;

                    } while (choice == 'y' || choice == 'Y');
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input format. Please enter a number.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }
    }


    


