using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod_LinQ_Ex
{
    static class CourseExtensions
    {
        public static void Display(this Course course, int count)
        {
            Console.WriteLine($"Course'S info {count} times");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(course);
            }
        }
    }
}
