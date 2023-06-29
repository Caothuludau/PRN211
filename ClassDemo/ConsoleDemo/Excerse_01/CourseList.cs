using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excerse_01
{
    internal class CourseList
    {
        List<Course> courses = new List<Course>();

        public CourseList()
        {
        }

        public void InputListOfCourse()
        {
            while (true)
            {
                Console.WriteLine("Nhap vao Course (C)? hay OnlineCourse (OC)? hay Stop (S)?");
                string type = Console.ReadLine();
                if (type.ToUpper().Equals("S")) break;
                Course c;
                if (type.ToUpper().Equals("C")) c = new Course();
                else c = new OnlineCourse();
                c.Input();
                courses.Add(c);
            }
                    }
        public void DisplayListOfCourse() {
            Console.WriteLine("List of course:");
            foreach (Course c in courses)
            {
                //Console.WriteLine(c.ToString());
                Console.WriteLine(c);
            }
        }
        public void Search(DateTime startDate, DateTime enDate)
        {
            Console.WriteLine("Danh sach Course tim duoc:");
            foreach (Course c in courses)
            {
                if(c.StartDate>= startDate && c.StartDate<= enDate)
                    Console.WriteLine(c);
            }
        }
        public void SearchByStartDate()
        {
            //Console.WriteLine("Nhap vao ngay bat dau:");
            //DateTime startDate = Convert.ToDateTime(Console.ReadLine());
            DateTime startDate = Valid.GetDateTime(new DateTime(2020, 1, 1),
                                            new DateTime(2023, 12, 31),
                                            "dd-MM-yyyy", "Nhap vao StartDate:");

            //Console.WriteLine("Nhap vao ngay ket thuc:");
            //DateTime endDate = Convert.ToDateTime(Console.ReadLine());
            DateTime endDate = Valid.GetDateTime(new DateTime(2020, 1, 1),
                                            new DateTime(2023, 12, 31),
                                            "dd-MM-yyyy", "Nhap vao endDate:");
            Search(startDate, endDate);
        }

        public void ReadFromFile(string filename)
        {
            courses.Clear();
            StreamReader reader = new StreamReader(filename);//đọc từng dòng
            string line;
            while ((line = reader.ReadLine())!=null)
            {
                //kiem tra dong hien tai la course hay onlinecourse
                Course c;
                if (line[0] == 'C') c= new Course();
                else c= new OnlineCourse();
                //dua du lieu tren line vao course, thao tac tren 1 course nen sang thuc hien o class course va onlinecourse

                c.ReadFromLine(line);
                courses.Add(c);

            }
            reader.Close();
        }
        public void InitData()
        {

            courses.Add(new Course(1, "PRN", new DateTime(2023, 10, 10)));
            courses.Add(new Course(2, "PRO", new DateTime(2023, 8, 7)));
            courses.Add(new Course(3, "PRJ", new DateTime(2023, 6, 9)));
            courses.Add(new Course(4, "OSG", new DateTime(2023, 5, 31)));
            courses.Add(new OnlineCourse(5, "CSD", new DateTime(2023, 1, 17), "http:\\home\\hjdhj"));
        }
        public void Sort()
        {
            courses.Sort();
        }
        public void SortById()
        {
            courses.Sort(new IdComparers());
        }
        public void SortByStartDate()
        {
            courses.Sort(new StartDateComparers());
        }
    }
}
