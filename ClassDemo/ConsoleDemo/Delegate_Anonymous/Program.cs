using Delegate_Anonymous;


internal class Program
{
    private static void Main(string[] args)
    {
        //7. gọi hàm
        //DemoBasicDelegate();

        //DemoMulticast();

        DemoUsingComparison();
    }
    //4. viết hàm Add
    public static int Add(int x, int y)
    {
        Console.WriteLine("Add function");
        return x + y;
    }
    //8. viết hàm Sub
    public static int Sub(int x, int y)
    {
        Console.WriteLine("Sub function");
        return x - y;
    }
    //11. Nếu chỉ biết rằng cần thực hiện 1 tính toán nào đấy
    //giữa 1 int x, và int y nhưng chưa biết là tính toán gì
    public static void Caculate(int x, int y, Caculation delobj)
    {
        delobj(x,y);//Nơi quyết định gọi hàm
    }
    //1. tạo hàm DemoBasicDelegate()
    public static void DemoBasicDelegate()
    {

        Caculation delegateobj;//2. Khai báo 1 biến kiểu Caculation
        delegateobj = new Caculation(Add);//3.khởi tạo delegate cần khai báo thêm hàm nhận vào 2 biến int
        Console.WriteLine("Output:" + delegateobj(9, 6));//5. Lời gọi hàm Add(9,6)
        //10. delegateobj = Sub
        delegateobj = new Caculation(Sub);//9. Đây là cách gọi thân quen với cách viết object
        Console.WriteLine("Output:" + delegateobj(9, 6));//Lời gọi hàm Sub

        //12. ý nghĩa của delegate là phân tách
        Caculate(20,25,Add);//Nơi quyết định hàm nào đc gọi

    }
    //13. Một tính chất khác của delegate
    public static void DemoMulticast()
    {
        Caculation delegateobj = Add;
        
        delegateobj += Sub;//thêm hàm Sub vào danh sách hàm đc gọi
        delegateobj += Add;//Kết quả là của hàm đc gọi cuối cùng
        Console.WriteLine("Output:" + delegateobj(9, 6));//lời gọi lần lượt các hàm Add, Sub
        Console.WriteLine("After remove:");
        delegateobj -= Add;
        delegateobj -= Add;
        delegateobj -= Add;
        delegateobj -= Sub;
        Console.WriteLine("Output:" + delegateobj(9, 6));//phát sinh lỗi runtime và delegate không trỏ tới hàm nào
        
    }
    public static void DemoUsingComparison()
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