/*
 Name = Simranjit Singh
 Student Id = 30011264
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = null;
            double grossSalary = 0.0;
            double taxRate = 0.0;

            Console.WriteLine("*******************************************");
            Console.WriteLine("*         The Rotorua Thermal Holiday park          *");
            Console.WriteLine("*******************************************");
            /*
             * Creating Employee Object
             */
            Employee employee = new Employee();

            /*
             * Ask the user to enter the details of the employee
             */
            Console.Write("Enter  name of employee: ");
            name = Console.ReadLine();
            Console.Write("Enter  gross salary of employee: ");
            grossSalary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter tax rate for salary of employee: ");
            taxRate = Convert.ToDouble(Console.ReadLine());
            employee.setName(name);
            employee.setGrossSalary(grossSalary);
            employee.setTaxRate(taxRate);

            Console.WriteLine("\n\n************************************");
            Console.WriteLine("*         EMPLOYEE DETAILS         *");
            Console.WriteLine("************************************");
            Console.WriteLine("Name of  Employee: {0}", employee.getName());
            Console.WriteLine("Gross Salary of  Employee: {0}", employee.getGrossSalary());
            Console.WriteLine("Tax Rate for Salary of  Employee: {0}", employee.getTaxRate());
            Console.WriteLine("Net Salary of  Employee: {0}", employee.calcNet());

            Console.ReadKey();
        }

    }
}
