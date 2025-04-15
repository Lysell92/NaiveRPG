using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using NaiveRPG.Interfaces;

namespace NaiveRPG.Models.Attacks
{
    public class WildSwing : IAttack
    {
        public string AttackName => "Wildswing";
        public int Damage => Random.Shared.Next(3, 8);

    }
}