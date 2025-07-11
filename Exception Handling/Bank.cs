using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handlling
{
    public class Bank
    {
        int id;
        String name;
        double ammount;

        public Bank()
        {

        }
        public Bank(int id, string name, double ammount)
        {
            this.id = id;
            this.name = name;
            this.ammount = ammount;
        }
       public void withdrow(int amo) 
        {
          double finalb=  this.ammount- amo;
            if (finalb < 0)
            {
                throw new Balance_Less("We Cant Withdrow Becose you not have Sufficient balance..");
            }
            else
            {
                this.ammount= finalb;
            }
        }

    }
}
