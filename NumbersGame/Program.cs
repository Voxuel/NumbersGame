using System;

namespace NumbersGame
{
    class Program
    {
        // Leo F SUT22
        static void Main(string[] args)
        {
            bool isRunning = true;
            int input = 0;
            Random rnd = new Random();
            // Runs program inside a while-loop to make it possible to restart.
            while (isRunning)
            {
                // Using the Next-method to limit the random number between 1-20.
                int random = rnd.Next(0,21);
                Console.WriteLine("Välkommen! Jag tänker på ett nummer mellan 1-20, Kan du gissa vilket? Du har fem försök...");

                // Let's user guess the number up to five times and checks if the method returns true.
                for (int i = 0; i < 5; i++)
                {
                    input = int.Parse(Console.ReadLine());
                    if(CheckGuess(random,input) == true)
                    {
                        break;
                    }
                }
                // If the user didn't answer correctly after five tries the following prints.
                if(random != input)
                {
                    Console.WriteLine("Tyvärr, Du lyckades inte gissa nummret på fem försök");
                }

                // Ask if restart is wanted. using continue to jump to the top of the while-loop.
                Console.WriteLine("Starta om? [1]Ja!, Skriv 1 och sen enter annars tryck enter för att avsluta.");
                int.TryParse(Console.ReadLine(), out int answer);
                if (answer == 1)
                {
                    Console.Clear();
                    continue;
                }
                isRunning = false;
            }



        }
        // Method to test the in data of x and y from main against each other and returns true or falls.
        static bool CheckGuess(int x, int y)
        {
            if (x == y)
            {
                Console.WriteLine("Woho! Du gjorde de!");
                return true;
            }
            else if (y < x)
            {
                Console.WriteLine("Tyvärr, Du gissade för lågt!");
                return false;
            }
            else if (y > x)
            {
                Console.WriteLine("Tyvärr, Du gissade för högt!");
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}
