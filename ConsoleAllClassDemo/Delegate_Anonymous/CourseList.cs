namespace Delegate_Anonymous
{
    internal class CourseList
    {
        List<Course> courses = new List<Course>();

        public CourseList()
        {
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
        public void InitData()
        {

            courses.Add(new Course(4, "PRN", new DateTime(2023, 10, 10)));
            courses.Add(new Course(7, "PRO", new DateTime(2023, 8, 7)));
            courses.Add(new Course(3, "PRJ", new DateTime(2023, 6, 9)));
            courses.Add(new Course(5, "OSG", new DateTime(2023, 5, 31)));
        }

        public int CompareById(Course x, Course y)
        {
            return x.Id.CompareTo(y.Id);
        }
        //Khi viết hàm mà chỉ dùng 1 lần thì để tránh rườm rà thì ta 
        //có 1 cơ chế là Anonymous function
        //Chỉ quan tâm đến nội dung của hàm
        //không quan tâm tên hàm
        public int CompareByTitle(Course x, Course y)
        {
            return x.Title.CompareTo(y.Title);
        }
        public void SortByTitle()
        {
            courses.Sort(CompareByTitle);
        }
        public void SortById()
        {
            courses.Sort(CompareById);
        }
        //Anonymous function
        //Vẫn rườm rà--> Lamda Expression
        public void SortByStartDate()
        {
            //courses.Sort(
            //    delegate (Course x, Course y){
            //        return x.StartDate.CompareTo(y.StartDate);
            //}
            //    );

            //Lamda Expression để viết ngắn gọn lại Anonymous
            //Quy tắc:1. kiểu dữ liệu truyền vào ko cần viết vì hàm Sort đã biết nó gọi Comparison
            //nên nó đã biết là nhận vào 2 đối tượng T là 2 course rồi
            //2. Nếu hàm ko có đối số thì bỏ luôn cặp đóng mở ngoặc tròn
            //và nếu chỉ có 1 tham số thì bỏ luôn cặp ngoặc tròn tiếp theo
            //3. nếu hàm chỉ có 1 câu lệnh thì cũng ko cần dấu {} thay bằng dấu =>
            //để phân tách giữa tham số truyền vào với công việc cần thực hiện
            //tiếp theo bỏ luôn cả dấu;
            //4.nếu là câu lệnh return thì bỏ luôn return và cả từ khóa delegate
            courses.Sort((x, y) => x.StartDate.CompareTo(y.StartDate));
        }
    }
}
