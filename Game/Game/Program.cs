internal class Program
{
    static public void game(string userName)
    {

        Console.WriteLine("Enter the number between 1-10");
        Console.WriteLine();


        int guestNumber = 0;
        string playAgain = "Y";

        Random random = new Random();

        int correctNumber = random.Next(1, 10);

        Console.WriteLine(correctNumber);


        do
        {
            Console.Write("Enter the your guest number: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out guestNumber))
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Please enter the integer number.");
                Console.ResetColor();
                Console.WriteLine();
            }
            else
            {
                guestNumber = Int32.Parse(input);

                if (guestNumber != correctNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong number, Please try again!");
                }
                else
                {
                    while (playAgain != "N")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("{0},You WON!", userName);

                        Console.Write("Play Again? [Y or N] ");
                        playAgain = Console.ReadLine().ToUpper();
                        Console.WriteLine();

                        if (playAgain == "Y")
                        {
                            game(userName);
                        }
                        if (playAgain == "N")
                        {
                            return;
                        }

                        Console.ResetColor();
                    }
                }

                Console.ResetColor();
                Console.WriteLine();
            }

        } while (guestNumber != correctNumber);

        Console.ReadLine();
    }


    private static void Main(string[] args)
    {

        string appName = "Number Guesser";
        string appVersion = "1.0.0";
        string appAuthor = "Viraj Sandakleum";

        Console.ForegroundColor = ConsoleColor.Cyan;

        Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
        Console.WriteLine();

        Console.ResetColor();

        Console.Write("What is your name? ");
        string userName = Console.ReadLine();

        Console.WriteLine("Hello {0}, Let's play a game...", userName);
        Console.WriteLine();

        game(userName);
    }


}