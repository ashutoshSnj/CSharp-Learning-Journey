using System;
namespace LINQ
{
    public class LINQ_Demo
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 5, 2, 7, 1, 4, 3, 6, 5, 2 };
            List<string> names = new List<string> { "Ashu", "Amit", "Bhavesh", "Ashu", "Ankit" };

            Console.WriteLine("1. Where (Filter even numbers):");
            var evens = numbers.Where(x => x % 2 == 0);
            Console.WriteLine(string.Join(", ", evens));

            Console.WriteLine("\n2. Select (Square each number):");
            var squares = numbers.Select(x => x * x);
            Console.WriteLine(string.Join(", ", squares));

            Console.WriteLine("\n3. OrderBy (Ascending):");
            var asc = numbers.OrderBy(x => x);
            Console.WriteLine(string.Join(", ", asc));

            Console.WriteLine("\n4. OrderByDescending (Descending):");
            var desc = numbers.OrderByDescending(x => x);
            Console.WriteLine(string.Join(", ", desc));

            Console.WriteLine("\n5. Take (First 3 numbers):");
            var top3 = numbers.Take(3);
            Console.WriteLine(string.Join(", ", top3));

            Console.WriteLine("\n6. Skip (Skip first 3 numbers):");
            var afterSkip = numbers.Skip(3);
            Console.WriteLine(string.Join(", ", afterSkip));

            Console.WriteLine("\n7. First:");
            Console.WriteLine(numbers.First());

            Console.WriteLine("\n8. FirstOrDefault:");
            List<int> empty = new List<int>();
            Console.WriteLine(empty.FirstOrDefault()); // returns 0 (default int)

            Console.WriteLine("\n9. Last:");
            Console.WriteLine(numbers.Last());

            Console.WriteLine("\n10. Any (Is there any number > 6?):");
            Console.WriteLine(numbers.Any(x => x > 6));  // True

            Console.WriteLine("\n11. All (Are all numbers > 0?):");
            Console.WriteLine(numbers.All(x => x > 0));  // True

            Console.WriteLine("\n12. Count:");
            Console.WriteLine(numbers.Count());

            Console.WriteLine("\n13. Distinct (Unique numbers):");
            var distinct = numbers.Distinct();
            Console.WriteLine(string.Join(", ", distinct));

            Console.WriteLine("\n14. ToList (Convert filtered to list):");
            var evenList = numbers.Where(x => x % 2 == 0).ToList();
            evenList.ForEach(Console.WriteLine);

            Console.WriteLine("\n15. GroupBy (Group names):");
            var grouped = names.GroupBy(n => n);
            foreach (var group in grouped)
            {
                Console.WriteLine($"{group.Key} appears {group.Count()} times");
            }
        }


    }
    }
