using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace start
{
   public  class Employee
    {
        int id;
        String name;

      public  Employee(int id, String name)
        {
            this.id = id;   
            this.name = name;
        }
        public int getId()
        {
            return this.id;
        }
        public String getName()
        {
            return this.name;
        }
        public void setName(String name)
        {
            this.name = name;
        }
        public void setID(int id)
        {
            this.id = id;
        }
      public  Employee()
        {

        }
       public virtual void print()
        {
            Console.WriteLine("Employee method called"+this.id + " " + this.name);

        }
    }
}
