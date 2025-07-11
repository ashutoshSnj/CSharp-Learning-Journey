using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handlling
{
    public class Balance_Less:Exception
    {
        public Balance_Less() {
            Console.WriteLine("You Not Have Sufficient Balance ......");
        }
        public Balance_Less(string message) : base(message)
        {

        }
    }
}
