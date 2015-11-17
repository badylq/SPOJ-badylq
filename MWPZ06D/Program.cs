using System;

namespace MWPZ06D
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
				int x = int.Parse(data[0]);
				int y = int.Parse(data[1]);
				if (x - 1 > y || x == 1)
				{
					Console.WriteLine("TAK");
				}
				else
				{
					if (y%(x-1) > 0)
					{
						Console.WriteLine("TAK");
					}
					else
					{
						Console.WriteLine("NIE");
					}
				}
			}
		}
	}
}
