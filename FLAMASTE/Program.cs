using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLAMASTE
{
	class Program
	{
		static void Main(string[] args)
		{
			int n;
			string word;
			n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				word = Console.ReadLine();
				string newWord = "";
				char c = word[0];
				int counter = 0;
				for (int j = 0; j < word.Length; j++)
				{
					if (c != word[j])
					{
						newWord += c;
						if (counter == 2)
						{
							newWord += c;
						}
						else
						{
							if (counter > 2)
							{
								newWord += counter;
							}
						}
						c = word[j];
						counter = 1;
					}
					else
					{
						counter++;
					}
				}
				newWord += c;
				if (counter == 2)
				{
					newWord += c;
				}
				else
				{
					if (counter > 2)
					{
						newWord += counter;
					}
				}
				Console.WriteLine(newWord);
			}
		}
	}
}
