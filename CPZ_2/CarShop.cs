using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPZ_2
{
    class CarShop
    {
        private int amount_departments;
        private string name;
        private double avg_month_cash;      //income per month
        private double salary;              //all employee per month
        private double product_price;       //product price per month
        private int employee_amount;
        private string address;
        private int amount_product; 
        List<Employee> employees;

        //make month cash by employye salary
        private void make_cash()
        {
            foreach (var i in this.employees)
                this.avg_month_cash += i.Salary * 2.8;
        }

        //delete employee and info about him
        private void delete_employee(Employee _employee)
        {
            this.employees.Remove(_employee);
            this.employee_amount--;
            this.salary -= _employee.Salary;
            this.make_cash();
        }

        //try add employee, if false - throw error. if true add information in shop
        private void add_empolee(string _name, double _salary)
        {
            foreach (var i in this.employees)
            {
                if (i == _name)
                    throw new Exception("Employee must be unique");
            }

            this.employees.Add(new Employee(_name, _salary));
            this.employee_amount++;
            this.salary += _salary;
            this.make_cash();
        }

        //init data
        public CarShop(string _name, string _address, int _amount_departments, int _amount_product)
        {
            if (String.IsNullOrEmpty(_name) || String.IsNullOrEmpty(_address) ||
                _amount_departments <= 0 || _amount_product <= 0)
                throw new Exception("Something went wrong! Some field is empty or less than 0.");

            this.employees = new List<Employee>();
            this.avg_month_cash = 0;
            this.name = _name;
            this.address = _address;
            this.amount_departments = _amount_departments;
            this.amount_product = _amount_product;
            this.make_cash();
        }

        //Get company profit. Default - year
        public double profit(int _month_amount = 12)
        {
            return this.avg_month_cash - _month_amount * (this.product_price + this.salary);
        }

        public static CarShop operator ++(CarShop _car)
        {
            _car.employee_amount++;
            return _car;
        }

        public static CarShop operator --(CarShop _car)
        {
            _car.employee_amount++;
            return _car;
        }

        public override string ToString()
        {
            return $"{this.name} - {this.address}";
        }

        public bool dismiss_employee(string _name)
        {
            foreach(var i in employees)
            {
                if (i == _name)
                {
                    this.delete_employee(i);
                    return true;
                }
            }
            return false;
        }

        public double tax(int _rate = 17, int _month = 12)
        {
            return this.profit(_month) * _rate / 100;
        }
    }
}
