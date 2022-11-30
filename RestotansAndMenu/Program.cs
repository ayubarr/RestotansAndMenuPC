using RestotansAndMenu;
using RestouransAndMenu;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main()
    {
        #region Products_Create
        Fruits banana = new Fruits(Fruits.Banana, 100);
        Fruits apple = new Fruits(Fruits.Apple, 120);
        Fruits grape = new Fruits(Fruits.Grape, 110);
        Fruits orange = new Fruits(Fruits.Orange, 130);

        Vegetables tomato = new Vegetables(Vegetables.Tomato, 70);
        Vegetables onion = new Vegetables(Vegetables.Onion, 40);
        Vegetables cucumber = new Vegetables(Vegetables.Cucumber, 50);
        Vegetables lettuce_Leaf = new Vegetables(Vegetables.Lettuce_Leaf, 60);

        Meats cowMeat = new Meats(Meats.Cow_Meat, 500);
        Meats chikenMeat = new Meats(Meats.Chicken_Meat, 400);
        Meats fishMeat = new Meats(Meats.Fish_Meat, 700);
        Meats pigMeat = new Meats(Meats.Pig_Meat, 600);

        Spices cheese_Sauce = new Spices(Spices.Cheese_Sauce, 150);
        Spices ketchup = new Spices(Spices.Ketchup, 130);
        Spices solt = new Spices(Spices.Solt, 20);
        Spices pepper = new Spices(Spices.Pepper, 50);

        Alchohol bear = new Alchohol(Alchohol.Bear, 200);
        Alchohol Vine = new Alchohol(Alchohol.Vine, 1000);

        List<Product> allProducts = new List<Product>
        {
            banana,
            apple,
            grape,
            cowMeat,
            chikenMeat,
            fishMeat,
            pigMeat,
            tomato,
            onion,
            cucumber,
            lettuce_Leaf,
            cheese_Sauce,
            ketchup,
            solt,
            pepper
        };
        #endregion

        #region Mealfs_Create
        Dictionary<Product, double> CowKebabProducts = new Dictionary<Product, double>
        {
            {cowMeat, 250 }
        };
        Dictionary<Product, double> ChikenKebabProducts = new Dictionary<Product, double>
        {
            {chikenMeat, 200 }
        };
        Dictionary<Product, double> AssortiKebabProducts = new Dictionary<Product, double>
        {
            {cowMeat, 150 },
            {chikenMeat, 100 }
        };
        Dictionary<Product, double> fruitSaladProducts = new Dictionary<Product, double>
        {
            {banana, 50 },
            {apple, 50 },
            {grape, 50},
            {orange, 50 },
        };
        Mealf cowKebab = new Mealf(Mealf.Cow_Kebab, CowKebabProducts);
        Mealf chikenKebab = new Mealf(Mealf.Chicken_Kebab, ChikenKebabProducts);
        Mealf assortiKebab = new Mealf(Mealf.Assorti_Kebab, AssortiKebabProducts);
        Mealf fruitSalad = new Mealf(Mealf.Fruit_Salad, fruitSaladProducts);
        #endregion

        #region RestoBars_Create
        List<Mealf> SluhiAndPivoMeals = new List<Mealf>
        {
            cowKebab,
            chikenKebab,
            assortiKebab,
            fruitSalad
        };
        RestoBar ShluhiAndPivo = new RestoBar("BitchAndBear", "Bob", SluhiAndPivoMeals);

        List<RestoBar> allRestoBars = new List<RestoBar>()
        {
            ShluhiAndPivo
        };
        #endregion

        ViewMainMenu(allRestoBars);


    }
    public static void ViewMainMenu(List<RestoBar> allRestoBars)
    {
        Console.WriteLine("MAIN MENU");
        Console.SetCursorPosition(0, 7);
        MainMenuButtons(allRestoBars);
    }
    public static void MainMenuButtons(List<RestoBar> allRestoBars)
    {

        Console.WriteLine("Enter {Z} key - to see Restaurants List\n\n");
        Console.WriteLine("Enter {Esc} key - to Exit and End Program");
        string[] keys = new string[]
        {
                    "Z",
                    "Ecape"
        };
        string choiceButtom = Button(keys);
        switch (choiceButtom)
        {
            case "Z":
                Console.Clear();
                ViewRestoBars(allRestoBars);
                break;
            case "Escape":
                Environment.Exit(0);
                break;
        }
    }
    public static void RestoBarsListMenuButtons(List<RestoBar> allRestoBars)
    {
        Console.WriteLine("Enter {Backspace} key - to BACK\n" +
                  "Enter {Esc} key - to Exit and End Program");
        string[] keys = new string[]
        {
            "Backspace",
            "Escape"
        };
        string choice = Button(keys);

        switch (choice)
        {
            case "Backspace":
                Console.Clear();
                ViewRestoBars(allRestoBars);
                break;
            case "Escape":
                Environment.Exit(0);
                break;
        }
    }
    public static string Button(string[] keys)
    {
        string input = "";
        do
        {
            var inputKey = Console.ReadKey(true);
            int keyAscii = (int)inputKey.Key;
            if (keyAscii <= 57 && keyAscii >= 49 || keyAscii >= 97 && keyAscii <= 105)
            {
                input = inputKey.Key.ToString();
                input = input[input.Length - 1].ToString();
                if(keys.Contains(input))
                    return input;
                Button(keys);
            }

            input = inputKey.Key.ToString();
        }
        while (!keys.Contains(input));
        return input;

    }
    public static void ViewRestoBars(List<RestoBar> allRestoBars)
    {
        int indexofRestoBars = 0;

        foreach (var restobar in allRestoBars)
        {
            indexofRestoBars++;
            Console.WriteLine($"Enter {{{indexofRestoBars}}} key - to see Restourant {restobar.Name} info ");
        }
        Console.WriteLine("Enter {Backspace} key - to BACK\n" +
                          "Enter {Esc} key - to Exit and End Program");
        List<string> keys = new List<string>()
        {
            "Backspace",
            "Escape"
        };

        int secondIndexofRestoBars = indexofRestoBars + 1;
        for (int i = 1; i < secondIndexofRestoBars; i++)
        {
            keys.Add(i.ToString());
        }
        string choiceButtom = Button(keys.ToArray());
        switch (choiceButtom)
        {
            case "Backspace":
                Console.Clear();
                ViewMainMenu(allRestoBars);
                break;
            case "Escape":
                Environment.Exit(0);
                break;
        }

        int index = Convert.ToInt32(choiceButtom);
        Console.Clear();
        int secondIndex = index - 1;
        allRestoBars[secondIndex].ViewRestobarInfo();
        RestoBarsListMenuButtons(allRestoBars);
    }




}

