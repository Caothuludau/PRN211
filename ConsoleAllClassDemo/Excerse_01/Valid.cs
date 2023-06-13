namespace Excerse_01
{
    internal class Valid
    {
        public static int GetInteger(int min, int max, string mgs)
        {
            int value;
            while (true)
            {
                try
                {
                    Console.WriteLine(mgs);
                    value = Convert.ToInt32(Console.ReadLine());
                    if (value < min || value > max) 
                        throw new OverflowException("Nhap vuot qua gioi han. Nhap lai.");
                    return value;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nhap sai, yeu cau nhap lai.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Nhap vuot qua gioi han cho phep.");
                }
            }
        }
        public static string GetString(int minLength, int maxLength, string mgs)
        {
           
                string value;
                while (true)
                {
                    Console.WriteLine(mgs);
                    value = Console.ReadLine().Trim();
                    if (value.Length >=minLength && value.Length <= maxLength) return value;
                    Console.WriteLine("Du lieu nhap sai. Yeu cau nhap lai.");
                }
            
        }
        public static DateTime GetDateTime(DateTime startDate, DateTime endDate, string pattern, string mgs)
        {
            DateTime value;
            while (true)
            {
                try
                {
                    Console.WriteLine(mgs);
                    value = DateTime.ParseExact(Console.ReadLine(), pattern, null);
                    if (value < startDate || value > endDate) 
                        throw new OverflowException("Nhap vuot qua gioi han. Nhap lai.");
                    return value;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nhap sai, yeu cau nhap lai.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Nhap vuot qua gioi han cho phep.");
                }
            }
        }
    }
}
