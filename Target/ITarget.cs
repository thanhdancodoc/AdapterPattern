using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Target
{
    public interface ITarget
    {
        void ProcessCompanySalary(string[,] employeesArray);
    }
}
