using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_and_Interfaces
{
    public abstract  class Student
    {
 
        int id;
        String name;

        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public Student()
        {
        }
        public int getId()
        {
            return id;
        }
        public String getName()
        {
            return name;
        }
        public void setName(String name)
        {
            this.name = name;
        }
        public void setId(int id)
        {
            this.id=id;
        }
        public  abstract void doStudy();
        public void msg()
        {
            Console.WriteLine("base class call");
        }
       
        
    }
}
