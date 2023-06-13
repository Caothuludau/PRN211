namespace Excerse_01
{
    internal class CourseList
    {
        List<Course> courses = new List<Course>();

        public CourseList()
        {
        }

        public void InitData()
        {
            courses.Add(new Course(1, "PRN", new DateTime(2023, 10, 10)));
            courses.Add(new Course(2, "PRO", new DateTime(2023, 8, 7)));
            courses.Add(new Course(3, "PRJ", new DateTime(2023, 6, 9)));
            courses.Add(new Course(4, "OSG", new DateTime(2023, 5, 31)));
        }

        public void DisplayListOfCourse()
        {
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
                if (c.StartDate >= startDate && c.StartDate <= enDate)
                    Console.WriteLine(c);
            }
        }
        //Khi viet ham ma chi dung 1 lan thi lang phi
        //Dua ra cơ che Anonymous Function
        //Chi quan tam noi sung, khong quan tam ten ham
        public int CompareById(Course x, Course y)
        {
            return x.Id.CompareTo(y.Id);
        }
        public int ComareByTitle(Course x, Course y)
        {
            return x.Title.CompareTo(y.Title);
        }

        public void SortById()
        {
            courses.Sort(CompareById);
        }
        public void SortByTitle()
        {
            courses.Sort(ComareByTitle);
        }
        //Anonymous Function
        //Su dung Lamda Expression de viet ngan gon Anonymous Function
        public void SortByStartDate()
        {
            courses.Sort(
                (x, y) => x.StartDate.CompareTo(y.StartDate));//Lamda Expession
            //Quy tac: 1.kieu du lieu truyen vao khong can viet vi da biet dang goi Comparision
            //Nen da biet nhan vao 2 doi tương T la 2 course
            //2. Neu ham khong co doi so hoac co 1 doi so thi bo qua dau ()
            //3. Neu ham chi co 1 lenh, va la lenh return thi bo cap dau {} thay bang dau =>
            //tiep theo bo luon dau ;
            //4. neu lenh là return thi bo luon chu return, va delegate
        }
    }
}
