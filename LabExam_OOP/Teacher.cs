using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LabExam_OOP
{
    public class Teacher : User
    {
        public Teacher(string name) : base(name)
        {
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Teacher: {Name}");
        }
    }
}