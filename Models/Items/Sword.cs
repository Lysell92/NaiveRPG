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
        public string ItemName { get; private set; }

        public Sword()
        {
            ItemName = "Basic Sword";
        }
    }
}
