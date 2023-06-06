using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exer_1;
internal class Run
{
    private static void Main(string[] args)
    {
        Menu menu = new Menu();
        CourseManager cm = new CourseManager();
        List<Course> courses = new List<Course>();

        // Adding a new Course
        Course course1 = new Course
        {
            id = 0001,
            ngayBD = DateTime.Now.AddDays(2),
            title = "AIntroduction to Programming"
        };

        courses.Add(course1);

        // Adding a new OnlineCourse
        OnlineCourse onlineCourse1 = new OnlineCourse
        {
            id = 0002,
            ngayBD = DateTime.Now,
            title = "BWeb Development Basics",
            meet = "https://example.com/meeting"
        };

        courses.Add(onlineCourse1);

        int selection = 0;
        while (selection != 5)
        {
            selection = menu.ShowMenu();
            cm.Feature(selection, courses);
        }
        
    }

    
}