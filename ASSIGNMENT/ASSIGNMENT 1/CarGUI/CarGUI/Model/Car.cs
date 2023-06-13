using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGUI.Model
{
    public class Car
    {
        public int CarID { get; set; }
        public string? Make { get; set; }
        public string? Color { get; set; }
        public string? Petname { get; set; }

        public Car( int carID, string? make, string? color, string? petname)
        {
            Make = make;
            Color = color;
            Petname = petname;
            CarID = carID;
        }
    }
}
