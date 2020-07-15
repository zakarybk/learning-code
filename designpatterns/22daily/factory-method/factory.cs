using System;
using System.Collections.Generic;

namespace factory_method
{
    // Product
    abstract class Ingredient {}

    // Concrete products
    class Bread : Ingredient {}
    class Turkey : Ingredient {}
    class Lettuce : Ingredient {}
    class Mayonnaise : Ingredient {}

    // Creator
    abstract class Sandwich
    {
        public List<Ingredient> ingredients = new List<Ingredient>();

        public Sandwich()
        {
            CreateIngredients();
        }

        public abstract void CreateIngredients();

        public List<Ingredient> Ingredients
        {
            get { return ingredients; }
        }
    }

    // Concrete creator
    class TurkeySandwich : Sandwich
    {
        public override void CreateIngredients()
        {
            ingredients.Add(new Bread());
            ingredients.Add(new Mayonnaise());
            ingredients.Add(new Lettuce());
            ingredients.Add(new Turkey());
            ingredients.Add(new Turkey());
            ingredients.Add(new Bread());
        }
    }

    class Dagwood : Sandwich
    {
        public override void CreateIngredients()
        {
            ingredients.Add(new Bread());
            ingredients.Add(new Turkey());
            ingredients.Add(new Turkey());
            ingredients.Add(new Lettuce());
            ingredients.Add(new Lettuce());
            ingredients.Add(new Mayonnaise());
            ingredients.Add(new Bread());
            ingredients.Add(new Turkey());
            ingredients.Add(new Turkey());
            ingredients.Add(new Lettuce());
            ingredients.Add(new Lettuce());
            ingredients.Add(new Mayonnaise());
            ingredients.Add(new Bread());
            ingredients.Add(new Turkey());
            ingredients.Add(new Turkey());
            ingredients.Add(new Lettuce());
            ingredients.Add(new Lettuce());
            ingredients.Add(new Mayonnaise());
            ingredients.Add(new Bread());
        }
    }
}