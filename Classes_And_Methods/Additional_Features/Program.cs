using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Features
{
    class Program
    {
        static void Main(string[] args)
        {
            const string title = "Hello World";
            var exChain = new Chain(title, 1999);
            exChain.PrintInfo();
            Console.Read();
        }
    }
}
