using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RestouransAndMenu
{
    public class RestoBar
    {
        public string Name { get; set; }    
        public string ChefsName { get; set; }
        public Dictionary<Mealf, double> Mealfs { get; set; }
        public RestoBar(string name, string chefsName, List<Mealf> mealfs)
        {
            Name = name;
            ChefsName = chefsName;
            Mealfs = new Dictionary<Mealf, double>();
            foreach (Mealf mealf in mealfs)
            {
                double mealfPrice = Math.Round(mealf.MealfPrice * 0.12 , 3);
                Mealfs.Add(mealf, mealfPrice);
            }
        }
  

        public void ViewRestobarInfo()
        {
            Console.WriteLine($"Info List of RestoBar - {Name}");
            Console.WriteLine($"ChefCook:\n{ChefsName}\n");
            Console.WriteLine("Menu: ");
            Console.WriteLine();
            ViewRestobarMenu();
        }
        public void ViewRestobarMenu()
        {
            int i = 1;
            foreach (var mealf in Mealfs)
            {
                mealf.Key.ViewProductsAndPrice(i++);
                Console.WriteLine($"\n{mealf.Key.MealfName} sell price = {mealf.Value / 100} Som\n");
            }
        }
    }
}
