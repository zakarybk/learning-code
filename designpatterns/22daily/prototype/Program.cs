using System;

namespace prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            SandwichMenu menu = new SandwichMenu();

            // Init with default sandwiches
            menu["BLT"] = new Sandwich("Wheat", "Bacon", "", "Lettuce, Tomato");
            menu["PB&J"] = new Sandwich("White", "", "", "Peanut butter, Jelly");
            menu["Turkey"]
                = new Sandwich("Rye", "Turkey", "Swiss", "Lettuce, Onion, Tomato");

            // Clone
            Sandwich sandwich1 = menu["BLT"].Clone() as Sandwich;
            Sandwich sandwich2 = menu["PB&J"].Clone() as Sandwich;
            Sandwich sandwich3 = menu["Turkey"].Clone() as Sandwich;
        }
    }
}
