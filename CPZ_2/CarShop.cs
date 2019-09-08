using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPZ_2
{
    class CarShop:IComparable
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
            this.avg_month_cash = 0;

            foreach (var i in this.employees)
                this.avg_month_cash += i.Salary * 2.8;

            this.product_price = (this.avg_month_cash - this.salary) * 0.75;
        }

        public List<Employee> Employees { get { return employees; } }

        //init data
        public CarShop(string _name, string _address, int _amount_departments, int _amount_product)
        {
            if (String.IsNullOrEmpty(_name) || String.IsNullOrEmpty(_address) ||
                _amount_departments <= 0 || _amount_product <= 0)
                throw new Exception("Something went wrong! Some field is empty or less than 0.");

            this.employees = new List<Employee>();
            this.employee_amount = 0;
            this.avg_month_cash = 0;
            this.name = _name;
            this.address = _address;
            this.amount_departments = _amount_departments;
            this.amount_product = _amount_product;
            this.make_cash();
        }



        //indexer for monthly income, employee salaries, and purchase costs
        public double this[int index]
        {
            get
            {
                if (index == 0)
                    return this.avg_month_cash;
                else if (index == 1)
                    return this.salary;
                else 
                    return this.product_price;
            }

            set
            {
                if (index == 0)
                    this.avg_month_cash = value;
                else if (index == 1)
                    this.salary = value;
                else 
                    this.product_price = value;
            }
        }


        //delete employee and info about him
        public void delete_employee(Employee _employee)
        {
            try
            {
                this.employees.Remove(_employee);
                this.employee_amount--;
                this.salary -= _employee.Salary;
                this.make_cash();
            }
            catch
            {
                return;
            }
        }

        //try add employee, if false - throw error. if true add information in shop
        public void add_empolee(string _name, double _salary)
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

        //Get company profit. Default - year
        public double profit(int _month = 12)
        {
            return (this.avg_month_cash - this.product_price - this.salary) * _month;
        }

        //overload opeartor ++ for amount employees
        public static CarShop operator ++(CarShop _car)
        {
            _car.employee_amount++;
            return _car;
        }

        //overload opeartor -- for amount employees
        public static CarShop operator --(CarShop _car)
        {
            _car.employee_amount--;
            return _car;
        }

        //override ToString method
        public override string ToString()
        {
            return this.name;
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

        //annual tax (default rate - 17%)
        public double annual_tax(int _rate = 17)
        {
            return this.profit(12) * _rate / 100;
        }

        public int CompareTo(object obj)
        {
            CarShop shop = obj as CarShop;
            if(shop != null)
            {
                return this.name.CompareTo(shop.name);
            }
            else
            {
                throw new Exception("Stores are not identical!");
            }
        }
    }
}
