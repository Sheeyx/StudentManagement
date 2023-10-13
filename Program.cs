using System;
using System.Runtime.InteropServices;

namespace StudentManagement
{
    class Program
    {
        static void Main()
        {
            Student student1 = new Student(1801222,"John");
            Course math1 = new Course("Math","CS17",3);
            student1.EnrolInCourse(math1);
            student1.DisplayEnrolledCourse();
            Console.WriteLine(student1.StudentId);
        }
    }
}
