using System;
using System.Linq;

namespace Infestation
{
    public interface IInfestable
    {
        bool CanInfest { get; }
    }
}