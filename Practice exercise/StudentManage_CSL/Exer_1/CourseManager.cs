using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_1
{
    internal class CourseManager
    {
        public void Feature(int selection, List<Course> courses)
        {
            Validation val = new Validation();
            switch (selection)
            {
                case 1:
                    while (true)
                    {
                        Console.WriteLine("Enter \"C\" to create new Course or \"OC\" to create new OnlineCourse (\"E\" to exit)");
                        string? courseSelection = Console.ReadLine();
                        //Convert 
                        if (string.Equals(courseSelection, "C", StringComparison.OrdinalIgnoreCase))
                        {
                            Course crs = new Course();
                            crs.Input();
                            Console.WriteLine(crs.ToString());
                            courses.Add(crs);
                        }
                        if (string.Equals(courseSelection, "OC", StringComparison.OrdinalIgnoreCase))
                        {
                            OnlineCourse crs = new OnlineCourse();
                            crs.Input();
                            Console.WriteLine(crs.ToString());
                            courses.Add(crs);
                        }
                        if (string.Equals(courseSelection, "E", StringComparison.OrdinalIgnoreCase))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter \"C\" or \"OC\"");
                        }
                    }
                    break;
                case 2:
                    this.DisplayCourse(courses);
                    break;

                case 3:
                    DateTime upperTimeBound = DateTime.Now;
                    DateTime lowerTimeBound = DateTime.Now;
                    string input;
                    bool exit = false;
                    while (!exit)
                    {
                        input = val.GetStringNotNull("Input Upper Time Bound ('E' to exit)");
                        if (string.Equals(input, "E", StringComparison.OrdinalIgnoreCase))
                        {
                            exit = true;
                        }
                        else
                        {
                            if (val.CheckDateTime(input))
                            {
                                upperTimeBound = DateTime.ParseExact(input, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                                break;
                            }
                        }
                    }

                    while (!exit)
                    {
                        input = val.GetStringNotNull("Input Lower Time Bound ('E' to exit)");
                        if (string.Equals(input, "E", StringComparison.OrdinalIgnoreCase))
                        {
                            exit = true;
                        }
                        else
                        {
                            if (val.CheckDateTime(input))
                            {
                                lowerTimeBound = DateTime.ParseExact(input, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                                break;
                            }
                        }
                    }

                    if (!exit)
                    {
                        List<Course> subCourses = courses.Where(course => course.ngayBD >= lowerTimeBound
                                                                 && course.ngayBD <= upperTimeBound)
                                                         .ToList<Course>();
                        this.DisplayCourse(subCourses);
                    }
                    break;

                case 4:
                    int choice = val.GetInt("How do you want to sort?"
                            + "\n 1. Sort courses by title"
                            + "\n 2. Sort courses by ID"
                            + "\n 3. Sort courses by Start Day", 1, 3);
                    if (choice == 1)
                    {
                        TitleComparer titleComparer = new TitleComparer();
                        courses.Sort(titleComparer);
                    }
                    else if (choice == 2)
                    {
                        IDComparer idComparer = new IDComparer();
                        courses.Sort(idComparer);
                    }
                    else if (choice == 3)
                    {
                        StartDateComparer startDateComparer = new StartDateComparer();
                        courses.Sort(startDateComparer);
                    }
                    this.DisplayCourse(courses);
                    break;
            }
        }

        public void DisplayCourse(List<Course> courses)
        {
            // Output table headers
            Console.WriteLine("{0,-12} {1,-12} {2,-40} {3,-20}", "Course Type", "StartDate", "Title", "Meet");

            // Output table rows
            foreach (Course course in courses)
            {
                //'is' operator is used to check if the course object is an instance of OnlineCourse.
                //If it is, it's cast to OnlineCourse and assigned to the onlineCourse 
                if (course is OnlineCourse onlineCourse)
                {
                    Console.WriteLine("{0,-12} {1,-12} {2,-40} {3,-20}", "OC" + course.id, course.ngayBD.ToShortDateString(), course.title, onlineCourse.meet);
                }
                else
                {
                    Console.WriteLine("{0,-12} {1,-12} {2,-40} {3,-20}", "NC" + course.id, course.ngayBD.ToShortDateString(), course.title, "None");
                }
            }
        }
    }
}
