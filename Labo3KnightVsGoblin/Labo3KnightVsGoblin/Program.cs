Random randomNumberGenerator = new Random();


int knightHealth;
Console.WriteLine("Enter the knight's health: ");
string input = Console.ReadLine();

bool isValidNumber = int.TryParse(input, out knightHealth);
if (isValidNumber = true)
{
    if (knightHealth <= 0 || knightHealth > 100)
    {
        //Ongeldige waarde ingegeven, standaard waarde 100 gebruiken:
        Console.WriteLine("Number must be between 0 an 100, default value 100 is used.");
        knightHealth = 100;
    }
}
else
{
    //Ongeldig iets ingegeven, standaard waarde 100 gebruiken:
    Console.WriteLine("Number must be between 0 and 100, ");
    knightHealth = 100;
} 
int goblinHealth = randomNumberGenerator.Next(1, 101);


Console.WriteLine($"Knight health: {knightHealth}");
Console.WriteLine($"Goblin health: {goblinHealth}");
Console.WriteLine();

//for (int attempt = 1; attempt <= 4; attempt++)
do
{


    //Hier start de game.
    Console.WriteLine("Available actions:");
    Console.WriteLine("1. Attack");
    Console.WriteLine("2. Heal");
    Console.WriteLine("Please select an action: ");
    string action = Console.ReadLine();

    int knightAttack = 10;
    int goblinAttack = 5;

    switch (action)
    {
        case "1":
            goblinHealth -= knightAttack;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"The knight used ATTACK and struck the goblin for {knightAttack} damage!");
            Console.ResetColor();
            break;
        case "2":
            knightHealth += 10;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("The knight used HEAL and restored some health.");
            Console.ResetColor();
            break;
        
        default:
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("This is not a valid action");
            Console.ResetColor();
            break;
    }

    knightHealth -= goblinAttack;
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("The goblin trew a pumpkinbomb.");
    Console.ResetColor();

    if (knightHealth <= 0)
    {
        Console.WriteLine("The knight has died.");
    }
    else
    {
        Console.WriteLine($"The knight is still standing {knightHealth}");
    }
    if (goblinHealth <= 0)
    {
        Console.WriteLine("The goblin has been slayed.");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"The goblin has survived. {goblinHealth}");
        Console.ResetColor();
    }
}while (knightHealth > 0 && goblinHealth > 0);







/* 
 * Deel 1
 * 
 * We gaan een applicatie maken waarin de speler als ridder tegen een goblin moet vechten.
 * We starten met een controle te implementeren die kijkt of de speler nog leeft.
 *  - Declareer en initialiseer een waarde knightHealth (0) en goblinHealth (20).
 *  - Indien de levenspunten van de speler (knightHealth) kleiner of gelijk zijn aan nul,
 *    dan toon je aan de speler dat hij/zij is gestorven. 
 *  - Doe hetzelfde voor de goblin.
 *  - Extra: gebruik de Random klasse om de levenspuntenvan de ridder en goblin in te stellen.
 */

/* 
 * Deel 2
 * 
 * - Indien de speler niet gestorven is, dan druk je af hoeveel levenspunten (knightHealth) 
 *   speler nog heeft. Gebruik hier else voor.
 * - Laat de speler zelf levenspunten ingeven voor de ridder (knightHealth). Zo kiest elke speler 
 *   zelf hoe moeilijk het gevecht is. 
 * - De waarde knightHealth moeten tussen 0 en 100. Indien de speler een ongeldige waarde ingeeft, 
 *   dan wordt de standaard waarde 100 gebruikt.
 *    - Extra: gebruik TryParse om de input van de speler te verwerken, 
 *      zodat het programma niet zal crashen.
 */

/*
 * Deel 3
 * 
 * Declareer en initialiseer een aanvalswaarde voor de ridder, attackKnight (10), 
 * en de goblin, attackGoblin (5).
 * Laat de speler een actie selecteren door een getal in te geven. Gebruik een switch:
 *  - Als ik als speler actie 1 kies, dan val ik aan en wordt attackKnight afgetrokken van 
 *    goblinHealth. Beschrijf in de output wat er gebeurt.
 *  - Als ik als speler actie 2 kies, dan genees ik mezelf 10 levenspunten. Beschrijf in de 
 *    output wat er gebeurt.
 *  - Als de speler een ongeldige actie ingeeft, dan weergeef je dit in de output.
 *  - Extra: voeg extra acties toe die de speler kan kiezen.
 *  - Extra: zorg er voor dat de goblin ook een actie neemt.
 */

/*
 * Deel 4
 * 
 * Gebruik een for lus, zodat de speler exact 4 keer een actie kan selecteren.
 */

/*
 * Deel 5
 * 
 * Vervang de for lus door een while lus die vraagt aan de speler om een actie 
 * uit te voeren zolang als de ridder of goblin nog leeft.
 * 
 * Extra: zorg er voor dat de goblin ook een actie neemt.
 */
