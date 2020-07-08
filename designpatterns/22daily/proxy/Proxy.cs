using System;

namespace proxy
{
    // The subject interface which both the RealSubject and proxy will need to implement
    public interface IServer
    {
        void TakeOrder(string order);
        string DeliverOrder();
        void ProcessPayment(string payment);
    }

    // The RealSubject class which the proxy can stand in for
    class Server : IServer
    {
        private string order;
        public void TakeOrder(string order)
        {
            Console.WriteLine("Server takes order for " + order + ".");
            this.order = order;
        }

        public string DeliverOrder()
        {
            return order;
        }

        public void ProcessPayment(string payment)
        {
            Console.WriteLine("Payment for order (" + payment + ") processed.");
        }
    }

    // The proxy class, which can substitute for the Real subject
    class NewServerProxy : IServer
    {
        private string order;
        private Server server = new Server();

        public void TakeOrder(string order)
        {
            Console.WriteLine("Net trainee server takes order for " + order + ".");
            this.order = order;
        }

        public string DeliverOrder()
        {
            return order;
        }

        public  void ProcessPayment(string payment)
        {
            Console.WriteLine("Net trainee cannot process payments yet!");
            server.ProcessPayment(payment);
        }
    }
}