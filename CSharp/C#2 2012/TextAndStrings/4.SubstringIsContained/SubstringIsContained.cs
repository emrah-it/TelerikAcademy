﻿using System;
using System.Text.RegularExpressions;
class SubstringIsContained
{
    static void Main()
    {
        string someText = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string regex = "in";
        Console.WriteLine(Regex.Matches(someText, regex, RegexOptions.IgnoreCase).Count);
    }
}