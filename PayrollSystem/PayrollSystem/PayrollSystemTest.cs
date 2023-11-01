// Employee hierarchy test application.
using System;
using static System.Console;

public class PayrollSystemTest
{
    public static void Main(string[] args)
    {
        // create derived class objects
        SalariedEmployee salariedEmployee1 =
           new SalariedEmployee("John", "Smith", "111-11-1111", 800.00M); // Salaried
        HourlyEmployee hourlyEmployee1 =
           new HourlyEmployee("Karen", "Price", "222-22-2222", 46.75M, 40); // Hourly
        SalariedEmployee salariedEmployee2 =
           new SalariedEmployee("Sue", "Jones", "333-33-3333", 1000.00M); // Salaried
        HourlyEmployee hourlyEmployee2 =
           new HourlyEmployee("Bob", "Lewis", "444-44-4444", 45.25M, 45); // Hourly

        // create four-element Employee array
        Employee[] employees = new Employee[4];

        // initialize array with Employees of derived types
        employees[0] = salariedEmployee1;
        employees[1] = hourlyEmployee1;
        employees[2] = salariedEmployee2;
        employees[3] = hourlyEmployee2;

        WriteLine("Employees processed polymorphically:\n");

        // generically process each element in array employees
        foreach (Employee currentEmployee in employees)
        {
            WriteLine($"{currentEmployee}"); // invokes ToString implicitly
            WriteLine($"earned {currentEmployee.CalcEarnings():C}");
            WriteLine();
        } 
    } 
} 
