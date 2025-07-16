using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{

    public class HashSet_demo
    {
        HashSet<Student> students = new HashSet<Student>();

        public void start()
        {
            this.addStudents(); 
            this.print();
            Console.WriteLine(this.lenght());
        }
        public void addStudents()
        {
            this.students.Add(new Student(1, "Ashutosh"));
            this.students.Add(new Student(2, "Ashutosh"));
            this.students.Add(new Student(5, "Ashutosh"));
            this.students.Add(new Student(1, "Ashutosh"));
        }
        public void print()
        {
            foreach (Student student in this.students)
            {
                Console.WriteLine(student.ToString());
            }
        }
        public int lenght()
        {
            return this.students.Count;
        }
    }
}
