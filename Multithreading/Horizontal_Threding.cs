using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThredding
{
    internal class Horizontal_Threding
    {
        public static void Main(string[] args)
        {

            Bank acc = new Bank(12, "Ashutosh Shelke", 800);
            ThreadHolder th = new ThreadHolder(acc);
            Thread t1 = new Thread(new ParameterizedThreadStart(th.run));
            Thread t2 = new Thread(new ParameterizedThreadStart(th.run));
            t1.Name = "t1";
            t2.Name = "t2";
            t1.Start(100);
            t2.Start(150);
            t1.Join();
            t2.Join();
            Console.WriteLine("this is the main thread = " + acc.getAmount());
        }
    }
}
