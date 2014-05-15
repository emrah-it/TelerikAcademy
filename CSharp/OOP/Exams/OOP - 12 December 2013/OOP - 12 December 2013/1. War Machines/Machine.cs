namespace _1.War_Machines
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Machine : IMachine
    {
        protected const string NoneTargets = "None";
        protected const string TypeString = "*Type";
        protected const string HealthStinrg = "*Health";
        protected const string AttackString = "*Attack";
        protected const string DefenseString = "*Defense";
        protected const string TargetString = "*Targets";

        private readonly IList<string> targets;
        private string name;

        public Machine(string name, double attackPoints, double defencePoints, double healthPoints)
        {
            this.Name = name;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defencePoints;
            this.HealthPoints = healthPoints;
            this.targets = new List<string>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }

                this.name = value;
            }
        }

        public IPilot Pilot { get; set; }

        public double HealthPoints { get; set; }

        public double AttackPoints { get; protected set; }

        public double DefensePoints { get; protected set; }

        public IList<string> Targets
        {
            get
            {
                return this.targets;
            }
        }

        public void Attack(string target)
        {
            this.targets.Add(target);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("- {0}", this.Name);
            output.Append("\n");
            output.AppendFormat(" {0}: {1}", TypeString, this.GetType().Name);
            output.Append("\n");
            output.AppendFormat(" {0}: {1}", HealthStinrg, this.HealthPoints);
            output.Append("\n");
            output.AppendFormat(" {0}: {1}", AttackString, this.AttackPoints);
            output.Append("\n");
            output.AppendFormat(" {0}: {1}", DefenseString, this.DefensePoints);
            output.Append("\n");
            output.AppendFormat(" {0}: ", TargetString);

            if (this.Targets.Count == 0)
            {
                output.AppendFormat("{0}", NoneTargets);
            }
            else
            {
                output.AppendFormat("{0}", string.Join(", ", this.Targets));
            }

            return output.ToString().Trim('\n');
        }
    }
}