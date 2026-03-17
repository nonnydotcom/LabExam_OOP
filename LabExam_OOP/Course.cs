using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabExam_OOP
{
    public class Course
    {
        private string courseId;
        private string courseName;
        private Teacher courseTeacher;
        private List<Student> students;

        public string CourseId { get { return courseId; } }
        public string CourseName { get { return courseName; } }

        public Course(string courseId, string courseName, Teacher teacher)
        {
            this.courseId = courseId;
            this.courseName = courseName;
            this.courseTeacher = teacher;
            this.students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
            Console.WriteLine(">> Student added!\n");
        }

        public void DisplayCourseReport()
        {
            Console.WriteLine($"\n=== Course Report: {CourseId} {CourseName} ===");
            courseTeacher.DisplayInfo();

            if (students.Count == 0)
            {
                Console.WriteLine("No students in this course.\n");
                return;
            }

            Console.WriteLine("--- Student List ---");

            double totalScore = 0;
            double maxScore = double.MinValue;
            double minScore = double.MaxValue;

            foreach (Student s in students)
            {
                s.DisplayInfo();

                totalScore += s.Score;
                if (s.Score > maxScore) maxScore = s.Score;
                if (s.Score < minScore) minScore = s.Score;
            }

            double averageScore = totalScore / students.Count;

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Highest Score: {maxScore}");
            Console.WriteLine($"Lowest Score:  {minScore}");
            Console.WriteLine($"Average Score: {averageScore:F2}");
            Console.WriteLine("==================================================\n");
        }
    }
}