using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NaiveRPG.Interfaces
{
    public interface IEnemy
    {
        public string EnemyName { get; }
        int HealthPoints { get; set; }
        int GoldOwned { get; }
        Sword? SwordToLoot { get; }
        Shield? ShieldToLoot { get; }
        Boots? BootsToLoot { get; }
        bool Dead { get; }
        void ReceiveDamage(int damagePoints);

        IAttack Attack { get; }
    }
}
