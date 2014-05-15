using System;
using System.IO;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the path");
        string path = Console.ReadLine();
        try
        {
            Console.WriteLine(File.ReadAllText(path));
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Not entered path");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Is not valid path");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("Too long path");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Cant find directory");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File is not exist");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Dose not exit premission to read this file");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Cant read this file bicouse not suport reading program");
        }
        catch (System.Security.SecurityException)
        {
            Console.WriteLine("Cant open this file becouse is secure");
        }
        catch (IOException)
        {
            Console.WriteLine("Cant do it right now, try again later.");
        }
    }
}
