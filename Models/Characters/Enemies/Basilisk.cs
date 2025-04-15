using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NaiveRPG.Interfaces;
using NaiveRPG.Models.Items;
using NaiveRPG.Models.Attacks;
namespace NaiveRPG.Models.Characters.Enemies
{
    public class Basilisk : IEnemy
    {
        public string EnemyName { get; }
        public int HealthPoints { get; set; }
        public int GoldOwned { get; }
        public Sword? SwordToLoot { get; }
        public Shield? ShieldToLoot { get; }
        public Boots? BootsToLoot { get; }
        public bool Dead => HealthPoints <= 0;

        public IAttack Attack { get; }

        public Basilisk(string name)
        {
            EnemyName = name;
            HealthPoints = 50;
            GoldOwned = 50;
            SwordToLoot = null;
            ShieldToLoot = new Shield();
            BootsToLoot = null;
            Attack = new Crunch();
        }

        public void ReceiveDamage(int damagePoints)
        {
            HealthPoints -= damagePoints;
        }
    }
}