using System;

namespace StudentClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Mahmud", "Mirzazada");

                   

            Group group = new Group();
            group.AddStudent(student);

      
        }


    }
}
