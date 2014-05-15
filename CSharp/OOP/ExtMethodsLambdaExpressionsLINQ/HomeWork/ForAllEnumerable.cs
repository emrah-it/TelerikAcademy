//2.Implement a set of extension methods for IEnumerable<T> that implement
//  the following group functions: sum, product, min, max, average.
//
//6.Write a program that prints from given array of integers all numbers
//that are divisible by 7 and 3. Use the built-in extension methods and
//lambda expressions. Rewrite the same with LINQ.
//

namespace HomeWork
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class ForAllEnumerable
    {
        public static T Min<T>(this IEnumerable<T> current)
        {
            return current.Min(x => x);
        }

        public static bool MyContain<T>(this IEnumerable<T> current, T value)
        {
            return current.Contains(value);
        }

        public static T Max<T>(this IEnumerable<T> current) where T : IComparable
        {
            return current.Max(x => x);
        }

        public static T Sum<T>(this IEnumerable<T> current) where T : IComparable
        {
            dynamic result = current.First();
            foreach (var item in current)
            {
                result += item;
            }
            result -= current.First();
            return result;
        }

        public static T Product<T>(this IEnumerable<T> current) where T : IComparable
        {
            dynamic result = current.First();
            foreach (var item in current)
            {
                result *= item;
            }
            result /= current.First();
            return result;
        }

        public static T Averge<T>(this IEnumerable<T> current) where T : IComparable
        {
            dynamic result = current.First();
            int count = 0;
            foreach (var item in current)
            {
                result += item;
                count++;
            }
            result -= current.First();
            result /= count;
            return result;
        }
    }
}