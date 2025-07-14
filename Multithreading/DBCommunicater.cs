using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThredding
{
    public class DBCommunicater
    {
        public void communicat(Object Username)
        {
            Console.WriteLine("DB Thread Exicuted " + Username);
            dbcall1();
            dbcall2();
            dbcall3();
            dbcall4();
        }
        public void dbcall1()
        {
            Console.WriteLine("DB Proccses 1 complited");
        }
        public void dbcall2()
        {
            Console.WriteLine("DB Proccses 2 complited");
        }
        public void dbcall3()
        {
            Console.WriteLine("DB Proccses 3 complited");
        }
        public void dbcall4()
        {
            Console.WriteLine("DB Proccses 4 complited");
        }
    }
}
