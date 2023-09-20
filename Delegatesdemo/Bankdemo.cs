using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Delegatesdemo
{
    internal class Bankdemo
    {
        public delegate void myDelegate();
        public class bank
        {
            public event myDelegate credit;
            public event myDelegate debit ;

            public void AcceptAccountbalance(Double per)
            {

            }
        }
    }
}
