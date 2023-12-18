using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otodik
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

			if (szamok.Any())
			{
				// Módosítottuk a Min-t Max-ra
				int legnagyobbElem = szamok.Max();

				Console.WriteLine($"A legnagyobb elem a listában: {legnagyobbElem}");
			}
			else
			{
				Console.WriteLine("Nincs megadott szám a listában.");
			}

			Console.ReadLine();
		}
	}
}
