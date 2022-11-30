using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestotansAndMenu
{
    internal class Spices : Products
    {
        public Spices(string name, double grammPrice) : base(name, grammPrice)
        {

        }
        public const string Solt = "Solt";
        public const double SoltGrammPrice = 0.003;
        public const string Pepper = "Pepper";
        public const double PepperGrammPrice = 0.15;
    }
}
