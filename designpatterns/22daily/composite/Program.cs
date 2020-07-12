using System;

namespace composite
{
    class Program
    {
        static void Main(string[] args)
        {
            SodaDispenser dispenser = new SodaDispenser();
            dispenser.colas.flavours.Add(new OriginalCola(220));
            dispenser.colas.flavours.Add(new CherryCola(230));

            dispenser.lemonLime.calories = 180;

            dispenser.rootBeers.flavours.Add(new OriginalRootBeer(225));
            dispenser.rootBeers.flavours.Add(new VanillaRootBeer(225));

            dispenser.DisplayCalories();
            Console.ReadKey();
        }
    }
}
