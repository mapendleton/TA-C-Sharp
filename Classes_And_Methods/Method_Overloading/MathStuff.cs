using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    public class MathStuff
    {
        public int DivideByFour(int num)
        {
            return num / 4;
        }

        public decimal DivideByFour(decimal dec)
        {
            return dec / 4m;
        }

        public int DivideByFour(string strNum)
        {
            bool success = int.TryParse(strNum, out int num);
            if (success)
            {
                return num / 4;
            }
            else
            {
                Console.WriteLine("incorrect input returning 0");
                return 0;
            }
        }
    }
}
