using System;

namespace MWPZ06A
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
				double x = double.Parse(data[0]);
				double y = double.Parse(data[1]);
				double z = double.Parse(data[2]);
				double len = (x + y - (z*y))/(1 - z);
				if (len < 0)
				{
					len *= -1;
				}
				len = len*12;
				int result = (int)len;
				if (len%1 > 0.5)
				{
					result++;
				}
				Console.WriteLine(result);
			}
		}
	}
}
