namespace _1.War_Machines
{
    using System.Collections.Generic;
    using System.Text;

    public class Pilot : IPilot
    {
        private readonly ICollection<IMachine> machines;

        public Pilot(string name)
        {
            this.Name = name.Trim('\n', ' ');
            this.machines = new List<IMachine>();
        }

        public string Name { get; protected set; }

        public void AddMachine(IMachine machine)
        {
            this.machines.Add(machine);
        }

        public string Report()
        {
            StringBuilder report = new StringBuilder();
            report.Append(this.ToString());
            report.Append("\n");

            foreach (var item in this.machines)
            {
                report.Append(item.ToString());
                report.Append("\n");
            }

            return report.ToString().Trim('\n');
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("{0} - ", this.Name);
            if (this.machines.Count == 0)
            {
                output.Append("no machines");
            }
            else if (this.machines.Count == 1)
            {
                output.Append("1 machine");
            }
            else
            {
                output.AppendFormat("{0} machines", this.machines.Count);
            }

            return output.ToString().Trim('\n');
        }
    }
}