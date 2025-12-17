Console.WriteLine("----!WELCOME TO EVANS LOAN CALCULATOR!----");

var loanAmount = getLoanAmount();
var annualInterestRate = getAnnualInterestRate();
var numMonths = getNumberOfMonths();

Console.WriteLine($"Loan Amonut {loanAmount}, Annual Interest Rate {annualInterestRate}, Number of months {numMonths}");

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

    throw new Exception("Error in getting loan Amount");
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
Console.ReadLine();