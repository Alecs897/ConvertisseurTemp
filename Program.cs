namespace convertisseur_temp;

class Program
{
    static void Main(string[] args)
    {
        // Créez un programme sur console qui converti une température rentrée par l’utilisateur dans l’unité de son choix.
        // Deux sens de conversion doivent être possibles : soit de degrés Celsius vers Fahrenheit, soit de degrés Fahrenheit vers Celsius.

        //1°C = 33.8°F

        Console.WriteLine("=== Convertisseur de températures ===");
        Console.WriteLine("1 : De Celsius à Fahrenheit; 2 : De Fahrenheit à Celsius ");
        int choix = Convert.ToInt32(Console.ReadLine());

        //Formule de °C à °F :  (0°C × 9/5) + 32 = 32°F 
        //Formule de °F à °C: (32°F - 32) × 5 / 9 = 0°C

        if (choix == 1)
        {
            Console.WriteLine("Entrez une température en degrés Celsius, sans préciser l'unité :");
            int reponse = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Votre température vaut : " + (reponse * 9 / 5) + 32 + "°F");

        }
        else if (choix == 2)
        {
            Console.WriteLine("Entrez une température en degrés Fahrenheit, sans préciser l'unité :");
            int reponse = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Votre température vaut : " + (reponse - 32) * 5 / 9 + "°C");

        }
        else (choix != 1 || choix != 2)
        {
            Console.WriteLine("Votre choix ne correspond pas, réessayez.");
        }

        Console.WriteLine("Merci d'avoir utilisé notre convertisseur.");
    }

}