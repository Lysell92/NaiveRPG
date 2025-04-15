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
        int HealthPoints { get; }
        int GoldOwned { get; }
        public bool Dead { get; }
        void ReceiveDamage(int damagePoints);
    }
}
