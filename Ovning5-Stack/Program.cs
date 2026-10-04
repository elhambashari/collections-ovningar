Stack<string> texter = new Stack<string>();

while (true)
{
    Console.WriteLine("\n--- Text och Ångra ---");
    Console.WriteLine("1. Lägg till text");
    Console.WriteLine("2. Ångra senaste inmatningen");
    Console.WriteLine("3. Visa aktuell text");
    Console.WriteLine("4. Avsluta");

    Console.Write("Välj ett alternativ: ");
    string val = Console.ReadLine()!;

    // Alternativ 1 - Lägg till text
    if (val == "1")
    {
        Console.Write("Skriv text: ");
        string text = Console.ReadLine()!;

        texter.Push(text);

        Console.WriteLine("Texten har lagts till!");
    }

    // Alternativ 2 - Ångra senaste inmatningen
    if (val == "2")
    {
        if (texter.Count > 0)
        {
            string borttagenText = texter.Pop();

            Console.WriteLine($"Ångrade: {borttagenText}");
        }
        else
        {
            Console.WriteLine("Det finns ingen text att ångra.");
        }
    }

    // Alternativ 3 - Visa aktuell text
    if (val == "3")
    {
        if (texter.Count > 0)
        {
            Console.WriteLine("\n--- Aktuell text ---");

            foreach (string text in texter)
            {
                Console.WriteLine(text);
            }
        }
        else
        {
            Console.WriteLine("Det finns ingen text.");
        }
    }

    // Alternativ 4 - Avsluta
    if (val == "4")
    {
        break;
    }
}