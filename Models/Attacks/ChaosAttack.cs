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
    public class ChaosAttack : IAttack
    {
        public string AttackName => "Chaosattack";
        int Chaosattack = Random.Shared.Next(1, 20);
        public int Damage => Chaosattack;
    }
}