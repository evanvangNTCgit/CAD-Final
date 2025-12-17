using CAD_Final;

autoLoanCalculator();
static void autoLoanCalculator()
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("----!WELCOME TO EVANS LOAN CALCULATOR!----");

    var carPrice = getPriceOfVehicle();
    var downPayment = getDownPayment();
    var principal = carPrice - downPayment;

    var loanAmount = getLoanAmount();
    var annualInterestRate = getAnnualInterestRate();
    var numMonths = getNumberOfMonths();

    var monthlyPayment = Math.Round(LoanFormulas.MonthlyPayment(principal, annualInterestRate, numMonths), 2);
    var totalPrincipalPaid = Math.Round(LoanFormulas.TotalPrincipalPaid(principal, annualInterestRate, numMonths), 2);
    var totalInterestPaid = Math.Round(LoanFormulas.TotalInterestPaid(principal, annualInterestRate, numMonths), 2);
    var totalPrincipalPlusInterest = Math.Round(LoanFormulas.TotalPrincipalPlusInterest(principal, annualInterestRate, numMonths), 2);

    displayForClient(monthlyPayment, totalPrincipalPaid, totalInterestPaid, totalPrincipalPlusInterest);
    static void displayForClient(double monthlyPayment, double totalPrincipalPaid, double totalInterestPaid, double totalPrincipalPlusInterest)
    {
        try
        {
            Console.Write("Monthly Payment: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(monthlyPayment);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n----------------------------------------------");
            Console.Write("Total Principal Paid: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(totalPrincipalPaid);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n----------------------------------------------");
            Console.Write("Total Interest Paid: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(totalInterestPaid);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n----------------------------------------------");
            Console.Write("Total Principal Plus Interest: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(totalPrincipalPlusInterest);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n----------------------------------------------");
        }
        catch
        {
            Console.WriteLine("An error occured trying to display ouput. \n Please restart program and try again.");
        }
    }

    Console.WriteLine("Type in restart to calculate again");
    var restartInput = Console.ReadLine();

    if(restartInput == "restart")
    {
        autoLoanCalculator();
    } else
    {
        Environment.Exit(0);
    }
}

//var test = LoanFormulas.MonthlyPayment(18000, 5.3, 60);
//var testing = LoanFormulas.TotalInterestPaid(18000, 5.3, 60);
//var t = LoanFormulas.TotalPrincipalPaid(18000, 5.3, 60);
//var e = LoanFormulas.TotalPrincipalPlusInterest(18000, 5.3, 60);
//Console.WriteLine("Monthly Payment " + test);
//Console.WriteLine("Total Interest Paid " + testing);
//Console.WriteLine("Total Principal Paid " + t);
//Console.WriteLine("Total Principal Plus Interst Paid " + e);

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

