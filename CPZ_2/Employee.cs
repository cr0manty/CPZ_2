using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPZ_2
{
    class Employee
    {
        private string name;
        private double salary;

        public Employee(string _name, double _salary)
        {
            if (String.IsNullOrEmpty(_name))
                throw new Exception("Every employee must have a name!");
            else if (_salary <= 0)
                throw new Exception("Every employee must have a salary!");
            this.name = _name;
            this.salary = _salary;
        }

        public static bool operator ==(Employee _employee, string _employee_name)
        {
            if (_employee.name == _employee_name)
                return true;
            return false;
        }

        public static bool operator !=(Employee _employee, string _employee_name)
        {
            if (_employee.name != _employee_name)
                return true;
            return false;
        }

        public double Salary { get; }

    }
}
