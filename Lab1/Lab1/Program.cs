using Lab1;

internal class Program
{
    private static void Main(string[] args)
    {
        Employee e = new Employee();
        Console.WriteLine(e.PositionToString());
        e.Input();
    }
}