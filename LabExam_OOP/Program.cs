using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabExam_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Course> courses = new List<Course>();
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("=== Menu ===");
                Console.WriteLine("1. Open new course");
                Console.WriteLine("2. Add student");
                Console.WriteLine("3. Display course report");
                Console.WriteLine("4. Exit");
                Console.Write("Choose (1-4): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter Course ID: ");
                        string cId = Console.ReadLine();
                        Console.Write("Enter Course Name: ");
                        string cName = Console.ReadLine();
                        Console.Write("Enter Teacher Name: ");
                        string tName = Console.ReadLine();

                        Teacher teacher = new Teacher(tName);
                        Course newCourse = new Course(cId, cName, teacher);
                        courses.Add(newCourse);

                        Console.WriteLine(">> Course opened!\n");
                        break;

                    case "2":
                        if (courses.Count == 0)
                        {
                            Console.WriteLine(">> Please open a course first!\n");
                            break;
                        }

                        Course selectedCourseForAdd = courses[0];
                        if (courses.Count > 1)
                        {
                            Console.Write("Enter Course ID to add student: ");
                            string searchId = Console.ReadLine();
                            selectedCourseForAdd = courses.Find(c => c.CourseId == searchId) ?? courses[0];
                        }

                        Console.Write("Enter Student ID: ");
                        string sId = Console.ReadLine();
                        Console.Write("Enter Student Name: ");
                        string sName = Console.ReadLine();
                        Console.Write("Enter Score (0-100): ");

                        if (double.TryParse(Console.ReadLine(), out double score))
                        {
                            Student newStudent = new Student(sName, sId, score);
                            selectedCourseForAdd.AddStudent(newStudent);
                        }
                        break;

                    case "3":
                        if (courses.Count == 0)
                        {
                            Console.WriteLine(">> Please open a course first!\n");
                            break;
                        }

                        Course selectedCourseForReport = courses[0];
                        if (courses.Count > 1)
                        {
                            Console.Write("Enter Course ID to view report: ");
                            string searchId = Console.ReadLine();
                            selectedCourseForReport = courses.Find(c => c.CourseId == searchId) ?? courses[0];
                        }

                        selectedCourseForReport.DisplayCourseReport();
                        break;

                    case "4":
                        isRunning = false;
                        Console.WriteLine(">> Exited.");
                        break;

                    default:
                        Console.WriteLine(">> Invalid choice.\n");
                        break;
                }
            }
        }
    }
}