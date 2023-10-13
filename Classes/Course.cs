using System;
using System.Collections.Generic;

namespace StudentManagement
{
    public class Course
    {
        public string CourseName {get; set;}
        public string CourseCode {get; set;}
        public int Credits {get;set;}

        public List<string> courseLists = new List<string>
        {
            "English",
            "Math",
            "Uzbek",
            "Russian",
            "Geometry",
            "Geography",
            "Chemestry",
            "Physics",
            "History"
        };

        public Course()
        {
            for (int i = 0; i < courseLists.Count; i++)
            {
                Console.WriteLine($"{i+1}. {courseLists[i]}");
            }
        }

        public Course(string courseName, string courseCode, int credits)
        {
            CourseName = courseName;
            CourseCode = courseCode;
            Credits = credits;
        }
    }
}