namespace SoftwareAcademy
{
    using System;
    using System.Linq;

    public interface ILocalCourse : ICourse
    {
        string Lab { get; set; }
    }
}