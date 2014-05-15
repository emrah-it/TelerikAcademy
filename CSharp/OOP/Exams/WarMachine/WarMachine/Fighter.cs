using System.Text;

public class Fighter : Machine, IFighter
{
    private const double FighterDefaulHealth = 200;
    private const string StealthString = "*Stealth";

    public Fighter(string name, double attackPoints, double defensePoints, bool stealthMode) : base(name, attackPoints, defensePoints, FighterDefaulHealth)
    {
        this.StealthMode = stealthMode;
    }

    public bool StealthMode { get; private set; }

    public void ToggleStealthMode()
    {
        if (this.StealthMode)
        {
            this.StealthMode = false;
        }
        else
        {
            this.StealthMode = true;
        }
    }

    public override string ToString()
    {
        StringBuilder output = new StringBuilder();
        output.Append(base.ToString());
        output.Append("\n");
        string onOrOf = this.StealthMode ? "ON" : "OFF";
        output.AppendFormat(" {0}: {1}", StealthString, onOrOf);
        return output.ToString().Trim('\n');
    }
}