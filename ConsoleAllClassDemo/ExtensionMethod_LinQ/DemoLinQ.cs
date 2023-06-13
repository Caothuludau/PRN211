namespace ExtensionMethod_LinQ
{
    internal class DemoLinQ
    {
        List<Course> courses;
        public DemoLinQ()
        {
            courses = new List<Course>()
            {
                new Course(1, "PRN211", new DateTime(2023, 1, 1)),
                new Course(2, "PRO192", new DateTime(2022, 8, 6)),
                new Course(3, "PRF192", new DateTime(2022, 1, 14)),
                new Course(4, "CSD202", new DateTime(2021, 1, 1)),
                new Course(5, "DBI202", new DateTime(2023, 12, 1)),
                new Course(6, "OSG202", new DateTime(2021, 1, 3)),
                new Course(7, "PRU223", new DateTime(2023, 5, 1)),
                new Course(8, "CSI104", new DateTime(2023, 1, 9)),
                new Course(9, "CSI105", new DateTime(2022, 1, 31)),
            };

        }
        public List<Course> GetAllCourse()
        {
            return courses;
        }
        public Course GetCourseByIDUsingMethod(int ID)
        {
            //Firt chứa 2 tham số, tham số đầu tiên là Course, tham số thứ 2 là
            //hàm được chọn theo điều kiện nào (bản ghi đầu tiên thỏa mãm điều kiện)
            return courses.First(x => x.Id == ID);
        }

        //demo hien thi danh sach cac course có ten giong voi pattern
        //Chon course thoa man dk dung where
        public List<Course> GetCourseByTitleUsingMethod(string pattern)
        {
            return courses.Where(x => x.Title.Contains(pattern)).ToList();
            //Ham nay tra ve mot Enumerable, muon tra ve 1 list thi dung ToList()
        }

        //Vi moi item du lieu chi co 2 thuoc tinh nen chua co kieu du lieu
        //vay ham tra ve void, hien thi trong ham
        public void GetCourseByDateUsingMethod(DateTime start, DateTime end)
        {
            var result = courses.Where(x => x.StartDate >= start && x.StartDate <= end)
                .Select(x => (x.Title, x.StartDate));
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Title} - {item.StartDate}");
            }
        }
        public Course GetCourseByIDUsingQuery(int ID)
        {
            return (from c in courses
                   where c.Id ==ID
                   select c).First();
        }

        public List<Course> GetCourseByTitleUsingQuery(string pattern)
        {
            return (from c in courses
                    where c.Title.Contains(pattern)
                    select c).ToList();
        }

        public void GetCourseByDateUsingQuery(DateTime start, DateTime end)
        {
            var result = (
                from c in courses
                where c.StartDate >= start && c.StartDate <= end
                //select (c.Title, c.StartDate)

                select new
                {
                    TitleName = c.Title,
                    Date = c.StartDate
                }//anonymous constructor
                );

            foreach (var item in result)
            {
                Console.WriteLine($"{item.TitleName} - {item.Date}");
            }
        }
    }
}
