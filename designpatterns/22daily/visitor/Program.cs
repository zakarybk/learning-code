using System;

namespace visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee dmitri = new LineCook();
            Employee jackson = new HeadChef();
            Employee amanda = new GeneralManager();

            Employees employees = new Employees();
            employees.Attach(dmitri);
            employees.Attach(jackson);
            employees.Attach(amanda);

            IncomeVisitor income = new IncomeVisitor();
            PaidTimeOffVisitor timeOff = new PaidTimeOffVisitor();

            employees.Accept(income);
            employees.Accept(timeOff);
        }
    }
}
