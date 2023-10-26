using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nepesseg
{
    class Program
    {
        static void Main()
        {
            var orszagok = new List<Orszag>();

            using var sr = new StreamReader(@"..\..\..\src\adatok-utf8.txt", Encoding.UTF8);
            _ = sr.ReadLine();

            while (!sr.EndOfStream)
            {
                orszagok.Add(new(sr.ReadLine()!));
            }
            Console.WriteLine($"3. feladat \n{orszagok.Count} ország adatait tartalmazza.");
            Console.WriteLine("4. feladat");
            var kina = orszagok.Single(d => d.Orszagnev == "Kína").Nepsuruseg;
            Console.WriteLine($"Kína népsűrűsége: {kina}/km^2");
            Console.WriteLine("5. feladat");
            var f5 = orszagok.Single(d => d.Orszagnev == "Kína").Nepesseg - orszagok.Single(d => d.Orszagnev == "India").Nepesseg;
            Console.WriteLine($"Kínában a lakosság {f5} fővel volt több.");
            Console.WriteLine("6. feladat");
            var f6 = orszagok.OrderByDescending(d => d.Nepesseg).ToList()[2];
            Console.WriteLine($"A harmadik legnépesebb ország: {f6}, a lakosság {} fő.");
            Console.WriteLine("7. feladat");
            Console.WriteLine(" A következő országok több, mint 30%-a a fővárosban lakik:");
            foreach (var o in  orszagok)
            {
                if (o.Koncetralt) Console.WriteLine($"\t {o.Orszagnev} ({o.Fovaros})");
            }

        }
    }
}
