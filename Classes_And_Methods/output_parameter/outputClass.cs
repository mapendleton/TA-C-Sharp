using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace output_parameter
{
    //step 6
    public static class OutputClass
    {
        //step 1 and 4
        public static void DivideByTwo(int input, out int result)
        {
            result = input / 2;
        }

        //step 5
        public static void DivideByTwo(float input, out float result)
        {
            result = input / 2;
        }

    }
}
