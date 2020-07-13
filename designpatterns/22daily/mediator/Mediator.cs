using System;

namespace mediator
{
    // The mediator interface, which defines a send message
    interface Mediator
    {
        void SendMessage(string message, ConcessionStand concessionStand);
    }

    // The colleague abstract class, representing an entity
    // involved in the conversation which should receive messages.
    abstract class ConcessionStand
    {
        protected Mediator mediator;

        public ConcessionStand(Mediator mediator)
        {
            this.mediator = mediator;
        }
    }

    // A concrete colleague class
    class NorthConcessionStand : ConcessionStand
    {
        public NorthConcessionStand(Mediator mediator) : base(mediator) {}

        public void Send(string message)
        {
            Console.WriteLine(
                "North Concession Stand sends message: " + message
            );
            mediator.SendMessage(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine(
                "North Concession Stand gets message: " + message
            );
        }
    }

    // A concrete colleague class
    class SouthConcessionStand : ConcessionStand
    {
        public SouthConcessionStand(Mediator mediator) : base(mediator) {}

        public void Send(string message)
        {
            Console.WriteLine(
                "South Concession Stand sends message: " + message
            );
            mediator.SendMessage(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine(
                "South Concession Stand gets message: " + message
            );
        }
    }

    // The Concrete Mediator class, which implement the send message method
    // and keeps track of all participants in the conversation
    class ConcessionsMediator : Mediator
    {
        private NorthConcessionStand northConcessions;
        private SouthConcessionStand southConcessions;

        public NorthConcessionStand NorthConcessions
        {
            set { northConcessions = value; }
        }

        public SouthConcessionStand SouthConcessions
        {
            set { southConcessions = value; }
        }

        public void SendMessage(string message, ConcessionStand colleague)
        {
            if (colleague == northConcessions)
                southConcessions.Notify(message);
            else
                northConcessions.Notify(message);
        }
    }
}