using System;
using System.Collections.Generic;
using System.Text;

namespace StudentClass
{
    class Group
    {
        public int No { get; set; }
        public int Limit { get; set; }
        public Student[] Students = { };



        public void AddStudent(Student student)
        {
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;

        }





    }
}
