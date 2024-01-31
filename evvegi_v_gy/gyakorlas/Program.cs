using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string f = "C:\\Users\\Munkacsi\\Desktop\\C# es js\\gyakorlas\\gyakorlas\\bin\\Debug\\net7.0\\sorsolas.txt";

        List<string> lista = new List<string>();

        using (StreamReader r = new StreamReader(f))
        {
            string sor;
            while ((sor = r.ReadLine()) != null)
            {
                lista.Add(sor);
            }
        }

        int het;

        do
        {
            Console.Write("Kérem, adjon meg egy hetet (1 és 52 között): ");
        } while (!int.TryParse(Console.ReadLine(), out het) || het < 1 || het > 52);

        if (het - 1 < lista.Count)
        {
            string vsor = lista[het - 1];
            string[] szamok = vsor.Split(';');

            Console.WriteLine($"Nyerő számok a(z) {het}. héten: {string.Join(", ", szamok.Skip(1))}");
        }
        else
        {
            Console.WriteLine($"A(z) {het}. hét nem található a megadott tartományban.");
        }

        int öelof = 0; 
        int öparoselof = 0; 

        Dictionary<int, int> szamelof = new Dictionary<int, int>();

        foreach (var sor in lista)
        {
            var szamok = sor.Split(';').Skip(1).Select(int.Parse);

            foreach (var szam in szamok)
            {
                öelof++; 

                if (szam % 2 == 0)
                {
                    öparoselof++; 
                }

                if (szamelof.ContainsKey(szam))
                {
                    szamelof[szam]++;
                }
                else
                {
                    szamelof[szam] = 1;
                }
            }
        }

        int lkelof = szamelof.OrderBy(kv => kv.Value).FirstOrDefault().Key;

        int elof5 = szamelof.ContainsKey(5) ? szamelof[5] : 0;
        int elof46 = szamelof.ContainsKey(46) ? szamelof[46] : 0;

        List<int> kihuzottszamok = Enumerable.Range(1, 90).ToList();

        kihuzottszamok.Sort((a, b) => szamelof.GetValueOrDefault(b, 0).CompareTo(szamelof.GetValueOrDefault(a, 0)));

        Console.WriteLine($"Páros számok előfordulása: {öelof}");
        Console.WriteLine($"A legkevesebbszer húzott szám: {lkelof}");
        Console.WriteLine($"Az 5-ös szám előfordulása: {elof5}");
        Console.WriteLine($"A 46-os szám előfordulása: {elof46}");

        Console.WriteLine("Kihúzott számok sorrendben (legtöbbször húzottaktól a legkevesebbszer húzottakig):");
        foreach (var szam in kihuzottszamok)
        {
            Console.WriteLine($"Szám {szam}: {szamelof.GetValueOrDefault(szam, 0)} alkalom");
        }
    }
}
