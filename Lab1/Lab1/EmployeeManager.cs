using Lab1;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class EmployeeManager
    {
        public void Feature(int choice, List<Employee> employees)
        {
            Validation val = new Validation();

            switch (choice)
            {
                case 1: // View all employees
                    DisplayEmployee(employees);
                    break;
                case 2: //Search employees by Id, name, position
                    int miniChoice = val.GetInt("How do you want to search?"
                            + "\n 1. Search employee by ID"
                            + "\n 2. Search employee by Name"
                            + "\n 3. Search employee by Position", 1, 3);
                    string searchInfo = val.GetStringNotNull("Please input infomation to search: ");
                    List<Employee> employeesFound = new List<Employee>();
                    if (miniChoice == 1)
                    {
                        foreach (Employee emp in employees)
                        {
                            if(emp.id.Equals(Convert.ToInt32(searchInfo)) )
                            {
                                employeesFound.Add(emp);
                            }
                        }
                    }
                    else if (miniChoice == 2)
                    {
                        foreach (Employee emp in employees)
                        {
                            if (emp.name != null && emp.name.Contains(searchInfo))
                            {
                                employeesFound.Add(emp);
                            }
                        }
                    }
                    else if (miniChoice == 3)
                    {
                        foreach (Employee emp in employees)
                        {
                            if (emp.position != null && emp.position.Contains(searchInfo))
                            {
                                employeesFound.Add(emp);
                            }
                        }
                    }
                    if (employeesFound == null)
                    {
                        Console.WriteLine("Not Found Any Employee Suitable");
                    }
                    else
                    {
                        DisplayEmployee(employeesFound);
                    }
                    break;
           

                case 3: // Search Employees with the base salary within a given range.
                    double upperSalaryBound = 0;
                    double lowerSalaryBound = 0;

                    upperSalaryBound = val.GetDouble("Input Upper Salary Bound", 1, 999999);
                    lowerSalaryBound = val.GetDouble("Input Lower Salary Bound", 1, 999999);



                    List<Employee> employees2 = employees.Where(employee => employee.salary >= lowerSalaryBound
                                                                 && employee.salary <= upperSalaryBound)
                                                         .ToList<Employee>();
                    if (employees2 == null)
                    {
                        Console.WriteLine("Not Found Any Employee Suitable");
                    }    
                    else
                    {
                        DisplayEmployee(employees2);
                    }
                   
                    break;
                case 4: // Search Employees with the year salary within a given range.
                    double upperYearSalaryBound = 0;
                    double lowerYearSalaryBound = 0;

                    upperYearSalaryBound = val.GetDouble("Input Upper Year Salary Bound", 1, 999999);
                    lowerYearSalaryBound = val.GetDouble("Input Lower Year Salary Bound", 1, 999999);

                    List<Employee> employees3 = employees.Where(employee => employee.SalaryByYear() >= lowerYearSalaryBound
                                                                 && employee.SalaryByYear() <= upperYearSalaryBound)
                                                         .ToList<Employee>();
                    if (employees3 == null)
                    {
                        Console.WriteLine("Not Found Any Employee Suitable");
                    }
                    else
                    {
                        DisplayEmployee(employees3);
                    }
                    break;
            }
        }

        public void DisplayEmployee(List<Employee> employees)
        {
            Console.WriteLine("{0,-20} {1,-20} {2,-20} {3,-20} {4,-20}", "Employee ID", "Employee's Name","Base Salary", "Position", "SalaryByYear");
            foreach (Employee emp in employees)
            {
                SalaryCalculation delobj = delegate (double salary, string position)
                {
                    if (emp.position == "Manager")
                        return salary * 16;
                    else if (emp.position == "Developer")
                        return salary * 14;
                    else
                        return salary * 12;
                };
                emp.DisplayInList(delobj);
            }
        }
    }
}

