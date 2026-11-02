namespace Topic_7_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
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
                coinSide = generator.Next(1, 3);
                Console.WriteLine("Now. Heads or Tails?");
                guess = Console.ReadLine();
                Console.Clear();
                Console.WriteLine();
                if (coinSide == heads)
                {
                    Console.WriteLine("The coin was heads!");
                    //if (guess = coinSide)
                    {
                        score++;
                        Console.WriteLine("Congratulations! You were right.");
                    }

                }
                else if (coinSide == tails)
                {
                    Console.WriteLine("The coin was tails!");
                    //if (guess = coinSide)
                    {
                        score++;
                        Console.WriteLine("Congratulations! You were right.");
                    }
                }
                //else if (coinSide == 3)
                {

                }
                Console.WriteLine("Your score is now: " + score);
            
        }   }
    }
}
