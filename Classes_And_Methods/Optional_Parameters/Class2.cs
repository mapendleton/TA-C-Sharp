using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_Parameters
{
    public class Class2
    {
        public int DoSomeMath(int num1,int num2 = 1)
        {
            return num1 * num2 * 100;
        }
    }
}
