using System;
using System.Text.RegularExpressions;

namespace KC010
{
	class Program
	{
		static void Main(string[] args)
		{
			string inp = Console.ReadLine();
			while (!String.IsNullOrWhiteSpace(inp))
			{
				int w = 0, n = 0, num = 0;

				string[] words = inp.Split(' ');
				for (int i = 0; i < words.Length; i++)
				{
					if (Regex.IsMatch(words[i], @"^[0-9]+$"))
						++n;
					else
					{
						//if(Regex.IsMatch(words[i], @"^[a-zA-Z]+$"))
							++w;
					}
						

				}
				Console.WriteLine("{0} {1}", n, w);
				inp = Console.ReadLine();
			}
		}
	}
}
