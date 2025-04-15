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
    public class Hydra : IEnemy
    {
        public string EnemyName { get; }
        public int HealthPoints { get; set; }
        public int GoldOwned { get; }
        public Sword? SwordToLoot { get; }
        public Shield? ShieldToLoot { get; }
        public Boots? BootsToLoot { get; }
        public bool Dead => HealthPoints <= 0;

        public IAttack Attack { get; }

        public Hydra(string name)
        {
            EnemyName = name;
            HealthPoints = 100;
            GoldOwned = 1000;
            SwordToLoot = null;
            ShieldToLoot = null;
            BootsToLoot = new Boots();
            Attack = new ChaosAttack();
        }

        public void ReceiveDamage(int damagePoints)
        {
            HealthPoints -= damagePoints;
        }
    }
}