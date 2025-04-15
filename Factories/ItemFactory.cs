using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NaiveRPG.Interfaces;
using NaiveRPG.Models.Items;
namespace NaiveRPG.Factories
{
    public class ItemFactory
    {
        public static IItem GetItem(string itemType)
        {
            switch (itemType)
            {
                case "Boots":
                    return new Boots();

                case "Shield":
                    return new Shield();

                case "Sword":
                    return new Sword();
                default:
                    throw new ArgumentException("Item doesn't exist mate");
            }
        }
    }
}