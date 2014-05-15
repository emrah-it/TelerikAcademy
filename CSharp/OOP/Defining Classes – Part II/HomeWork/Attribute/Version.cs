//11. Create a [Version] attribute that can be applied to
//  structures, classes, interfaces, enumerations and methods
//  and holds a version in the format major.minor (e.g. 2.11).
//  Apply the version attribute to a sample class and display
//  its version at runtime.

namespace HomeWork.Attribute
{
    using System;

    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class
| AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method)]
    public class VersionAttribute : System.Attribute
    {
        private int major;
        private int minor;

        public VersionAttribute(string majorMinor)
        {
            var majorAndMinor = majorMinor.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            this.major = int.Parse(majorAndMinor[0]);
            this.minor = int.Parse(majorAndMinor[1]);
        }

        public int Major { get { return this.major; } }

        public int Minor { get { return this.minor; } }
        public override string ToString()
        {
            return string.Format("{0}.{1}", this.Major, this.minor);
        }
    }
}