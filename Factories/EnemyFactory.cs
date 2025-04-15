using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NaiveRPG.Interfaces;
using NaiveRPG.Models.Characters.Enemies;
namespace NaiveRPG.Factories
{
    public static class EnemyFactory
    {
        public static IEnemy CreateEnemy(string enemyType)
        {
            return enemyType switch
            {
                "Gnoll" => new Gnoll("Gnoll Guardian"),
                "Basilisk" => new Basilisk("Fierce Basilisk"),
                "Hydra" => new Hydra("Mythical Hydra"),
                _ => throw new ArgumentException("Enemy type doesn't exist.")
            };
        }
    }
}
