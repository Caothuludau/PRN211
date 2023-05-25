using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Validation
    {
        public int GetInt(string msg, int min, int max)
        {
            while (true)
            {
                Console.WriteLine(msg);
                if (int.TryParse(Console.ReadLine(), out int input) && input <= max && input >= min)
                {
                    // Exit the loop when the condition is met
                    return input;
                }
                else if (input < min && input > max)
                {
                    Console.WriteLine("Invalid input. Please enter in range of 1 - 5");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                }
            }
        }

        public double GetDouble(string msg, double min, double max)
        {
            while (true)
            {
                Console.WriteLine(msg);
                if (double.TryParse(Console.ReadLine(), out double input) && input <= max && input >= min)
                {
                    // Exit the loop when the condition is met
                    return input;
                }
                else if (input < min && input > max)
                {
                    Console.WriteLine($"Invalid input. Please enter in range of {min} - {max}");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a double.");
                }
            }
        }

        public string GetStringNotNull(string msg)
        {
            while (true)
            {
                Console.WriteLine(msg);
                string? input = Console.ReadLine();
                if (input == null)
                {
                    Console.WriteLine("Invalid input. Please enter not null string");
                }
                else
                {
                    return input;
                }
            }
        }

        public DateTime GetDateTime(string msg)
        {
            while (true)
            {
                Console.WriteLine(msg);
                try
                {
                    DateTime parsedDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
                    return parsedDate;
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please enter in format (dd-MM-yyyy).");
                }
            }
        }

        public Position GetPosition(string msg)
        {
            while (true)
            {
                try
                {
                    Position[] positionList = (Position[])Enum.GetValues(typeof(Position));
                    int input = this.GetInt(msg, 1, positionList.Length);
                    
                    foreach (Position position in positionList)
                    {
                        if (input == (int) position)
                        {
                            return position;
                        }
                    }
                }
                catch
                {

                }
            }
        }
    }
}
