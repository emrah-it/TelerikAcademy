﻿using System;
using System.Linq;

namespace AcademyRPG
{
    public interface IResource : IWorldObject
    {
        int Quantity { get; }

        ResourceType Type { get; }
    }
}