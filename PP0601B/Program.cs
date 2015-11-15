using System;

namespace PP0601B
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
				int n = int.Parse(data[0]);
				int x = int.Parse(data[1]);
				int y = int.Parse(data[2]);
				for (int j = 1; j < n; j++)
				{
					if (j%x == 0 && j%y != 0)
					{
						Console.Write(j + " ");
					}
				}
				Console.WriteLine();
			}
		}
	}
}
