using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_and_Interfaces
{
    internal class Engineering_Student: Student,payable
    {
        Student std;
        int semno;
        public Engineering_Student() { }
        public Engineering_Student(int id, string name, int semno) : base(id, name)
        {
            this.semno = semno;
        }
        public override void doStudy()
        {
            Console.WriteLine("derive class impliments");
        }

        public void pay()
        {
            Console.WriteLine("Engineerig Student pay");
        }
        public void payeable()
        {
            Console.WriteLine("Derive class method calll");
          
        }
        void payable.payeable()
        {
            Console.WriteLine("correct impliment the interface method");
        }
        public void msg()
        {
            Console.WriteLine("derive class call");
        }
        public unsafe void chekckid(Student* student)
        {
            if (this.getId() > student->getId())
            {
                this.std = *student;
            }
        }
        public void printall()
        {
            Console.WriteLine(this.getName() + this.getId() + "\n");
            if (this.std != null)
            {
                Console.WriteLine(this.std.getName() + this.std.getId());
            }

        }
    }
}
