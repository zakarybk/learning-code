using System;
using System.Collections.Generic;

namespace builder
{
    // The Director
    class AssemblyLine
    {
        public void Assemble(SandwichBuilder sandwichBuilder)
        {
            sandwichBuilder.AddBread();
            sandwichBuilder.AddMeats();
            sandwichBuilder.AddCheese();
            sandwichBuilder.AddVeggies();
            sandwichBuilder.AddCondiments();
        }
    }

    // The Product class
    class Sandwich
    {
        private string sandwichType;
        private Dictionary<string, string> ingredients
            = new Dictionary<string, string>();

        public Sandwich(string sandwichType)
        {
            this.sandwichType = sandwichType;
        }   

        public string this[string key]
        {
            get { return ingredients[key]; }
            set { ingredients[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("Sandwich: {0}", sandwichType);
            Console.WriteLine(" Bread: {0}", ingredients["bread"]);
            Console.WriteLine(" Meat: {0}", ingredients["meat"]);
            Console.WriteLine(" Cheese: {0}", ingredients["cheese"]);
            Console.WriteLine(" Veggies: {0}", ingredients["veggies"]);
            Console.WriteLine(" Condiments: {0}", ingredients["condiments"]);
        }
    }

    // The builder abstract class
    abstract class SandwichBuilder
    {
        protected Sandwich sandwich;

        public Sandwich Sandwich { get { return sandwich; }}

        public abstract void AddBread();
        public abstract void AddMeats();
        public abstract void AddCheese();
        public abstract void AddVeggies();
        public abstract void AddCondiments();
    }

    // A ConcreteBuilder class
    class TurkeyClub : SandwichBuilder
    {
        public TurkeyClub()
        {
            sandwich = new Sandwich("Turkey Club");
        }

        public override void AddBread()
        {
            sandwich["bread"] = "12-Grain";
        }

        public override void AddMeats()
        {
            sandwich["meat"] = "Turkey";
        }

        public override void AddCheese()
        {
            sandwich["cheese"] = "Swiss";
        }

        public override void AddVeggies()
        {
            sandwich["veggies"] = "Lettuce, Tomato";
        }

        public override void AddCondiments()
        {
            sandwich["condiments"] = "Mayo";
        }
    }

    // A ConcreteBuilder class
    class BLT : SandwichBuilder
    {
        public BLT()
        {
            sandwich = new Sandwich("BLT");
        }

        public override void AddBread()
        {
            sandwich["bread"] = "Wheat";
        }

        public override void AddMeats()
        {
            sandwich["meat"] = "Bacon";
        }

        public override void AddCheese()
        {
            sandwich["cheese"] = "None";
        }

        public override void AddVeggies()
        {
            sandwich["veggies"] = "Lettuce, Tomato";
        }

        public override void AddCondiments()
        {
            sandwich["condiments"] = "Mayo, Mustard";
        }
    }

    // A ConcreteBuilder class
    class HamAndCheese : SandwichBuilder
    {
        public HamAndCheese()
        {
            sandwich = new Sandwich("Ham and Cheese");
        }

        public override void AddBread()
        {
            sandwich["bread"] = "White";
        }

        public override void AddMeats()
        {
            sandwich["meat"] = "Ham";
        }

        public override void AddCheese()
        {
            sandwich["cheese"] = "American";
        }

        public override void AddVeggies()
        {
            sandwich["veggies"] = "None";
        }

        public override void AddCondiments()
        {
            sandwich["condiments"] = "Mayo";
        }
    }

}