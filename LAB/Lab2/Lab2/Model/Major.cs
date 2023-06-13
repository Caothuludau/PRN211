using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Model
{
    internal class Major
    {
        public string? MajorCode { get; set; }
        public string? MajorTitle { get; set; }

        public Major(string? majorCode, string? majorTitle)
        {
            MajorCode = majorCode;
            MajorTitle = majorTitle;
        }

        public Major()
        {
            
        }
    }
}
