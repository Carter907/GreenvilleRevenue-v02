using System;

class Program
{
    public static void Main(string[] args)
    {

        string input;
        do
        {
            printMenu();
            input = Console.ReadLine();

            if (input == "1")
            {
                printMoreContestants();
            }

        } while (input != "2");

        Console.WriteLine("Thank you for using the Greenville Revenue App, good-bye!");
    }
    static void printMenu()
    {
        Console.WriteLine(
                      @"************************************
*  The stars shine in Greenville.  *
************************************

Please Enter the following number below from the following menu:

1. CALCULATE Greenville Revenue Year-Over-Year
2. Exit
      ");

    }
    static void printMoreContestants()
    {
        Console.WriteLine("Please enter the contestants for the previous year");
        var previousYear = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter the contestants for this year");
        var currYear = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Last year's competition had {0} contestants, and this year's has {1} contestants", previousYear, currYear);
        if (currYear > previousYear)
            Console.WriteLine("It is true that this year's competition is bigger than last year's.");
        else
            Console.WriteLine("It is false that this year's competition is bigger than last year's.");
    }
}