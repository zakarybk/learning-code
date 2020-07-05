using System;

namespace builder
{
    class Program
    {
        static void Main(string[] args)
        {
            SandwichBuilder builder;

            // Create a shop with an assembly line
            AssemblyLine shop = new AssemblyLine();

            // Construct and display sandwiches
            builder = new HamAndCheese();
            shop.Assemble(builder);
            builder.Sandwich.Show();

            builder = new BLT();
            shop.Assemble(builder);
            builder.Sandwich.Show();

            builder = new TurkeyClub();
            shop.Assemble(builder);
            builder.Sandwich.Show();

            Console.ReadKey();
        }
    }
}
