using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_1
{
    internal class OnlineCourse : Course
    {
        public string? meet { get; set; }

        public OnlineCourse()
        {
            
        }

        public override void Input() {
            Validation val = new Validation();
            id = val.GetInt("Enter course ID: ", 0, 9999);
            ngayBD = val.GetDateTime("Enter start date (dd-MM-yyyy): ");
            title = val.GetStringNotNull("Enter title: ");
            meet = val.GetStringNotNull("Enter meet link: ");
        }

        public override string? ToString()
        {
            return $"OnlineCourse\t ID: {id}\t NgayBD: {ngayBD}\t Title: {title}\t Meet: {meet}";
        }
    }
}
