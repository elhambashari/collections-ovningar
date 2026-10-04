Console.Write("Hur många tal vill du lagra? ");
int antal = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Du vill lagra {antal} tal.");

int[] tal = new int[antal];

for (int i = 0; i < tal.Length; i++)
{
    Console.Write($"Ange tal {i + 1}: ");
    tal[i] = int.Parse(Console.ReadLine()!);
}

Console.WriteLine("\nTalen du matade in:");

for (int i = 0; i < tal.Length; i++)
{
    Console.WriteLine(tal[i]);
}

int summa = 0;

for (int i = 0; i < tal.Length; i++)
{
    summa += tal[i];
}

double medelvarde = (double)summa / tal.Length;

Console.WriteLine($"Summa: {summa}");
Console.WriteLine($"Medelvärde: {medelvarde}");