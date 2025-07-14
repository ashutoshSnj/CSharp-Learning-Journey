using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThredding
{
    public  class ThreadHolder
    {
        Bank ref1;
        public ThreadHolder() { }
        public ThreadHolder(Bank obj)
        {
            ref1 = obj;
        }
        public void run(Object obj )
        {
            double dob= Convert.ToDouble(obj);
          //  double d1 = (double)obj;
            this.ref1.withdow(dob);
            Console.WriteLine(Thread.CurrentThread.Name+ "is complited Ammount is "+ref1.getAmount());
        }
    }
}
