using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestotansAndMenu
{
    public class Products
    {
        public string Name { get; set; }
        public double GrammPrice { get; set; }

        public Products(string name, double grammPrice)
        {
            Name = name;
            GrammPrice = grammPrice;
        }
    }
}
