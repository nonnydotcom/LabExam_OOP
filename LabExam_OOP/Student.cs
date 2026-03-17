using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LabExam_OOP
{
    public class Student : User
    {
        private string studentId;
        private double score;
        private string grade;

        public string StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }

        public double Score
        {
            get { return score; }
            set { score = value; }
        }

        public string Grade
        {
            get { return grade; }
            private set { grade = value; }
        }

        public Student(string name, string studentId, double score) : base(name)
        {
            this.StudentId = studentId;
            this.Score = score;
            CalculateGrade();
        }

        private void CalculateGrade()
        {
            if (Score >= 80) Grade = "A";
            else if (Score >= 75) Grade = "B+";
            else if (Score >= 70) Grade = "B";
            else if (Score >= 65) Grade = "C+";
            else if (Score >= 60) Grade = "C";
            else if (Score >= 55) Grade = "D+";
            else if (Score >= 50) Grade = "D";
            else Grade = "F";
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"[Student] ID: {StudentId} | Name: {Name} | Score: {Score} | Grade: {Grade}");
        }
    }
}