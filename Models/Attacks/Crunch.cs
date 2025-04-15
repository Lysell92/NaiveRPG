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
    public class Crunch : IAttack
    {
        public string AttackName => "Crunch";
        public int Damage => Random.Shared.Next(5, 10);
    }
}
