using CAD_Final;
using System.Transactions;

autoLoanCalculator();
static void autoLoanCalculator()
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("----!WELCOME TO EVANS LOAN CALCULATOR!----");

    var carPrice = UserInputFunctions.getPriceOfVehicle();
    var downPayment = UserInputFunctions.getDownPayment();
    var principal = carPrice - downPayment;

    var loanAmount = UserInputFunctions.getLoanAmount();
    var annualInterestRate = UserInputFunctions.getAnnualInterestRate();
    var numMonths = UserInputFunctions.getNumberOfMonths();

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
