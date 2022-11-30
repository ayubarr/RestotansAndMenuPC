using RestotansAndMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestouransAndMenu
{
    public class Fruits : Products
    {
        public Fruits(string name, double grammPrice) : base(name, grammPrice)
        {

        }
        public const string Banana = "Banana";
        public const double BananaGrammPrice = 0.25;
        public const string OrangeMeat = "Ground meat";
        public const double OrangeMeatGrammPrice = 0.10;
        public const string Strawberry = "SteakMeat";
        public const double StrawberryGrammPrice = 0.5;
    }
}
