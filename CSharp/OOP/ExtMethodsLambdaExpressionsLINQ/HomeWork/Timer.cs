//7.Using delegates write a class Timer that has can execute certain method
//  at each t seconds.

namespace HomeWork
{
    using System;

    public static class Timer
    {
        public static void CallMethod(Action MethodToCall, int timeInSecons)
        {
            DateTime current = DateTime.Now;

            while (true)
            {
                if (DateTime.Now.Subtract(current).Seconds >= timeInSecons)
                {
                    MethodToCall();
                    current = DateTime.Now;
                }
            }
        }
    }
}