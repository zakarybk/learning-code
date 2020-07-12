using System;
using System.Collections.Generic;

namespace composite
{
    public abstract class SoftDrink
    {
        public int calories { get; set; }

        public SoftDrink(int calories)
        {
            this.calories = calories;
        }
    }

    public class OriginalCola : SoftDrink
    {
        public OriginalCola(int calories) : base(calories) {}
    }

    public class CherryCola : SoftDrink
    {
        public CherryCola(int calories) : base(calories) {}
    }

    public class OriginalRootBeer : SoftDrink
    {
        public OriginalRootBeer(int calories) : base(calories) {}
    }

    public class VanillaRootBeer : SoftDrink
    {
        public VanillaRootBeer(int calories) : base(calories) {}
    }

    public class LemonLime : SoftDrink
    {
        public LemonLime(int calories) : base(calories) {}
    }

    // Composite class
    public class Colas
    {
        public List<SoftDrink> flavours { get; set; }

        public Colas()
        {
            flavours = new List<SoftDrink>();
        }
    }

    public class RootBeers
    {
        public List<SoftDrink> flavours { get; set; }

        public RootBeers()
        {
            flavours = new List<SoftDrink>();
        }
    }

    // The component class
    public class SodaDispenser
    {
        public Colas colas { get; set; }
        public LemonLime lemonLime { get; set; }
        public RootBeers rootBeers { get; set; }

        public SodaDispenser()
        {
            colas = new Colas();
            lemonLime = new LemonLime(190);
            rootBeers = new RootBeers();
        }

        public void DisplayCalories()
        {
            var sodas = new Dictionary<String, int>();

            foreach (var cola in colas.flavours)
                sodas.Add(cola.GetType().Name, cola.calories);

            foreach (var rootBeer in rootBeers.flavours)
                sodas.Add(rootBeer.GetType().Name, rootBeer.calories);

            Console.WriteLine("Calories:");

            foreach (var soda in sodas)
                Console.WriteLine(
                    soda.Key + ": " + soda.Value.ToString() + " calories."
                );
        }
    }
}