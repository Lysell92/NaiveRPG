using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using NaiveRPG.Models.Items;
using NaiveRPG.Interfaces;

namespace NaiveRPG.Models.Characters.Enemies
{
    public class Hydra : IEnemy
    {
        public string EnemyName { get; }
        public int HealthPoints { get; private set; }
        public int GoldOwned { get; }
        public Sword? SwordToLoot { get; }
        public Shield? ShieldToLoot { get; }
        public Boots? BootsToLoot { get; }
        public bool Dead { get { return HealthPoints <= 0; } }

        public Hydra(string name)
        {
            EnemyName = name;
            HealthPoints = 50;
            GoldOwned = 1000;
            SwordToLoot = null;
            ShieldToLoot = null;
            BootsToLoot = new Boots();
        }

        public void ReceiveDamage(int damagePoints)
        {
            HealthPoints = HealthPoints - damagePoints;
        }
    }
}