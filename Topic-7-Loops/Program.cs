namespace Topic_7_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
                string guess;
                int coinSide;
                int heads = 1;
                int tails = 2;
                string quit;
                Random generator = new Random();
                double score = 3;
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
            while (true)
            {
                coinSide = generator.Next(1, 3);
                Console.WriteLine("Now. Heads or Tails?");
                guess = Console.ReadLine();
                Console.Clear();
                if (coinSide == heads)
                {
                    Console.WriteLine("The coin was heads!");
                    if (guess.ToUpper() == "HEADS"||guess.ToUpper() =="H")
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
                else if (coinSide == tails)
                {
                    Console.WriteLine("The coin was tails!");
                    if (guess.ToUpper() == "TAILS"|| guess.ToUpper() == "T")
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
                //else if (coinSide == 3)
                {

                }
                //Console.Clear();
                Console.WriteLine("Your score is now: " + score);
        }   }
    }
}
