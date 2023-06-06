using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_1
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
                    string input = Console.ReadLine();
                    DateTime parsedDate = DateTime.ParseExact(input, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                    return parsedDate;
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please enter in format (dd-MM-yyyy).");
                }
            }
        }

        public bool CheckDateTime(string input)
        {
            try
            {
                DateTime.ParseExact(input, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                return true;
            }
            catch
            {
                Console.WriteLine("Invalid input. Please enter in format (dd-MM-yyyy).");
                return false;
            }
        }
    }
}
