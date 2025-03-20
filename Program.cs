namespace SimpleStudentManagementProject_CSharpProject1
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
                dates[i] = DateTime.Now;
                studentCount++;
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
        


        static void deleteStudent() { 


        static void Main(string[] args)
        {
         AddStudent();
         ViewStudents();

        }
    }
}
