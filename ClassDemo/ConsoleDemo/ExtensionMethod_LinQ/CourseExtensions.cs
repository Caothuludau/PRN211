using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod_LinQ
{
    static class CourseExtensions
    {
        public static void Display(this Course course, int count = 1 )
        {
            Console.WriteLine($"Course's info ({count}) times:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(course);
            }
        }
    }
}
