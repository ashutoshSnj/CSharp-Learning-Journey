using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
   public  class LIst_Demo
    {
        List<string> list = new List<string>();
        public void start()
        {
            this.add();
            this.check(2);
            Console.WriteLine(this.check(2));
        }
        public void add()
        {
            list.Add("Ashutosh");
            list.Add("Sanjay");
            list.Add("Shelke");
            list.Add("list");
        }
        public void remove(String str)
        {
          list.Remove(str);
        }
        public void print()
        {
            foreach (string str in list)
            {
                System.Console.WriteLine(str);
            }
        }
        public void length() {
            System.Console.WriteLine(this.list.Count);
                }
        public void add(String str) {
            this.list.Add(str);     
        }
        public void sort()
        {
            this.list.Sort();
            this.print();
        }
        public string check(int index) {
            return $"this is are present at index " + index   + this.list[index];
        }

    }
}
