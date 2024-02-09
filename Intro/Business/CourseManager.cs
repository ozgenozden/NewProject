using System;
using Intro.Entities;

namespace Intro.Business;

public class CourseManager
{
    Course[] courses = new Course[3];
    public CourseManager()
	{

        Course course1 = new Course();
        course1.Id = 1;
        course1.Name = "JAVA";
        course1.Description = "Java 17.1";
        course1.Price = 5345;

        Course course2 = new Course();
        course2.Id = 1;
        course2.Name = "C#";
        course2.Description = "C# 8.0";
        course2.Price = 4000;

        Course course3 = new Course();
        course3.Id = 1;
        course3.Name = "Phyton";
        course3.Description = "Phyton 2.1";
        course3.Price = 2000;

        courses[0] = course1;
        courses[1] = course2;
        courses[2] = course3;



    }
    public Course[] GetAll()
    {
        return courses;
    }
}

