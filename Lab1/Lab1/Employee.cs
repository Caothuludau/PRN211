using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Employee
    {
        public int id { get; set; }
        public string? name { get; set; }
        public double salary { get; set; }
        public Position position { get; set; }

        public void Input()
        {
            Validation val = new Validation();
            id = val.GetInt("Enter Employee's ID: ", 0, 9999);
            name = val.GetStringNotNull("Enter Employee's Name: ");
            salary = val.GetDouble("Enter Salary for this Employee: ", 0, 99999);
            position = val.GetPosition("Enter Employee's Position: " + PositionToString());
        }

        public void Display(SalaryCaculation delobj)
        {
            
        }

        public string PositionToString()
        {
            string positionString = "";
            Position[] positions = (Position[])Enum.GetValues(typeof(Position));
            
            foreach (Position position in positions)
            {
                positionString = positionString + ($"\n{(int)position} for {(position)}" );
            }

            return positionString;
        }
    }
}
