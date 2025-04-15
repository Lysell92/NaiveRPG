using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NaiveRPG.Models.Characters.Enemies;
using NaiveRPG.Factories;
using NaiveRPG.Models.Visuals;
using NaiveRPG.Interfaces;
namespace NaiveRPG.Services
{
    public class GameCombat
    {
        public static void Engage(Character player, IEnemy enemy)
        {
            Console.WriteLine($"{player.Name} vs {enemy.EnemyName} — Fight!");
            GameLogic.Continue();

            while (player.HealthPoints > 0 && !enemy.Dead)
            {
                Console.WriteLine($"{player.Name} uses {player.Attack.AttackName}!");
                enemy.ReceiveDamage(player.Attack.Damage);
                GameLogic.Continue();

                if (!enemy.Dead)
                {
                    Console.WriteLine($"{enemy.EnemyName} uses {enemy.Attack.AttackName}!");
                    player.ReceiveDamage(enemy.Attack.Damage);
                    Console.WriteLine($"{player.Name} has {player.HealthPoints} left and the {enemy.EnemyName} now has {enemy.HealthPoints} left.");
                    GameLogic.Continue();
                }
            }

            if (player.HealthPoints <= 0)
            {
                Console.WriteLine($"{player.Name} has been defeated!");
                GameLogic.ExitGame();
            }
            else
            {
                CollectLoot(player, enemy);
                GameLogic.Continue();
            }
        }

        public static void CollectLoot(Character player, IEnemy enemy)
        {
            Console.WriteLine($"{enemy.EnemyName} was defeated! You gain {enemy.GoldOwned} gold.");
            player.GoldOwned += enemy.GoldOwned;

            if (enemy.SwordToLoot != null)
            {
                Console.WriteLine($"You picked up: {enemy.SwordToLoot.ItemName}");
                player.SwordOwned = enemy.SwordToLoot;
            }
            if (enemy.ShieldToLoot != null)
            {
                Console.WriteLine($"You picked up: {enemy.ShieldToLoot.ItemName}");
                player.ShieldOwned = enemy.ShieldToLoot;
            }
            if (enemy.BootsToLoot != null)
            {
                Console.WriteLine($"You picked up: {enemy.BootsToLoot.ItemName}");
                player.BootsOwned = enemy.BootsToLoot;
            }
            GameLogic.ShowInventory(player);
        }
    }
}
