using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CAD_Final
{
    public static class LoanFormulas
    {
        public static double MonthlyPayment(double loanAmount, double annualInterestRate, int monthsTerm)
        {
            double monthlyInterestRate = (annualInterestRate / 100) / 12;

            // Calculation: P * [ i(1 + i)^n / ((1 + i)^n - 1) ]
            double numerator = monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, monthsTerm);
            double denominator = Math.Pow(1 + monthlyInterestRate, monthsTerm) - 1;

            return ((loanAmount * (numerator / denominator)));
        }

        public static double TotalInterestPaid(double Principal, double annualInterestRate, int monthsTerm)
        {

            // M = monthly payment
            // (M * N) - P 
            var monthlyPayment = MonthlyPayment(Principal, annualInterestRate, monthsTerm);

            return (monthlyPayment * monthsTerm) - Principal;
        }

        public static double TotalPrincipalPaid(double Principal, double annualInterestRate, int monthsTerm)
        {
            // M = monthly payment
            // (M * N) - P 
            var monthlyPayment = MonthlyPayment(Principal, annualInterestRate, monthsTerm);
            return ((monthlyPayment * monthsTerm));
        }

        public static double TotalPrincipalPlusInterest(double loanAmount, double annualInterestRate, int monthsTerm)
        {
            return (TotalPrincipalPaid(loanAmount, annualInterestRate, monthsTerm) + TotalInterestPaid(loanAmount, annualInterestRate, monthsTerm));
        }
    }
}
