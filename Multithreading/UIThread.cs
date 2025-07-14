using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThredding
{
    public class UIThread
    {
       public void createUI()
        {
            Console.WriteLine("UI Thread Exicuted");
            runUI1();
            runUI2();
            runU3();    
            runUI4();   

        }
        public void runUI1()
        {
            Console.WriteLine("prosses 1 done by UI");
            Console.WriteLine(Thread.CurrentThread.IsAlive);
        }
        public void runUI2()
        {
            Console.WriteLine("prosses 2 done by UI");
            Thread.Sleep(1000);

        }
        public void runU3()
        {
            Console.WriteLine("prosses 3 done by UI");
        }
        public void runUI4()
        {
            Console.WriteLine("prosses 4 done by UI");
        }
    }
}
