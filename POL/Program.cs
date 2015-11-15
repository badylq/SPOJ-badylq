using System;

namespace POL
{
	class Program
	{
		static void Main(string[] args)
		{
			int t = int.Parse(Console.ReadLine());
			string inp;
			for (int i = 0; i < t; i++)
			{
				inp = Console.ReadLine();
				inp = inp.Remove(inp.Length/2);
				Console.WriteLine(inp);
			}
		}
	}
}
