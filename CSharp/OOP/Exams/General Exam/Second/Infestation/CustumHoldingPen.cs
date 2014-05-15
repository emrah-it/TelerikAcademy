using System;
using System.Linq;

namespace Infestation
{
    public class CustumHoldingPen : HoldingPen
    {
        protected override void ExecuteInsertUnitCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "Tank":
                    this.InsertUnit(new Tank(commandWords[2]));
                    break;
                case "Marine":
                    this.InsertUnit(new Marine(commandWords[2]));
                    break;
                case "Queen":
                    this.InsertUnit(new Queen(commandWords[2]));
                    break;
                case "Parasite":
                    this.InsertUnit(new Parasite(commandWords[2]));
                    break;
                default:
                    base.ExecuteInsertUnitCommand(commandWords);
                    break;
            }
        }

        //Unit targetUnit = this.GetUnit(interaction.TargetUnit);

        //           targetUnit.DecreaseBaseHealth(interaction.SourceUnit.Power);
        //           break;
        protected override void ProcessSingleInteraction(Interaction interaction)
        {
            switch (interaction.InteractionType)
            {
                case InteractionType.Infest:
                    if (interaction.TargetUnit.UnitClassification == UnitClassification.Biological)
                    {
                        if (interaction.SourceUnit.UnitClassification == UnitClassification.Biological)
                        {
                            Unit current = this.GetUnit(interaction.TargetUnit);

                            current.AddSupplement(new InfestationSpores());
                            return;
                        }
                        else
                        {
                            return;
                        }
                    }
                    else if (interaction.TargetUnit.UnitClassification == UnitClassification.Mechanical)
                    {
                        if (interaction.SourceUnit.UnitClassification == UnitClassification.Psionic)
                        {
                            Unit current = this.GetUnit(interaction.TargetUnit);

                            current.AddSupplement(new InfestationSpores());
                            return;
                        }
                        else
                        {
                            return;
                        }
                    }
                    else if (interaction.TargetUnit.UnitClassification == UnitClassification.Mechanical)
                    {
                        if (interaction.SourceUnit.UnitClassification == UnitClassification.Psionic)
                        {
                            Unit current = this.GetUnit(interaction.TargetUnit);

                            current.AddSupplement(new InfestationSpores());
                            return;
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        Unit current = this.GetUnit(interaction.TargetUnit);

                        current.AddSupplement(new InfestationSpores());
                        return;
                    }

                    break;
                default:
                    base.ProcessSingleInteraction(interaction);
                    break;
            }
        }

        protected override void ExecuteAddSupplementCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "PowerCatalyst":
                    {
                        Unit current = this.GetUnit(commandWords[2]);
                        if (current != null)
                        {
                            current.AddSupplement(new PowerCatalyst(3, 0, 0));
                        }
                    }
                    break;
                case "HealthCatalyst ":
                    {
                        Unit current = this.GetUnit(commandWords[2]);
                        if (current != null)
                        {
                            current.AddSupplement(new HealthCatalyst(0, 3, 0));
                        }
                    }
                    break;
                case "AggressionCatalyst":
                    {
                        Unit current = this.GetUnit(commandWords[2]);
                        if (current != null)
                        {
                            current.AddSupplement(new AggressionCatalyst(0, 0, 3));
                        }
                    }
                    break;
                case "Weapon":
                    {
                        Unit current = this.GetUnit(commandWords[2]);
                        if (current != null)
                        {
                            current.AddSupplement(new Weapon());
                        }
                    }
                    break;
                default:
                    break;
            }
        }
    }
}