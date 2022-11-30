using RestouransAndMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestotansAndMenu
{
    public class Meats : Products
    {
        public Meats(string name, double grammPrice) : base(name, grammPrice)
        {
            MeatProductsNames = new List<string>()
            {
                Cutlet,
                GroundMeat,
                SteakMeat
            };     
        }
        public static List<string> MeatProductsNames { get; set; }
        public static List<Products> options = new List<Products>()
        {
            new Products (Cutlet, CutletGrammPrice)
            {
                Name = Cutlet,
                GrammPrice = CutletGrammPrice,
            },
            new Products(GroundMeat, GroundMeatGrammPrice)
            {
                Name = GroundMeat,
                GrammPrice = GroundMeatGrammPrice,
            },
            new Products(SteakMeat, SteakMeatGrammPrice)
            {
                Name = SteakMeat,
                GrammPrice= SteakMeatGrammPrice,
            }
        };
        public const string Cutlet = "Cutlet";
        public const double CutletGrammPrice = 0.25;
        public const string GroundMeat = "Ground meat";
        public const double GroundMeatGrammPrice = 0.10;
        public const string SteakMeat = "SteakMeat";
        public const double SteakMeatGrammPrice = 0.5;
    }
}
