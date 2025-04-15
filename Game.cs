
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using NaiveRPG.Models.Visuals;
using NaiveRPG.Models.Characters.Enemies;
using NaiveRPG.Factories;
using NaiveRPG.Services;
using NaiveRPG;

namespace NaiveRPG
{
    public class Game
    {
        public void StartGame()
        { 
            Console.WriteLine("Welcome adventurer! What is your name?");
            string playerName = Console.ReadLine();

            Character aChar = new Character(playerName,"ChaosAttack");
            GamePlay game = new GamePlay(aChar);
            game.Intro();

            var gnoll = EnemyFactory.CreateEnemy("Gnoll");
            GameCombat.Engage(aChar, gnoll);

            var basilisk = EnemyFactory.CreateEnemy("Basilisk");
            GameCombat.Engage(aChar, basilisk);

            game.BossEncounter();

            var hydra = EnemyFactory.CreateEnemy("Hydra");
            GameCombat.Engage(aChar, hydra);

            game.Ending();
            GameLogic.ExitGame();
        }
    }
}