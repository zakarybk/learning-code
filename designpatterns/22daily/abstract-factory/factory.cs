namespace abstract_factory
{
    abstract class Sandich {}

    abstract class Dessert {}

    abstract class RecipeFactory
    {
        public abstract Sandich CreateSandwich();
        public abstract Dessert CreateDessert();
    }

    class BLT : Sandich {}

    class CremeBrulee : Dessert {}

    class AdulstCuisineFactory : RecipeFactory
    {
        public override Sandich CreateSandwich()
        {
            return new BLT();
        }

        public override Dessert CreateDessert()
        {
            return new CremeBrulee();
        }
    }

    class GrilledCheese : Sandich {}

    class IceCreamSundae : Dessert {}

    class KidCuisineFactory : RecipeFactory
    {
        public override Sandich CreateSandwich()
        {
            return new GrilledCheese();
        }

        public override Dessert CreateDessert()
        {
            return new IceCreamSundae();
        }
    }
}