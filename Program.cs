﻿namespace SimpleStudentManagementProject_CSharpProject1
{
    internal class Progra
    {
        static double[] studentMarks = new double[10];
        static string[] studentNames = new string[10];
        static int studentCount = 0;
        static int[] age = new int[10];
        static DateTime[] dates  = new DateTime[10];


        static void AddStudent()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter Student Name: ");
                studentNames[i] = Console.ReadLine().ToLower();
                Console.WriteLine("Enter Student Marks: ");
                studentMarks[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Student Age: ");
                age[i] = int.Parse(Console.ReadLine());
                if (age[i] < 21)
                {
                    Console.WriteLine("Student Age should be greater than 18");
                    break;
                }
                dates[i] = DateTime.Now;
                studentCount++;
                if (i > studentCount) {
                    Console.WriteLine("out of range");
                    break;
                
                }
                Console.WriteLine("Student Added Successfully");
                Console.WriteLine("Do you want to add more students? (yes/no)");
                string choice = Console.ReadLine();
                if (choice == "no")
                {
                    break;
                }
            }
        }

        static void ViewStudents()
        {
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("Student Name: " + studentNames[i]);
                Console.WriteLine("Student Marks: " + studentMarks[i]);
                Console.WriteLine("Student Age: " + age[i]);
                Console.WriteLine("Date: " + dates[i]);
            }
        } 
        static void FindStudent()
        {
            Console.WriteLine("Enter Student Name: ");
            string name = Console.ReadLine().ToLower();
            for (int i = 0; i < studentCount; i++)
            {
                if (studentNames[i] == name)
                {
                    Console.WriteLine("Student Name: " + studentNames[i]);
                    Console.WriteLine("Student Marks: " + studentMarks[i]);
                    Console.WriteLine("Student Age: " + age[i]);
                    Console.WriteLine("Date: " + dates[i]);
                }
            }
        }
        static void getaverage()
        {
            double sum = 0;
            for (int i = 0; i < studentCount; i++)
            {
                sum += studentMarks[i];
            }
            double average = sum / studentCount;
            Console.WriteLine("Average Marks: " + Math.Round(average,2));
        }

        static void getmax()
        {
            double max = studentMarks[0];
            string name = studentNames[0];
            for (int i = 0; i < studentCount; i++)
            {
                if (studentMarks[i] > max)
                {
                    max = studentMarks[i];
                    name = studentNames[i];

                }
            }
            Console.WriteLine("Maximum Marks: " + max+" and he is : "+name);
        }

        static void studentSort()
        {
            for (int i = 0; i < studentCount; i++)
            {
                for (int j = i + 1; j < studentCount; j++)
                {
                    if (studentMarks[i] > studentMarks[j])
                    {
                        double temp = studentMarks[i];
                        studentMarks[i] = studentMarks[j];
                        studentMarks[j] = temp;
                        string tempName = studentNames[i];
                        studentNames[i] = studentNames[j];
                        studentNames[j] = tempName;
                        int tempAge = age[i];
                        age[i] = age[j];
                        age[j] = tempAge;
                        DateTime tempDate = dates[i];
                        dates[i] = dates[j];
                        dates[j] = tempDate;
                    }
                }
            }
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("Student Name: " + studentNames[i]);
                Console.WriteLine("Student Marks: " + studentMarks[i]);
                Console.WriteLine("Student Age: " + age[i]);
                Console.WriteLine("Date: " + dates[i]);
            }


            
        }



        static void deleteStudentandshift() {
            for(int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("Student Name: " + studentNames[i]);
                Console.WriteLine("Student Marks: " + studentMarks[i]);
                Console.WriteLine("Student Age: " + age[i]);
                Console.WriteLine("Date: " + dates[i]);
            }
            Console.WriteLine("Enter Student Name to delete: ");
            string name = Console.ReadLine().ToLower();
            for (int i = 0; i < studentCount; i++)
            {
                if (studentNames[i] == name)
                {
                    for (int j = i; j < studentCount - 1; j++)
                    {
                        studentNames[j] = studentNames[j + 1];
                        studentMarks[j] = studentMarks[j + 1];
                        age[j] = age[j + 1];
                        dates[j] = dates[j + 1];
                    }
                    studentCount--;
                    Console.WriteLine("Student Deleted Successfully");
                    break;
                }
            }
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("Student Name: " + studentNames[i]);
                Console.WriteLine("Student Marks: " + studentMarks[i]);
                Console.WriteLine("Student Age: " + age[i]);
                Console.WriteLine("Date: " + dates[i]);
                Console.WriteLine("-----------------------------------");
            }






        }


        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. View Students");
                Console.WriteLine("3. Find Student");
                Console.WriteLine("4. Get Average Marks");
                Console.WriteLine("5. Get Maximum Marks");
                Console.WriteLine("6. Sort Students");
                Console.WriteLine("7. Delete Student");
                Console.WriteLine("8. Exit");
                Console.WriteLine("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());


                switch (choice)
                {

                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        ViewStudents();
                        break;
                    case 3:
                        FindStudent();
                        break;
                    case 4:
                        getaverage();
                        break;
                    case 5:
                        getmax();
                        break;
                    case 6:
                        studentSort();
                        break;
                    case 7:
                        deleteStudentandshift();
                        break;
                    case 8:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadLine();

            }




            }
    }
}
