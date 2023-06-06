using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_1
{
    internal class Course
    {
        public int id { get; set; }
        public DateTime ngayBD { get; set; }
        public string title { get; set; }
        public Course()
        {
            title = "NoTitle";
        }


        public virtual void Input()
        {
            Validation val = new Validation();
            id = val.GetInt("Enter course ID: ", 0, 9999);
            ngayBD = val.GetDateTime("Enter start date (dd-MM-yyyy): ");
            title = val.GetStringNotNull("Enter title: ");
        }

        public override string? ToString()
        {
            return $"Course\t ID: {id}\t NgayBD: {ngayBD}\t Title: {title}";
        }
    }
}