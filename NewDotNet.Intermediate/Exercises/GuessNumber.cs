using System.Globalization;

namespace NewDotNet.Intermediate.Exercises;

public class GuessNumber
{
    public void Guess()
    {
        Random random = new Random();
        int winningNumber = random.Next(1, 50);

        bool win = false;

        string? a = Console.ReadLine();
        do
        {
            Console.WriteLine("Guess a number in between 0 and 50");
            int i = int.Parse(a);

            if (i > winningNumber)
            {
                Console.WriteLine("Too high,  try again");
            }
            else if (i < winningNumber)
            {
                Console.WriteLine("Too low, try again");
            }

            else if (i == winningNumber)
            {
                Console.WriteLine("You won🤗");
                win = true;
            }
        } while (!win);
        
        Console.WriteLine("Thank you for playing!"); 
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey(true);
    }
}