internal class Program
{
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

        int correctNumber = 7;
        int guestNumber = 0;

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
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You WON!");
                }

                Console.ResetColor();
                Console.WriteLine();
            }


        } while (guestNumber != correctNumber);

        Console.ReadLine();
    }
}