using System;
using System.Collections.Generic;

namespace visitor
{
    /// The Element abstract class.
    /// All this does is define an Accept operator
    /// which needs to be implemented by any class that can be visited
    abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    }

    /// The ConcreteElement class,
    /// which implements all operations defined by the Element.
    class Employee : Element
    {
        public string Name { get; set; }
        public double AnnualSalary { get; set; }
        public int PaidTimeOffDays { get; set; }

        public Employee(string name, double annualSalary, int paidTimeOffDays)
        {
            Name = name;
            AnnualSalary = annualSalary;
            PaidTimeOffDays = paidTimeOffDays;
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    /// The Visitor interface
    /// which declares a Visit operation for each ConcreteVisitor to implement
    interface IVisitor
    {
        void Visit(Element element);
    }

    /// A Concrete Visitor class
    class IncomeVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            Employee employee = element as Employee;

            // We've had a great year, so 10% pay raises for everyone!
            employee.AnnualSalary *= 1.10;
            Console.WriteLine(
                "{0} {1}'s new income: {2:C}",
                employee.GetType().Name,
                employee.Name,
                employee.AnnualSalary
            );
        }
    }

    // A Concrete Visitor class
    class PaidTimeOffVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            Employee employee = element as Employee;

            // And because you all helped have such a great year,
            // all of my employees get three extra paid time off days each!
            employee.PaidTimeOffDays += 3;
            Console.WriteLine(
                "{0} {1}'s new vacation days: {2}",
                employee.GetType().Name,
                employee.Name,
                employee.PaidTimeOffDays
            );
        }
    }

    /// The object Structure class, which is a collection of Concrete Elements.
    /// This could be implemented using another pattern such as Composite.
    class Employees
    {
        private List<Employee> employees = new List<Employee>();

        public void Attach(Employee employee)
        {
            employees.Add(employee);
        }

        public void Detach(Employee employee)
        {
            employees.Remove(employee);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (Employee e in employees)
                e.Accept(visitor);
            Console.WriteLine();
        }
    }

    class LineCook : Employee
    {
        public LineCook() : base("Dmitri", 32000, 7) {}
    }

    class HeadChef : Employee
    {
        public HeadChef() : base("Jackson", 69015, 21) {}
    }

    class GeneralManager : Employee
    {
        public GeneralManager() : base("Amanda", 78000, 24) {}
    }
}