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
            Console.WriteLine("(Press Enter to Continue)");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("The rules of this game are simple:");
            Console.WriteLine("(Press Enter to Continue)");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Choose heads or tails");
            Console.WriteLine();
            Console.WriteLine("If you're right, you get a point. If you're wrong, you lose a point.");
            Console.WriteLine("(Press Enter to Continue)");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You start with 3 points and lose when you run out.");
            Console.WriteLine();
            Console.WriteLine("Pretty easy right? Thought so.");
            Console.WriteLine("(Press Enter to Continue)");
            Console.ReadLine();
            Console.Clear();
            while (score > 0)
            {
                coinSide = generator.Next(1, 3);
                Console.Write("You have " + score);
                Console.WriteLine(" points.");
                Console.WriteLine("Now. Heads or Tails? (Or Quit)");
                guess = Console.ReadLine();
                if (guess.ToUpper() == "QUIT"|| guess.ToUpper() == "Q")
                {
                    Console.WriteLine("Thanks for playing!");
                    Console.Write("You finished with " + score);
                    Console.WriteLine(" points.");
                    Console.WriteLine("See you next time.");
                    break;
                }
                if (guess.ToUpper() != "HEADS" && guess.ToUpper() != "H" && guess.ToUpper() != "TAILS" && guess.ToUpper() != "T")
                {
                    Console.WriteLine("Invalid choice. Please enter heads, tails, or quit.");
                }
                else
                {
                    Console.WriteLine();
                    if (coinSide == 1 && (guess.ToUpper() == "HEADS" || guess.ToUpper() == "H"))
                    {
                        upside = "heads";
                        Console.WriteLine("               ,,===\"\"\"\"\"\"\"===,,\r\n           ,==\"\"' |\\ |   /\\   `\"\"==,\r\n        ,=\"'|\\    | \\|  /__\\   /\\  `\"=,\r\n      /\"    |,\"\\  |  | /'  `\\ /  )     \"\\\r\n    /\"  ,\"  |                 `\\/    /|  \"\\\r\n   /'  |   ,                       /\",|   `\\\r\n  /'   \",/\"                           |    `\\\r\n /'      I=I=I               ,d8ba,___      `\\\r\n/'     I=8=8=8=I_I_          88888P\"\"\"       `\\\r\n|   xXXXXXXXXXXXXXXXxIxx    ,888\"             |\r\n| ~XXXXXXXXXXXXXXX~-~-~-~-~ d888~-~-~-~-~-~-~ |\r\n| ~-~-~-~-~-~-~-~-,aad888ba,8888,-~-~-~-~-~-~ |\r\n| ~-~-~-~-~-~-,ad888888888888888b-~-~-~-~-~-~ |\r\n\\ ~-~-~-~-~,ad8888888888888888888-~-~-~-~-~-~ /\r\n`\\ -~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~- /'\r\n `\\ ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~,-,~~~~~ /'\r\n  `\\    /\"\\         1 9 9 4        \\ /\\    /'\r\n   `\\  \"\\,/'                   |\\   `\\ `  /'\r\n     \"\\      /\"\"\\   |    |     |,'\\     /\"\r\n       `\"=,_ \\__/   |__  |__   |    ,=\"'  \r\n          `\"\"=,__             __,=\"\"'     \r\n               ``\"\"=========\"\"''\r\n");
                        Console.WriteLine("The coin was heads! You were correct.");
                        score++;
                    }
                    else if (coinSide == 2 && (guess.ToUpper() == "TAILS" || guess.ToUpper() == "T"))
                    {
                        score++;
                        upside = "tails";
                        Console.WriteLine("        _.-'~~`~~'-._\r\n     .'`  B   E   R  `'.\r\n    / I               T \\\r\n  /`       .-'~\"-.       `\\\r\n ; L      / `-    \\      Y ;\r\n;        />  `.  -.|        ;\r\n|       /_     '-.__)       |\r\n|        |-  _.' \\ |        |\r\n;        `~~;     \\\\        ;\r\n ;  INGODWE /      \\\\)P    ;\r\n  \\  TRUST '.___.-'`\"     /\r\n   `\\                   /`\r\n     '._   1 9 9 7   _.'\r\n        `'-..,,,..-'`\r\n");
                        Console.WriteLine("The coin was tails! You were correct.");
                    }
                    else
                    {
                        Console.WriteLine("You got it wrong, pal.");
                        score--;
                    }
                }
                Console.WriteLine("Press ENTER to continue");
                Console.ReadLine();
                Console.Clear();

            }
            if (score == 0)
            {
                Console.WriteLine("Game over! You ran out of points.");
                Console.WriteLine("Better luck next time.");
            }
        }
    }
}
