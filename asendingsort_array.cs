using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    /**internal class asendingsort_array
    {
        static void Main(string[] args)
        {
            int n,temp;
            int[] array = new int[5];
            Console.WriteLine( "give the array");
            n=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the array element");
            for (int i=0;i<array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<array.Length;i++)
            {
                for(int j=i+1;j<array.Length;j++)
                {
                    if(array[i]>array[j])
                    {
                        temp = array[i];
                        array[i] =array[j];
                        array[j] = temp;    

                    }
                }
            }
            Console.WriteLine("after asending order in numbers");
            for(int i=0;i< array.Length;i++)
            {
                Console.WriteLine(array[i]);    
            }
            Console.WriteLine();
        }
    }**/
}
