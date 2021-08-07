using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Language-Integrated Query (LINQ) is the name for a set of
            // technologies based on the integration of query capabilities directly
            // into the C# language.
            List<int> numbers = new List<int>()
            {
                8, 3, 11, 23, 9, 2, 7, 300
            };
            // SORTS -sorting operation
            // OrderBy, OrderByDescending, and Reverse
            // OrderBy = ascending
            var orderedNumbers = numbers.OrderBy(num => num);
            foreach (int num in orderedNumbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Ordered:", orderedNumbers);

            // OrderByDescending
            var descendingOrderNumbers = numbers.OrderByDescending(num => num);
            foreach (int num in descendingOrderNumbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Descending:", descendingOrderNumbers);
            // also:
            // Console.WriteLine($"Descending Numbers: { String.Join(',', descendingNumbers)}");

            // "Cannot assign 'expression' to an implicitly typed local" error:
            // return type of Reverse is void, so we can't store data with it.
            // Reverse reverses the order of the passed collection
            numbers.Reverse();
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Ordered:", numbers);

            /////////////////////////////////////////////////////////////////////
            // Aggregate methods
            // Max, Sum, Min, Average, Count
            // Max returns highest number
            // Min returns lowest
            // Sum adds all ints in collection
            // Average averages the ints - whole sum divided by number of elements
            // Count number of number; .length in JS

            // Filtering method
            // Where
            // like .map in JS
            List<int> numbers2 = new List<int>()
            {
                2, 3, 3, 4, 6, 7, 8, 9
            };

            // Max, Sum, Min, Average, Count
            var maxNumber = numbers2.Max();
            Console.WriteLine(maxNumber);

            var sumOfNumbers = numbers2.Sum();
            Console.WriteLine(sumOfNumbers);

            var minNumber = numbers2.Min();
            Console.WriteLine(minNumber);

            var averageNumber = numbers2.Average();
            Console.WriteLine(averageNumber);

            var count =  numbers2.Count();
            Console.WriteLine(count);

            var biggerNumbers = numbers.Where(num => num > 3);
            Console.WriteLine($"Bigger Numbers: { String.Join(',', biggerNumbers)}");
            ;
            // Select is like Array.map
            // Transforming data

        }
    }
}
