namespace Oppgave315A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var number = random.Next(1, 10); // Picks a number between 1-100 for you to guess!
            var attempts = 0; //How many times you used to guess the number.
            var myGuess = 0; //The number I have guessed.

            Console.WriteLine("Hei\nVelkommen til gjetteleken!");
            do
            { 
                Console.Write("Gjett et tall fra 1 til 10: ");
                myGuess = Convert.ToInt32(Console.ReadLine());
                attempts++;

                if (myGuess == number)
                {
                    Console.WriteLine($"Du gjettet riktig. Du har brukt {attempts} forsøk!"); // ("Du har brukt {0} forsøk!",attempts)
                } else if (myGuess < number)
                {
                    Console.WriteLine("Feil!,tallet er høyere!");
                }
                else
                {
                    Console.WriteLine("Feil,tallet er lavere!");
                }

            } while (myGuess != number);

            Console.ReadLine();

        }
    }
}
