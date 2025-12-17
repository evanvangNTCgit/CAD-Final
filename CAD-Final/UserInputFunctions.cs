using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD_Final
{
    public static class UserInputFunctions
    {
        public static double getLoanAmount()
        {
            var validInput = false;
            var loanReturn = double.MinValue;

            do
            {
                Console.WriteLine("What is your loan amount?");
                var loanInput = Console.ReadLine();

                // Now convert into a number...
                double.TryParse(loanInput, out loanReturn);

                if (loanReturn <= 0)
                {
                    // This will skip to the condition check
                    // Valid input since it didnt set it true yet should loop back to top.
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input lets try again...");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                else
                {
                    validInput = true;
                }
            }
            while (!validInput);

            return loanReturn;
        }

        public static double getAnnualInterestRate()
        {
            var validInput = false;
            var interestReturn = double.MinValue;

            do
            {
                Console.WriteLine("What is your annual interest rate?");
                var interestInput = Console.ReadLine();

                // Now convert into a number...
                double.TryParse(interestInput, out interestReturn);

                if (interestReturn <= 0)
                {
                    // This will skip to the condition check
                    // Valid input since it didnt set it true yet should loop back to top.
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input lets try again...");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                else
                {
                    validInput = true;
                }
            }
            while (!validInput);

            return interestReturn;
        }

        public static int getNumberOfMonths()
        {
            var validInput = false;
            var monthsReturn = int.MinValue;

            do
            {
                Console.WriteLine("What is the amount of months on the loan?");
                var monthsInput = Console.ReadLine();

                // Now convert into a number...
                int.TryParse(monthsInput, out monthsReturn);

                if (monthsReturn <= 0)
                {
                    // This will skip to the condition check
                    // Valid input since it didnt set it true yet should loop back to top.
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input lets try again...");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                else
                {
                    validInput = true;
                }
            }
            while (!validInput);

            return monthsReturn;
        }

        public static double getPriceOfVehicle()
        {
            var validInput = false;
            var priceReturn = double.MinValue;

            do
            {
                Console.WriteLine("What is the total price of your vehicle?");
                var priceInput = Console.ReadLine();

                // Now convert into a number...
                double.TryParse(priceInput, out priceReturn);

                if (priceReturn <= 0)
                {
                    // This will skip to the condition check
                    // Valid input since it didnt set it true yet should loop back to top.
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input lets try again...");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                else
                {
                    validInput = true;
                }
            }
            while (!validInput);

            return priceReturn;
        }

        public static double getDownPayment()
        {
            var validInput = false;
            var priceReturn = double.MinValue;

            do
            {
                Console.WriteLine("What is the total down payment on your vehicle?");
                var priceInput = Console.ReadLine();

                // Now convert into a number...
                double.TryParse(priceInput, out priceReturn);

                if (priceReturn <= 0)
                {
                    // This will skip to the condition check
                    // Valid input since it didnt set it true yet should loop back to top.
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input lets try again...");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                else
                {
                    validInput = true;
                }
            }
            while (!validInput);

            return priceReturn;
        }

    }
}
