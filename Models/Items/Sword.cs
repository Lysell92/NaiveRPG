using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using NaiveRPG.Interfaces;
namespace NaiveRPG.Models.Items
{
    public class Sword : IItem
    {
        public string getItemName() => "Sword";
        public string getItemDescription() => "A sword for the lord, thank you!";
    }
}
