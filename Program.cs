namespace PremierProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int nombre_secret = rand.Next(1, 101);
            int nb_essai = 0;
            int propal;

            Console.WriteLine("Je pense à un nombre entre 1 et 100 !");
            Console.WriteLine("Essaie de le deviner :");

            while (true)
            {
                string input = Console.ReadLine();
                if (!int.TryParse(input, out propal))
                {
                    Console.WriteLine("Erreur : tu dois rentrer un nombre ! Essaie encore :");
                    continue;
                }

                nb_essai++;

                if (propal == nombre_secret)
                {
                    Console.WriteLine($"Bravo ! {nombre_secret} était le bon nombre ! Tu as trouvé en {nb_essai} essai(s).");
                    break;
                }
                else if (propal > nombre_secret)
                {
                    Console.WriteLine($"{propal} est trop grand ! Essaie encore :");
                }
                else
                {
                    Console.WriteLine($"{propal} est trop petit ! Essaie encore :");
                }
            }
        }
    }
}