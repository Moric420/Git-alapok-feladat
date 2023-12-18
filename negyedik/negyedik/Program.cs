using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negyedik
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> szamok = new List<int>();

			Console.WriteLine("Adjon meg számokat a listához! (0 a befejezéshez)");

			while (true)
			{
				Console.Write("Kérem adjon meg egy számot: ");
				string input = Console.ReadLine();

				if (int.TryParse(input, out int szam))
				{
					if (szam == 0)
						break;

					szamok.Add(szam);
				}
				else
				{
					Console.WriteLine("Érvénytelen bemenet! Kérem csak számokat adjon meg.");
				}
			}

			// Ellenőrizzük, hogy van-e szám a listában, mielőtt a Minimum metódust használnánk
			if (szamok.Any())
			{
				// Használjuk a Min metódust a legkisebb elem kiválasztásához
				int legkisebbElem = szamok.Min();

				Console.WriteLine($"A legkisebb elem a listában: {legkisebbElem}");
			}
			else
			{
				Console.WriteLine("Nincs megadott szám a listában.");
			}

			Console.ReadLine();
		}
	}
}
