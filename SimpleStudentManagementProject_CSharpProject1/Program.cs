using System.Reflection.Metadata;
using System.Xml.Linq;

namespace SimpleStudentManagementProject_CSharpProject1
{
    internal class Student 
    {
        // Create the array and add the required variables...
        static double[] Mark= new double[5];
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

        //2. View all students_______
        static void ViewStudents()
        {
//            Student[] students = new Student[StudentCounter];

//        new Student { Name = "Zahra", Age = 20, Mark = 85.5, Date = DateTime.Now
//    };
//    new Student { Name = "Sara", Age = 17, Mark = 90.0, Date = DateTime.Now
//};
//new Student { Name = "Saif", Age = 21, Mark = 78.3, Date = DateTime.Now };
//new Student { Name = "Ali", Age = 18, Mark = 88.2, Date = DateTime.Now };
//new Student { Name = "Sami", Age = 19, Mark = 92.7, Date = DateTime.Now };


//// Display all stored students
//Console.WriteLine("List of Students:");
//foreach (Student student in students)
//{
//    Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Mark: {student.Mark}, Entry Time: {student.EntryTime}");
//}
        }


        //3. Find a student by name________
        static void FindaStudentByName()
        {
            char choice;
            do
            {
                string search_name;
                
                int flag = 0;
                Console.WriteLine("Enter student Name:");
                search_name = Console.ReadLine().ToLower();

                for (int i = 0; i < StudentCounter; i++)
                {
                    
                    if (Name[i].ToLower() == search_name)
                    {
                        Console.WriteLine("Student Information: \nName | Age | Mark | Enrollment date\n");
                        Console.WriteLine($"{Name[i]} | {Age[i]} | {Mark[i]} | {Date[i]}");
                        flag = 1;
                    }
                }
                if (flag == 0)
                {
                    Console.WriteLine("Not found");
                }

                Console.WriteLine("Do you want to search for anther student? Yes / No");
                choice = Console.ReadKey().KeyChar;

            } while (choice == 'y' || choice == 'Y');

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
