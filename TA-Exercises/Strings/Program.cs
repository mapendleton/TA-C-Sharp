using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main()
        {
            string fName = "Bob";
            string lName = "George";
            string mName = "Heart";

            string fullName = fName + " " + mName + " " + lName;

            fullName.ToUpper();

            StringBuilder sb = new StringBuilder();
            sb.Append("\t" + fullName + " went to the market.");
            sb.Append(" He bought himself some cheese and crackers. \n");
            sb.Append(" Why did he buy cheese and crackers you ask?");
            sb.Append(" He loves cheese and crackers, obviously. \n");
            sb.Append("\t When people ask, \"Wont you get fat?\"");
            sb.Append(fName + " always says, \"I'm already fat\". \n");
            sb.Append(" Then " + fName + " eats all the cheese and crackers happily ever after.");

            Console.WriteLine(sb.ToString());
            Console.WriteLine("\n THE END");
            Console.Read();

            
        }
    }
}
