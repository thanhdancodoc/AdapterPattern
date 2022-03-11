using AdapterPattern.Target;
using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] employeesArray = new string[5, 3]
             {
                {"101","John","10000"},
                {"102","Smith","20000"},
                {"103","Dev","30000"},
                {"104","Pam","40000"},
                {"105","Sara","50000"}
             };

            ITarget target = new EmployeeAdapter();
            Console.WriteLine("HR system passes employee string array to Adapter\n");   //Chuyển dữ liệu xuống Adapter để xử lý
            target.ProcessCompanySalary(employeesArray);
            Console.Read();
        }
    }
}
