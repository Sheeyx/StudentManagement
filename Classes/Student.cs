﻿using System;
using System.Collections.Generic;

namespace StudentManagement
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public List<Course> CoursesEnrolled { get; set; }


        

        public Student(int studentId, string name)
        {
            Name = name;
            StudentId = studentId;
            CoursesEnrolled = new List<Course>();
        }

        public void EnrolInCourse(Course course)
        {
            CoursesEnrolled.Add(course);
        }
        public void DropCourse(Course course)
        {
            CoursesEnrolled.Remove(course);
        }
        public void DisplayEnrolledCourse()
        {
            Console.WriteLine("Here are enrolled courses: ");

            foreach (var course in CoursesEnrolled)
            {
                Console.WriteLine(course.CourseName);
            }
        }
    }
}
