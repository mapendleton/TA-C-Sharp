using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchExercise
{
    public class ZeroOrBelowException : Exception
    {
        public ZeroOrBelowException()
        {
        }
        public ZeroOrBelowException(string message)
            : base(message)
        {
        }
        public ZeroOrBelowException(string message,Exception inner)
            : base(message,inner)
        {
        }
    }
}
