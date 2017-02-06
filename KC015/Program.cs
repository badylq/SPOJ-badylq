using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KC015
{
	class Program
	{
		static bool Sprawdz(string small, string big, byte dzialanie) //0- rowne 1 - nie rowne, 2 - mniejsza/wieksza
		{
			if (small.Length == big.Length)
			{
				bool smallBigger = false;
				bool bigBigger = false;

				for (int i = 0; i < small.Length; i++)
				{
					if(small[i] == big[i])
						continue;
					if (small[i] > big[i])
					{
						smallBigger = true;
						break;
					}
						bigBigger = true;
						break;
				}
				if (smallBigger && dzialanie == 1 )
					return true;
				if (bigBigger && dzialanie != 0)
					return true;
			}
			else
			{
				if (dzialanie == 0)
					return false;
				if (small.Length < big.Length || dzialanie == 1)
					return true;

			}
			return false;
		}
		static void Main(string[] args)
		{
			string inp = Console.ReadLine();
			while (!String.IsNullOrWhiteSpace(inp))
			{
				string[] inpt = inp.Split(' ');
				bool wyn = false;
				switch (inpt[1][0])
				{
					case '=':
						wyn = Sprawdz(inpt[0], inpt[2], 0);
						break;
					case '!':
						wyn = Sprawdz(inpt[0], inpt[2], 1);
						break;
					case '<':
						wyn = Sprawdz(inpt[0], inpt[2], 2);
						break;
					default:
						wyn = Sprawdz(inpt[2], inpt[0], 2);
						break;
				}
				Console.WriteLine(wyn ? "1" : "0");
				inp = Console.ReadLine();
			}
		}
	}
}
