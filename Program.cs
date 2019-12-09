using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentEstimator
{
    // **************************************************
    //
    // Title: Rent Estimator
    // Application Type: Console- .NET Framework
    // Description: Calculates monthly rent based on utilities and square footage
    // Author: Tyler Smith
    // Dated Created: 12/7/2019
    // Last Modified: 12/9/2019
    //
    // **************************************************  
    class Program
    {
        static void Main(string[] args)
        {
            DisplayWelcomeScreen();

            int squarefootage;
            double costpersquarefoot, utilities = 0, totalsqftcost, total;
            string name, houselocation;

            Console.Write("\n\n");
            Console.Write("Calculate Monthly Rent:\n");
            Console.Write("----------------------------");
            Console.Write("\n\n");

            Console.Write("Input Desired Location :");
            houselocation = Console.ReadLine();
            Console.Write("Input the name of the renter :");
            name = Console.ReadLine();
            Console.Write("Input the Square Footage of the Property : ");
            squarefootage = Convert.ToInt32(Console.ReadLine());
            if (squarefootage < 1000)
                costpersquarefoot = 1.20;
            else if (squarefootage >= 1001 && squarefootage < 2000)
                costpersquarefoot = 1.50;
            else if (squarefootage >= 2001 && squarefootage < 3000)
                costpersquarefoot = 1.80;
            else
                costpersquarefoot = 2.00;
            totalsqftcost = squarefootage * costpersquarefoot;
            if (totalsqftcost > 300)
                utilities = totalsqftcost * 15 / 100.0;
            total = totalsqftcost + utilities;
            if (total < 100)
                total = 100;
            Console.Write("\nMonthly Rent\n");
            Console.Write("Location                            :{0}\n", houselocation);
            Console.Write("Renter Name                         :{0}\n", name);
            Console.Write("Square Footage                      :{0}\n", squarefootage);
            Console.Write("Cost From Square Footage            :{1}\n", costpersquarefoot, totalsqftcost);
            Console.Write("Utilities per month                 :{0}\n", utilities);
            Console.Write("Monthly Rent                        :{0}\n", total);

            DisplayContinuePrompt();
            Console.Clear();

            DisplayScreenHeader("Thanks for using my rent calculator!");
            DisplayContinuePrompt();
        }
        static void DisplayScreenHeader(string headerText)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t" + headerText);
            Console.WriteLine();
        }
        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
        static void DisplayWelcomeScreen()
        {
            

            Console.WriteLine();
            Console.WriteLine("Welcome to the Rent Calculator!");
            Console.WriteLine();
            Console.WriteLine("This app will calculate your rent based off utilities and square footage combined");
            Console.WriteLine("Utilities are determined by the total square footage");
            DisplayContinuePrompt();
            Console.Clear();
        }
    }
}
