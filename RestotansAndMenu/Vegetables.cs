using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestotansAndMenu
{
    internal class Vegetables : Products
    {
        public Vegetables(string name, double grammPrice) : base(name, grammPrice)
        {

        }
        public const string Potato = "Potato";
        public const double PotatoGrammPrice = 0.04;
        public const string Tomato = "Tomato";
        public const double TomatoGrammPrice = 0.1;
        public const string Onion = "Onion";
        public const double OnoinGrammPrice = 0.03;

    }
}
