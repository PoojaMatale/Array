using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    /**internal class Uniqueelement_array
    {
        static void Main(string[] args)
        {
            int[] array = {1,2,3,4,5,6,7,8,9};
            for(int i=0; i<array.Length; i++)
            {
                int cnt = 1;
                bool isvisited=false;
                for(int k=i-1; k>=0; k--)
                {
                    if (array[k] == array[1])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if(isvisited==false)
                {
                    for(int j=i+1; j<array.Length;j++)
                    {
                        if (array[j] == array[i])
                        {
                            cnt++;
                        }
                    }
                    if(cnt==1)
                    {
                        Console.WriteLine(array[i]);
                    }
                }
            }
        }
    }**/
}
