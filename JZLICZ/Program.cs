using System;
using System.Collections.Generic;
using System.Linq;

namespace JZLICZ
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			Dictionary<char, int> smallLetters = new Dictionary<char, int>();
			Dictionary<char, int> hugeLetters = new Dictionary<char, int>();
			for (int i = 0; i < n; i++)
			{
				string inp = Console.ReadLine();
				foreach (var c in inp)
				{
					if(c != ' ')
					{
						if(c >= 'a')
						{
							if (smallLetters.ContainsKey(c))
							{
								smallLetters[c]++;
							}
							else
							{
								smallLetters.Add(c,1);
							}
						}
						else
						{
							if (hugeLetters.ContainsKey(c))
							{
								hugeLetters[c]++;
							}
							else
							{
								hugeLetters.Add(c, 1);
							}
						}
					}
				}
			}
			var list = smallLetters.Keys.ToList();
			list.Sort();
			foreach (var key in list)
			{
				Console.WriteLine("{0} {1}", key, smallLetters[key]);
			}
			list = hugeLetters.Keys.ToList();
			list.Sort();
			foreach (var key in list)
			{
				Console.WriteLine("{0} {1}", key, hugeLetters[key]);
			}
		}
	}
}
