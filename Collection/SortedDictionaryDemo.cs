using System;
using System.Collections.Generic;

namespace Collection
{
    public class SortedDictionaryDemo
    {
        SortedDictionary<int, Student> students = new SortedDictionary<int, Student>();

        public void Start()
        {
            AddStudent(3, new Student(3, "Shelke"));
            AddStudent(1, new Student(1, "Ashu"));
            AddStudent(2, new Student(2, "Sanjay"));

            PrintAll();

            Console.WriteLine("\nAfter Removing 1:");
            RemoveStudent(1);
            PrintAll();

            Console.WriteLine("\nContains Key 2: " + ContainsStudent(2));
            Console.WriteLine("Count: " + Count());

            Console.WriteLine("\nTryGet for key 3:");
            Student student;
            if (TryGetStudent(3, out student))
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\nManual Iterator:");
            ManualIterator();

            Console.WriteLine("\nClearing All:");
            ClearAll();
            PrintAll();
        }

        public void AddStudent(int id, Student student)
        {
            if (!students.ContainsKey(id))
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
            return students.ContainsKey(id);
        }

        public bool TryGetStudent(int id, out Student student)
        {
            return students.TryGetValue(id, out student);
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
            foreach (KeyValuePair<int, Student> entry in students)
            {
                Console.WriteLine("Key = " + entry.Key + ", Value = " + entry.Value);
            }
        }

        public void ManualIterator()
        {
            IEnumerator<KeyValuePair<int, Student>> enumerator = students.GetEnumerator();
            while (enumerator.MoveNext())
            {
                KeyValuePair<int, Student> entry = enumerator.Current;
                Console.WriteLine("Key = " + entry.Key + ", Value = " + entry.Value);
            }
        }
    }
}
