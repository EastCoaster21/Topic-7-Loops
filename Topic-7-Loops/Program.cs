namespace Topic_7_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string guess;
            string upside;
            int coinSide;
            int heads = 1;
            int tails = 2;
            string quit;
            Random generator = new Random();
            int score = 3;
            Console.WriteLine("Welcome to the coin flip game!");
            Console.WriteLine("(Press Enter to Continue:)");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("The rules of this game are simple:");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Choose heads or tails");
            Console.WriteLine();
            Console.WriteLine("If you're right, you get a point. If you're wrong, you lose a point.");
            Console.WriteLine();
            Console.WriteLine("You start with 3 points and lose when you run out.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Pretty easy right? Thought so.");
            Console.ReadLine();
            Console.Clear();
            while (score > 0)
            {
                coinSide = generator.Next(1, 3);
                Console.Write("You have " + score);
                Console.WriteLine(" points.");
                Console.WriteLine("Now. Heads or Tails? (Or Quit)");
                guess = Console.ReadLine();
                Console.Clear();
                if (guess == "quit")
                {
                    Console.WriteLine("Thanks for playing!");
                    Console.Write("You finished with " + score);
                    Console.WriteLine(" points.");
                    break;
                }
                if (guess != "heads" && guess != "tails")
                {
                    Console.WriteLine("Invalid choice. Please enter heads, tails, or quit.");
                    Console.WriteLine();
                    if (coinSide == 1)
                    {
                        upside = "heads";
                        Console.WriteLine("The coin was heads!");
                    }
                    else 
                    {
                        upside = "tails";
                        Console.WriteLine("The coin was tails!");
                    }
                }
                else if (coinSide == 2)
                {
                   Console.WriteLine("The coin was tails!");
                   if (guess.ToUpper() == "TAILS" || guess.ToUpper() == "T")
                   {
                      score++;
                      Console.WriteLine("Congratulations! You were right.");
                   }
                   else
                   {
                      score--;
                      Console.WriteLine("You got it wrong, sorry.");
                   }
                }
            }
            if (score == 0)
            {
                Console.WriteLine("Game over! You ran out of points.");
                Console.WriteLine("Better luck next time.");
            }
        }
    }
}
