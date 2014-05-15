namespace _1.War_Machines
{
    using System.Collections.Generic;
 
    public interface ICommand
    {
        string Name { get; }

        IList<string> Parameters { get; }
    }
}