using System;
using System.Collections.Generic;

namespace Collection
{
    public class DictionaryDemo
    {
        Dictionary<int, Student> students = new Dictionary<int, Student>();

        public void Start()
        {
            AddStudent(1, new Student(1, "Ashu"));
            AddStudent(2, new Student(2, "Sanjay"));
            AddStudent(3, new Student(3, "Shelke"));

            PrintAll();
            Console.WriteLine();

            RemoveStudent(2);
            Console.WriteLine("After Removing ID 2:");
            PrintAll();

            Console.WriteLine($"\nContains Key 3: {ContainsStudent(3)}");
            Console.WriteLine($"Total Count: {Count()}");

            Console.WriteLine("\nTryGetValue for Key 1:");
            if (TryGetStudent(1, out Student student))
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\nManual Iterator using IEnumerator:");
            ManualIterator();

            Console.WriteLine("\nClearing All...");
            ClearAll();
            PrintAll();
        }

        public void AddStudent(int id, Student student)
        {
            if (!students.ContainsKey(id))
                students.Add(id, student);
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
            foreach (var entry in students)
            {
                Console.WriteLine($"Key = {entry.Key}, Value = {entry.Value}");
            }
        }

        public void ManualIterator()
        {
            IEnumerator<KeyValuePair<int, Student>> enumerator = students.GetEnumerator();

            while (enumerator.MoveNext())
            {
                var pair = enumerator.Current;
                Console.WriteLine($"Key = {pair.Key}, Value = {pair.Value}");
            }
        }
    }
}
