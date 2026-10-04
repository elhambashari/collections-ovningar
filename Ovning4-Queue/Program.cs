Queue<string> uppgifter = new Queue<string>();

while (true)
{
    Console.WriteLine("\n--- Uppgiftshanterare ---");
    Console.WriteLine("1. Lägg till en uppgift");
    Console.WriteLine("2. Visa nästa uppgift");
    Console.WriteLine("3. Slutför en uppgift");
    Console.WriteLine("4. Visa alla uppgifter");
    Console.WriteLine("5. Avsluta");

    Console.Write("Välj ett alternativ: ");
    string val = Console.ReadLine()!;

    // Alternativ 1 - Lägg till en uppgift
    if (val == "1")
    {
        Console.Write("Skriv uppgiften: ");
        string uppgift = Console.ReadLine()!;

        uppgifter.Enqueue(uppgift);

        Console.WriteLine("Uppgiften har lagts till!");
    }

    // Alternativ 2 - Visa nästa uppgift
    if (val == "2")
    {
        if (uppgifter.Count > 0)
        {
            string nastaUppgift = uppgifter.Peek();

            Console.WriteLine($"Nästa uppgift är: {nastaUppgift}");
        }
        else
        {
            Console.WriteLine("Det finns inga uppgifter i kön.");
        }
    }

    // Alternativ 3 - Slutför en uppgift
    if (val == "3")
    {
        if (uppgifter.Count > 0)
        {
            string klarUppgift = uppgifter.Dequeue();

            Console.WriteLine($"Slutförd uppgift: {klarUppgift}");
        }
        else
        {
            Console.WriteLine("Det finns inga uppgifter att slutföra.");
        }
    }

    // Alternativ 4 - Visa alla uppgifter
    if (val == "4")
    {
        if (uppgifter.Count > 0)
        {
            Console.WriteLine("\n--- Återstående uppgifter ---");

            foreach (string uppgift in uppgifter)
            {
                Console.WriteLine(uppgift);
            }
        }
        else
        {
            Console.WriteLine("Det finns inga uppgifter i kön.");
        }
    }

    // Alternativ 5 - Avsluta
    if (val == "5")
    {
        break;
    }
}