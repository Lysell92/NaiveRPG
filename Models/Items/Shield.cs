using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using NaiveRPG.Interfaces;
namespace NaiveRPG.Models.Items
{
    public class Shield : IItem
    {
        public string getItemName() => "Shield";
        public string getItemDescription() => "That is a dope shield, amazing";
    }
}
