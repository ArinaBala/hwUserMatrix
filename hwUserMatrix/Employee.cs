using System;
using System.Collections.Generic;
using System.Text;

namespace hwUserMatrix
{

        internal class Employee
        {
            private decimal salary;
            public string Name 
        { 
            get;

            set;
        }
            public decimal Salary
            {
                get
                {
                    return salary;
                }
                set
            {       
                    if (value < 0)
                    {
                        salary = 0;
                    }
                    else
                    {
                        salary = value;
                    }
                }
            }

            public Employee(string name, decimal salary)
            {
                Name = name;
                Salary = salary;
            }
            public static Employee operator +(Employee emp, decimal amount)
            {
                emp.Salary += amount;
                return emp;
            }
            public static Employee operator -(Employee emp, decimal amount)
            {
                emp.Salary -= amount;
                return emp;
            }

         
            public static Employee operator ++(Employee emp)
            {
                emp.Salary += 500;
                return emp;
            }

        
            public static Employee operator --(Employee emp)
            {
                emp.Salary -= 500; 
                return emp;
            }

            public static bool operator ==(Employee left, Employee right)
            {
            if (ReferenceEquals(left, right))
            {
                return true;
            }
            if (left is null || right is null)
            {
                return false;
            }

                return left.Salary == right.Salary;
            }

            public static bool operator !=(Employee left, Employee right)
            {
                return !(left == right);
            }
            public static bool operator <(Employee left, Employee right)
            {
                return left.Salary < right.Salary;
            }

            public static bool operator >(Employee left, Employee right)
            {
                return left.Salary > right.Salary;
            }
            public override bool Equals(object obj)
            {
                if (obj is Employee other)
                {
                    return this.Salary == other.Salary;
                }
                return false;
            }

            public override string ToString()
            {
                return $"Робітник: {Name}, Зарплата: {Salary} грн";
            }
        }
    }

