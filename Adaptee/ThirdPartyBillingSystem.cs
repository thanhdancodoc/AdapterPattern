using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Adaptee
{
    public class ThirdPartyBillingSystem
    {
        //ThirdPartyBillingSystem accepts employees information as a List to process each employee salary
        public void ProcessSalary(List<Employee> listEmployee)
        {
            foreach (Employee employee in listEmployee)
            {
                Console.WriteLine(employee.Salary + "$ Salary Credited to " + employee.Name + " Account");
            }
        }
    }
}
