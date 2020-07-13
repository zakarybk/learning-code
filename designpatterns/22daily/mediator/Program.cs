using System;

namespace mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcessionsMediator mediator = new ConcessionsMediator();

            NorthConcessionStand leftKitch = new NorthConcessionStand(mediator);
            SouthConcessionStand rightKitchen = new SouthConcessionStand(mediator);

            mediator.NorthConcessions = leftKitch;
            mediator.SouthConcessions = rightKitchen;

            leftKitch.Send("Can you send some popcorn?");
            rightKitchen.Send("Sure thing, Kenny's on his way.");

            rightKitchen.Send("Do you have any extra hot dogs?" +
                            "We've had a rush on them over here.");
            leftKitch.Send("Just a couple, we'll send Kenny back with them.");

            Console.ReadKey();
        }
    }
}
