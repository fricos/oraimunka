using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        List<int> randomSzamok = GenerateRandomNumbers(random, 4);

        Console.WriteLine("Generált véletlen számok:");
        PrintNumbers(randomSzamok);

        List<int> bekertSzamok = GetUserInput(4);

        int talalatok = CompareNumbers(randomSzamok, bekertSzamok);
        Console.WriteLine($"Önnek {talalatok} találata volt.");

        if (talalatok == 4)
        {
            Console.WriteLine("Gratulálunk, Ön nyert!");
        }

        Console.Write("Szeretné folytatni a játékot? (Igen/Nem): ");
        string valasz = Console.ReadLine();

        if (valasz.Equals("Nem", StringComparison.OrdinalIgnoreCase))
        {
            SaveNumbersToFile(randomSzamok, bekertSzamok, "szamok.txt");
            Console.WriteLine("A számok el lettek mentve a szamok.txt fájlba.");
        }
    }

    static List<int> GenerateRandomNumbers(Random random, int count)
    {
        List<int> szamok = new List<int>();
        for (int i = 0; i < count; i++)
        {
            szamok.Add(random.Next(1, 101)); // Véletlen szám 1 és 100 között
        }
        return szamok;
    }

    static void PrintNumbers(List<int> szamok)
    {
        foreach (int szam in szamok)
        {
            Console.Write($"{szam} ");
        }
        Console.WriteLine();
    }

    static List<int> GetUserInput(int count)
    {
        List<int> bekertSzamok = new List<int>();
        Console.WriteLine($"\nKérem, adjon meg {count} számot:");

        for (int i = 0; i < count; i++)
        {
            Console.Write($"Szám {i + 1}: ");
            int bekertSzam = Convert.ToInt32(Console.ReadLine());
            bekertSzamok.Add(bekertSzam);
        }

        return bekertSzamok;
    }

    static int CompareNumbers(List<int> randomSzamok, List<int> bekertSzamok)
    {
        int talalatok = 0;
        for (int i = 0; i < randomSzamok.Count; i++)
        {
            if (randomSzamok[i] == bekertSzamok[i])
            {
                talalatok++;
            }
        }
        return talalatok;
    }

    static void SaveNumbersToFile(List<int> randomSzamok, List<int> bekertSzamok, string fileName)
    {
        using (StreamWriter sw = new StreamWriter(fileName))
        {
            sw.WriteLine("Generált számok:");
            sw.WriteLine(string.Join(" ", randomSzamok));
            sw.WriteLine("\nBekért számok:");
            sw.WriteLine(string.Join(" ", bekertSzamok));
        }
    }
}
