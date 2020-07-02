using System;
using System.Collections.Generic;

namespace prototype
{
    abstract class SandwichPrototype
    {
        public abstract SandwichPrototype Clone();
    }

    class Sandwich : SandwichPrototype
    {
        private string bread;
        private string meat;
        private string cheese;
        private string veggies;

        public Sandwich(string bread, string meat, string cheese, string veggies)
        {
            this.bread = bread;
            this.meat = meat;
            this.cheese = cheese;
            this.veggies = veggies;
        }

        public override SandwichPrototype Clone()
        {
            string ingredients = GetIngredients();
            Console.WriteLine(
                "Cloning sandwich with ingredients: {0}",
                ingredients
            );

            return MemberwiseClone() as SandwichPrototype;
        }

        private string GetIngredients()
        {
            return bread + ", " + meat + ", " + cheese + ", " + veggies;
        }
    }

    class SandwichMenu
    {
        private Dictionary<string, SandwichPrototype> sandwiches 
            = new Dictionary<string, SandwichPrototype>();

        public SandwichPrototype this[string name]
        {
            get { return sandwiches[name]; }
            set 
            {
                sandwiches.Add(name, value);
            }
        }
    }
}