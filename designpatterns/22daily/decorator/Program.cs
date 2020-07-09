using System;

namespace decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define dishes and number we have of each
            FreshSalad caesarSalad = new FreshSalad(
                "Crisp romaine lettuce",
                "Freshly-grated Parmesan cheese",
                "House-made Caesar dressing"
            );
            caesarSalad.Display();

            Pasta fettuccineAlfredo = new Pasta(
                "Fresh-made daily pasta",
                "Creamly garlic alfredo sauce"
            );
            fettuccineAlfredo.Display();

            Console.WriteLine("\nMaking these dishes available");

            /// Decorate the dishes; now if we attempt to order them
            /// once we're out of ingredients, we can notify customer
            Available caesarAvailable = new Available(caesarSalad, 3);
            Available alfredoAvailalbe = new Available(fettuccineAlfredo, 4);

            // Step 3: Order a bunch of dishes
            caesarAvailable.OrderItem("John");
            caesarAvailable.OrderItem("Sally");
            caesarAvailable.OrderItem("Mabush");

            alfredoAvailalbe.OrderItem("Sally");
            alfredoAvailalbe.OrderItem("Francis");
            alfredoAvailalbe.OrderItem("Venkat");
            alfredoAvailalbe.OrderItem("Diana");

            // There won't be enough for this order
            alfredoAvailalbe.OrderItem("Dennis");

            caesarAvailable.Display();
            alfredoAvailalbe.Display();

            Console.ReadKey(); // wait
        }
    }
}
