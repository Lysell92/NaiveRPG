using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using NaiveRPG.Models.Visuals;
using NaiveRPG.Factories;
using NaiveRPG.Models.Items;
using NaiveRPG.Services;

namespace NaiveRPG.Services
{
    public class GameLogic
    {
        public static void ShowInventory(Character aChar)
        {
            Console.WriteLine($"{aChar.Name} now owns:");
            Console.WriteLine("---------------------------");
            Console.WriteLine($"Money  :  {aChar.GoldOwned} gold");
            Console.WriteLine($"Boots  :  {(aChar.BootsOwned != null ? aChar.BootsOwned.ToString() : "(none)")}");
            Console.WriteLine($"Shield :  {(aChar.ShieldOwned != null ? aChar.ShieldOwned.ToString() : "(none)")}");
            Console.WriteLine($"Sword  :  {(aChar.SwordOwned != null ? aChar.SwordOwned.ToString() : "(none)")}");
            Console.WriteLine();
            GameLogic.Continue();
        }

        public static void ExitGame()
        {
            while (true)
            {
                Console.WriteLine("Press Escape to quit the game. See you later :=)");
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
