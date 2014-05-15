namespace _1.War_Machines
{
    using System.Text;

    public class Tank : Machine, ITank
    {
        private const double TankHealtPoits = 100;
        private const double TankDefenceAdds = 30;
        private const double TankAttackAdds = 40;

        public Tank(string name, double attackPoints, double defensePoints) : base(name, attackPoints - TankAttackAdds, defensePoints + TankDefenceAdds, TankHealtPoits)
        {
            this.DefenseMode = true;
        }

        public bool DefenseMode { get; private set; }

        public void ToggleDefenseMode()
        {
            if (this.DefenseMode)
            {
                this.DefenseMode = false;
                this.DefensePoints -= TankDefenceAdds;
                this.AttackPoints += TankAttackAdds;
            }
            else
            {
                this.DefenseMode = true;
                this.DefensePoints += TankDefenceAdds;
                this.AttackPoints -= TankAttackAdds;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append(base.ToString());
            output.Append("\n");
            string onOrOf = this.DefenseMode ? "ON" : "OFF";
            output.AppendFormat(" {0}: {1}", DefenseString, onOrOf);
            return output.ToString();
        }
    }
}