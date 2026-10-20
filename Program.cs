namespace convertisseur_temp;

class Program
{
    static void Main(string[] args)
    {
        // Créez un programme sur console qui converti une température rentrée par l’utilisateur dans l’unité de son choix.
        // Deux sens de conversion doivent être possibles : soit de degrés Celsius vers Fahrenheit, soit de degrés Fahrenheit vers Celsius.
        
        // Étape 1 : on déclare les variables
        int choice;
        float userTemperature;
        float convertedTemperature;

        // Étape 2a : on donne du contexte à l'utilisateur
        Console.WriteLine("=== Convertisseur de températures ===");
        Console.WriteLine("1. De Celsius à Fahrenheit");
        Console.WriteLine("2. De Fahrenheit à Celsius");

        // Étape 2b : on demande à l'utilisateur le sens de conversion
        Console.Write("> Entrez votre choix (1 ou 2) : ");
        choice = Convert.ToInt32(Console.ReadLine());

        // En fonction du choix de l'utilisateur concernant le sens de conversion
        if (choice == 1)
        {
            // L'utilisateur veut une conversion de °C => °F

            Console.Write("> Entrez une température en degrés Celsius, sans préciser l'unité (ex = 19,5) : ");
            userTemperature = Convert.ToSingle(Console.ReadLine());

            convertedTemperature = (userTemperature * 9.0f/5.0f) + 32.0f;

            Console.WriteLine("\nVotre température vaut " + convertedTemperature + "°F");

        }
        else if (choice == 2)
        {
            // L'utilisateur veut une conversion de °F => °C

            Console.Write("> Entrez une température en degrés Fahrenheit, sans préciser l'unité (ex = 19,5) : ");
            userTemperature = Convert.ToSingle(Console.ReadLine());

            convertedTemperature = (userTemperature - 32.0f) * 5.0f/9.0f;

            Console.WriteLine("\nVotre température vaut " + convertedTemperature + "°C");

        }
        else
        {
            // L'utilisateur s'est trompé
            Console.WriteLine("\nLe choix entré (" + choice + ") est un choix invalide. Merci d'insérer 1 ou 2.");
        }

        // Ce code va s'afficher sans être affecté par le bloc conditionnel ci-dessus
        Console.WriteLine("Merci d'avoir utilisé notre convertisseur.");
    }
}