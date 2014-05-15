//20. * By using delegates develop an universal static method to calculate the sum of infinite convergent series with given precision depending on a function of its term. By using proper functions for the term calculate with a 2-digit precision the sum of the infinite series:
//	1 + 1/2 + 1/4 + 1/8 + 1/16 + …
//	1 + 1/2! + 1/3! + 1/4! + 1/5! + …
//	1 + 1/2 - 1/4 + 1/8 - 1/16 + …
//
namespace HomeWork
{
    using System;

    public static class CalculateSecuence
    {
        public static double ConvergentSum(Func<int, double> termValue, double precision)
        {
            double previousSum = 0;
            double sum = 0;
            int counter = 1;

            do
            {
                previousSum = sum;
                sum = previousSum + termValue(counter);
                counter++;
            } while (Math.Abs(sum - previousSum) > precision);
            return sum;
        }
    }
}