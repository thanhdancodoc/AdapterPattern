using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public Employee(int id, string name, decimal salary)
        {
            ID = id;
            Name = name;
            Salary = salary;
        }
    }
}
