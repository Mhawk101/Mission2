using System;
using System.Threading.Tasks;


internal class Program
{
    private static void Main(string[] args)
    {
        //print welcome messages

        System.Console.WriteLine("Welcome to the dice throwing simulator!");
        System.Console.WriteLine("How many rolls would you like to simulate? ");

        //get the number of rolls from the user then convert it to an integer
        string nRolls = System.Console.ReadLine();
        int number = int.Parse(nRolls);


        //run the DiceSimulator.RunSimulation method
        DiceSimulator simulator = new DiceSimulator();
        int[] totals = simulator.RunSimulation(number);

        // Print results histogram
        System.Console.WriteLine();
        System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        System.Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        System.Console.WriteLine("Total Number of Rolls: " + number);
        System.Console.WriteLine();

        decimal percent2 = ((decimal)totals[2] / number) * 100;
        decimal percent3 = ((decimal)totals[3] / number) * 100;
        decimal percent4 = ((decimal)totals[4] / number) * 100;
        decimal percent5 = ((decimal)totals[5] / number) * 100;
        decimal percent6 = ((decimal)totals[6] / number) * 100;
        decimal percent7 = ((decimal)totals[7] / number) * 100;
        decimal percent8 = ((decimal)totals[8] / number) * 100;
        decimal percent9 = ((decimal)totals[9] / number) * 100;
        decimal percent10 = ((decimal)totals[10] / number) * 100;
        decimal percent11 = ((decimal)totals[11] / number) * 100;
        decimal percent12 = ((decimal)totals[12] / number) * 100;

        System.Console.WriteLine(" 2: " + new string('*', (int)percent2));
        System.Console.WriteLine(" 3: " + new string('*', (int)percent3));
        System.Console.WriteLine(" 4: " + new string('*', (int)percent4));
        System.Console.WriteLine(" 5: " + new string('*', (int)percent5));
        System.Console.WriteLine(" 6: " + new string('*', (int)percent6));
        System.Console.WriteLine(" 7: " + new string('*', (int)percent7));
        System.Console.WriteLine(" 8: " + new string('*', (int)percent8));
        System.Console.WriteLine(" 9: " + new string('*', (int)percent9));
        System.Console.WriteLine("10: " + new string('*', (int)percent10));
        System.Console.WriteLine("11: " + new string('*', (int)percent11));
        System.Console.WriteLine("12: " + new string('*', (int)percent12));

        //Print thank you
        System.Console.WriteLine();
        System.Console.WriteLine("Thank you for using the dice throwing simulator.  Goodbye!");
    }
}



internal class DiceSimulator
{
    //define the method so it retuns an array
    public int[] RunSimulation(int number)

    {
        //create teh array
        int[] totals = new int[13];

        //keep track of number of rolls starting it at 0
        int totalrolls = 0;

        //generate random number
        Random rng = new Random();

        //loop through the number of dice rolls input
        for (int i = 0; i < number; i++)
        {

            int dice1 = rng.Next(1, 7);
            int dice2 = rng.Next(1, 7);

            //add the two random rolls together
            int total = dice1 + dice2;

            //incriment the rolls counter
            totalrolls = totalrolls + 1;
            
            //update the array
            totals[total]++;

        }

        //return the array
        return totals;

    }
}
    