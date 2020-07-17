using System;

namespace facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server();

            // Name
            Console.WriteLine(
                "Hello! I'll be your server today. What is your name?"
            );
            var name = Console.ReadLine();
            Patron patron = new Patron(name);

            // Appetiser
            Console.WriteLine(
                "Hello {0}. What appetiser would you like (1-15):", 
                name
            );
            var appID = int.Parse(Console.ReadLine());

            // Entree
            Console.WriteLine(
                "That's a good one. What entree would you like? (1-60):"
            );
            var entreeID = int.Parse(Console.ReadLine());

            // Drink
            Console.WriteLine(
                "A great choice! Finally, what drink would you like? (1-20):"
            );
            var drinkID = int.Parse(Console.ReadLine());

            // Place order
            Console.WriteLine("I'll get that order right away.");
            server.PlaceOrder(patron, appID, entreeID, drinkID);
        }
    }
}
