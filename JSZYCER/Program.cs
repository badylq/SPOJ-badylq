using System;
using System.Text;

namespace JSZYCER
{
	class Program
	{
		static void Main(string[] args)
		{
			StringBuilder inp = new StringBuilder(Console.ReadLine());
			while (!String.IsNullOrWhiteSpace(inp.ToString()))
			{
				for (int i = 0; i < inp.Length; i++)
				{
					if(inp[i] == ' ')
						continue;
					inp[i] = (char) ((int) inp[i] > 87 ? (int)inp[i] - 23 : (int)inp[i] + 3);
				}
				Console.WriteLine(inp.ToString());
				inp = new StringBuilder(Console.ReadLine());
			}
		}
	}
}
