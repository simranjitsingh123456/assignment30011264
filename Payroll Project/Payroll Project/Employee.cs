using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_Project
{
    class Employee
    {
        private string name;
        private double grossSalary;
        private double taxRate;

        public Employee()
        {
            name = null;
            grossSalary = 0.0;
            taxRate = 0.0;

            Console.WriteLine("Employee Record Successfuly created!");
        }

        public void setName(string value)
        {
            this.name = value;
        }

        public string getName()
        {
            return this.name;
        }

        public void setGrossSalary(double value)
        {
            this.grossSalary = value;
        }

        public double getGrossSalary()
        {
            return this.grossSalary;
        }

        public void setTaxRate(double value)
        {
            this.taxRate = value;
        }

        public double getTaxRate()
        {
            return this.taxRate;
        }

        public double calcNet()
        {
            double netSalary = ((this.grossSalary) + (this.grossSalary * this.taxRate));
            return netSalary;
        }

    }
}
