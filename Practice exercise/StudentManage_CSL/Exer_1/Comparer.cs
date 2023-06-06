using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_1
{
    internal class TitleComparer : IComparer<Course>
    {
        public int Compare(Course? x, Course? y)
        {
            return string.Compare(x.title, y.title, StringComparison.OrdinalIgnoreCase);
        }
    }
    internal class IDComparer : IComparer<Course>
    {
        public int Compare(Course? x, Course? y)
        {
            return x.id - y.id;
        }
    }
    internal class StartDateComparer : IComparer<Course>
    {
        public int Compare(Course? x, Course? y)
        {
            return DateTime.Compare(x.ngayBD, y.ngayBD);
        }
    }

}
