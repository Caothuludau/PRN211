using Delegate_Anonymous_Ex;
using Excerse_01;

internal class Program
{
    private static void Main(string[] args)
    {
        //DemoDelagate();
        //DelegateMultiCast();

        DemoUsingComparision();
    }
    public static int Add(int x, int y)
    {
        Console.WriteLine("Add function:");
        return x + y;
    }
    public static int Sub(int x, int y)
    {
        Console.WriteLine("Sub function:");
        return x - y;
    }

    //Nếu chỉ biết có 1 ham có 2 tham so int
    //Thuc hien phep tinh nao thi chua biet
    public static void Caculate(int x, int y, Caculation delobj)
    {
        delobj(x, y);//Noi quyet dinh goi ham
    }
    public static void DemoDelagate()
    {
        Caculation delegateobj;//khai bao 1 bien delegate
        delegateobj = new Caculation(Add);//khoi tao delegate, them loi goi ham Add
        Console.WriteLine("Output:" + delegateobj(6, 9));
        delegateobj = Sub;
        //delegateobj = new Caculation(Sub);
        Console.WriteLine("Output:" + delegateobj(6, 9));

        Caculate(20, 25, Sub);//Noi quyet dinh ham nao duoc goi
    }

    //Mot tinh chat khac cua delegate
    public static void DelegateMultiCast()
    {
        Caculation delegateobj = Add;//them ham Add vao loi goi ham
        delegateobj += Sub;//Them ham Sub
        delegateobj += Add;
        Console.WriteLine("Output: " + delegateobj(9, 6));

        delegateobj -= Add;
        delegateobj -= Add;
        delegateobj -= Add;
        delegateobj -= Sub;

        //Console.WriteLine("After remove: " + delegateobj(9, 6));//Loi run time vi delegate khong tro vao ham nao
    }

    public static void DemoUsingComparision()
    {
        CourseList courseList = new CourseList();
        courseList.InitData();
        Console.WriteLine("Sort by Id:");
        courseList.SortById();
        courseList.DisplayListOfCourse();

        Console.WriteLine("Sort by Title:");
        courseList.SortByTitle();
        courseList.DisplayListOfCourse();

        Console.WriteLine("Sort by StartDate:");
        courseList.SortByStartDate();
        courseList.DisplayListOfCourse();
    }
}

