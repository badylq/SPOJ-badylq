using System;

namespace VSR
{
	class Program
	{
		static void Main(string[] args)
		{
			int t = int.Parse(Console.ReadLine());
			for (int i = 0; i < t; i++)
			{
				string inp = Console.ReadLine();
				string[] data = inp.Split(' ');
				int v1 = int.Parse(data[0]);
				int v2 = int.Parse(data[1]);
                Console.WriteLine((2 * v1 * v2) / (v1 + v2));
			}
		}
	}
}
