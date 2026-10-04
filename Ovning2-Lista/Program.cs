List<Bok> bocker = new List<Bok>();

while (true)
{
    Console.WriteLine("\n--- Boksamling ---");
    Console.WriteLine("1. Lägg till en bok");
    Console.WriteLine("2. Visa alla böcker");
    Console.WriteLine("3. Sök efter en bok");
    Console.WriteLine("4. Avsluta");

    Console.Write("Välj ett alternativ: ");
    string val = Console.ReadLine()!;

    // Alternativ 1 - Lägg till en bok
    if (val == "1")
    {
        Console.Write("Ange titel: ");
        string titel = Console.ReadLine()!;

        Console.Write("Ange författare: ");
        string forfattare = Console.ReadLine()!;

        Console.Write("Ange publiceringsår: ");
        int ar = int.Parse(Console.ReadLine()!);

        Bok nyBok = new Bok();

        nyBok.Titel = titel;
        nyBok.Forfattare = forfattare;
        nyBok.YearPublished = ar;

        bocker.Add(nyBok);

        Console.WriteLine("Boken har lagts till!");
    }

    // Alternativ 2 - Visa alla böcker
    if (val == "2")
    {
        Console.WriteLine("\n--- Alla böcker ---");

        foreach (Bok bok in bocker)
        {
            Console.WriteLine($"Titel: {bok.Titel}");
            Console.WriteLine($"Författare: {bok.Forfattare}");
            Console.WriteLine($"Publiceringsår: {bok.YearPublished}");
            Console.WriteLine();
        }
    }

    // Alternativ 3 - Sök efter en bok
    if (val == "3")
    {
        Console.Write("Ange titel att söka efter: ");
        string sokTitel = Console.ReadLine()!;

        foreach (Bok bok in bocker)
        {
            if (bok.Titel.ToLower() == sokTitel.ToLower())
            {
                Console.WriteLine("\nBoken hittades!");
                Console.WriteLine($"Titel: {bok.Titel}");
                Console.WriteLine($"Författare: {bok.Forfattare}");
                Console.WriteLine($"Publiceringsår: {bok.YearPublished}");
            }
        }
    }

    // Alternativ 4 - Avsluta
    if (val == "4")
    {
        break;
    }
}