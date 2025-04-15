using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NaiveRPG.Interfaces;

namespace NaiveRPG.Models.Attacks
{
    public class WildSwing : IAttack
    {
        public string AttackName => "Wildswing";
        int wildswing = Random.Shared.Next(3, 8);
        public int Damage => wildswing;

    }
}