namespace SoftwareAcademy
{
    using System;
    using System.Linq;

    public interface IOffsiteCourse : ICourse
    {
        string Town { get; set; }
    }
}