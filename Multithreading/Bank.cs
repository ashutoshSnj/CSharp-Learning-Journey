using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThredding
{
    public  class Bank
    {
        int id;
        String Holdername;
        double balance;
        private readonly object lockObj = new object();

        public void withdow(double bal)
        {
            lock (lockObj)
            {
                double temp = this.balance;
                Thread.Sleep(1000);
                temp = temp - bal;
                this.balance = temp;
                Console.WriteLine(Thread.CurrentThread.Name + this.balance);
            }
        }
        internal double getAmount()
        {
           return this.balance;
        }

        public Bank() {
        }
        public Bank(int id, string holdername,double balancee)
        {
            this.id = id;

            Holdername = holdername;
            this.balance = balancee;
        }
    }
}
