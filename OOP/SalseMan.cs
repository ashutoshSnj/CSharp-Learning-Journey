using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace start
{
    public class SalseMan : Employee
    {
        int target;
        public SalseMan(int id, String name, int target) : base(id, name)
        {
            this.target = target;
        }
        public SalseMan()
        {

        }
        public override void print()
        {
            Console.WriteLine("Salseman method called" + this.target);

        }
        public override bool Equals(object? obj)
        {

            if (obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }
            SalseMan ref1 = (SalseMan)obj;

            return this.getId() == ref1.getId();

        }
        public static bool operator ==(SalseMan obj1, SalseMan obj2)
        {

            /*if (obj1.getId() == obj2.getId())
            {
                return true;
            }
            else
            {
                return false;
            }*/
            if((Object)obj1==null || (Object)obj2==null)
            {
                return false;
            }
           return obj1.getId() == obj1.getId();
        }
        public static bool operator !=(SalseMan obj1, SalseMan obj2)
        {
            return !(obj1 == obj2);
        }
        public override int GetHashCode()
        {
            return this.getId();
        }

    }

}
    
        
  
