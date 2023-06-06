internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Cao thu lu dau bat dau voi zero");
        //Console.WriteLine("Cao thu lu dau tiep tuc voi 1");
        //int i;
        //Console.Write("\n Cao thu lu dau bat dau voi: ");
        //i = int.Parse(Console.ReadLine());
        //Console.WriteLine("Vay CTLD tiep tuc voi: {0}, {1}, {2}", i + 1, i + 2, i + 3);
        //Console.WriteLine("Vay CTLD tiep tuc voi: " + (i + 1));

        //Console.ReadKey(); // System("pause");
        //for (int j = 0; j < 10; j++)
        //{
        //    Console.WriteLine("{0}", j);
        //}
        //int []ctld = { 1, 2, 3, 4, 5, 6 };
        //foreach (int i in ctld)
        //{
        //    Console.WriteLine("{0}", i);
        //}

        List<string> list = new List<string>();
        list.Add("cao");
        list.Add("thu");
        list.Add("lu");
        list.Add("dau");
        
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }

        foreach(string info in list)
        {
            Console.WriteLine(info);
        }
    }
}