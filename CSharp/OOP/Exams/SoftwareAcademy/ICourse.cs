﻿namespace SoftwareAcademy
{
    using System;
    using System.Linq;

    public interface ICourse
    {
        string Name { get; set; }

        ITeacher Teacher { get; set; }

        void AddTopic(string topic);

        string ToString();
    }
}