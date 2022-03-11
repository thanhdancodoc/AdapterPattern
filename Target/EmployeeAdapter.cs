using AdapterPattern.Adaptee;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Target
{
    public class EmployeeAdapter : ThirdPartyBillingSystem, ITarget
    {
        //VCB
        //ThirdPartyBillingSystem thirdPartyBillingSystem = new ThirdPartyBillingSystem();
        //BIDV bidv = new BIDV();
        public void ProcessCompanySalary(string[,] employeesArray)
        {
            string Id = null;
            string Name = null;
            string Salary = null;
            List<Employee> listEmployee = new List<Employee>();
            for (int i = 0; i < employeesArray.GetLength(0); i++)
            {
                for (int j = 0; j < employeesArray.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        Id = employeesArray[i, j];
                    }
                    else if (j == 1)
                    {
                        Name = employeesArray[i, j];
                    }
                    else
                    {
                        Salary = employeesArray[i, j];
                    }
                }
                listEmployee.Add(new Employee(Convert.ToInt32(Id), Name, Convert.ToDecimal(Salary)));
            }
            Console.WriteLine("Adapter converted Array of Employee to List of Employee");   //Thông báo đã chuyển đổi thành công
            Console.WriteLine("Then delegate to the ThirdPartyBillingSystem for processing the employee salary\n");     //Bên thứ 3 sẽ xử lý tiền lương
            ProcessSalary(listEmployee);
        }
    }
}
