using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod_LinQ
{
    //Phải là lớp static
    static class ListExtensions
    {
       // phải chưa các hàm static
       public static void Display(this List<Course> course)
        {
            Console.WriteLine("List of Course:");
            foreach (Course c in course) Console.WriteLine(c);
        }
    }
}
