using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Array.Generic_array
{
    /**internal class duplicate
    {
        static void Main(string[] args)
        {
            int[]array=new int[2];
            List<int> list=new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            for(int i=0; i<list.Count;  i++)
            {
                Console.WriteLine(list[i]);

                int Cnt = 0;
                bool isvisited = false;
                for(int k=i+1;k>=0;k--)
                {
                    if (list[k] == list[i])
                    {
                       isvisited = true;
                        break;
                    }
                }
                if (isvisited)
                {
                    for(int j=0;j<list.Count;j++)
                    {
                        if (list[j] == list[i])
                        {
                            Cnt++;
                        }
                    }
                    if(Cnt>1)
                    {
                        list.Remove(list[i])
                    }
                    
                }
            }
                
        }

    }**/
}
