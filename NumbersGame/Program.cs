using System.ComponentModel;
//Christian Rapp
//SUT 23
namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(1, 20);
            int tries = 0;
            bool gameO = false;

            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");

            while (!gameO && tries < 5)
            {
                Console.WriteLine("Ange din gissing");

                if (int.TryParse(Console.ReadLine(), out int guess))
                {
                    tries++;
                    string result = CheckGuess(guess, number);

                    Console.WriteLine(result);

                    if (result == "Woho! Du gjorde det!")
                    {
                        gameO = true;
                    }

                    if (tries == 5)
                    {
                        Console.WriteLine("Tyvärr du lyckades inte gissa talet på fem försök");
                    }
                }
                else
                {
                    Console.WriteLine("Ogiltig inmatning. Var god ange ett heltal.");
                }
            }
        }

        static string CheckGuess(int guess, int number)
        {
            if (guess < number)
            {
                return "Tyvärr du gissade för lågt!";
            }
            else if (guess > number)
            {
                return "Tyvärr du gissade för högt!";
            }
            else
            {
                return "Woho! Du gjorde det!";






            }


        }

    }

}
                    











