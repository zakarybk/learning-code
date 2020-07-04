using System;
using System.Collections.Generic;

namespace flyweight
{
    // The Flyweight class
    abstract class Slider // Slider is a small burger
    {
        protected string Name;
        protected string Cheese;
        protected string Toppings;
        protected decimal Price;

        public abstract void Display(int orderTotal);
    }

    // A ConcreteFlyweight class
    class BaconMaster : Slider
    {
        public BaconMaster()
        {
            Name = "Bacon Master";
            Cheese = "American";
            Toppings = "lots of bacon";
            Price = 2.39m;
        }

        public override void Display(int orderTotal)
        {
            Console.WriteLine(
                "Slider #" + orderTotal + ": "
                + Name + " - topped with "
                + Cheese + " cheese and "
                + Toppings + "! $" + Price.ToString()
            );
        }
    }

    // A ConcreteFlyweight class
    class VeggieSlider : Slider
    {
        public VeggieSlider()
        {
            Name = "Veggie Slider";
            Cheese = "Swiss";
            Toppings = "lettuce, onion, tomato, and pickles";
            Price = 1.99m;
        }

        public override void Display(int orderTotal)
        {
            Console.WriteLine(
                "Slider #" + orderTotal + ": "
                + Name + " - topped with "
                + Cheese + " cheese and "
                + Toppings + "! $" + Price.ToString()
            );
        }
    }

    // A ConcreteFlyweight class
    class BBQKing : Slider
    {
        public BBQKing()
        {
            Name = "BBQ King";
            Cheese = "American";
            Toppings = "onion rings, lettuce, and BBQ sauce";
            Price = 2.49m;
        }

        public override void Display(int orderTotal)
        {
            Console.WriteLine(
                "Slider #" + orderTotal + ": "
                + Name + " - topped with "
                + Cheese + " cheese and "
                + Toppings + "! $" + Price.ToString()
            );
        }
    }

    // The FlyweightFactory class
    class SliderFactory
    {
        private Dictionary<char, Slider> sliders =
            new Dictionary<char, Slider>();

        public Slider GetSlider(char key)
        {
            Slider slider = null;
            if (sliders.ContainsKey(key))
                slider = sliders[key];
            else {
                switch (key)
                {
                    case 'B': slider = new BaconMaster(); break;
                    case 'V': slider = new VeggieSlider(); break;
                    case 'Q': slider = new BBQKing(); break;
                }
                if (slider != null)
                    sliders.Add(key, slider);
                else
                    throw new ArgumentException(String.Format("{0} is not a key!", key));
            }
            return slider;
        }
    }
}