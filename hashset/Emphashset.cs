using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.hashset
{
    /**internal class Emphashset
    {
        public class Employee
        {
            public string Name { get; set; }
            public int salary { get; set; }
        }

        public class CheckPrice : IComparer<Employee>
        {
            public int Compare(Employee x, Employee y)// x=p1, y=p2
            {
                if (x.salary > y.salary)
                {
                    return 1;
                }
                else if (x.salary < y.salary)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }

        public class Program
        {
            static void Main(string[] args)
            {
                Employee emp = new Employee { Name = "sayali", salary = 38000 };
                Employee emp1 = new Employee { Name = "kavita", salary = 25000 };

                CheckPrice c = new CheckPrice();

                int result = c.Compare(emp, emp1);

                if (result == 1)
                {
                    Console.WriteLine("sayali has higher salary than kavita");
                }
                else if (result == -1)
                {
                    Console.WriteLine("sayali has less salary than kavita");
                }
                else
                {
                    Console.WriteLine("sayali and kavita loptop has equal salary");
                }
    }

   }         
    }**/       
}