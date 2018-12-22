using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_And_Methods
{
    public class Methods
    {
        public static int Squared(int numInput)
        {
            int result = numInput * numInput;
            return result;
        }

        public static int Cubed(int numInput)
        {
            int result = numInput * numInput * numInput;
            return result;
        }

        public static float MinTipCalc(float bill)
        {
            float result = bill * .10f;
            return result;
        }
    }
}
