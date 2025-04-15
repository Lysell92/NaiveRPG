using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NaiveRPG.Models.Items;
using NaiveRPG.Interfaces;

namespace NaiveRPG.Models.Characters.Enemies
{
    public class Gnoll : IEnemy
    {
        public string EnemyName { get; }
        public int HealthPoints { get; private set; }
        public int GoldOwned { get; }
        public Sword? SwordToLoot { get; }
        public Shield? ShieldToLoot { get; }
        public Boots? BootsToLoot { get; }
        public bool Dead { get { return HealthPoints <= 0; } }

        public Gnoll(string name)
        {
            EnemyName = name;
            HealthPoints = 20;
            GoldOwned = 10;
            SwordToLoot = new Sword();
            ShieldToLoot = null;
            BootsToLoot = null;
        }

        public void ReceiveDamage(int damagePoints)
        {
            HealthPoints = HealthPoints - damagePoints;
        }
    }
}
