using Lab1;
using System.IO;
using System.Numerics;

internal class Program
{
    private static void Main(string[] args)
    {
        Menu menu = new Menu();
        EmployeeManager cm = new EmployeeManager();
        List<Employee> employees = new List<Employee>();
        //Read employee out of the datafile
        string filePath = "D:\\PRN211\\Lab1\\Data.txt";
        using (StreamReader sr = new StreamReader(filePath, System.Text.Encoding.UTF8))
        {
            String line = "";
            while ((line = sr.ReadLine()) != null)
            {
                try
                {
                    // Read each line and split them in to small string that contains the fields of employee
                    string[] empInfo = line.Split("|");

                    // Create new employee by the info and add it to the employee list
                    int empID = Convert.ToInt32(empInfo[0]);
                    string empName = empInfo[1];
                    double empSalary = Convert.ToDouble(empInfo[2]);
                    string empPosition = empInfo[3];

                    Employee emp = new Employee(empID, empName, empSalary, empPosition);
                    employees.Add(emp);
                }
                catch (Exception ex) {
                    
                }
            }
        }
        int selection = 0;
        while (selection != 5)
        {
            selection = menu.ShowMenu();
            cm.Feature(selection, employees);
        }
    }
}