using System;
using System.Collections;
using System.Collections.Specialized;

namespace Collection
{
    public class OrderedDictionaryDemo
    {
        OrderedDictionary students = new OrderedDictionary();

        public void Start()
        {
            AddStudent(5, new Student(5, "Ashu"));
            AddStudent(2, new Student(2, "Sanjay"));
            AddStudent(9, new Student(9, "Shelke"));

            PrintAll();

            Console.WriteLine("\nAfter Removing key 2:");
            RemoveStudent(2);
            PrintAll();

            Console.WriteLine("\nContains 5: " + ContainsStudent(5));
            Console.WriteLine("Count: " + Count());

            Console.WriteLine("\nManual Iterator:");
            ManualIterator();

            Console.WriteLine("\nClearing All:");
            ClearAll();
            PrintAll();
        }

        public void AddStudent(int id, Student student)
        {
            if (!students.Contains(id))
            {
                students.Add(id, student);
            }
        }

        public void RemoveStudent(int id)
        {
            students.Remove(id);
        }

        public bool ContainsStudent(int id)
        {
            return students.Contains(id);
        }

        public int Count()
        {
            return students.Count;
        }

        public void ClearAll()
        {
            students.Clear();
        }

        public void PrintAll()
        {
            foreach (DictionaryEntry entry in students)
            {
                Student student = (Student)entry.Value;
                Console.WriteLine("Key = " + entry.Key + ", Value = " + student);
            }
        }

        public void ManualIterator()
        {
            IDictionaryEnumerator enumerator = students.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Student student = (Student)enumerator.Value;
                Console.WriteLine("Key = " + enumerator.Key + ", Value = " + student);
            }
        }
    }
}
