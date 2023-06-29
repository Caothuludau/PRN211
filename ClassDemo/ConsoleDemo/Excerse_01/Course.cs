namespace Excerse_01
{
    internal class Course : IComparable<Course>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }

        public Course()
        {
        }

        public Course(int id, string title, DateTime startDate)
        {
            Id = id;
            Title = title;
            StartDate = startDate;
        }

        public override string ToString()
        {
            //return $"{Id} - {Title} - {StartDate}";
            return $"{Id} - {Title} - {StartDate.ToString("dd-MM-yyyy")}";
        }
        public virtual void Input()
        {
            Console.WriteLine("Nhap thong tin course:");
            Id = Valid.GetInteger(0, 20000, "Nhap vao Id:");

            Title = Valid.GetString(1, 200, "Nhap vao Title:");

            StartDate = Valid.GetDateTime(new DateTime(2020, 1, 1),
                                            new DateTime(2023, 12, 31),
                                            "dd-mm-yyyy", "Nhap vao StartDate:");
        }
        public virtual void ReadFromLine(string line)//line co format C|Id|Title|StartDate
        {
            
            string[] items = line.Split("|");
        
                Id = Convert.ToInt32(items[1]);
                Title = items[2];
                StartDate = Convert.ToDateTime(items[3]);      

        }
        public int CompareTo(Course other)
        {
            return this.Title.CompareTo(other.Title);
        }

    }
    class OnlineCourse : Course
    {
        public string Meet { get; set; }

        public OnlineCourse()
        {
        }

        public OnlineCourse(int id, string title, DateTime startDate, string meet) : base(id, title, startDate)
        {
            Meet = meet;
        }

        public override string ToString()
        {
            return base.ToString() + $" - {Meet}";
        }
        public override void Input()
        {
            base.Input();
            //Console.WriteLine("Nhap link meet:");
            //Meet = Console.ReadLine();
            Meet = Valid.GetString(1, 200, "Nhap vao Meet:");
        }
        public override void ReadFromLine(string line)//line co format OC|Id|Title|StartDate|meet
        {
            int lastLine = line.IndexOf('|');
            base.ReadFromLine(line.Substring(0,lastLine));
            Meet = line.Substring(lastLine + 1);
        }
    }
}
