using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }

        public void Quit()
        {
            Console.WriteLine("{0} {1} id: {2} has quit",this.FirstName,this.LastName,this.Id);
        }

        //p129 or 52% of C# course exercise == sign overloading
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            return employee1.Id == employee2.Id;
        }

        public static bool operator !=(Employee employee1,Employee employee2)
        {
            return employee1.Id != employee2.Id; 
        }
    }
}
