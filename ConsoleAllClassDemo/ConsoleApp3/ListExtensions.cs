using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod_LinQ_Ex
{
    static class ListExtensions
    {
        public static void Display(this List<Course> courses)
        {
            Console.WriteLine("List of course:");
            foreach (Course c in courses) Console.WriteLine(c);
        }
    }
}
