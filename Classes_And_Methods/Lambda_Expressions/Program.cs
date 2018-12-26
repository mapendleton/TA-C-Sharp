using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //added reference to Abstract class that has an Employee class I can use
            List<Abstract.Employee> employees = new List<Abstract.Employee>();

            List<string> fNames = new List<string>() { "bob","luke","lisa","jenna","alex",
                "george","frank","hannah","hope","lek","brooke","ray","fred","jan","vince",
                "freddy","dan","parker","sam","andy","tyler","alan","hob","rob","dillon"
            };

            List<string> lNames = new List<string>() { "lawler","pendleton","kelly","anderson",
                "fuller","tops","errgo","george","boggs","froth","diamond","mercury","vaas"
            };

            Random rand = new Random();

            //randomly fill employee list, may create dupilicates of id but just for exercise demonstration
            for (int i = 0; i < 10; i++)
            {
                Abstract.Employee employee = new Abstract.Employee();
                employee.firstName = fNames[rand.Next(0, fNames.Count)];
                employee.lastName = lNames[rand.Next(0, lNames.Count)];
                employee.Id = rand.Next(0, 1000);
                employees.Add(employee);
            }

            //add 2 joes for p140 TA exercise
            Abstract.Employee employee1 = new Abstract.Employee() { firstName = "joe", lastName = "diamond", Id = 308 };
            Abstract.Employee employee2 = new Abstract.Employee() { firstName = "joe", lastName = "boot", Id = 980 };
            employees.Add(employee1);
            employees.Add(employee2);

            //step 2 TA exercise
            List<Abstract.Employee> newEmployeeList = new List<Abstract.Employee>();
            foreach (Abstract.Employee employee in employees)
            {
                //Console.WriteLine("{0} {1} ID: {2}",employee.firstName,employee.lastName,employee.Id);
                if (employee.firstName == "joe")
                {
                    newEmployeeList.Add(employee);
                }
            }

            //step 3 lamba expression
            List<Abstract.Employee> list2 = employees.Where(x => x.firstName == "joe").ToList();

            //step 4
            List<Abstract.Employee> list3 = employees.Where(x => x.Id > 5).ToList();

            foreach (Abstract.Employee employee in list2)
            {
                Console.WriteLine("{0} {1} ID: {2}",employee.firstName,employee.lastName,employee.Id);
            }
            Console.WriteLine("List 3 \n");
            foreach (Abstract.Employee employee in list3)
            {
                Console.WriteLine("{0} {1} ID: {2}", employee.firstName, employee.lastName, employee.Id);
            }
            Console.Read();
            
        }
    }
}
