using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Prime_array
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] array = new int[10];
            for(int i=0;i<array.Length; i++)
            {
                bool isprime = true;
                for(int j=2;j<array.Length;j++)
                {
                    if (array[i]%array[j]==0)
                    {
                        isprime= false;
                        break;
                    }
                }
                if(isprime==true)
                {
                    Console.WriteLine(i);
                     sum = sum + i;
                }
            }
            Console.WriteLine("sum of prime number");
        }
    }
}
