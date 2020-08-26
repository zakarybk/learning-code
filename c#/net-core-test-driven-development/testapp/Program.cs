using System;

namespace testapp
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = ("John", "Doe");
            (string firstName, string lastName) moreNames = GetNames();

            // Normal
            Console.WriteLine(names.ToString());

            // By turple
            Console.WriteLine(moreNames.firstName + " " + moreNames.lastName);

            // By reference
            string firstName = "";
            string lastName = "";
            GetMoreNames(out firstName, out lastName);
            Console.WriteLine(firstName + " " + lastName);

            // By referemce without previously declared vars
            CreateAndAssignName();
            CreateAndAssignNameImplicitly();

            Console.WriteLine("Hello World!");

            RefLocals();

            Console.WriteLine(GetFifthDayOfWeek());
            
            NestedFunction(out string name);
            Console.WriteLine(name);

            void NestedFunction(out string name)
            {
                name = "Bob";
            }

            var longDigit = 2_300_400_500_78; // Digit separator
            var binaryValue = 0b11101011; // binary literal
        }

        static void CreateAndAssignName()
        {
            GetMoreNames(out string firstName, out string lastName);
            Console.WriteLine(firstName + " " + lastName);
        }

        static void CreateAndAssignNameImplicitly()
        {
            GetMoreNames(out var firstName, out var lastName);
            Console.WriteLine(firstName + " " + lastName);
        }

        private static (string, string) GetNames()
        {
            (string firstName, string lastName) names = ("John", "Doe");
            return names;
        }

        private static void GetMoreNames(out string firstName, out string lastName)
        {
            firstName = "John";
            lastName = "Doe";
        }

        private static void RefLocals()
        {
            string dayOfWeek = "Sunday";
            ref string day = ref dayOfWeek;                         // Almost like a pointer to dayOfWeek
            Console.WriteLine($"day-{day}, dayOfWeek-{dayOfWeek}"); // Sunday Sunday
            day = "Monday";
            Console.WriteLine($"day-{day}, dayOfWeek-{dayOfWeek}"); // Monday Monday
            dayOfWeek = "Tuesday";
            Console.WriteLine($"day-{day}, dayOfWeek-{dayOfWeek}"); // Tuesday Tuesday
        }

        public static ref string GetFifthDayOfWeek()
        {
            string [] daysOfWeek= new string [7] {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
            return ref daysOfWeek[4];
        }

        public void ProcessLoan(Loan loan)
        {
            if (loan is CarLoan carLoan)
            {
                // do something
            }
            if (loan is var carLoan2) // var, same type as obj
            {
                // do something
            }
            if (loan is null)
            {
                // do something
            }

            // patterns as conditions in switch
            switch(loan)
            {
                case CarLoan carLoan3:
                    break;
                case HouseLoan houseLoan when (houseLoan.IsElligible):
                    break;
                case null:
                    // throw exception
                    break;
                default:
                    // something
                    break;
            }
        }
    }

    class Loan
    {

    }

    class CarLoan : Loan
    {
    
    }

    class HouseLoan : Loan
    {
        public  bool IsElligible;
    }
}
