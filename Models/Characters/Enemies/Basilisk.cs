using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NaiveRPG.Interfaces;
using NaiveRPG.Models.Items;
namespace NaiveRPG.Models.Characters.Enemies
{

    public class Basilisk : IEnemy
    {
        public string EnemyName { get; }
        public int HealthPoints { get; private set; }
        public int GoldOwned { get; }
        public Sword? SwordToLoot { get; }
        public Shield? ShieldToLoot { get; }
        public Boots? BootsToLoot { get; }
        public bool Dead { get { return HealthPoints <= 0; } }

        public Basilisk(string name)
        {
            EnemyName = name;
            HealthPoints = 35;
            GoldOwned = 20;
            SwordToLoot = null;
            ShieldToLoot = new Shield();
            BootsToLoot = null;
        }

        public void ReceiveDamage(int damagePoints)
        {
            HealthPoints = HealthPoints - damagePoints;
        }
    }
}
