using System;

namespace chain_of_responsibility
{
    // The details of the purchase request
    class PurchaseOrder
    {
        public PurchaseOrder(int num, double amt, double price, string name)
        {
            RequestNumber = num;
            Amount = amt;
            Price = price;
            Name = name;
        }

        public int RequestNumber { get; set; }
        public double Amount { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
    }

    /// The handler abstract class.
    /// Any class which inherits 
    /// will be resposbile for restaurant requests
    abstract class Approver
    {
        protected Approver supervisor;

        public void SetSupervisor(Approver supervisor)
        {
            this.supervisor = supervisor;
        }

        public abstract void ProcessRequest(PurchaseOrder purchase);
    }

    // A cencrete Handler class
    class HeadChef : Approver
    {
        public override void ProcessRequest(PurchaseOrder purchase)
        {
            if (purchase.Price < 1000)
                Console.WriteLine(
                    "{0} approved purchase request #{1}",
                    this.GetType().Name,
                    purchase.RequestNumber
                );
            else if (supervisor != null)
                supervisor.ProcessRequest(purchase);
        }
    }

    // A concrete Handler class
    class PurchasingManager : Approver
    {
        public override void ProcessRequest(PurchaseOrder purchase)
        {
            if (purchase.Price < 2500)
                Console.WriteLine(
                    "{0} approved purchase request #{1}",
                    this.GetType().Name,
                    purchase.RequestNumber
                );
            else if (supervisor != null)
                supervisor.ProcessRequest(purchase);
        }
    }

    // A concrete Handler class
    class GeneralManager : Approver
    {
        public override void ProcessRequest(PurchaseOrder purchase)
        {
            if (purchase.Price < 10000)
                Console.WriteLine(
                    "{0} approved purchase request #{1}",
                    this.GetType().Name,
                    purchase.RequestNumber
                );
            else
                Console.WriteLine(
                    "Purchase request #{0} requires an executive meeting!",
                    purchase.RequestNumber
                );
        }
    }
}