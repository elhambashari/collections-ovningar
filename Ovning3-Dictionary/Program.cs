Dictionary<string, int> studentBetyg = new Dictionary<string, int>();

while (true)
{
    Console.WriteLine("\n--- Studentbetyg ---");
    Console.WriteLine("1. Lägg till elev och betyg");
    Console.WriteLine("2. Uppdatera betyg");
    Console.WriteLine("3. Visa alla elever och betyg");
    Console.WriteLine("4. Visa medelbetyg");
    Console.WriteLine("5. Avsluta");

    Console.Write("Välj ett alternativ: ");
    string val = Console.ReadLine()!;

    // Alternativ 1 - Lägg till elev och betyg
    if (val == "1")
    {
        Console.Write("Ange elevens namn: ");
        string namn = Console.ReadLine()!;

        Console.Write("Ange elevens betyg: ");
        int betyg = int.Parse(Console.ReadLine()!);

        if (studentBetyg.ContainsKey(namn))
        {
            Console.WriteLine("Eleven finns redan.");
        }
        else
        {
            studentBetyg.Add(namn, betyg);
            Console.WriteLine("Eleven och betyget har lagts till!");
        }
    }

    // Alternativ 2 - Uppdatera betyg
    if (val == "2")
    {
        Console.Write("Ange elevens namn: ");
        string namn = Console.ReadLine()!;

        if (studentBetyg.ContainsKey(namn))
        {
            Console.Write("Ange det nya betyget: ");
            int nyttBetyg = int.Parse(Console.ReadLine()!);

            studentBetyg[namn] = nyttBetyg;

            Console.WriteLine("Betyget har uppdaterats!");
        }
        else
        {
            Console.WriteLine("Eleven finns inte.");
        }
    }

    // Alternativ 3 - Visa alla elever och betyg
    if (val == "3")
    {
        Console.WriteLine("\n--- Alla elever ---");

        foreach (var elev in studentBetyg)
        {
            Console.WriteLine($"Namn: {elev.Key}, Betyg: {elev.Value}");
        }
    }

    // Alternativ 5 - Avsluta
    if (val == "5")
    {
        break;
    }
}