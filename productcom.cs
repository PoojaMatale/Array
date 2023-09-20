using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
   /**public class productcom : IComparable
    {
        
        private string name;
        private float price;

        public productcom(string name, float price)
        {

            this.name = name;
            this.price = price;
        }
        public int CompareTo(object obj)
        {
            productcom p = (productcom)obj;

            if (this.price > p.price)
            {
                return 1;
            }
            else if (this.price < p.price)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        public override string ToString()
        {
            return $"{name} {price}";
        }
   }
    public class product
    {
        static void Main(string[] args)
        {
            productcom hp = new productcom("hp", 25000);
            productcom acer = new productcom("acer", 50000);
            int result = hp.CompareTo(acer);
            if (result == 1)
            {
                Console.WriteLine("hp has more price than acer ");
            }
            else if (result == -1)
            {
                Console.WriteLine("hp has less price than acer");
            }
            else
            {
                Console.WriteLine("hp and acer has both are equal");
            }

        }
    }**/

}
