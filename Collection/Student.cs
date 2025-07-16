using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Collection
{
    public class Student : IComparable<Student>
    {
        int id;
        string name;

        public Student() { }
        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
       
        public override int GetHashCode()
        {
            return this.id;
        }
        public override bool Equals(object? obj) {
            Student obj1 = (Student) obj;
            {
                if (obj1.id == this.id)
                {
                    return true;
                }
                else
                {
                   return false;
                }
        }

        }
        public override string ToString()
        {
            return $"Student(Id={this.id}, Name={this.name})";
        }

        public int CompareTo(Student? other)
        {
            Student student = other as Student;
            if (this.id > student.id)
            {
                return 1;
            }
            else if (this.id < student.id)
            {
                return -1;
            }
            return 0;
        }
    }
}
