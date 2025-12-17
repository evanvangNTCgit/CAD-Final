using CAD_Final;
using System.Collections.Concurrent;

Console.WriteLine("----!WELCOME TO EVANS LOAN CALCULATOR!----");

//var carPrice = getPriceOfVehicle();
//var downPayment = getDownPayment();
//var loanAmount = getLoanAmount();
//var annualInterestRate = getAnnualInterestRate();
//var numMonths = getNumberOfMonths();

//Console.WriteLine($"Price of vehicle {carPrice}, Down Payment {downPayment}, Loan Amonut {loanAmount}, Annual Interest Rate {annualInterestRate}, Number of months {numMonths}");

var test = LoanFormulas.MonthlyPayment(18000, 5.3, 60);
var testing = LoanFormulas.TotalInterestPaid(18000, 5.3, 60);
var t = LoanFormulas.TotalPrincipalPaid(18000, 5.3, 60);
var e = LoanFormulas.TotalPrincipalPlusInterest(18000, 5.3, 60);
Console.WriteLine("Monthly Payment " + test);
Console.WriteLine("Total Interest Paid " + testing);
Console.WriteLine("Total Principal Paid " + t);
Console.WriteLine("Total Principal Plus Interst Paid " + e);

static double getLoanAmount()
{
    Console.WriteLine("What is your loan amount?");
    var loanInput = Console.ReadLine();

    // Now to convert into a number...
    try
    {
        double.TryParse(loanInput, out double loanReturn);
        loanReturn = Math.Round(loanReturn, 2);

        // First check if its a valid input...
        if (loanReturn <= 0)
        {
            Console.WriteLine("Please try again");
            // Now lets try again...
            getLoanAmount();
        }

        return loanReturn;
    }
    catch
    {
        // Okay it failed here just try it again;
        getLoanAmount();
    }

    throw new Exception("Error in getting loan Amount");
}

static double getAnnualInterestRate()
{
    Console.WriteLine("What is your annual interest rate?");
    var annualInterestInput = Console.ReadLine();

    // Now to convert into a number...
    try
    {
        double.TryParse(annualInterestInput, out double annualInterestReturn);
        annualInterestReturn = Math.Round(annualInterestReturn, 2);

        // First check if its a valid input...
        if (annualInterestReturn <= 0)
        {
            Console.WriteLine("Please try again");
            // Now lets try again...
            getAnnualInterestRate();
        }

        return annualInterestReturn;
    }
    catch
    {
        // Okay it failed here just try it again;
        getAnnualInterestRate();
    }

    throw new Exception("Error in getting annual interest rate");
}

static int getNumberOfMonths()
{
    Console.WriteLine("What is the amount of months on the loan?");
    var monthsInput = Console.ReadLine();

    // Now to convert into a number...
    try
    {
        int.TryParse(monthsInput, out int monthsReturn);

        // First check if its a valid input...
        if (monthsReturn <= 0)
        {
            Console.WriteLine("Please try again");
            // Now lets try again...
            getNumberOfMonths();
        }

        return monthsReturn;
    }
    catch
    {
        // Okay it failed here just try it again;
        getNumberOfMonths();
    }

    throw new Exception("Error in getting loan Amount");
}

static double getPriceOfVehicle()
{
    Console.WriteLine("What is the total price of your vehicle?");
    var priceInput = Console.ReadLine();

    // Now to convert into a number...
    try
    {
        double.TryParse(priceInput, out double priceReturn);
        priceReturn = Math.Round(priceReturn, 2);

        // First check if its a valid input...
        if (priceReturn <= 0)
        {
            Console.WriteLine("Please try again");
            // Now lets try again...
            getPriceOfVehicle();
        }

        return priceReturn;
    }
    catch
    {
        // Okay it failed here just try it again;
        getPriceOfVehicle();
    }

    throw new Exception("Error in total price of car");
}

static double getDownPayment()
{
    Console.WriteLine("What is the toal down payment on the vehicle?");
    var priceInput = Console.ReadLine();

    // Now to convert into a number...
    try
    {
        double.TryParse(priceInput, out double priceReturn);
        priceReturn = Math.Round(priceReturn, 2);

        // First check if its a valid input...
        if (priceReturn <= 0)
        {
            Console.WriteLine("Please try again");
            // Now lets try again...
            getDownPayment();
        }

        return priceReturn;
    }
    catch
    {
        // Okay it failed here just try it again;
        getDownPayment();
    }

    throw new Exception("Error in total price of car");
}
Console.ReadLine();