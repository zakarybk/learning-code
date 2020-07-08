using System;

namespace proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            NewServerProxy trainee = new NewServerProxy();

            trainee.TakeOrder("Pizza");
            trainee.DeliverOrder();
            trainee.ProcessPayment("£5");
        }
    }
}
