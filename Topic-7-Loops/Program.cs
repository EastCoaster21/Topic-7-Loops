namespace Topic_7_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int answer;
            string heads;
            string tails;
            string quit;
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
            Console.WriteLine("Now. Heads or Tails?");
            Console.WriteLine();
            Console.WriteLine("1.Heads");
            Console.WriteLine("2.Tails");
            Console.WriteLine("3.quit");
            answer = Convert.ToInt32(Console.ReadLine());
            if (answer == 1)
            {

            }
            else if (answer == 2)
            {
                
            }
            else if (answer == 3)
            {
                
            }
        }
    }
}
