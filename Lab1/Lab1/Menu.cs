using Lab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Menu
    {
        public int ShowMenu()
        {
            Validation val = new Validation();
            int selection = val.GetInt("What do you want me to do?"
                            + "\n 1. View all employees"
                            + "\n 2. Search employees by id, name, position"
                            + "\n 3. Search Employees with the base salary within a given range"
                            + "\n 4. Search Employees with the year salary within a given range"
                            + "\n 5. byebye", 1, 5);
            return selection;
        }
    }
}