//6. Write a program that prints from given array of integers all numbers that are
//  divisible by 7 and 3. Use the built-in extension methods and lambda expressions.
//  Rewrite the same with LINQ.

namespace HomeWork
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class DivisibleBy7and3
    {
        public static List<int> AllDivisibleNumbersLambda(List<int> value)
        {
            List<int> result = value.FindAll(x => x % 3 == 0 && x % 7 == 0);

            return result;
        }

        public static List<int> AllDivisibleNumbersBuildInExpression(List<int> value)
        {
            Func<List<int>, List<int>> select = (List<int> x) =>
                {
                    List<int> res = new List<int>();
                    foreach (var item in x)
                    {
                        if (item % 3 == 0 && item % 7 == 0)
                        {
                            res.Add(item);
                        }
                    }
                    return res;
                };

            List<int> result = select(value);
            return result;
        }

        public static IEnumerable<int> AllDivisibleNumbersLinq(List<int> value)
        {
            var result = from curr in value
                         where curr % 3 == 0 && curr % 3 == 0
                         select curr;
            return result;
        }
    }
}