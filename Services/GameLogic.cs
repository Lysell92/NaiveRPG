using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using NaiveRPG.Models.Visuals;
using NaiveRPG.Models.Items;
using NaiveRPG.Services;

namespace NaiveRPG.Services
{
    public class GameLogic
    {
        public static void ShowInventory()
        {
            Character aChar = new Character("Player1");
            Console.WriteLine($"{aChar} now owns:");
            Console.WriteLine("---------------------------");
            Console.WriteLine($"Money  :  {aChar.GoldOwned} gold");
            Console.WriteLine($"Boots  :  {(aChar.BootsOwned == null ? "(none)" : aChar.BootsOwned.ToString())}");
            Console.WriteLine($"Shield :  {(aChar.ShieldOwned == null ? "(none)" : aChar.ShieldOwned.ToString())}");
            Console.WriteLine($"Sword  :  {(aChar.SwordOwned == null ? "(none)" : aChar.SwordOwned.ToString())}");
            Console.WriteLine();
            Console.WriteLine();
            Continue();
        }

        public static void RestartGame()
        {
            while (true)
            {
                Console.WriteLine("Press Enter to restart the game, or Esc to quit.");
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Escape)
                    break;
            }
        }
        public static void Continue()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
            Console.Clear();
        }
    }
}
