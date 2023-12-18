using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masodik
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

				// Ellenőrizzük, hogy a felhasználó valóban számot adott-e meg
				if (int.TryParse(input, out int szam))
				{
					// Ha 0-t adott meg, kilépünk a ciklusból
					if (szam == 0)
						break;

					// Hozzáadjuk a számot a listához
					szamok.Add(szam);
				}
				else
				{
					Console.WriteLine("Érvénytelen bemenet! Kérem csak számokat adjon meg.");
				}

				Console.ReadLine();
			}
		}
	}
}
