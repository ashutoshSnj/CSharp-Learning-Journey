using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
     public class SortedSetdemo
    {
        SortedSet<Student> set=new SortedSet<Student>();
        public void start()
        {
            this.addStudents();
            this.print();
            Console.WriteLine(this.lenght());
        }
        public void addStudents()
        {
            set.Add(new Student(5, "Ashutosh"));
            set.Add(new Student(12, "Ashutosh"));
            set.Add(new Student(26, "Ashutosh"));
            set.Add(new Student(1, "shelke"));
        }
        public void print()
        {
            foreach (Student student in this.set)
            {
                Console.WriteLine(student.ToString());
            }
        }
        public int lenght()
        {
            return this.set.Count;
        }
    }
}

