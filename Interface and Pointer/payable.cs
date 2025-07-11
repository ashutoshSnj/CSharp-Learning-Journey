using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_and_Interfaces
{
    internal interface payable
    {
       const int s = 12;
        void pay();
        public void payeable()
        {
            Console.WriteLine("interface method call");
        }
      
    }
}
