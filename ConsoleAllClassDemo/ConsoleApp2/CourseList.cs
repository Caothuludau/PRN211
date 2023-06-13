namespace ConsoleApp2
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
                Console.WriteLine("Nhap vao Course (C) hoac OnlineCourse (O) hoac Stop (S)");
                string chr = Console.ReadLine();
                if (chr.ToUpper().Equals("S")) break;
                Course c;
                if (chr.ToUpper().Equals("C")) c = new Course();
                else c = new OnlineCourse();
                c.Input();
                courses.Add(c);
            }
        }
        public void DisplayListOfCourse()
        {
            Console.WriteLine("List of course:");
            foreach (Course c in courses)
                Console.WriteLine(c.ToString());
        }

        public void Search(DateTime startDate, DateTime endDate)
        {
            Console.WriteLine("Danh sach course tim duoc la:");
            foreach (Course c in courses)
            {
                if (c.StartDate >= startDate && c.StartDate <= endDate)
                    Console.WriteLine(c);
            }
        }
        public void SearchByStartDate()
        {
            Console.WriteLine("Nhap vao startDate:");
            DateTime startDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Nhap vao endDate:");
            DateTime endDate = Convert.ToDateTime(Console.ReadLine());
            Search(startDate, endDate);
        }
        public void InitData()
        {
            courses.Add(new Course(2, "PRN", new DateTime(2011, 1, 1)));
            courses.Add(new Course(3, "PRO", new DateTime(2011, 1, 1)));
            courses.Add(new Course(1, "CSD", new DateTime(2011, 1, 1)));
            courses.Add(new Course(5, "OSG", new DateTime(2011, 1, 1)));

        }
        
    }
}
