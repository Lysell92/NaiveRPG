using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NaiveRPG.Interfaces;
using NaiveRPG.Models.Attacks;
namespace NaiveRPG.Factories
{
    public class AttackFactory
    {
        public static IAttack GetAttack(string attackType)
        {
            switch (attackType)
            {
                case "WildSwing":
                    return new WildSwing();

                case "Crunch":
                    return new Crunch();

                case "ChaosAttack":
                    return new ChaosAttack();
                default:
                    throw new ArgumentException("Attack doesn't exist mate");
            }
        }
    }
}
