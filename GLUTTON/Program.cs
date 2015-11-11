using System;

namespace GLUTTON
{
	class Program
	{
		static void Main(string[] args)
		{
			int n, guests, boxSize;
			int cookies;
			int boxesNeeded;
			n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				cookies = 0;
				string inp = Console.ReadLine();
				string[] values = inp.Split(' ');
				guests = int.Parse(values[0]);
				boxSize = int.Parse(values[1]);
				for (int j = 0; j < guests; j++)
				{
					int eatTime = int.Parse(Console.ReadLine());
					cookies += 86400/eatTime;
				}
				boxesNeeded = cookies / boxSize;
				if (cookies%boxSize != 0)
				{
					boxesNeeded++;
				}
				Console.WriteLine(boxesNeeded);
			}
		}
	}
}
