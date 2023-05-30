using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Employee
    {
        public int id { get; set; }
        public string? name { get; set; }
        public double salary { get; set; }
        public string? position { get; set; }

        public Employee()
        {
            
        }
        public Employee(int id, string? name, double salary, string? position)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.position = position;
        }

        public void Input()
        {
            Validation val = new Validation();
            id = val.GetInt("Enter Employee's ID: ", 0, 9999);
            name = val.GetStringNotNull("Enter Employee's Name: ");
            salary = val.GetDouble("Enter Salary for this Employee: ", 0, 99999);
            position = val.GetStringNotNull("Enter Employee's Position: ");
            
        }
        

        public void Display(SalaryCalculation delobj)
        {
            double salaryByYear = delobj(this.salary, this.position);
            Console.WriteLine("{0,-20} {1,-20} {2,-20} {3,-20}", "Employee ID", "Employee's Name", "Position", "SalaryByYear");
            Console.WriteLine("{0,-20} {1,-20} {2,-20} {3,-20}", this.id, this.name, this.position, salaryByYear);
        }

        public void DisplayInList(SalaryCalculation delobj)
        {
            double salaryByYear = delobj(this.salary, this.position);
            Console.WriteLine("{0,-20} {1,-20} {2,-20} {3,-20} {4,-20}", this.id, this.name, this.salary, this.position, salaryByYear);
        }

        public double SalaryByYear()
        {
            SalaryCalculation delobj = delegate (double salary, string position)
            {
                if (this.position == "Manager")
                    return  salary * 16;
                else if (this.position == "Developer")
                    return  salary * 14;
                else
                    return  salary * 12;
            };
            return delobj(this.salary, this.position);
        }
    }
}
