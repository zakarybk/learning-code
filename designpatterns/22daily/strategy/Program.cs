using System;

namespace strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            CookMethod method = new CookMethod();

            Console.WriteLine("What food would you like to cook?");
            var food = Console.ReadLine();
            method.SetFood(food);

            Console.WriteLine("What cooking strategy would you like to use (1-3)?");
            int input = int.Parse(Console.ReadKey().KeyChar.ToString());

            switch(input)
            {
                case 1:
                    method.SetCookStrategy(new Grilling());
                    method.Cook();
                    break;
                case 2:
                    method.SetCookStrategy(new OvenBaking());
                    method.Cook();
                    break;
                case 3:
                    method.SetCookStrategy(new DeepFrying());
                    method.Cook();
                    break;
                default:
                    Console.WriteLine("Invalid Selection!");
                    break;
            }
        }
    }
}
