using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.String1
{
    /**internal class alphabet_string
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a string");
            string str=Convert.ToString(Console.ReadLine());
            char[] ch = str.ToCharArray();
            int cnt1=0; int cnt2=0;int cnt3=0;

            for(int  i=0; i<str.Length; i++)
            {
                if (ch[i] == 'A' || ch[i] == 'Z' || ch[i] == 'a' || ch[i]=='z')
                {
                    cnt1++; 
                }
                else if (char.IsDigit(ch[i]))
                {
                    cnt2++;
                }
                else if ((ch[i] >= '0' && ch[i]<=9))
                {
                    cnt3++; 
                }
                Console.WriteLine("total number of alphabet charater");
                Console.WriteLine("total digit of number");
                Console.WriteLine("total special charater");
            }
        }
    }**/
}
