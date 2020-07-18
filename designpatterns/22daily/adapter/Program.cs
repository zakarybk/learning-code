using System;

namespace adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Meat unknown = new Meat("Beef");
            unknown.LoadData();

            MeatDetails beef = new MeatDetails("Beef");
            beef.LoadData();

            MeatDetails turkey = new MeatDetails("Turkey");
            turkey.LoadData();

            MeatDetails chicken = new MeatDetails("Chicken");
            chicken.LoadData();
        }
    }
}
