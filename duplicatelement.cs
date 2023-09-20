using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    /**internal class duplicatelement
    {
        static void Main(string[] args)
        {
            int[] arr = {2,4,3,5,7,3,9,2};
            
            {
                for(int i=0; i<arr.Length; i++)
                {
                    int count = 0;
                    bool isvisited = false;
                    for(int k=i-1; k>=0;k--)
                    {
                        if (arr[k] == arr[i])
                        {
                           isvisited = true;
                            break;
                        }
                            
                    }
                    if(isvisited==false)
                    {
                        for(int j= i+1; j<arr.Length;j++)
                        {
                            if (arr[j] == arr[i])
                            {
                                count++;
                            }
                        }
                        if(count>1)
                        {
                            Console.WriteLine("count is"+count);
                        }
                    }
                   
                    
                    
                }
                
            }



        }  
              
    }**/
}
