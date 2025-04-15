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
    public class Gnoll : IEnemy
    {
        public string EnemyName { get; }
        public int HealthPoints { get; set; }
        public int GoldOwned { get; }
        public Sword? SwordToLoot { get; }
        public Shield? ShieldToLoot { get; }
        public Boots? BootsToLoot { get; }
        public bool Dead => HealthPoints <= 0;

        public IAttack Attack { get; }

        public Gnoll(string name)
        {
            EnemyName = name;
            HealthPoints = 35;
            GoldOwned = 20;
            SwordToLoot = new Sword();
            ShieldToLoot = null;
            BootsToLoot = null;
            Attack = new WildSwing();
        }

        public void ReceiveDamage(int damagePoints)
        {
            HealthPoints -= damagePoints;
        }
    }
}
