using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Sumprime_array
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0; i < array.Length; i++)
            {
                
                if (array[i]%2== 0)
                {
                    sum = sum + array[i];
                }
                Console.WriteLine("sum of element"+sum);
            }

        }
    }
}
