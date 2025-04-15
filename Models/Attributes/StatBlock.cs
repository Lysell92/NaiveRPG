using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaiveRPG.Models.Attributes
{
    public class StatBlock
    {
        public int Strength { get; }
        public int Vitality { get; }
        public int Intelligence { get; }
        public int Dexterity { get; }

        public StatBlock(int strength, int vitality, int intelligence, int dexterity)
        {
            Strength = strength;
            Vitality = vitality;
            Intelligence = intelligence;
            Dexterity = dexterity;
        }
    }
}