namespace BreakPassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = "745";
            string guessPassword = TypePassword();
            while (guessPassword != password)
            {
                string padLock=Visualise(guessPassword,password);
                Console.WriteLine(padLock);
                guessPassword = TypePassword();
            }

            Console.WriteLine("The password is correct!");
        }

        private static string Visualise(string guessPassword, string password)
        {
            char[] padLock = new char[3];
            for (int i = 0; i < password.Length; i++)
            {
                if (guessPassword[i] == password[i])
                    padLock[i] = guessPassword[i];
                else if (password.Contains(guessPassword[i].ToString()))
                    padLock[i] = '?';
                else
                    padLock[i] = 'X';
            }
            return new string(padLock);
        }

        private static string TypePassword()
        {
            Console.WriteLine("Guess the password (please enter 3 numbers)");
            string guess = Console.ReadLine();
            while(guess.Length!=3 || !int.TryParse(guess,out _))
            {
                Console.WriteLine("Invalid input!");
                Console.WriteLine("Guess the password (please enter 3 numbers)");

                guess = Console.ReadLine();
            }

            return guess;
        }
    }
}