using System;

namespace BFN1
{
	class Program
	{
		private static string ConvertNumber(string number)
		{
			char[] charArray = number.ToCharArray();
			Array.Reverse(charArray);
			return new string(charArray);
		}

		static void Main(string[] args)
		{
			int t, NumberOfAdditions;
			string n;
			bool isPalindrom;
			t = int.Parse(Console.ReadLine());
			for (int i = 0; i < t; i++)
			{
				NumberOfAdditions = 0;
				isPalindrom = false;
				n = Console.ReadLine();
				while (!isPalindrom)
				{
					int numberOfDigitsToCheck = n.Length/2;
					int pal = 0;
					for (int j = 0; j < numberOfDigitsToCheck; j++)
					{
						if (n[j] != n[n.Length - j - 1])
							++pal;
					}
					if (pal == 0)
						isPalindrom = true;
					else
					{
						NumberOfAdditions++;
						int number = int.Parse(n) + int.Parse(ConvertNumber(n));
						n = number.ToString();
					}
				}
				Console.WriteLine(n + " " + NumberOfAdditions);
			}
		}
	}
}
