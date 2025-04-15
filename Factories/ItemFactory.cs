using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NaiveRPG.Interfaces;
using NaiveRPG.Models.Items;
namespace NaiveRPG.Factories
{
    public static class ItemFactory
    {
        public static IItem CreateItem(string itemType)
        {
            return itemType switch
            {
                "Sword" => new Sword(),
                "Shield" => new Shield(),
                "Boots" => new Boots(),
                _ => throw new ArgumentException("Item type doesn't exist.")
            };
        }
    }
}