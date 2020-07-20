using System;

namespace template_method
{
    abstract class Bread
    {
        public abstract void MixIngredients();
        public abstract void Bake();
        public virtual void Slice()
        {
            Console.WriteLine("Slicing the " + GetType().Name + " bread!");
        }

        public void Make()
        {
            MixIngredients();
            Bake();
            Slice();
        }
    }

    class TwelveGrain : Bread
    {
        public override void MixIngredients()
        {
            Console.WriteLine("Gathering Ingredients for 12-Grain Bread.");
        }

        public override void Bake()
        {
            Console.WriteLine("Baking the 12-Grain Bread. (25 minutes)");
        }
    }

    class SourDough : Bread
    {
        public override void MixIngredients()
        {
            Console.WriteLine("Gathering Ingredients for Soughdogh Bread.");
        }

        public override void Bake()
        {
            Console.WriteLine("Baking the Soughdough Bread. (20 minutes)");
        }
    }

    class WholeWheat : Bread
    {
        public override void MixIngredients()
        {
            Console.WriteLine("Gathering Ingredients for Whole Wheat Bread.");
        }

        public override void Bake()
        {
            Console.WriteLine("Baking the Whole Wheat. (15 minutes)");
        }
    }
}