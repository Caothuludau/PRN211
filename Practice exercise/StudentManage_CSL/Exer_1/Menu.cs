using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_1
{
    internal class Menu
    {
        public int ShowMenu()
        {
            Validation val = new Validation();
            int selection = val.GetInt("What do you want me to do?"
                            + "\n 1. Create a Course/ Online Course"
                            + "\n 2. Read all availabled Course/ Online Course"
                            + "\n 3. Search for courses which 'ngayBD' in a range"
                            + "\n 4. Sort Courses"
                            + "\n 5. byebye", 1, 5);
            return selection;
        }
    }
}
