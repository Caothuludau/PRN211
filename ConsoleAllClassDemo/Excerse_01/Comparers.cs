namespace Excerse_01
{
    class IdComparers : IComparer<Course>
    {
        public int Compare(Course c1, Course c2)
        {
            return c1.Id.CompareTo(c2.Id);
        }
    }
    class StartDateComparers : IComparer<Course>
    {
        public int Compare(Course c1, Course c2)
        {
            return c1.StartDate.CompareTo(c2.StartDate);
        }
    }
}
