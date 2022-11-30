using RestotansAndMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestouransAndMenu
{
    public class Alchohol : Product
    {
        public Alchohol(string name, double grammPrice) : base(name, grammPrice)
        {
        }
        public const string Bear = "Bear";
        public const string Vine = "Vine";
        public const string Vodka = "Vodka";
        public const string Rom = "Rom";

    }
}
