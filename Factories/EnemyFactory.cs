using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NaiveRPG.Interfaces;
using NaiveRPG.Models.Characters.Enemies;
namespace NaiveRPG.Factories
{
    public class EnemyFactory
    {
        public static IEnemy GetEnemy(string enemyType)
        {
            switch (enemyType)
            {
                case "Gnoll":
                    return new Gnoll();

                case "Basilisk":
                    return new Basilisk();

                case "Hydra":
                    return new Hydra();
                default:
                    throw new ArgumentException("Enemy doesn't exist mate");
            }
        }
    }
}
