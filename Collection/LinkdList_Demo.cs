using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class LinkdList_Demo
    {
        LinkedList <string>list = new LinkedList <string> ();   
        public void start()
        {
            this.add();
            this.print();
        }
       public void add()
        {
            this.list.AddLast("Ashutosh");
            this.list.AddLast("Sanjay");
            this.list.AddFirst("mr");
            this.list.AddFirst(".");
            this.list.AddLast("Shelke");

        }
        public void print()
        {
            foreach(string str in this.list)
            {
                if (str == null)
                {
                    Console.WriteLine("null is present");
                }
                Console.WriteLine(str);
            }
        }
        public void remove(string str)
        {
            this.list.Remove(str);
            
        }
        

    }
}
