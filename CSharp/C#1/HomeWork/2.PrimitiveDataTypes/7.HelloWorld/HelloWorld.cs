using System;
class HelloWorld
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";
        object helloWorld = hello + " " + world;
        string helloWorldInString = (string)helloWorld;
        Console.WriteLine(helloWorldInString);
    }
}
