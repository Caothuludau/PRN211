namespace Excerse_01
{
    internal class Course
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
       
        public int CompareTo(Course other)
        {
            return this.Title.CompareTo(other.Title);
        }

    }
    
    }

