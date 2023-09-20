using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
   /**internal class Frequnecyofcount_array
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            int[] array2 =new int[10];
            int cnt = 0;
            Console.WriteLine("enter the array elements");
            for(int i=0; i<5; i++)
            {
                Console.WriteLine("element {0}- ",i);
                array[i] = Convert.ToInt32(Console.ReadLine());
                array2[i] = -1;

            }
            for (int i = 0; i < 5; i++)
            {
                cnt = 1;
                for (int j = 0; j < 5; j++)
                {
                    if (array[i] == array2[j])
                    {
                        cnt++;
                        array[j] = cnt;
                    }
                }
                Console.WriteLine("frqunency of array element");
                for(i=0;i<5; i++)
                {
                    if (array2[i] != 0)
                    {
                        Console.WriteLine("element{0}occurs{1}times", array[i], array2[i]);
                    }
                }
            }
            

        }
    }**/
}
